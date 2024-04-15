namespace MiniCoreApi1.Models
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }

        public string NombreVendedor { get; set; }

        public virtual ICollection<Venta> Ventas { get; } = new List<Venta>();
    }
}
