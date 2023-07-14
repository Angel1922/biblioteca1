using biblioteca.Domain.Entities;
using biblioteca.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;



namespace biblioteca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamoController : ControllerBase
    {
        private readonly INumCorrelativo prestamoRepository;
        public PrestamoController(INumCorrelativo prestamoRepository) 
        {
            this.prestamoRepository = prestamoRepository;
        }
        [HttpGet("GetPrestamo")]
        public IActionResult Get()
        {
            var prestamo = this.prestamoRepository.ObtenerNumCorrelativo();
            return Ok(prestamo);
        }


        // GET api/<PrestamoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var prestamo = this.prestamoRepository.Obtenerprestamo(id);
            return Ok(prestamo);
        }


        // POST api/<PrestamoController>
        [HttpPost("Guardar")]
        public IActionResult Post([FromBody] Prestamo prestamo)
        {
            this.prestamoRepository.Guardar(prestamo);
            return Ok();
        }


        // PUT api/<PrestamoController>/5
        [HttpPost("Actualizar")]
        public IActionResult Put([FromBody] Prestamo prestamo)
        {
            this.prestamoRepository.Actualizar(prestamo);
            return Ok();
        }

       
    }
}
