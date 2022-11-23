using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HMSProject
{
  public partial class DoctorForm : Form
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly AppDbContext _context;
    
    public DoctorForm(
      UserManager<ApplicationUser> userManager
      , AppDbContext context)
    {
      _userManager = userManager;
      _context = context;
      InitializeComponent();
    }

    void populate()
    {
      var dbDoctors = _context.Doctors.Include(d => d.ApplicationUser);

      DoctorGV.DataSource = dbDoctors.ToList();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Form form = Application.OpenForms["Home"]; //it should works
      form.Show();
      this.Hide();
    }

    private async void AddButton_Click(object sender, EventArgs e)
    {
      if (DocId.Text == "" || DocName.Text == "" || DocSurname.Text == "" || DocPass.Text == "" || DocExp.Text == "")
        MessageBox.Show("No Empty Fill Accepted");
      else
      {
        try
        {
          var passwordString = "P@ssword1";
          var hasher = new PasswordHasher<ApplicationUser>();
          var user = new ApplicationUser
          {
            Email = BuildEmailAlias(DocName.Text, DocSurname.Text),
            NormalizedEmail = BuildEmailAlias(DocName.Text, DocSurname.Text)?.ToUpperInvariant(),
            UserName = BuildEmailAlias(DocName.Text, DocSurname.Text),
            PasswordHash = hasher.HashPassword(null, passwordString),
            EmailConfirmed = true,
          };

          var result = await _userManager.CreateAsync(user, passwordString);
          if (result.Succeeded)
          {
            var userAdded = _context.Users.Add(user);
            _context.SaveChanges();

            // Link doctor and role
            var userRole = new IdentityUserRole<string>
            {
              UserId = userAdded?.Entity?.Id,
              RoleId = _context.Roles.FirstOrDefault(r => r.Name == Role.Doctor.ToString())?.Id
            };
            _context.UserRoles.Add(userRole);

            var doctor = new Doctor
            {
              ApplicationUser = user,
              Name = DocName.Text,
              Surname = DocSurname.Text,
              YearsOfExperience = int.Parse(DocExp.Text),
            };
            _context.Doctors.Add(doctor);
          }

          await _context.SaveChangesAsync();

          MessageBox.Show("Doctor Successfully Added");
          populate();
        }
        catch (Exception ex)
        {
          throw ex;
        }
      }
    }

    private void DoctorForm_Load(object sender, EventArgs e)
    {
      populate();
    }

    private async void DeleteButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (DocId.Text == "")
          MessageBox.Show("Please enter doctor ID!");
        else
        {
          if (int.TryParse(DocId.Text, out int id))
          {
            var doctor = _context.Doctors.Find(id);
            if (doctor == null)
            {
              MessageBox.Show($"Doctor with Id='{id}' does not exist.");
              return;
            }

            // Remove doctor
            var doctorDeleteResult = _context.Doctors.Remove(doctor);
            if (doctorDeleteResult.Entity != null)
            {
              // Remove doctor's user role record
              var userRoleToBeRemoved = _context.UserRoles.FirstOrDefault(ur => ur.UserId == doctor.ApplicationUserId);
              _context.UserRoles.Remove(userRoleToBeRemoved);
            }

            await _context.SaveChangesAsync();

            // Remove doctor user
            var userDeleteResult = await _userManager.DeleteAsync(doctor.ApplicationUser);
            var userId = await _userManager.GetUserIdAsync(doctor.ApplicationUser);
            if (!userDeleteResult.Succeeded)
            {
              throw new InvalidOperationException($"Unexpected error occurred deleting user with ID '{userId}'.");
            }

            MessageBox.Show("Doctor Successfully Deleted");

            populate();
          }
          else
          {
            MessageBox.Show("Doctor ID must be an integer value!");
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      DocId.Text = DoctorGV.SelectedRows?[0].Cells?[0].Value.ToString();
      DocName.Text = DoctorGV.SelectedRows?[0].Cells?[1].Value.ToString();
      DocSurname.Text = DoctorGV.SelectedRows?[0].Cells?[2].Value.ToString();
      DocExp.Text = DoctorGV.SelectedRows?[0].Cells?[3].Value.ToString();
      DocPass.Text = "******";
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (int.TryParse(DocId.Text, out int id))
        {
          var doctor = _context.Doctors.Find(id);
          if (doctor == null)
          {
            MessageBox.Show($"Doctor with Id='{id}' does not exist.");
            return;
          }

          doctor.Name = DocName.Text;
          doctor.Surname = DocSurname.Text;
          doctor.YearsOfExperience = int.Parse(DocExp.Text);

          var result = _context.Doctors.Update(doctor);
          _context.SaveChanges();
          MessageBox.Show("Doctor Successfully Updated");
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }

      populate();
    }

    private void DocId_OnValueChanged(object sender, EventArgs e)
    {

    }

    private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
    {

    }

    private string BuildEmailAlias(string name, string surname)
      => $"{name}_{surname}@localhost.com";
  }
}
