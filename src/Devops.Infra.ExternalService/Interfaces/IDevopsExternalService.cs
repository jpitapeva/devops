using Devops.Infra.ExternalService.Entities;

namespace Devops.Infra.ExternalService.Interfaces
{
    public interface IDevopsExternalService
    {
        Task<ProjetosEntities.Response?> ObterProjetos(RequestBaseEntities.Request requestBase, CancellationToken cancellationToken);
        Task<RepositoriosEntities.Response?> ObterRepositorios(RequestBaseEntities.Request requestBase, CancellationToken cancellationToken);
    }
}
