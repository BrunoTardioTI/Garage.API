using Garage.API.WS.GerenciaUsuario.Facade;
using Garage.API.WS.GerenciaUsuario.Service;

namespace Garage.API.WS.GerenciaUsuario.Depedencia
{
    public static class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Registro das dependências
            services.AddScoped<IUsuarioFacade, UsuarioFacade>();
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}
