using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HMSProject
{
  public static class DatabaseMigrator
  {
    public static IApplicationBuilder MigrateDatabase(this IApplicationBuilder app, ILoggerFactory? loggerFactory = null)
    {
      using (var scope = app.ApplicationServices
          .GetRequiredService<IServiceScopeFactory>()
          .CreateScope())
      {
        var appDbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        var logger = loggerFactory?.CreateLogger("Migration");

        var services = scope.ServiceProvider;
        try
        {
          logger?.LogInformation("Migrating database...");

          var hasDbMigrations = appDbContext.Database.GetPendingMigrations().Any();
          if (hasDbMigrations)
            appDbContext.Database.Migrate();

          logger?.LogInformation("Migrated database.");
        }
        catch (Exception ex)
        {
          //Log errors or do anything you think it's needed
          logger?.LogError(ex, $"An error occurred while migrating the database - {ex.Message}");
          throw;
        }
      }
      return app;
    }

  }
}
