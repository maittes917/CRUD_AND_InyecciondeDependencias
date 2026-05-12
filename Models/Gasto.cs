namespace MisGastosApi.Models
{
    public class Gasto
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public string Categoria { get; set; }
        public DateTime Fecha { get; set; }
    }
}