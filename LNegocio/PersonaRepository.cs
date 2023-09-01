using LDatos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocio
{
    public interface IPersonaRepository
    {
        Task<List<Persona>> ObtenerPersonas();

        Task<Persona> ObtenerPersona(int personaId);
        Task<bool> SavePersona(Persona persona);
    }
    public class PersonaRepository : IPersonaRepository
    {
        private readonly AppDbContext _context;
        public PersonaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Persona> ObtenerPersona(int personaId)
        {

            return await _context!.Personas!.FindAsync(personaId);
        }

        public async Task<List<Persona>> ObtenerPersonas()
        {

            return await _context.Personas!.
                Include(p=>p.Mascotas).
                ToListAsync();
        }

        public async Task<bool> SavePersona(Persona persona)
        {
            await _context.Personas!.AddAsync(persona);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
