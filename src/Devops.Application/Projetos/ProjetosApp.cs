using AutoMapper;
using Devops.Application.Projetos.Interfaces;
using Devops.Infra.ExternalService.Entities;
using Devops.Infra.ExternalService.Interfaces;
using Devops.Model.ViewModel.Devops;
using System.Threading;
using System.Threading.Tasks;

namespace Devops.Application.Projetos
{
    public class ProjetosApp : IProjetosApp
    {
        private readonly IDevopsExternalService _devops;
        private readonly IMapper _mapper;

        public ProjetosApp(IDevopsExternalService devops, IMapper mapper)
        {
            _devops = devops;
            _mapper = mapper;
        }

        public async Task<ProjetosViewModel.Response> ObterProjetos(ProjetosViewModel.Request request, CancellationToken cancellationToken)
        {
            var requestBaseEntities = _mapper.Map<RequestBaseEntities.Request>(request);
            var projetos = await _devops.ObterProjetos(requestBaseEntities, cancellationToken);

            return _mapper.Map<ProjetosViewModel.Response>(projetos);
        }

        public async Task<RepositoriosViewModel.Response> ObterRepositorios(RepositoriosViewModel.Request request, CancellationToken cancellationToken)
        {
            var requestBaseEntities = _mapper.Map<RequestBaseEntities.Request>(request);
            var projetos = await _devops.ObterRepositorios(requestBaseEntities, cancellationToken);

            return _mapper.Map<RepositoriosViewModel.Response>(projetos);
        }
    }
}