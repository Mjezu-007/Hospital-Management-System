using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace HMSProject
{
  public partial class Home : Form
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ILogger<Home> _logger;
    private readonly LoginForm _loginForm;
    private readonly DoctorForm _doctorForm;
    private readonly NurseForm _nurseForm;
    private readonly PatientForm _patientForm;

    public string TempRoleString { get; set; }

    public Home(ILogger<Home> logger
      , UserManager<ApplicationUser> userManager
      , LoginForm loginForm
      , DoctorForm doctorForm
      , PatientForm patientForm
      , NurseForm nurseForm)
    {
      _logger = logger;
      _loginForm = loginForm;
      _userManager = userManager;
      _doctorForm = doctorForm;
      _patientForm = patientForm;
      _nurseForm = nurseForm;
      InitializeComponent();
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
      _loginForm?.Show();
      this.Hide();
    }

    private void label5_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      if (TempRoleString != "Admin" && TempRoleString != "Doctor")
      {
        MessageBox.Show("Your role doesn't allow you to complete this action.");
        return;
      }

      _doctorForm.Show();
      this.Hide();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
      if (TempRoleString != "Admin")
      {
        MessageBox.Show("Your role doesn't allow you to complete this action.");
        return;
      }

      _patientForm.Show();
      this.Hide();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
      if (TempRoleString != "Admin")
      {
        MessageBox.Show("Your role doesn't allow you to complete this action.");
        return;
      }

      //DiagnosisForm Diag = new DiagnosisForm();
      //Diag.Show();
      //this.Hide();
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
      if (TempRoleString != "Admin" && TempRoleString != "Nurse")
      {
        MessageBox.Show("Your role doesn't allow you to complete this action.");
        return;
      }

      _nurseForm.Show();
      this.Hide();
    }
  }
}
