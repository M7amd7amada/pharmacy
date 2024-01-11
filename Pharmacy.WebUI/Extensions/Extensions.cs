using Microsoft.EntityFrameworkCore;
using Pharmacy.DataAccess;
using Pharmacy.DataAccess.Data;
using Pharmacy.Domain;

namespace Pharmacy.WebUI.Extensions;

public static class Extensions
{
    public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("SqlServer");
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString,
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

        builder.Services
            .AddWebUI()
            .AddDomain(builder.Configuration)
            .AddDataAccess();

        return builder;
    }
}