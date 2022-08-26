using Devops.Domain.Entities;

namespace Devops.Domain.Interfaces
{
    public interface IDevopsService
    {
        Task<List<CommitEntities.Response>> ObterCommitsAsync(CommitEntities.Request request, CancellationToken cancellationToken);
    }
}
