using HMSProject.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace HMSProject
{
  public partial class LoginForm : Form
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly AppDbContext _context;
    //private readonly Home _homeForm;

    public LoginForm(
      AppDbContext context
      , UserManager<ApplicationUser> userManager
      //, SignInManager<ApplicationUser> signInManager
      )
    {
      _context = context ?? throw new ArgumentNullException(nameof(context));
      _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
      //_signInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
      //_homeForm = homeForm;
      InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
      if (DocNameTb.Text == "" || PassTb.Text == "" || Role.SelectedIndex == -1)
      {
        MessageBox.Show("Enter a valid Username, Password and Position");
        return;
      }

      if (!InternetConnectionChecker.IsConnectedToInternet())
      {
        MessageBox.Show("Unable to connect to database. Make sure you have internet connection.");
        return;
      }

      var isValidCredentials = await VerifyUserNamePassword(userName: DocNameTb.Text, password: PassTb.Text);
      if (!isValidCredentials)
      {
        MessageBox.Show("Incorrect information. Please contact your administrator.");
        return;
      }


      UserRoleCapturer.UserRole = Role.Text;
      Home home = new Home(_context, _userManager);
      home?.Show();

      //_homeForm.Show();
      this.Hide();
    }

    private void label2_Click(object sender, EventArgs e)
    {
      DocNameTb.Text = string.Empty;
      PassTb.Text = string.Empty;
    }

    private async Task<bool> VerifyUserNamePassword(string userName, string password)
    {
      var existingUser = await _userManager.FindByEmailAsync(userName);
      if (existingUser == null)
      {
        return false;
      }

      var isPasswordValid = await _userManager.CheckPasswordAsync(existingUser, password);
      if (!isPasswordValid)
        throw new InvalidOperationException($"Invalid password for user Id={existingUser.Id}.");

      return true;
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
      var status = InternetConnectionChecker.IsConnectedToInternet() ? "ONLINE" : "OFFLINE";
      label4.Text += status;
    }
  }
}
