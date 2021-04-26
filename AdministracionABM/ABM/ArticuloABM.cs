using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdministracionABM
{
    public partial class ArticuloABM : Form
    {
        public Articulo articulo;
        public ArticuloABM()
        {
            InitializeComponent();
        }
        private void AddArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ordenesDBDataSetRubro.Rubro' Puede moverla o quitarla según sea necesario.
            this.rubroTableAdapter.Fill(this.ordenesDBDataSetRubro.Rubro);
            if (articulo != null)
            {
                CargarArticulo();
                button1.Text = "UPDATE";
            }
            else
            {
                button1.Text = "INSERT";
            }
        }

        private void CargarArticulo() {

            denominaciontxt.Text = articulo.Denominacion;
            codigotxt.Text = articulo.Codigo;
            preciocompratxt.Text = articulo.PrecioCompra.ToString();
            precioventatxt.Text = articulo.PrecioVenta.ToString();
            ivatxt.Text = articulo.iva.ToString();
            rubropadreidtxt.Text = articulo.RubroId.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var qry = string.Empty;
            try
            {
                if (articulo != null)
                {
                    if (rubropadreidtxt.Text == "0" || rubropadreidtxt.Text == "")
                    {
                        qry = "UPDATE ARTICULO SET Denominacion = '" + denominaciontxt.Text + "', Codigo = '" + codigotxt.Text + "', PrecioCompra = " + Double.Parse(preciocompratxt.Text) + ", PrecioVenta = " + Double.Parse(precioventatxt.Text) + ", Iva = " + Double.Parse(ivatxt.Text) + ", RubroID = NULL WHERE Id = " + articulo.Id.ToString();
                    }
                    else
                    {
                        qry = "UPDATE ARTICULO SET Denominacion = '" + denominaciontxt.Text + "', Codigo = '" + codigotxt.Text + "', PrecioCompra = " + Double.Parse(preciocompratxt.Text) + ", PrecioVenta = " + Double.Parse(precioventatxt.Text) + ", Iva = " + Double.Parse(ivatxt.Text) + ", RubroID = " + Int32.Parse(rubropadreidtxt.Text) + " WHERE Id = " + articulo.Id.ToString();
                    }
                }
                else
                {
                    if (rubropadreidtxt.Text == "")
                    {
                        qry = string.Format("INSERT INTO ARTICULO (Denominacion, Codigo, PrecioCompra, PrecioVenta, Iva) VALUES ('{0}','{1}',{2},{3},{4})", denominaciontxt.Text, codigotxt.Text, Double.Parse(preciocompratxt.Text), Double.Parse(precioventatxt.Text), Double.Parse(ivatxt.Text));
                    }
                    else
                    {
                        qry = string.Format("INSERT INTO ARTICULO (Denominacion, Codigo, PrecioCompra, PrecioVenta, Iva, RubroID) VALUES ('{0}','{1}',{2},{3},{4},{5})", denominaciontxt.Text, codigotxt.Text, Double.Parse(preciocompratxt.Text), Double.Parse(precioventatxt.Text), Double.Parse(ivatxt.Text), Int32.Parse(rubropadreidtxt.Text));
                    }
                }
                sqlConection.ExercuteQry(qry);
                Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("exeption: " + ex.Message);
            }
        }

        private void preciocompratxt_TextChanged(object sender, EventArgs e)
        {
            double precioCompraDouble;

            var valid = Double.TryParse(preciocompratxt.Text, out precioCompraDouble);

            if (!valid)
            {
                preciocompravalidator.Text = "invalido!!!!";
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void precioventatxt_TextChanged(object sender, EventArgs e)
        {
            double precioventaDouble;

            var valid = double.TryParse(precioventatxt.Text, out precioventaDouble);

            if (!valid)
            {
                precioventavalidator.Text = "invalido!!!!";
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void ivatxt_TextChanged(object sender, EventArgs e)
        {
            double ivadouble;

            var valid = double.TryParse(ivatxt.Text, out ivadouble);

            if (!valid)
            {

                ivavalidator.Text = "invalido!!!!";
                button1.Enabled = false;

            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void rubropadreidtxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rubropadreidtxt.Text = comboBox1.SelectedValue.ToString();
        }
    }
}

