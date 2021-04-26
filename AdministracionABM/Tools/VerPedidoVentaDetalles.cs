using AdministracionABM.Modelo;
using System;
using System.Windows.Forms;

namespace AdministracionABM.Tools
{
    public partial class VerPedidoVentaDetalles : Form
    {
        public PedidoVenta pedidoVenta;

        public VerPedidoVentaDetalles()
        {
            InitializeComponent();
        }

        private void VerPedidoVentaDetalles_Load(object sender, EventArgs e)
        {
            detalleDatagrid.DataSource = sqlConection.GetTable(string.Format("SELECT * FROM PedidoVentaDetalle Where PedidoVentaID={0}",pedidoVenta.Id));
        }
    }
}
