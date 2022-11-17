using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HMSProject
{
  public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
  {
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
      builder.HasData(
       new Doctor
       {
         Id = 1,
         ApplicationUserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
         Name = "Andrew",
         Surname = "Sheen",
         YearsOfExperience = 9
       },
       new Doctor
       {
         Id = 2,
         ApplicationUserId = "9e224968-33e4-4652-b7b7-8574d048cdb9",
         Name = "Carla",
         Surname = "Harley",
         YearsOfExperience = 4
       }
      );
    }
  }
}
