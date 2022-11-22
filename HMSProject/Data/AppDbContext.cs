﻿
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
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

        var connectionString = "server=sql9.freesqldatabase.com; user=sql9579170; password=freesqlpassword123; database=sql9579170";
        optionsBuilder.UseMySql(connectionString
          , ServerVersion.AutoDetect(connectionString));
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