using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using MetroFramework.Forms;

namespace TareaPatronDecorador
{
    public partial class frmServer : MetroForm
    {
        SQL s = new SQL();
        public frmServer()
        {
            InitializeComponent();
        }
        private void btnCerrarS_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            string usuario = string.Format("select * from Pizzeria where Fecha = '{0}'", dtpFecha.Text);
       }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
