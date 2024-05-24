using Garage.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Garage.API.WS.GerenciaUsuario.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
