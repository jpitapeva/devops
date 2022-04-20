using AutoMapper;
using Devops.Infra.Mappings.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace Devops.Infra.Mappings
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddMappings(this IServiceCollection services)
        {
            services.AddSingleton(_ => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ExternalServiceToApplicationProfile());
                cfg.AddProfile(new ApplicationToExternalServiceProfile());
            }).CreateMapper());

            return services;
        }
    }
}