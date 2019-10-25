using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaPatronDecorador
{
    public partial class frmLogin : Form
    {
        SQL s = new SQL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
          
                frmVenta frmVenta = new frmVenta();
                frmVenta.Show();
                this.Hide();
                if (txtUsuario.Text == "Server" && txtContrasena.Text == "pizza12")
                {
                    frmServer frSrv = new frmServer();
                    frSrv.Show();
                    this.Hide();

                }
                else if (txtUsuario.Text == "Ventas" && txtContrasena.Text == "pizza34")
                {
       
                }
                else
                {
                    MessageBox.Show("Asegúrese de que los datos sean correctos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
      

        }
    }
}
