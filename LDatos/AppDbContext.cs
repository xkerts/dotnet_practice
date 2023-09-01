using Microsoft.EntityFrameworkCore;
namespace LDatos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
                
        }

        public DbSet<Perro>? Perros { get; set; }
        public DbSet<Persona>? Personas { get; set; }
    }
}
