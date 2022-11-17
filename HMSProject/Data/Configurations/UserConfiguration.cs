using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HMSProject
{
  public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
  {
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
      var hasher = new PasswordHasher<ApplicationUser>();
      builder.HasData(
        new ApplicationUser
        {
          Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
          Email = "admin@localhost.com",
          NormalizedEmail = "ADMIN@LOCALHOST.COM",
          PasswordHash = hasher.HashPassword(null, "P@ssword1"),
          UserName = "Admin@localhost.com",
          NormalizedUserName = "ADMIN@LOCALHOST.COM",
          EmailConfirmed = true
        },
        new ApplicationUser
        {
          Id = "9e224968-33e4-4652-b7b7-8574d048cdb9",
          Email = "user@localhost.com",
          NormalizedEmail = "USER@LOCALHOST.COM",
          PasswordHash = hasher.HashPassword(null, "P@ssword1"),
          UserName = "User@localhost.com",
          NormalizedUserName = "USER@LOCALHOST.COM",
          EmailConfirmed = true
        },
        new ApplicationUser
        {
          Id = "f583f605-f00c-4fcb-8393-5206bd1178c4",
          Email = "murray@localhost.com",
          NormalizedEmail = "MURRAY@LOCALHOST.COM",
          PasswordHash = hasher.HashPassword(null, "P@ssword1"),
          UserName = "murray@localhost.com",
          NormalizedUserName = "MURRAY@LOCALHOST.COM",
          EmailConfirmed = true
        },
        new ApplicationUser
        {
          Id = "0a928ef6-03ac-4a28-b0be-199ee6015077",
          Email = "michelle@localhost.com",
          NormalizedEmail = "MICHELLE@LOCALHOST.COM",
          PasswordHash = hasher.HashPassword(null, "P@ssword1"),
          UserName = "michelle@localhost.com",
          NormalizedUserName = "MICHELLE@LOCALHOST.COM",
          EmailConfirmed = true
        }
      );
    }
  }
}
