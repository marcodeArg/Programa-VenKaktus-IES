using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMoralesER
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (mskID.Text != "" && txtNombre.Text != "")
            {
                string varID = mskID.Text, varNombre = txtNombre.Text, varMensaje;

                varMensaje = varID + "," + varNombre;

                StreamWriter swClientes = new StreamWriter("clientes.txt", true);
                swClientes.WriteLine(varMensaje);
                swClientes.Close();

                mskID.Clear();
                txtNombre.Clear();
                mskID.Focus();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (mskID.Text == "")
                {
                    mskID.Focus();
                }
                else
                {
                    txtNombre.Focus();
                }
            }
            
           
        }
    }
}
