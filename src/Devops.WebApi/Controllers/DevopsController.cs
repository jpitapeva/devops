using Devops.Application.Projetos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using Devops.Model.ViewModel.Devops;

namespace Devops.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevopsController : ControllerBase
    {
        private readonly IProjetosApp _projetosApp;

        public DevopsController(IProjetosApp projetosApp)
        {
            _projetosApp = projetosApp;
        }

        [HttpGet("projetos")]
        public async Task<IActionResult> GetProjetos([FromQuery]ProjetosViewModel.Request request, CancellationToken cancellationToken)
        {
            var projetos = await _projetosApp.ObterProjetos(request, cancellationToken);
            if (projetos is null)
                return BadRequest("Personal access token ou organizacao invalida");

            return Ok(projetos);
        }

        [HttpGet("repositorios")]
        public async Task<IActionResult> GetRepositorios([FromQuery]RepositoriosViewModel.Request request, CancellationToken cancellationToken)
        {
            var projetos = await _projetosApp.ObterRepositorios(request, cancellationToken);
            if (projetos is null)
                return BadRequest("Personal access token ou organizacao invalida");

            return Ok(projetos);
        }
    }
}
