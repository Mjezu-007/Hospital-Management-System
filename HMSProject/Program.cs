using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HMSProject
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      var Configuration = new ConfigurationBuilder()
        .AddNewtonsoftJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        .Build();

      var services = new ServiceCollection();
      services.ConfigureServices(Configuration).AddLogging();

      ApplicationConfiguration.Initialize();
      using (ServiceProvider serviceProvider = services.BuildServiceProvider())
      {
        var startupForm = serviceProvider.GetRequiredService<SplashForm>();
        Application.Run(startupForm);
      }
    }

    private static IServiceCollection ConfigureServices(this IServiceCollection services, IConfigurationRoot configuration)
    {
      services.AddDbContext<AppDbContext>(options =>
        options.UseMySql(configuration["Data:AzureDbConnectionString"], ServerVersion.AutoDetect(configuration["Data:AzureDbConnectionString"])));

      //services.AddIdentity<IdentityUser, IdentityRole>();
      services.AddIdentity<ApplicationUser, IdentityRole>()
         .AddEntityFrameworkStores<AppDbContext>();

      //services.Configure<PasswordHasherOptions>(options =>
      //  options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3);

      services.AddLogging(ConfigureServices => ConfigureServices.AddConsole())
      .AddScoped<SplashForm>()
      .AddScoped<LoginForm>()
      .AddScoped<Home>()
      .AddScoped<DoctorForm>()
      .AddScoped<PatientForm>()
      .AddScoped<NurseForm>()
      .AddScoped<DiagnosisForm>()
      .AddSingleton<IHttpContextAccessor>(new HttpContextAccessor() { HttpContext = new DefaultHttpContext() { RequestServices = services.BuildServiceProvider() } });

      return services;
    }
  }
}