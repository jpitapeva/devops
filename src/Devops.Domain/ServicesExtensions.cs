using Devops.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Devops.Domain
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.RegisterServices();

            return services;
        }

        private static void RegisterServices(this IServiceCollection services)
        {
            services.Scan(_ => _
            .FromAssemblies(
                typeof(DevopsService).Assembly
                )
            .AddClasses()
            .AsImplementedInterfaces());
        }
    }
}