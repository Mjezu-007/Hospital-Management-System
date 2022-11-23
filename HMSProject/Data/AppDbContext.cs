
using HMSProject.Data;
using HMSProject.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HMSProject
{
  public class AppDbContext : IdentityDbContext<ApplicationUser>
  {
    public AppDbContext() : base() { }

    public AppDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);

      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("Server=tcp:hms-ab-project.database.windows.net,1433;Initial Catalog=hms_db;Persist Security Info=False;User ID=hms-admin;Password=freesqlpassword123#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;",
       builder => builder.EnableRetryOnFailure());
      }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      builder.ApplyConfiguration(new UserConfiguration());
      builder.ApplyConfiguration(new RoleConfiguration());
      builder.ApplyConfiguration(new UserRoleConfiguration());
      builder.ApplyConfiguration(new DoctorConfiguration());
      builder.ApplyConfiguration(new PatientConfiguration());
      builder.ApplyConfiguration(new NurseConfiguration());
      builder.ApplyConfiguration(new DiagnosisConfiguration());
    }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public DbSet<Patient> Patients { get; set; }
    
    public DbSet<Nurse> Nurses { get; set; }
    
    public DbSet<DiagnosisSummary> DiagnosisSummaries { get; set; }
  }
}