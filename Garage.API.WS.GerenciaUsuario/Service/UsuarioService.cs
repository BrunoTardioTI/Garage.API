using Garage.API.Core.Entities;
using Garage.API.WS.GerenciaUsuario.Repositories;

namespace Garage.API.WS.GerenciaUsuario.Service
{
    public interface IUsuarioService
    {
        void CriarUsuario(Usuario usuario);
        Usuario ObterUsuarioPorId(Guid id);
    }

    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public void CriarUsuario(Usuario usuario)
        {
            usuario.Id = Guid.NewGuid();
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public Usuario ObterUsuarioPorId(Guid id)
        {
            return  _context.Usuarios.Find(id);
        }
    }
}
