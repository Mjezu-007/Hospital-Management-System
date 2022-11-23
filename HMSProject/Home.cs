using HMSProject.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace HMSProject
{
  public partial class Home : Form
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly AppDbContext _context;
    public string UserRole { get; set; }
    //private readonly LoginForm _loginForm;
    //private readonly DoctorForm _doctorForm;
    //private readonly NurseForm _nurseForm;
    //private readonly PatientForm _patientForm;

    public string TempRoleString { get; set; }

    public Home(AppDbContext context
      , UserManager<ApplicationUser> userManager
      , string userRole = null
      //, LoginForm loginForm
      //, DoctorForm doctorForm
      //, PatientForm patientForm
      //, NurseForm nurseForm
      )
    {
      _context = context;
      _userManager = userManager;
      UserRole = userRole;
      //_loginForm = loginForm;
      //_doctorForm = doctorForm;
      //_patientForm = patientForm;
      //_nurseForm = nurseForm;
      InitializeComponent();
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
      LoginForm loginForm = new LoginForm(_context, _userManager); 
      loginForm?.Show();
      this.Hide();
    }

    private void label5_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      if (UserRoleCapturer.UserRole != "Admin" && UserRoleCapturer.UserRole != "Doctor")
      {
        MessageBox.Show("Your role doesn't allow you to complete this action.");
        return;
      }

      DoctorForm doctorForm = new DoctorForm(_userManager, _context); 
      doctorForm?.Show();
      this.Hide();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
      if (UserRoleCapturer.UserRole != "Admin")
      {
        MessageBox.Show("Your role doesn't allow you to complete this action.");
        return;
      }

      PatientForm patientForm = new PatientForm(_userManager, _context);
      patientForm?.Show();
      this.Hide();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
      if (UserRoleCapturer.UserRole != "Admin")
      {
        MessageBox.Show("Your role doesn't allow you to complete this action.");
        return;
      }

      DiagnosisForm Diag = new DiagnosisForm(_userManager, _context);
      Diag.Show();
      this.Hide();
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
      if (UserRoleCapturer.UserRole != "Admin" && UserRoleCapturer.UserRole != "Doctor")
      {
        MessageBox.Show("Your role doesn't allow you to complete this action.");
        return;
      }

      NurseForm nurseForm = new NurseForm(_userManager, _context);
      nurseForm?.Show();
      this.Hide();
    }
  }
}
