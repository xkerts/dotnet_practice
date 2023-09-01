using LDatos;
using LNegocio;
using LViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerroController : ControllerBase
    {
        private readonly IPerroRepository _perroRepository;

        public PerroController(IPerroRepository perroRepository)
        {
                _perroRepository = perroRepository;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult> ObtenerPerros()
        {
            try
            {
                return Ok(await _perroRepository.ObtenerPerros());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost("[action]")]
        public async Task<ActionResult> GuardarPerro([FromBody] PerroRequest request)
        {
            try
            {
                Perro perro = new Perro
                {
                    Nombre = request.Nombre,
                    Direccion = request.Direccion,
                    DuenoId = request.DuenoId
                };
                return Ok(await _perroRepository.SavePerro(perro));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult> ObtenerPerro(int id )
        {
            try
            {
                return Ok(await _perroRepository.ObtenerPerro(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
