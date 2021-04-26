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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Entrarbtn_Click(object sender, EventArgs e)
        {
            var qry = string.Format("SELECT * FROM USUARIOS WHERE NOMBRE='{0}' AND PASSWORD = '{1}'", usuariotxt.Text, passwordtxt.Text);
            var table = sqlConection.GetTable(qry);

            if (table.Rows.Count != 0)
            {
                var mainform = new MainWindows();
                mainform.Show();
            }
            else
            {
                MessageBox.Show("Usuario o password incorrecto");
                return;
            }

            this.Hide();
        }

        private void registrarbtn_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            ActiveControl = usuariotxt;
            passwordtxt.PasswordChar = '\u25CF';
        }
    }
}
