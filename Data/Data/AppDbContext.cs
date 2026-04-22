using Microsoft.EntityFrameworkCore;
using MisGastosApi.Models;

namespace MisGastosApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Gasto> Gastos { get; set; }
    }
}