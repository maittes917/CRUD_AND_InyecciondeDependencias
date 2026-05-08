using MisGastosApi.Models;

namespace MisGastosApi.Services
{
    public interface IGastoService
    {
        List<Gasto> GetAll();

        Gasto GetById(int id);

        Gasto Add(Gasto gasto);

        Gasto Update(int id, Gasto gasto);

        bool Delete(int id);
    }
}