using Garage.API.Core.Entities;

namespace Garage.API.WS.GerenciaUsuario.Service
{

    public interface IUsuarioService
    {
        Usuario CadastraNovoUsuario();
        Usuario AtualizarUsuario();
        Usuario ExcluirUsuario();
    }
    public class UsuarioService : IUsuarioService
    {
        public Usuario CadastraNovoUsuario()
        {
            // Receber o usuario
            // Validar certos campos
            // Verficar condicoes se ja tem anterior;
            // Fabricar usuario
            // Executar insert
            // Retornar 
            return null;
        }
        public Usuario AtualizarUsuario()
        {
            // Receber o usuario
            // Validar certos campos
            // Verficar condicoes se ja tem anterior;
            // atualizar
            // Retornar 
            return null;
        }

        public Usuario ExcluirUsuario()
        {
            // Receber o usuario
            // Validar certos campos
            // Verficar condicoes se ja tem anterior;
            // desativar
            // Retornar 
            return null;
        }
    }
}
