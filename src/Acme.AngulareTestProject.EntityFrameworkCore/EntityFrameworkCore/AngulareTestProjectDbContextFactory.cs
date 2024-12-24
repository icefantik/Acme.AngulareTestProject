using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.AngulareTestProject.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AngulareTestProjectDbContextFactory : IDesignTimeDbContextFactory<AngulareTestProjectDbContext>
{
    public AngulareTestProjectDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        AngulareTestProjectEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AngulareTestProjectDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new AngulareTestProjectDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.AngulareTestProject.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
