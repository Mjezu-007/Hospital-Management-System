using Microsoft.Extensions.Logging;

namespace HMSProject
{
  public partial class Home : Form
  {
    private readonly ILogger<Home> _logger;
    private readonly LoginForm _loginForm;

    public string TempRoleString { get; set; }

    public Home(ILogger<Home> logger
      /*, LoginForm loginForm*/)
    {
      _logger = logger;
      //_loginForm = loginForm;
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

      //DoctorForm Doc = new DoctorForm();
      //Doc.Show();
      //this.Hide();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
      if (TempRoleString != "Admin")
      {
        MessageBox.Show("Your role doesn't allow you to complete this action.");
        return;
      }

      //PatientForm Pat = new PatientForm();
      //Pat.Show();
      //this.Hide();
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

      //NurseForm Nurse = new NurseForm();
      //Nurse.Show();
      //this.Hide();
    }
  }
}
