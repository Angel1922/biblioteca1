using biblioteca.Domain.Entities;
using biblioteca.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace biblioteca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumCorrelativoController : ControllerBase
    {
        private readonly INumCorrelativo numcorrelativoRepository;
        public NumCorrelativoController(INumCorrelativo numcorrelativoRepository)
        {
            this.numcorrelativoRepository = numcorrelativoRepository;
        }


        // GET: api/<NumCorrelativoController>
        [HttpGet("GetNumCorrelativo")]
        public IActionResult Get()
        {
            var numcorrelativo = this.numcorrelativoRepository.ObtenerNumCorrelativo();
            return Ok(numcorrelativo);
        }

        // GET api/<NumCorrelativoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var numcorrelativo = this.numcorrelativoRepository.ObtenerNumCorrelativo(id);
            return Ok(numcorrelativo);
        }

      
        [HttpPost("Guardar")]
        public IActionResult Post([FromBody] NumeroCorrelativo correlativo)
        {
            this.numcorrelativoRepository.Guardar(correlativo);
            return Ok();
        }

       
        [HttpPost("Actualizar")]
        public IActionResult Put([FromBody] NumeroCorrelativo correlativo)
        {
            this.numcorrelativoRepository.Actualizar(correlativo);
            return Ok();
        }
    }
}
