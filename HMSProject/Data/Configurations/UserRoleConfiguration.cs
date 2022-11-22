using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HMSProject.Data.Configurations
{
  public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
  {
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
      builder.HasData(
        // Admins.
        new IdentityUserRole<string>
        {
          RoleId = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
          UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
        },
        // Doctors.
        new IdentityUserRole<string>
        {
          RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
          UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
        },
        // Patients.
        new IdentityUserRole<string>
        {
          RoleId = "34144627-963c-40b6-aac5-1285592a52c0",
          UserId = "f583f605-f00c-4fcb-8393-5206bd1178c4"
        },
        new IdentityUserRole<string>
        {
          RoleId = "34144627-963c-40b6-aac5-1285592a52c0",
          UserId = "0a928ef6-03ac-4a28-b0be-199ee6015077"
        },
        // Nurses.
        new IdentityUserRole<string>
        {
          RoleId = "5b6a080e-96c3-49b3-98eb-f7f5390ef46b",
          UserId = "ff759c08-ffff-4cea-b72c-78d3b31b1289"
        }
      );
    }
  }
}
