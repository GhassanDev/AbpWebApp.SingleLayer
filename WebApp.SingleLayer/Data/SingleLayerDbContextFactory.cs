using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApp.SingleLayer.Data;

public class SingleLayerDbContextFactory : IDesignTimeDbContextFactory<SingleLayerDbContext>
{
    public SingleLayerDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SingleLayerDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SingleLayerDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
