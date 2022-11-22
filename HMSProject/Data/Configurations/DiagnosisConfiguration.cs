using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HMSProject.Data.Configurations
{
  public class DiagnosisConfiguration : IEntityTypeConfiguration<DiagnosisSummary>
  {
    public void Configure(EntityTypeBuilder<DiagnosisSummary> builder)
    {
      builder.HasData(
       new DiagnosisSummary
       {
         Id = 1,
         PatientName = "Patient1",
         Diagnosis = "Alzheimer’s disease",
         Medicines = "Donepezil, galantamine and rivastigmine",
         Symptoms = "Decreased range of motion"
       },
       new DiagnosisSummary
       {
         Id = 2,
         PatientName = "Patient2",
         Diagnosis = "Arthritis",
         Medicines = "Naproxen (Aleve), aspirin and ibuprofen (Motrin, Advil)",
         Symptoms = "Pain, Stiffness, Swelling and Decreased range of motion"
       }
      );
    }
  }
}
