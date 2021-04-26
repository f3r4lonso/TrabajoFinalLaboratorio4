using AdministracionABM.Modelo;
using AdministracionABM.Tools;
using System;
using System.Data;
using System.Windows.Forms;

namespace AdministracionABM
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {
            pedidoVentaDetalle.Enabled = false;
        }

        private void PedidoBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "PedidoVenta";
            dataGridView1.DataSource = sqlConection.GetTable("SELECT * FROM PedidoVenta");
            pedidoVentaDetalle.Enabled = true;
        }

        private void ArticuloBtn_Click(object sender, EventArgs e)
        {
            pedidoVentaDetalle.Enabled = false;
            label1.Text = "Articulo";
            dataGridView1.DataSource = sqlConection.GetTable("SELECT * FROM Articulo");
        }

        private void RubroBtn_Click(object sender, EventArgs e)
        {
            pedidoVentaDetalle.Enabled = false;
            label1.Text = "Rubro";
            dataGridView1.DataSource = sqlConection.GetTable("SELECT * FROM Rubro");
        }

        private void ClienteBtn_Click(object sender, EventArgs e)
        {
            pedidoVentaDetalle.Enabled = false;
            label1.Text = "Cliente";
            dataGridView1.DataSource = sqlConection.GetTable("SELECT * FROM Cliente");
        }

        //agregar
        private void button2_Click(object sender, EventArgs e)
        {

            switch (label1.Text)
            {
                case "":
                    MessageBox.Show("elija un ABM pue!!");
                    break;
                case "Articulo":
                    var articuloForm = new ArticuloABM();
                    articuloForm.ShowDialog();
                    ArticuloBtn_Click(null, null);
                    break;
                case "Rubro":
                    var rubroForm = new RubroABM();
                    rubroForm.ShowDialog();
                    RubroBtn_Click(null, null);
                    break;
                case "Cliente":
                    var clienteForm = new ClienteABM();
                    clienteForm.ShowDialog();
                    ClienteBtn_Click(null, null);
                    break;
                case "PedidoVenta":
                    var pedidoForm = new PedidoVentaABM();
                    pedidoForm.ShowDialog();
                    PedidoBtn_Click(null, null);
                    break;
            }
        }

        //modificar
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (label1.Text)
                {
                    case "":
                        MessageBox.Show("Elija un ABM");
                        break;
                    case "Articulo":

                        if (dataGridView1.SelectedRows.Count != 0)
                        {
                            var articulo = new Articulo();

                            DataGridViewRow row = this.dataGridView1.SelectedRows[0];

                            articulo.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            articulo.Denominacion = row.Cells["Denominacion"].Value.ToString();
                            articulo.Codigo = row.Cells["Codigo"].Value.ToString();
                            articulo.PrecioCompra = Convert.ToDouble(row.Cells["PrecioCompra"].Value);
                            articulo.PrecioVenta = Convert.ToDouble(row.Cells["PrecioVenta"].Value);
                            articulo.iva = Convert.ToDouble(row.Cells["Iva"].Value);

                            if (row.Cells["RubroId"].Value.ToString() != "")
                            {
                                articulo.RubroId = Convert.ToInt32(row.Cells["RubroId"].Value);
                            }
                            else
                            {
                                articulo.RubroId = 0;
                            }

                            var articuloForm = new ArticuloABM();
                            articuloForm.articulo = articulo;
                            articuloForm.ShowDialog();
                            ArticuloBtn_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un row");

                        }

                        break;
                    case "Rubro":

                        if (dataGridView1.SelectedRows.Count != 0)
                        {
                            var rubro = new Rubro();

                            DataGridViewRow row = this.dataGridView1.SelectedRows[0];

                            rubro.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            rubro.Codigo = row.Cells["Codigo"].Value.ToString();
                            rubro.Denominacion = row.Cells["Denominacion"].Value.ToString();

                            if (row.Cells["RubroPadreId"].Value.ToString() != "")
                            {
                                rubro.RubroPadreId = Convert.ToInt32(row.Cells["RubroPadreId"].Value);
                            }
                            else
                            {
                                rubro.RubroPadreId = 0;
                            }


                            var form = new RubroABM();
                            form.rubro = rubro;
                            form.ShowDialog();
                            RubroBtn_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un row");
                        }
                        break;

                    case "Cliente":
                        if (dataGridView1.SelectedRows.Count != 0)
                        {
                            var cliente = new Cliente();
                            cliente.DomicilioCliente = new Domicilio();

                            DataGridViewRow row = this.dataGridView1.SelectedRows[0];

                            cliente.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            cliente.RazonSocial = row.Cells["RazonSocial"].Value.ToString();
                            cliente.Cuit = row.Cells["Cuit"].Value.ToString();
                            cliente.Saldo = Convert.ToDouble(row.Cells["Saldo"].Value);

                            if (row.Cells["DomicilioID"].Value.ToString() != "")
                            {

                                cliente.DomicilioCliente.Id = Convert.ToInt32(row.Cells["DomicilioID"].Value);

                                DataTable domicilioTable = sqlConection.GetTable("SELECT * FROM DOMICILIO WHERE ID=" + cliente.DomicilioCliente.Id);

                                if (domicilioTable != null)
                                {
                                    DataRow row1 = domicilioTable.Rows[0];
                                    cliente.DomicilioCliente.Id = Convert.ToInt32(row1.ItemArray[0]);
                                    cliente.DomicilioCliente.Calle = row1.ItemArray[1].ToString();
                                    cliente.DomicilioCliente.Numero = Convert.ToInt32(row1.ItemArray[2]);
                                    cliente.DomicilioCliente.Localidad = row1.ItemArray[3].ToString();
                                    cliente.DomicilioCliente.Latitud = Convert.ToDecimal(row1.ItemArray[4]);
                                    cliente.DomicilioCliente.Longitud = Convert.ToDecimal(row1.ItemArray[5]);
                                }

                            }

                            var formCLiente = new ClienteABM();
                            formCLiente.cliente = cliente;
                            formCLiente.ShowDialog();
                            ClienteBtn_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un row");
                        }
                        break;
                    case "PedidoVenta":
                        var pedidoForm = new PedidoVentaABM();
                        pedidoForm.Show();
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        //borrar
        private void button3_Click(object sender, EventArgs e)
        {
            var qry = string.Empty;

            try
            {
                switch (label1.Text)
                {
                    case "":
                        MessageBox.Show("Elija un ABM");
                        break;
                    case "Articulo":

                        if (dataGridView1.SelectedRows.Count != 0)
                        {
                            var row = dataGridView1.SelectedRows[0];
                            qry = string.Format("DELETE FROM ARTICULO WHERE ID = {0}", Convert.ToInt32(row.Cells["Id"].Value));
                            sqlConection.ExercuteQry(qry);
                            ArticuloBtn_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una columna");
                        }

                        break;
                    case "Rubro":
                        if (dataGridView1.SelectedRows.Count != 0)
                        {
                            var row = dataGridView1.SelectedRows[0];
                            qry = string.Format("DELETE FROM RUBRO WHERE ID = {0}", Convert.ToInt32(row.Cells["Id"].Value));
                            sqlConection.ExercuteQry(qry);
                            RubroBtn_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una columna");
                        }
                        break;

                    case "Cliente":
                        if (dataGridView1.SelectedRows.Count != 0)
                        {
                            var row = dataGridView1.SelectedRows[0];
                            qry = string.Format("DELETE FROM CLIENTE WHERE ID = {0}", Convert.ToInt32(row.Cells["Id"].Value));
                            sqlConection.ExercuteQry(qry);
                            ClienteBtn_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una columna");
                        }
                        break;
                    case "PedidoVenta":
                        if (dataGridView1.SelectedRows.Count != 0)
                        {
                            var row = dataGridView1.SelectedRows[0];
                            qry = string.Format("DELETE FROM PedidoVenta WHERE ID = {0}", Convert.ToInt32(row.Cells["Id"].Value));
                            sqlConection.ExercuteQry(qry);
                            PedidoBtn_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una columna");
                        }
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void pedidoVentaDetalle_Click(object sender, EventArgs e)
        {

            var pedidoVenta = new PedidoVenta();

            if (dataGridView1.SelectedRows.Count != 0)
            {
                var row = dataGridView1.SelectedRows[0];
                pedidoVenta.Id = Convert.ToInt32(row.Cells["Id"].Value);
                pedidoVenta.ClienteID = Convert.ToInt32(row.Cells["ClienteID"].Value);
            }
            else {
                MessageBox.Show("seleccione un pedido venta para ver los detalles");
                return;
            }

            var pedidoDetalleForm = new VerPedidoVentaDetalles();
            pedidoDetalleForm.pedidoVenta = pedidoVenta;
            pedidoDetalleForm.ShowDialog();
        }
    }
}
