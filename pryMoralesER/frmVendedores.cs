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
            //Valido si los campos tienen información
            if (mskID.Text != "" && txtNombre.Text != "")
            {
                //Variables
                string varID = mskID.Text, varNombre = txtNombre.Text, varMensaje;
                char separador = Convert.ToChar(",");
                bool repetido = false;

                varMensaje = varID + "," + varNombre;

                //COMISIÓM
                if (cbComision.Checked)
                {
                    varMensaje += ",SI";
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


                //Creo el archivo
                StreamWriter swArchivoVendedores = new StreamWriter("vendedores.txt", true);
                swArchivoVendedores.Close();


                StreamReader srVendedores = new StreamReader("vendedores.txt");

                //Saber si esta repetido el ID
                while (!srVendedores.EndOfStream)
                {
                    string[] vecVendedor = srVendedores.ReadLine().Split(separador);

                    if (vecVendedor[0] == varID)
                    {
                        repetido = true;
                    }

                }

                srVendedores.Close();

                //Si el ID no esta repetido...
                if (!repetido)
                {
                    StreamWriter swVendedores = new StreamWriter("vendedores.txt", true);
                    swVendedores.WriteLine(varMensaje);
                    swVendedores.Close();

                    mskID.Clear();
                    txtNombre.Clear();
                    cbActivo.Checked = false;
                    cbComision.Checked = false;

                    mskID.Focus();
                }
                //Si el ID esta repetido...
                else
                {
                    MessageBox.Show("ID REPETIDA");
                    mskID.Focus();
                    mskID.SelectAll();
                }
            }

            //Si no se llenaron todos los campos necesarios
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
