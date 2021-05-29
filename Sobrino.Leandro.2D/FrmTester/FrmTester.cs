using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmTester
{
    public partial class FrmTester : Form
    {
        private Vendedor v;

        public FrmTester()
        {
            InitializeComponent();
            this.v = new Vendedor("Leandro");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTester_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);
            lstStock.Items.Add(p1);
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);
        }
        /// <summary>
        /// Al hacer click en el boton se realiza una venta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            if (lstStock.SelectedItem != null)
            {
                bool seAgrego = this.v + (Publicacion)lstStock.SelectedItem;
                if (seAgrego)
                {
                    MessageBox.Show($"Se pudo vender un ejemplar de {(Publicacion)lstStock.SelectedItem}");
                }
                else
                {
                    MessageBox.Show($"No queda stock de {(Publicacion)lstStock.SelectedItem}");
                }
            }
            else 
            {
                MessageBox.Show("No se seleccionó nada.");
            }

        }
        /// <summary>
        /// Al hacer click en el boton se muestra el informe del vendedor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            rtbInforme.Text = Vendedor.InformeDeVentas(v);
        }
        /// <summary>
        /// Al hacer click en el boton se sale del programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Evento para chequear si se quiere salir del programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTester_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del programa?","Salida del programa",
                                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
