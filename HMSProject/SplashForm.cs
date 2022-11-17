namespace HMSProject
{
  public partial class SplashForm : Form
  {
    private readonly LoginForm _loginForm;
    public SplashForm(LoginForm loginForm)
    {
      _loginForm = loginForm;
      InitializeComponent();
    }
    int startpoint = 0;
    private void timer1_Tick(object sender, EventArgs e)
    {
      startpoint += 1;
      Myprogressbar.Value = startpoint;
      if (Myprogressbar.Value == 100)
      {
        Myprogressbar.Value = 0;
        timer1.Stop();
        _loginForm.Show();
        this.Hide();
      }

    }

    private void SplashForm_Load(object sender, EventArgs e)
    {
      this.timer1.Start();
    }

    private void Myprogressbar_ValueChanged(object sender, EventArgs e)
    {

    }
  }
}
