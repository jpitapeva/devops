using Devops.Infra.ExternalService.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Devops.Infra.ExternalService
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddExternalServices(this IServiceCollection services)
        {
            services.AddHttpClient();

            services.AddScoped<IDevopsExternalService, DevopsExternalService>();

            return services;
        }
    }
}