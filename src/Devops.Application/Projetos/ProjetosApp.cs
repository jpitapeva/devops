using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Devops.Application.Projetos.Interfaces;
using Devops.Domain.Entities;
using Devops.Domain.Interfaces;
using Devops.Model.ViewModel.Devops;

namespace Devops.Application.Projetos
{
    public class ProjetosApp : IProjetosApp
    {
        private readonly IDevopsExternalService _externalService;
        private readonly IDevopsService _service;
        private readonly IMapper _mapper;

        public ProjetosApp(IDevopsExternalService devops, IMapper mapper, IDevopsService service)
        {
            _externalService = devops;
            _mapper = mapper;
            _service = service;
        }

        public async Task<List<CommitsViewModel.Response>> ObterCommits(CommitsViewModel.Request request, CancellationToken cancellationToken)
        {
            var requestBaseEntities = _mapper.Map<CommitEntities.Request>(request);
            var projetos = await _service.ObterCommitsAsync(requestBaseEntities, cancellationToken);

            return _mapper.Map<List<CommitsViewModel.Response>>(projetos); ;
        }

        public async Task<ProjetosViewModel.Response> ObterProjetos(ProjetosViewModel.Request request, CancellationToken cancellationToken)
        {
            var requestBaseEntities = _mapper.Map<RequestBaseEntities.Request>(request);
            var projetos = await _externalService.ObterProjetos(requestBaseEntities, cancellationToken);

            return _mapper.Map<ProjetosViewModel.Response>(projetos);
        }

        public async Task<RepositoriosViewModel.Response> ObterRepositorios(RepositoriosViewModel.Request request, CancellationToken cancellationToken)
        {
            var requestBaseEntities = _mapper.Map<RequestBaseEntities.Request>(request);
            var projetos = await _externalService.ObterRepositorios(requestBaseEntities, cancellationToken);

            return _mapper.Map<RepositoriosViewModel.Response>(projetos);
        }
    }
}