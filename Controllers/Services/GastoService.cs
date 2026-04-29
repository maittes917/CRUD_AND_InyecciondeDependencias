using MisGastosApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace MisGastosApi.Services
{
    public class GastoService : IGastoService
    {
        private static List<Gasto> gastos = new List<Gasto>();

        public List<Gasto> GetAll()
        {
            return gastos;
        }

        public Gasto Add(Gasto gasto)
        {
            gasto.Id = gastos.Count + 1;
            gastos.Add(gasto);
            return gasto;
        }

        public Gasto Update(int id, Gasto gastoActualizado)
        {
            var gasto = gastos.FirstOrDefault(g => g.Id == id);
            if (gasto == null) return null;

            gasto.Monto = gastoActualizado.Monto;
            gasto.Categoria = gastoActualizado.Categoria;
            gasto.Fecha = gastoActualizado.Fecha;

            return gasto;
        }

        public bool Delete(int id)
        {
            var gasto = gastos.FirstOrDefault(g => g.Id == id);
            if (gasto == null) return false;

            gastos.Remove(gasto);
            return true;
        }
    }
}