using MisGastosApi.Models;

namespace MisGastosApi.Services
{
    public class GastoService : IGastoService
    {
        private static List<Gasto> gastos = new List<Gasto>();
        private static int id = 1;

        public List<Gasto> GetAll()
        {
            return gastos;
        }

        public Gasto GetById(int id)
        {
            return gastos.FirstOrDefault(g => g.Id == id);
        }

        public Gasto Add(Gasto gasto)
        {
            gasto.Id = id++;
            gastos.Add(gasto);

            return gasto;
        }

        public Gasto Update(int id, Gasto gastoActualizado)
        {
            var gasto = gastos.FirstOrDefault(g => g.Id == id);

            if (gasto == null)
                return null;

            gasto.Categoria = gastoActualizado.Categoria;
            gasto.Monto = gastoActualizado.Monto;

            return gasto;
        }

        public bool Delete(int id)
        {
            var gasto = gastos.FirstOrDefault(g => g.Id == id);

            if (gasto == null)
                return false;

            gastos.Remove(gasto);

            return true;
        }
    }
}