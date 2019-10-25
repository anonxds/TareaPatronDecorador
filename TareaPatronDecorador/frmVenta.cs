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
using Xceed;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace TareaPatronDecorador
{
    public partial class frmVenta : Form
    {
        Pizza p;
        SQL s = new SQL();
        string borrado = "...";
        public frmVenta()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lblVistaPrecio.Text == "...")
            {
                MessageBox.Show("Asegurece de que tanga una pizza por ordenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dgvPizza.Rows.Add(lblVistaBorde.Text, lblVistaPrecio.Text, lblVistaCondimento.Text, lblVistaFecha.Text);
                lblVistaBorde.Text = borrado;
                lblVistaPrecio.Text = Convert.ToString(borrado.ToString()).ToString();
                lblVistaCondimento.Text = Convert.ToString(borrado);
            }
        }

        private void btnBGrueso_Click(object sender, EventArgs e)
        {
            p = new BordeGrueso();
            lblVistaBorde.Text = p.Descripcion();
            lblVistaPrecio.Text = p.precio().ToString();
        }

        private void btnBDelgado_Click(object sender, EventArgs e)
        {
            p = new BordeDelgado();
            lblVistaBorde.Text = p.Descripcion();
            lblVistaPrecio.Text = p.precio().ToString();
        }

        private void btnBMixto_Click(object sender, EventArgs e)
        {
            p = new BordeMixto();
            lblVistaBorde.Text = p.Descripcion();
            lblVistaPrecio.Text = p.precio().ToString();
        }

        private void btnBRelleno_Click(object sender, EventArgs e)
        {
            p = new BordeRelleno();
            lblVistaBorde.Text = p.Descripcion();
            lblVistaPrecio.Text = p.precio().ToString();
        }

        private void btnQueso_Click(object sender, EventArgs e)
        {
            p = new CndQueso(p);
            lblVistaCondimento.Text = p.Descripcion();
            lblVistaPrecio.Text = p.precio().ToString();
        }

        private void btnPeperoni_Click(object sender, EventArgs e)
        {
            p = new CndPeperoni(p);
            lblVistaCondimento.Text = p.Descripcion();
            lblVistaPrecio.Text = p.precio().ToString();
        }

        private void btnJamon_Click(object sender, EventArgs e)
        {
            p = new CndJamon(p);
            lblVistaCondimento.Text = p.Descripcion();
            lblVistaPrecio.Text = p.precio().ToString();
        }

        private void btnSalchicha_Click(object sender, EventArgs e)
        {
            p = new CndSalchicha(p);
            lblVistaCondimento.Text = p.Descripcion();
            lblVistaPrecio.Text = p.precio().ToString();
        }

        private void btnAnchoas_Click(object sender, EventArgs e)
        {
            p = new CndAnchoas(p);
            lblVistaCondimento.Text = p.Descripcion();
            lblVistaPrecio.Text = p.precio().ToString();
        }

        private void btnPina_Click(object sender, EventArgs e)
        {
            p = new CndPina(p);
            lblVistaCondimento.Text = p.Descripcion();
            lblVistaPrecio.Text = p.precio().ToString();
        }


        private void btnTerminar_Click(object sender, EventArgs e)
        {
            s.exportarDataGVaPDF(dgvPizza, "Factura");
            try
            {
                foreach (DataGridViewRow row in dgvPizza.Rows)
                {

                    string masa = Convert.ToString(row.Cells["BordePizza"].Value);
                    string precio = Convert.ToString(row.Cells["Precio"].Value);
                    string condimento = Convert.ToString(row.Cells["Condimento"].Value);
                    string fecha = Convert.ToString(row.Cells["Fecha"].Value);
                    string query = string.Format("insert into pizzeria (BordePizza,Precio,Condimento,Fecha) values ('{0}','{1}','{2}','{3}')", masa, precio, condimento, fecha);
                    s.Exe(query);
                }
                MessageBox.Show("Datos guardados correctamente", "Dato guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la información \n" + ex, "Dato no guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblVistaBorde.Text = borrado;
            lblVistaPrecio.Text = Convert.ToString(borrado.ToString()).ToString();
            lblVistaCondimento.Text = Convert.ToString(borrado);
        }

        private void tmrFecha_Tick(object sender, EventArgs e)
        {
            lblVistaFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\user\dfhc.docx";

            ExportarDgvAWord(dgvPizza, filename);
        }

        private void ExportarDgvAWord(DataGridView dgv, string filename)
        {

            //Creamos el Word
            DocX miWord = DocX.Create(filename);

            //Creamos la tabla
            //Le sumo + 1 para adicionarle el encabezado
            Table miTabla = miWord.AddTable(dgv.RowCount + 1, dgv.ColumnCount);
            miWord.InsertParagraph("Hello Word");

            for (int fila = -1; fila < dgv.RowCount; fila++)
            {
                for (int col = 0; col < dgv.ColumnCount; col++)
                {
                    if (fila == -1) //Es encabezado
                    {
                        //Mediante Bold() cambio a negrita toda la fila
                        miTabla.Rows[0].Cells[col].Paragraphs.First().Append(dgv.Columns[col].HeaderText).Bold();
                    }
                    else //Es otra fila
                    {
                        miTabla.Rows[fila + 1].Cells[col].Paragraphs.First().Append(dgv.Rows[fila].Cells[col].Value.ToString());
                    }
                }
            }

            miWord.InsertTable(miTabla);
            miWord.Save();
        }

        
    }
}


