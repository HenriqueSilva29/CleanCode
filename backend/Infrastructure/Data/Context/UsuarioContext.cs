using backend.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Infrastructure.Data.Context
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> opts) : base(opts) { 

        }

        //public DbSet<Usuario> Usuarios { get; set; }

    }
}
