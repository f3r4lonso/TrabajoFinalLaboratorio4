namespace AdministracionABM
{
    public class Articulo
    {
        public Articulo()
        {

        }

        public int Id { get; set; }
        public string Denominacion { get; set; }
        public string Codigo { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public double iva { get; set; }
        public int RubroId { get; set; }

    }
}