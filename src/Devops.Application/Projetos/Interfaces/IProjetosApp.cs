using Devops.Model.ViewModel.Devops;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Devops.Application.Projetos.Interfaces
{
    public interface IProjetosApp
    {
        Task<ProjetosViewModel.Response> ObterProjetos(ProjetosViewModel.Request request, CancellationToken cancellationToken);
        Task<RepositoriosViewModel.Response> ObterRepositorios(RepositoriosViewModel.Request request, CancellationToken cancellationToken);
        Task<List<CommitsViewModel.Response>> ObterCommits(CommitsViewModel.Request request, CancellationToken cancellationToken);
    }
}
