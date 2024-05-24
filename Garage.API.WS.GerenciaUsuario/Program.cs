
using Garage.API.WS.GerenciaUsuario.Depedencia;
using Garage.API.WS.GerenciaUsuario.Facade;
using Garage.API.WS.GerenciaUsuario.Service;
using System;

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


            // Configurar o banco de dados SQLite
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            // Chamar o método estático para registrar dependências
            DependencyInjection.RegisterServices(builder.Services, connectionString);

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
