using LDatos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocio
{
    public interface IPerroRepository
    {
        Task<List<Perro>> ObtenerPerros();

        Task<Perro> ObtenerPerro(int perroId);
        Task<bool> SavePerro(Perro perro);
    }
    public class PerroRepository : IPerroRepository
    {
        private readonly AppDbContext _context;
        public PerroRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Perro> ObtenerPerro(int perroId)
        {

            return await _context!.Perros!.FindAsync(perroId);
        }

        public async Task<List<Perro>> ObtenerPerros()
        {

            return await _context.Perros!.ToListAsync();
        }

        public async Task<bool> SavePerro(Perro perro)
        {
            await _context.Perros!.AddAsync(perro);
            await _context.SaveChangesAsync();
            return   true;
        }
    }
}
