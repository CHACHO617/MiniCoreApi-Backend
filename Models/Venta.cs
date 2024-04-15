namespace MiniCoreApi1.Models
{
    public class Venta
    {

        public int IdVenta { get; set; }

        public int IdVendedor { get; set; }

        public string Ventas { get; set; } = null!; 
       
        public int Monto { get; set; }

        public DateTime FechaVenta { get; set; }

        public virtual Vendedor IdVendedorNatvigation { get; set; } = null!; 

    }
}
