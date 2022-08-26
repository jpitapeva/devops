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

        /// <summary>
        /// Obtem lista de projetos do devops
        /// </summary>
        /// <param name="request">request</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>Lista de projetos</returns>
        [HttpGet("projetos")]
        public async Task<IActionResult> GetProjetos([FromQuery]ProjetosViewModel.Request request, CancellationToken cancellationToken)
        {
            var projetos = await _projetosApp.ObterProjetos(request, cancellationToken);
            if (projetos is null)
                return BadRequest("Personal access token ou organizacao invalida");

            return Ok(projetos);
        }

        /// <summary>
        /// Obtem lista de repositorios do devops
        /// </summary>
        /// <param name="request">request</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>lista dos repositorios</returns>
        [HttpGet("repositorios")]
        public async Task<IActionResult> GetRepositorios([FromQuery]RepositoriosViewModel.Request request, CancellationToken cancellationToken)
        {
            var projetos = await _projetosApp.ObterRepositorios(request, cancellationToken);
            if (projetos is null)
                return BadRequest("Personal access token ou organizacao invalida");

            return Ok(projetos);
        }

        /// <summary>
        /// Obtem lista de commits do devops
        /// </summary>
        /// <param name="request">request</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>lista de commits por autor</returns>
        [HttpGet("commits")]
        public async Task<IActionResult> GetCommits([FromQuery] CommitsViewModel.Request request, CancellationToken cancellationToken)
        {
            var projetos = await _projetosApp.ObterCommits(request, cancellationToken);
            if (projetos is null)
                return BadRequest("Personal access token ou organizacao invalida");

            return Ok(projetos);
        }
    }
}
