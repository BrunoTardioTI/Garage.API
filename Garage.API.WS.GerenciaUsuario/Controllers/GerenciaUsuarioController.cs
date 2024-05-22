using Garage.API.WS.GerenciaUsuario.Facade;
using Garage.API.WS.GerenciaUsuario.Models;
using Microsoft.AspNetCore.Mvc;

namespace Garage.API.WS.GerenciaUsuario.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class GerenciaUsuarioController : ControllerBase
    {
        private readonly ILogger<GerenciaUsuarioController> _logger;

        private readonly IUsuarioFacade _usuarioFacade;
        public GerenciaUsuarioController(
            ILogger<GerenciaUsuarioController> logger,
            IUsuarioFacade usuarioFacade)
        {
            _logger = logger;
            _usuarioFacade = usuarioFacade;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsuario(long id)
        {
            var usuario = await _usuarioFacade.ObterUsuarioPorId(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }
    }
}
