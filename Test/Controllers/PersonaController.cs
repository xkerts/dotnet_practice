using LDatos;
using LNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaRepository _personaRepository;
        public PersonaController(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult> ObtenerPersonas()
        {
            try
            {
                return Ok(await _personaRepository.ObtenerPersonas());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost("[action]")]
        public async Task<ActionResult> GuardarPersona([FromBody] Persona p)
        {
            try
            {
                Persona persona = new Persona
                {
                    Nombre = p.Nombre,
                    Direccion = p.Direccion,
                };
                return Ok(await _personaRepository.SavePersona(persona));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

    }
}
