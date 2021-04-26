namespace AdministracionABM
{
    public class Domicilio
    {
        public Domicilio()
        {
        }

        public int Id { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Localidad { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
    }
}