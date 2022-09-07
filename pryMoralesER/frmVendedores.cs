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
    public partial class frmVendedores : Form
    {
        public frmVendedores()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (mskID.Text != "" && txtNombre.Text != "")
            {
                string varID = mskID.Text, varNombre = txtNombre.Text, varMensaje;
     

                varMensaje = varID + "," + varNombre;

                //COMISIÓM
                if (cbComision.Checked) 
                {
                    varMensaje += ",SI" ;
                }
                else
                {
                    varMensaje += ",NO";
                }

                //ACTIVO
                if (cbActivo.Checked)
                {
                    varMensaje += ",SI";
                }
                else
                {
                    varMensaje += ",NO";
                }

 
                StreamWriter swVendedores = new StreamWriter("vendedores.txt", true);
                swVendedores.WriteLine(varMensaje);
                swVendedores.Close();

                mskID.Clear();
                txtNombre.Clear();
                cbActivo.Checked = false;
                cbComision.Checked = false;

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
