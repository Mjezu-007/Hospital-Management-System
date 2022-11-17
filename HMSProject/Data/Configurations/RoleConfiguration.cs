using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HMSProject
{
  public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
  {
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
      builder.HasData(
        new IdentityRole
        {
          Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
          Name = "Doctor",
          NormalizedName = "DOCTOR"
        }, 
        new IdentityRole
        {
          Id = "5b6a080e-96c3-49b3-98eb-f7f5390ef46b",
          Name = "Nurse",
          NormalizedName = "NURSE"
        },
        new IdentityRole
        {
          Id = "34144627-963c-40b6-aac5-1285592a52c0",
          Name = "Patient",
          NormalizedName = "PATIENT"
        },
        new IdentityRole
        {
          Id = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
          Name = "Administrator",
          NormalizedName = "ADMINISTRATOR"
        }
      );
    }
  }
}
