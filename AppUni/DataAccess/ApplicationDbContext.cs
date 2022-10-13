using AppUni.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppUni.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Facultad> Facultades { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
