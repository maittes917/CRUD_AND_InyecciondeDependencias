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

        [HttpPost]
        public IActionResult Post([FromBody] Gasto gasto)
         {
             _gastoService.Add(gasto);
               return Ok(gasto);
}

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Gasto gasto)
        {
            var actualizado = _gastoService.Update(id, gasto);
            if (actualizado == null) return NotFound();

            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var eliminado = _gastoService.Delete(id);
            if (!eliminado) return NotFound();

            return Ok("Eliminado");
        }
    }
}