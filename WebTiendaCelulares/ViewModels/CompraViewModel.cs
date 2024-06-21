namespace WebTiendaCelulares.ViewModels
{
    public class CompraViewModel
    {
        public int Id { get; set; }

        public decimal Total { get; set; }

        public DateTime FechaVenta { get; set; }

        public string Usuario { get; set; }

        public string Celular { get; set; }
    }
}
