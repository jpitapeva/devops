using Devops.Domain.Entities;
using Devops.Domain.Interfaces;

namespace Devops.Domain.Services
{
    public class DevopsService : IDevopsService
    {
        private readonly IDevopsExternalService _devopsExternalService;

        public DevopsService(IDevopsExternalService devopsExternalService)
        {
            _devopsExternalService = devopsExternalService;
        }

        public async Task<List<CommitEntities.Response>> ObterCommitsAsync(CommitEntities.Request request, CancellationToken cancellationToken)
        {
            var repositorios = await _devopsExternalService.ObterRepositorios(request, cancellationToken);
            if (repositorios is null || repositorios?.Propriedades == null)
                return null;

            var commits = new List<CommitEntities.Response>();
            foreach (var repositorio in repositorios.Propriedades)
            {
                request.RepositorioId = repositorio.Id;
                var commitResponse = await _devopsExternalService.ObterCommits(request, cancellationToken);
                if (commitResponse is { Quantidade: > 0 } && repositorio?.Projeto != null && repositorio?.Projeto?.Nome != null)
                {
                    commitResponse.Projeto = repositorio.Projeto.Nome;
                    commits.Add(commitResponse);
                }
            }
            return commits;
        }
    }
}
