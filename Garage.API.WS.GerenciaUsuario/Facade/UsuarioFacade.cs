using Garage.API.Core.Entities;
using Garage.API.WS.GerenciaUsuario.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Garage.API.WS.GerenciaUsuario.Facade
{
    public interface IUsuarioFacade
    {
        Task<IActionResult> CadastraUsuario(UsuarioDTO usuario);
        Task<Usuario> ObterUsuarioPorId(long id);
    }

    public class UsuarioFacade : IUsuarioFacade
    {
        public Task<IActionResult> CadastraUsuario(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> ObterUsuarioPorId(long id)
        {
            return
                Task.FromResult(
                new Usuario("joao", "teste", "email@email", "3222222", DateTime.Now,
                       "endereco teste", "perfil teste"));

        }
    }
}
