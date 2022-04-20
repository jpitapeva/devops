using Devops.Application.Projetos;
using Devops.Application.Projetos.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Devops.Application
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProjetosApp, ProjetosApp>();

            return services;
        }
    }
}