using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace HMSProject
{
  public partial class PatientForm : Form
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ILogger<DoctorForm> _logger;
    private readonly AppDbContext _context;
    private readonly Home _homeform;

    public PatientForm(ILogger<DoctorForm> logger
       , UserManager<ApplicationUser> userManager
       , AppDbContext context
       , Home home)
    {
      _userManager = userManager;
      _logger = logger;
      _context = context;
      _homeform = home;
      InitializeComponent();
    }

    void populate()
    {
      var dbPatients = _context.Patients.Include(p => p.ApplicationUser);

      PatientGV.DataSource = dbPatients.ToList();
    }
    private void button4_Click(object sender, EventArgs e)
    {
      _homeform.Show();
      this.Hide();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
      if (PatId.Text == "" || PatName.Text == "" || PatDoc.Text == "" || PatPhone.Text == "" || PatAge.Text == "" || MajorTb.Text == "")
        MessageBox.Show("No Empty Fill Accepted");
      else
      {
        try
        {
          var passwordString = "P@ssword1";
          var hasher = new PasswordHasher<ApplicationUser>();
          var user = new ApplicationUser
          {
            Email = BuildEmailAlias(PatName.Text, PatDoc.Text),
            NormalizedEmail = BuildEmailAlias(PatName.Text, PatDoc.Text)?.ToUpperInvariant(),
            UserName = BuildEmailAlias(PatName.Text, PatDoc.Text)?.ToUpperInvariant(),
            PasswordHash = hasher.HashPassword(null, passwordString),
            EmailConfirmed = true,
          };

          var result = await _userManager.CreateAsync(user, passwordString);
          if (result.Succeeded)
          {
            var userAdded = _context.Users.Add(user);
            _context.SaveChanges();

            // Link patient and role
            var userRole = new IdentityUserRole<string>
            {
              UserId = userAdded?.Entity?.Id,
              RoleId = _context.Roles.FirstOrDefault(r => r.Name == Role.Patient.ToString())?.Id
            };
            _context.UserRoles.Add(userRole);

            var patient = new Patient
            {
              ApplicationUser = user,
              Name = PatName.Text,
              Doctor = PatDoc.Text,
              PhoneNumber = int.Parse(PatPhone.Text),
              Age = int.Parse(PatAge.Text),
              Gender = (Gender)GenderCb.SelectedIndex,
              BloodGroup = (BloodType)BloodCb.SelectedIndex,
              Sickness = MajorTb.Text
            };
            _context.Patients.Add(patient);
          }

          await _context.SaveChangesAsync();

          MessageBox.Show("Patient Successfully Added");
          populate();
        }
        catch (Exception ex)
        {
          throw ex;
        }
      }
    }

    private void PatientForm_Load(object sender, EventArgs e)
    {
      populate();
    }

    private async void button3_Click(object sender, EventArgs e)
    {
      try
      {
        if (PatId.Text == "")
          MessageBox.Show("Please enter doctor ID!");
        else
        {
          if (int.TryParse(PatId.Text, out int id))
          {
            var patient = _context.Patients.Find(id);
            if (patient == null)
            {
              MessageBox.Show($"Patient with Id='{id}' does not exist.");
              return;
            }

            // Remove patient
            var patientDeleteResult = _context.Patients.Remove(patient);
            if (patientDeleteResult.Entity != null)
            {
              // Remove patient's user role record
              var userRoleToBeRemoved = _context.UserRoles.FirstOrDefault(ur => ur.UserId == patient.ApplicationUserId);
              _context.UserRoles.Remove(userRoleToBeRemoved);
            }

            await _context.SaveChangesAsync();

            // Remove doctor user
            var userDeleteResult = await _userManager.DeleteAsync(patient.ApplicationUser);
            var userId = await _userManager.GetUserIdAsync(patient.ApplicationUser);
            if (!userDeleteResult.Succeeded)
            {
              throw new InvalidOperationException($"Unexpected error occurred deleting user with ID '{userId}'.");
            }

            MessageBox.Show("Patient Successfully Deleted");

            populate();
          }
          else
          {
            MessageBox.Show("Patient ID must be an integer value!");
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      PatId.Text = PatientGV.SelectedRows?[0].Cells?[0].Value.ToString();
      PatName.Text = PatientGV.SelectedRows?[0].Cells?[1].Value.ToString();
      PatDoc.Text = PatientGV.SelectedRows?[0].Cells?[2].Value.ToString();
      PatPhone.Text = PatientGV.SelectedRows?[0].Cells?[3].Value.ToString();
      PatAge.Text = PatientGV.SelectedRows?[0].Cells?[4].Value.ToString();
      GenderCb.Text = PatientGV.SelectedRows?[0].Cells?[5].Value.ToString();
      BloodCb.Text = PatientGV.SelectedRows?[0].Cells?[6].Value.ToString();
      MajorTb.Text = PatientGV.SelectedRows?[0].Cells?[7].Value.ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        if (int.TryParse(PatId.Text, out int id))
        {
          var patient = _context.Patients.Find(id);
          if (patient == null)
          {
            MessageBox.Show($"Patient with Id='{id}' does not exist.");
            return;
          }

          patient.Name = PatName.Text;
          patient.Doctor = PatDoc.Text;
          patient.PhoneNumber = int.Parse(PatPhone.Text);
          patient.Age = int.Parse(PatAge.Text);
          patient.Sickness = MajorTb.Text;
          patient.Gender = (Gender)GenderCb.SelectedIndex;
          patient.BloodGroup = (BloodType)BloodCb.SelectedIndex;

          var result = _context.Patients.Update(patient);
          _context.SaveChanges();
          MessageBox.Show("Patient Successfully Updated");
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }

      populate();
    }

    private void label5_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void PatId_OnValueChanged(object sender, EventArgs e)
    {

    }

    private void GenderCb_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void PatDoc_OnValueChanged(object sender, EventArgs e)
    {

    }

    private void PatAge_OnValueChanged(object sender, EventArgs e)
    {

    }

    private string BuildEmailAlias(string name, string doctor)
      => $"{name}_{doctor}@localhost.com";
  }
}
