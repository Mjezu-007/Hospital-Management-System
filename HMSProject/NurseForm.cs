using HMSProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HMSProject
{
  public partial class NurseForm : Form
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ILogger<DoctorForm> _logger;
    private readonly AppDbContext _context;

    public NurseForm(ILogger<DoctorForm> logger
      , UserManager<ApplicationUser> userManager
      , AppDbContext context)
    {
      _logger = logger;
      _userManager = userManager;
      _context = context;
      InitializeComponent();
    }

    #region NurseForm_Load(object sender, EventArgs e)
    private void NurseForm_Load(object sender, EventArgs e)
    {
      Populate();
    }
    #endregion

    #region AddButton_Click(object sender, EventArgs e)
    private async void AddButton_Click(object sender, EventArgs e)
    {
      if (NurseId.Text == "" || NurseName.Text == "" || NurseSurname.Text == "" || NursePass.Text == "" || NurseExp.Text == "")
        MessageBox.Show("No Empty Fill Accepted");
      else
      {
        try
        {
          var passwordString = "P@ssword1";
          var hasher = new PasswordHasher<ApplicationUser>();
          var user = new ApplicationUser
          {
            Email = BuildEmailAlias(NurseName.Text, NurseSurname.Text),
            NormalizedEmail = BuildEmailAlias(NurseName.Text, NurseSurname.Text)?.ToUpperInvariant(),
            UserName = BuildEmailAlias(NurseName.Text, NurseSurname.Text)?.ToUpperInvariant(),
            PasswordHash = hasher.HashPassword(null, passwordString),
            EmailConfirmed = true,
          };

          var result = await _userManager.CreateAsync(user, passwordString);
          if (result.Succeeded)
          {
            //var hasUser = _userManager.FindByIdAsync(user.Id) != null;
            //var userAdded = _context.Users.Add(user);
            //_context.SaveChanges();

            // Link nurse and role
            var userRole = new IdentityUserRole<string>
            {
              UserId = user?.Id,
              RoleId = _context.Roles.FirstOrDefault(r => r.Name == Role.Nurse.ToString())?.Id
            };
            _context.UserRoles.Add(userRole);

            var nurse = new Nurse
            {
              ApplicationUser = user,
              Name = NurseName.Text,
              Surname = NurseSurname.Text,
              YearsOfExperience = int.Parse(NurseExp.Text),
            };
            _context.Nurses.Add(nurse);
          }

          await _context.SaveChangesAsync();

          MessageBox.Show("Nurse Successfully Added");
          Populate();
        }
        catch (Exception ex)
        {
          throw ex;
        }
      }
    }
    #endregion

    #region DeleteButton_Click(object sender, EventArgs e)
    private async void DeleteButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (NurseId.Text == "")
          MessageBox.Show("Please enter nurse ID!");
        else
        {
          if (int.TryParse(NurseId.Text, out int id))
          {
            var nurse = _context.Nurses.Include(n => n.ApplicationUser).FirstOrDefault();
            if (nurse == null)
            {
              MessageBox.Show($"Nurse with Id='{id}' does not exist.");
              return;
            }

            if (MessageBox.Show("This will delete a nurse from the database. Confirm?", "Delete Nurse", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
              // Remove nurse
              var nurseDeleteResult = _context.Nurses.Remove(nurse);
              if (nurseDeleteResult.Entity != null)
              {
                // Remove nurse's user role record
                var userRoleToBeRemoved = _context.UserRoles.FirstOrDefault(ur => ur.UserId == nurse.ApplicationUserId);
                _context.UserRoles.Remove(userRoleToBeRemoved);
              }

              await _context.SaveChangesAsync();

              // Remove nurse user
              var userDeleteResult = await _userManager.DeleteAsync(nurse.ApplicationUser);
              var userId = await _userManager.GetUserIdAsync(nurse.ApplicationUser);
              if (!userDeleteResult.Succeeded)
              {
                throw new InvalidOperationException($"Unexpected error occurred deleting user with ID '{userId}'.");
              }

              MessageBox.Show("Nurse Successfully Deleted");

              Populate();
            }
          }
          else
          {
            MessageBox.Show("Nurse ID must be an integer value!");
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    #endregion

    #region UpdateButton_Click(object sender, EventArgs e)
    private void UpdateButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (int.TryParse(NurseId.Text, out int id))
        {
          var nurse = _context.Nurses.Find(id);
          if (nurse == null)
          {
            MessageBox.Show($"Nurse with Id='{id}' does not exist.");
            return;
          }

          nurse.Name = NurseName.Text;
          nurse.Surname = NurseSurname.Text;
          nurse.YearsOfExperience = int.Parse(NurseExp.Text);

          var result = _context.Nurses.Update(nurse);
          _context.SaveChanges();

          MessageBox.Show("Nurse Successfully Updated");
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }

      Populate();
    }
    #endregion

    #region Populate()
    void Populate()
    {
      var dbNurses = _context.Nurses.Include(d => d.ApplicationUser).AsNoTracking();

      NurseGV.DataSource = dbNurses.ToList();
    }
    #endregion

    #region  NurseGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    private void NurseGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      NurseId.Text = NurseGV.SelectedRows?[0].Cells?[0].Value.ToString();
      NurseName.Text = NurseGV.SelectedRows?[0].Cells?[1].Value.ToString();
      NurseSurname.Text = NurseGV.SelectedRows?[0].Cells?[2].Value.ToString();
      NurseExp.Text = NurseGV.SelectedRows?[0].Cells?[3].Value.ToString();
      NursePass.Text = "******";
    }
    #endregion

    #region HomeButton_Click(object sender, EventArgs e)
    private void HomeButton_Click(object sender, EventArgs e)
    {

    }
    #endregion

    private string BuildEmailAlias(string name, string surname)
      => $"{name}_{surname}@localhost.com";

  }
}
