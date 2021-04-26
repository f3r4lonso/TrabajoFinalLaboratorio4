using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionABM.Modelo
{
    public class PedidoVentaDetalle
    {
        public PedidoVentaDetalle() { }

        public int id { get; set; }
        public int Cantidad { get; set; }
        public double SubTotal { get; set; }
        public double PorcentajeDescuento { get; set; }
        public int PedidoVentaID { get; set; }
        public int ArticuloID { get; set; }

        public string ArticuloNombre { get; set; }
    }
}
