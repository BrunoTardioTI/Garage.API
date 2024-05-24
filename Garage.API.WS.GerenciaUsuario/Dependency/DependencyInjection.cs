using Garage.API.WS.GerenciaUsuario.Facade;
using Garage.API.WS.GerenciaUsuario.Repositories;
using Garage.API.WS.GerenciaUsuario.Service;
using Microsoft.EntityFrameworkCore;

namespace Garage.API.WS.GerenciaUsuario.Depedencia
{
    public static class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services , string connectionString)
        {

            // Registro do DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(connectionString));

            // Registro das dependências
            services.AddScoped<IUsuarioFacade, UsuarioFacade>();
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}
