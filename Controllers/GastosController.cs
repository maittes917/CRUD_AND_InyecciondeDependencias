using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GastosController : ControllerBase
    {
        private static List<Gasto> gastos = new List<Gasto>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(gastos);
        }

        [HttpPost]
        public IActionResult Post(Gasto gasto)
        {
            gasto.Id = gastos.Count + 1;
            gastos.Add(gasto);
            return Ok(gasto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Gasto input)
        {
            var g = gastos.FirstOrDefault(x => x.Id == id);
            if (g == null) return NotFound();

            g.Monto = input.Monto;
            g.Categoria = input.Categoria;
            g.Fecha = input.Fecha;

            return Ok(g);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var g = gastos.FirstOrDefault(x => x.Id == id);
            if (g == null) return NotFound();

            gastos.Remove(g);
            return Ok();
        }
    }

    public class Gasto
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public string Categoria { get; set; }
        public DateTime Fecha { get; set; }
    }
}