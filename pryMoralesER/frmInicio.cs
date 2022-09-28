using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMoralesER
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes fClientes = new frmClientes();
            fClientes.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedores fVendedores = new frmVendedores();
            fVendedores.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas fVentas = new frmVentas();
            fVentas.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaClientes fConsultaClientes = new frmConsultaClientes();
            fConsultaClientes.ShowDialog();
        }

        private void vendedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaVendedores fConsultaVendedores = new frmConsultaVendedores();
            fConsultaVendedores.ShowDialog();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaVentas fConsultaVentas = new frmConsultaVentas();
            fConsultaVentas.ShowDialog();
        }
    }
}
