using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionABM.Modelo;

namespace AdministracionABM
{
    public partial class RubroABM : Form
    {
        public Rubro rubro;

        public RubroABM()
        {
            InitializeComponent();
        }

        private void AddRubro_Load(object sender, EventArgs e)
        {
            this.rubroTableAdapter.Fill(this.ordenesDBDataSetRubro.Rubro);
            rubropadretxt.Text = "0";

            if (rubro != null)
            {
                codigotxt.Text = rubro.Codigo;
                denominaciontxt.Text = rubro.Denominacion;
                rubropadretxt.Text = rubro.RubroPadreId.ToString();
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            var qry = string.Empty;

            try
            {
                if (rubro != null)
                {
                    //update

                    if (rubro.RubroPadreId == 0)
                    {
                        qry = string.Format("UPDATE RUBRO SET Codigo='{0}', Denominacion='{1}' WHERE Id ={2}", codigotxt.Text, denominaciontxt.Text, rubro.Id);
                    }
                    else
                    {
                        qry = string.Format("UPDATE RUBRO SET Codigo='{0}', Denominacion='{1}', RubroPadreId={2} WHERE Id ={3}", codigotxt.Text, denominaciontxt.Text, rubropadretxt.Text, rubro.Id);
                    }
                }
                else
                {
                    //insert
                    var codigo = codigotxt.Text;
                    var denomiacion = denominaciontxt.Text;
                    var rpadreId = int.Parse(rubropadretxt.Text);

                    if (rpadreId == 0)
                    {
                        qry = string.Format("INSERT INTO RUBRO (Codigo, Denominacion) VALUES('{0}','{1}')", codigo, denomiacion);
                    }
                    else
                    {
                        qry = string.Format("INSERT INTO RUBRO (Codigo, Denominacion, RubroPadreId) VALUES('{0}','{1}',{2})", codigo, denomiacion, rpadreId);
                    }
                }
                sqlConection.ExercuteQry(qry);
                rubro = null;
                Hide();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void rpadrecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rubropadretxt.Text = rpadrecombo.SelectedValue.ToString();
        }
    }
}
