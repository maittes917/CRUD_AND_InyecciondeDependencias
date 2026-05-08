using Microsoft.AspNetCore.Mvc;
using MisGastosApi.Models;
using MisGastosApi.Services;

namespace MisGastosApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GastosController : ControllerBase
    {
        private readonly IGastoService _gastoService;

        public GastosController(IGastoService gastoService)
        {
            _gastoService = gastoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_gastoService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var gasto = _gastoService.GetById(id);

            if (gasto == null)
                return NotFound();

            return Ok(gasto);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Gasto gasto)
        {
            return Ok(_gastoService.Add(gasto));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Gasto gasto)
        {
            var actualizado = _gastoService.Update(id, gasto);

            if (actualizado == null)
                return NotFound();

            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var eliminado = _gastoService.Delete(id);

            if (!eliminado)
                return NotFound();

            return Ok("Gasto eliminado");
        }
    }
}