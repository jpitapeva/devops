using Devops.Domain.Entities;

namespace Devops.Domain.Interfaces
{
    public interface IDevopsExternalService
    {
        Task<ProjetosEntities.Response?> ObterProjetos(RequestBaseEntities.Request requestBase, CancellationToken cancellationToken);
        Task<RepositoriosEntities.Response?> ObterRepositorios(RequestBaseEntities.Request requestBase, CancellationToken cancellationToken);
        Task<CommitEntities.Response?> ObterCommits(CommitEntities.Request request, CancellationToken cancellationToken);
    }
}
