using AdministracionABM.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdministracionABM
{
    public partial class PedidoVentaABM : Form
    {
        public PedidoVenta pedidoVenta;
        public List<PedidoVentaDetalle> detalle;
        public int actualizarDetalle;
        public List<string> listaestados;
        public PedidoVentaABM()
        {
            InitializeComponent();
            detalle = new List<PedidoVentaDetalle>();
            actualizarDetalle = -1;
            ConfigurarGrilla(); articuloscb.SelectedIndex = -1;
        }

        private void PedidoVentaABM_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ordenesDBDataSetArticulo.Articulo' Puede moverla o quitarla según sea necesario.
            this.articuloTableAdapter.Fill(this.ordenesDBDataSetArticulo.Articulo);
            // TODO: esta línea de código carga datos en la tabla 'ordenesDBDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.ordenesDBDataSet.Cliente);

            //Crear archivos de recurso para los estados
            estadocb.Items.Add("pendiente");
            estadocb.Items.Add("enviado");
            estadocb.Items.Add("entregado");
            estadocb.Items.Add("anulado");
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            var qry = string.Empty;

            try
            {
                if (pedidoVenta != null)
                {
                    //UPDATE
                }
                else
                {
                    //INSERT
                    int entregado = 0;

                    if (entregadochb.Checked == true)
                    {
                        entregado = 1;
                    }

                    qry = string.Format("INSERT INTO PedidoVenta (FechaEstimadaEntrega, GastosEnvio, Entregado, FechaPedido, NroPedido, SubTotal, MontoTotal ,ClienteID, Estado) VALUES ('{0}',{1},{2},'{3}',{4},{5},{6},{7},'{8}')", fechaentregadp.Value.ToString("MM/dd/yyyy"), gastosenviotxt.Text.Replace(",", "."), entregado, fechapedidodp.Value.ToString("MM/dd/yyyy"), nropedidotxt.Text, subtotaltxt.Text.Replace(",", "."), montototaltxt.Text.Replace(",", "."), clientecb.SelectedValue, estadocb.Text);
                    sqlConection.ExercuteQry(qry);

                    var idpedidoventa = sqlConection.GetTable("SELECT MAX(Id) FROM PedidoVenta");

                    if (idpedidoventa.Rows.Count != 0)
                    {

                        foreach (PedidoVentaDetalle item in detalle)
                        {
                            var detalleqry = string.Format("INSERT INTO PedidoVentaDetalle (Cantidad, SubTotal, PorcentajeDescuento, PedidoVentaID, ArticuloID) values ({0},{1},{2},{3},{4})", item.Cantidad.ToString(), item.SubTotal.ToString().Replace(",", "."), item.PorcentajeDescuento.ToString().Replace(",", "."), idpedidoventa.Rows[0].ItemArray[0].ToString(), item.ArticuloID.ToString());
                            sqlConection.ExercuteQry(detalleqry);
                        }
                    }
                }

                pedidoVenta = null;
                Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //agregar btn
        private void button1_Click(object sender, EventArgs e)
        {
            var pedidoventadetalle = new PedidoVentaDetalle();

            pedidoventadetalle.ArticuloID = Convert.ToInt32(articuloscb.SelectedValue);
            pedidoventadetalle.Cantidad = Convert.ToInt32(cantidadarticulotxt.Text);
            pedidoventadetalle.SubTotal = Convert.ToDouble(subtotalarticulotxt.Text);
            pedidoventadetalle.PorcentajeDescuento = Convert.ToDouble(descuentoarticulotxt.Text);
            pedidoventadetalle.ArticuloNombre = articuloscb.Text;

            if (actualizarDetalle > -1)
            {
                detalle[actualizarDetalle] = pedidoventadetalle;
            }
            else
            {
                detalle.Add(pedidoventadetalle);
            }

            RefrescarGrillaDetalle();
            button2_Click(null, null);
        }

        private void RefrescarGrillaDetalle()
        {

            dataGridViewDetalle.DataSource = null;
            dataGridViewDetalle.DataSource = detalle;
            dataGridViewDetalle.Refresh();
            calcularPreciosPedidoVenta();

        }

        //limpiar btn
        private void button2_Click(object sender, EventArgs e)
        {
            actualizarDetalle = -1;
            articuloscb.SelectedIndex = -1;
            cantidadarticulotxt.Text = string.Empty;
            subtotalarticulotxt.Text = string.Empty;
            descuentoarticulotxt.Text = string.Empty;
            precioventatxt.Text = string.Empty;
        }

        private void ConfigurarGrilla()
        {
            dataGridViewDetalle.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.DataPropertyName = "ArticuloNombre";
            columna1.HeaderText = "Artuculo";
            dataGridViewDetalle.Columns.Add(columna1);

            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.DataPropertyName = "Cantidad";
            columna2.HeaderText = "Cantidad";
            dataGridViewDetalle.Columns.Add(columna2);

            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.DataPropertyName = "SubTotal";
            columna3.HeaderText = "SubTotal";
            dataGridViewDetalle.Columns.Add(columna3);

            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.DataPropertyName = "PorcentajeDescuento";
            columna4.HeaderText = "Descuento";
            dataGridViewDetalle.Columns.Add(columna4);

            DataGridViewButtonColumn columna5 = new DataGridViewButtonColumn();
            columna5.HeaderText = "Editar";
            columna5.Text = "Editar";
            columna5.UseColumnTextForButtonValue = true;
            dataGridViewDetalle.Columns.Add(columna5);

            DataGridViewButtonColumn columna6 = new DataGridViewButtonColumn();
            columna6.HeaderText = "Eliminar";
            columna6.Text = "Eliminar";
            columna6.UseColumnTextForButtonValue = true;
            dataGridViewDetalle.Columns.Add(columna6);

            //DataGridViewTextBoxColumn columna7 = new DataGridViewTextBoxColumn();
            //columna7.DataPropertyName = "id";
            //columna7.HeaderText = "id";
            //columna7.Visible = false;
            //dataGridViewDetalle.Columns.Add(columna7);
        }

        private void dataGridViewDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = e.RowIndex;
            var columna = e.ColumnIndex;


            switch (columna)
            {
                case 5: //eliminar
                    detalle.RemoveAt(fila);
                    RefrescarGrillaDetalle();
                    break;
                case 4: // editar

                    var pedidoventa = (PedidoVentaDetalle)detalle[fila];
                    articuloscb.SelectedValue = pedidoventa.ArticuloID.ToString();

                    cantidadarticulotxt.Text = pedidoventa.Cantidad.ToString();
                    subtotalarticulotxt.Text = pedidoventa.SubTotal.ToString();
                    descuentoarticulotxt.Text = pedidoventa.PorcentajeDescuento.ToString();

                    actualizarDetalle = fila;

                    break;
            }
        }

        private void articuloscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (articuloscb.SelectedValue == null) { return; }

            var qry = string.Format("SELECT * FROM ARTICULO WHERE ID = {0}", articuloscb.SelectedValue);

            var articulo = sqlConection.GetTable(qry);

            if (articulo.Rows.Count != 0)
            {
                precioventatxt.Text = articulo.Rows[0].ItemArray[4].ToString();
            }
        }

        public void calcularPreciosPedidoVenta()
        {

            decimal subtotalsuma = 0;

            foreach (PedidoVentaDetalle item in detalle)
            {

                subtotalsuma += Convert.ToDecimal(item.SubTotal);
            }

            subtotaltxt.Text = subtotalsuma.ToString();

            if (gastosenviotxt.Text != "")
            {

                subtotalsuma += Convert.ToDecimal(gastosenviotxt.Text);
            }

            montototaltxt.Text = subtotalsuma.ToString();

        }
        public void calcularPreciosPedidoVentaDetalle()
        {

            decimal descuento = 0;
            if (articuloscb.SelectedValue == null) { return; }
            if (descuentoarticulotxt.Text == "")
            {
                descuento = 0;
            }
            else
            {
                descuento = Convert.ToDecimal(descuentoarticulotxt.Text);
            }

            var resutadoDescuento = 1 - (descuento / 100);

            subtotalarticulotxt.Text = ((Convert.ToDecimal(precioventatxt.Text) * Convert.ToInt32(cantidadarticulotxt.Text)) * resutadoDescuento).ToString();

        }

        private void cantidadarticulotxt_TextChanged(object sender, EventArgs e)
        {
            calcularPreciosPedidoVentaDetalle();
        }

        private void descuentoarticulotxt_TextChanged(object sender, EventArgs e)
        {
            calcularPreciosPedidoVentaDetalle();
        }

        private void gastosenviotxt_TextChanged(object sender, EventArgs e)
        {
            calcularPreciosPedidoVenta();
        }
    }
}
