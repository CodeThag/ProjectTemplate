using Application.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions;

public static class InfrastructureServicesExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {

        //services.AddTransient<IDateTime, DateTimeService>();
        // services.AddTransient<IIdentityService, IdentityService>();
        return services;
    }
}
