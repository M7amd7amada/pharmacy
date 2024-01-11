using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pharmacy.Domain.Helper;
using Pharmacy.Domain.Settings;

namespace Pharmacy.Domain;

public static class DependencyInjection
{
    public static IServiceCollection AddDomain(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddAutoMapper(typeof(MappingProfile));

        services.Configure<AppSettings>(configuration.GetSection("SettingsConfiguration"));

        return services;
    }
}