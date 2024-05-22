
using Garage.API.WS.GerenciaUsuario.Facade;
using Garage.API.WS.GerenciaUsuario.Service;

namespace Garage.API.WS.GerenciaUsuario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Registro das dependências
            builder.Services.AddScoped<IUsuarioFacade, UsuarioFacade>();
            builder.Services.AddScoped<IUsuarioService, UsuarioService>(); 

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
