using HMSProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HMSProject
{
  public class NurseConfiguration : IEntityTypeConfiguration<Nurse>
  {
    public void Configure(EntityTypeBuilder<Nurse> builder)
    {
      builder.HasData(
       new Nurse
       {
         Id = 1,
         ApplicationUserId = "ff759c08-ffff-4cea-b72c-78d3b31b1289",
         Name = "Zachariah",
         Surname = "Castaneda",
         YearsOfExperience = 2
       }
      );
    }
  }
}
