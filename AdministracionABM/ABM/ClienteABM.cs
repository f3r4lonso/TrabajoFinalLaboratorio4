using AdministracionABM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionABM
{
    public partial class ClienteABM : Form
    {
        public Cliente cliente;
        public static Domicilio domicilioObj;

        public ClienteABM()
        {
            InitializeComponent();
        }

        private void ClienteABM_Load(object sender, EventArgs e)
        {
            if (cliente != null) {

                rsocialtxt.Text = cliente.RazonSocial;
                cuittxt.Text = cliente.Cuit;
                saldotxt.Text = cliente.Saldo.ToString();
                calletxt.Text = cliente.DomicilioCliente.Calle;
                numerotxt.Text = cliente.DomicilioCliente.Numero.ToString();
                localidadtxt.Text = cliente.DomicilioCliente.Localidad;
                latitudtxt.Text = cliente.DomicilioCliente.Latitud.ToString();
                longitudtxt.Text = cliente.DomicilioCliente.Longitud.ToString();
            }
        }

        public static void cargarDomicilo(Domicilio domicilio) {

            domicilioObj = domicilio;
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            var buscardomicilio = new BuscarDomicilio();
            buscardomicilio.ShowDialog();

            if (domicilioObj != null)
            {
                calletxt.Text = domicilioObj.Calle;
                numerotxt.Text = domicilioObj.Numero.ToString();
                localidadtxt.Text = domicilioObj.Localidad;
                latitudtxt.Text = domicilioObj.Latitud.ToString();
                longitudtxt.Text = domicilioObj.Longitud.ToString();
            }
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            var qry = string.Empty;
            try
            {
                if (domicilioObj != null)
                {
                    //Hace insert de Cliente con un domicilio existente
                    qry = string.Format("INSERT INTO CLIENTE (RazonSocial, Cuit, Saldo, DomicilioID) VALUES ('{0}','{1}',{2},{3})", rsocialtxt.Text.ToString(), cuittxt.Text.ToString(), double.Parse(saldotxt.Text).ToString(), domicilioObj.Id.ToString());
                    sqlConection.ExercuteQry(qry);
                    qry = string.Empty;
                    domicilioObj = null;
                }
                else if (cliente != null)
                {
                    if (cliente.DomicilioCliente.Id == 0) {
                        qry = string.Format("INSERT INTO DOMICILIO (Calle, Numero, Localidad, Latitud, Longitud) VALUES ('{0}',{1},'{2}',{3},{4})", calletxt.Text, int.Parse(numerotxt.Text), localidadtxt.Text, decimal.Parse(latitudtxt.Text), decimal.Parse(longitudtxt.Text));
                        sqlConection.ExercuteQry(qry);
                    }

                    qry = string.Format("UPDATE DOMICILIO SET Calle='{0}', Numero={1}, Localidad = '{2}', Latitud={3}, Longitud={4} WHERE ID = {5}", calletxt.Text.ToString(), numerotxt.Text.ToString(), localidadtxt.Text.ToString(), Convert.ToDecimal(latitudtxt.Text).ToString(), Convert.ToDecimal(longitudtxt.Text).ToString(), cliente.DomicilioCliente.Id.ToString());
                    sqlConection.ExercuteQry(qry);

                    qry = string.Format("UPDATE Cliente SET RazonSocial='{0}', Cuit='{1}', Saldo= {2}, DomicilioID= {3} WHERE Id = {4}", rsocialtxt.Text, cuittxt.Text, saldotxt.Text, cliente.DomicilioCliente.Id, cliente.Id);
                    sqlConection.ExercuteQry(qry);

                    qry = string.Empty;
                    cliente = null;
                }
                else
                {
                    //hace inser de domicilio nuevo y luego insert de Cliente a ese domicilio
                    qry = string.Format("INSERT INTO DOMICILIO (Calle, Numero, Localidad, Latitud, Longitud) VALUES ('{0}',{1},'{2}',{3},{4})", calletxt.Text, int.Parse(numerotxt.Text), localidadtxt.Text, decimal.Parse(latitudtxt.Text), decimal.Parse(longitudtxt.Text));
                    sqlConection.ExercuteQry(qry);

                    var idDomicilio = sqlConection.GetTable("select max(ID) from [OrdenesDB].[dbo].[Domicilio]");

                    qry = string.Format("INSERT INTO CLIENTE (RazonSocial, Cuit, Saldo, DomicilioID) VALUES ('{0}','{1}',{2},{3})", rsocialtxt.Text.ToString(), cuittxt.Text.ToString(), double.Parse(saldotxt.Text).ToString(), Convert.ToInt32((idDomicilio.Rows[0]).ItemArray[0]));
                    sqlConection.ExercuteQry(qry);

                }
            }
            catch (Exception ex) { MessageBox.Show("Exception: " + ex.Message); }

            Hide();
        }
    }
}
