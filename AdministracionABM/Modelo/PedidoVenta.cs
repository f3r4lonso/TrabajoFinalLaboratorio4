using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionABM.Modelo
{
    public class PedidoVenta
    {
        public int Id { get; set; }
        public DateTime FechaEstimadaEntrega { get; set; }
        public decimal GastosEnvio { get; set; }
        public string Estado { get; set; }
        public bool Entregado { get; set; }
        public DateTime FechaPedido { get; set; }
        public long NroPedido { get; set; }
        public decimal SubTotal { get; set; }
        public decimal MontoTotal { get; set; }
        public int ClienteID { get; set; }

        public  int ClienteId { get; set; }
        public  List<PedidoVentaDetalle> PedidoVentaDetalles { get; set; }
    }
}
