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
    public partial class BuscarDomicilio : Form
    {
        public BuscarDomicilio()
        {
            InitializeComponent();
        }

        private void BuscarDomicilio_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sqlConection.GetTable("SELECT * FROM Domicilio");
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                var domicilio = new Domicilio();

                DataGridViewRow row = this.dataGridView1.SelectedRows[0];

                domicilio.Id = Convert.ToInt32(row.Cells["Id"].Value);
                domicilio.Calle = row.Cells["Calle"].Value.ToString();
                domicilio.Numero = Convert.ToInt32(row.Cells["Numero"].Value);
                domicilio.Localidad = row.Cells["Localidad"].Value.ToString();
                domicilio.Latitud = Convert.ToDecimal(row.Cells["Latitud"].Value);
                domicilio.Longitud = Convert.ToDecimal(row.Cells["Longitud"].Value);

                ClienteABM.domicilioObj = domicilio;

                this.Hide();
            }
        }
    }
}
