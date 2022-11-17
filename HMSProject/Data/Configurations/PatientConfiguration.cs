using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HMSProject
{
  public class PatientConfiguration : IEntityTypeConfiguration<Patient>
  {
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
      builder.HasData(
       new Patient
       {
         Id = 1,
         ApplicationUserId = "f583f605-f00c-4fcb-8393-5206bd1178c4",
         Name = "Murray",
         Doctor = "Little",
         PhoneNumber = 0727075020,
         Age = 45,
         Gender = Gender.Male,
         BloodGroup = BloodType.ABNegative,
         Sickness = "Malaria"
       },
       new Patient
       {
         Id = 2,
         ApplicationUserId = "0a928ef6-03ac-4a28-b0be-199ee6015077",
         Name = "Michelle",
         Doctor = "Hartman",
         PhoneNumber = 0828576405,
         Age = 23,
         Gender = Gender.Female,
         BloodGroup = BloodType.ANegative,
         Sickness = "Ringworm"
       }
      );
    }
  }
}
