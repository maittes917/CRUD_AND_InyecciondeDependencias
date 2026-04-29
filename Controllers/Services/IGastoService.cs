using MisGastosApi.Models;
using System.Collections.Generic;

namespace MisGastosApi.Services
{
    public interface IGastoService
    {
        List<Gasto> GetAll();
        Gasto Add(Gasto gasto);
        Gasto Update(int id, Gasto gasto);
        bool Delete(int id);
    }
}
