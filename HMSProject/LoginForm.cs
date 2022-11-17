using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace HMSProject
{
  public partial class LoginForm : Form
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly ILogger<LoginForm> _logger;
    private readonly AppDbContext _context;
    private readonly Home _homeForm;

    public LoginForm(ILogger<LoginForm> logger
      , AppDbContext context
      , UserManager<ApplicationUser> userManager
      , SignInManager<ApplicationUser> signInManager
      , Home homeForm)
    {
      _logger = logger ?? throw new ArgumentNullException(nameof(logger));
      _context = context ?? throw new ArgumentNullException(nameof(context));
      _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
      _signInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
      _homeForm = homeForm;
      InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
      if (DocNameTb.Text == "" || PassTb.Text == "" || Role.SelectedIndex == -1)
      {
        MessageBox.Show("Enter a valid Username, Password and Position");
        return;
      }

      var isValidCredentials = await VerifyUserNamePassword(userName: DocNameTb.Text, password: PassTb.Text);
      if (!isValidCredentials)
      {
        MessageBox.Show("Incorrect information. Please contact your administrator.");
        return;
      }

      _homeForm.Show();
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
        _logger.LogWarning(LoggerEventIds.UserValidationFailed, $"User with '{userName}' not found.");
        return false;
      }

      var isPasswordValid = await _userManager.CheckPasswordAsync(existingUser, password);
      if (!isPasswordValid)
        _logger.LogWarning(LoggerEventIds.InvalidPassword, $"Invalid password for user Id={existingUser.Id}.");

      return true;
    }
  }
}
