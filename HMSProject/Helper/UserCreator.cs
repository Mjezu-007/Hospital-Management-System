using Microsoft.AspNetCore.Identity;

namespace HMSProject
{
  public static class UserCreator
  {
    public static void CreateIdentityUser(
      UserManager<ApplicationUser> userManager
      , ApplicationUser user
      , string password)
    {
      var result = userManager.CreateAsync(user, password);
      if (result.IsCompletedSuccessfully)
      {

      }
    }
  }
}
