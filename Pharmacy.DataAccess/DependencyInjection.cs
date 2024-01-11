using Microsoft.Extensions.DependencyInjection;
using Pharmacy.DataAccess.Data;
using Pharmacy.Domain.Interfaces;

namespace Pharmacy.DataAccess;

public static class DependencyInjection
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}