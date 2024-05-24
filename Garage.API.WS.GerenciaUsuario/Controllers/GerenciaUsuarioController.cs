using Garage.API.Core.Entities;
using Garage.API.WS.GerenciaUsuario.Facade;
using Garage.API.WS.GerenciaUsuario.Models;
using Garage.API.WS.GerenciaUsuario.Service;
using Microsoft.AspNetCore.Mvc;

namespace Garage.API.WS.GerenciaUsuario.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class GerenciaUsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public GerenciaUsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult CriarUsuario([FromBody] Usuario usuario)
        {
            _usuarioService.CriarUsuario(usuario);
            return Ok(usuario);
        }

        [HttpGet("{id}")]
        public IActionResult ObterUsuarioPorId(Guid id)
        {
            var usuario = _usuarioService.ObterUsuarioPorId(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }
    }
}
