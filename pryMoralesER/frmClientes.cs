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
            //Valido si los campos tienen información
            if (mskID.Text != "" && txtNombre.Text != "")
            {
                char separador = Convert.ToChar(",");
                string varID = mskID.Text, varNombre = txtNombre.Text, varMensaje;
                bool repetido = false;

                varMensaje = varID + "," + varNombre;

                //Si el archivo existe, prosigo normal
                if (File.Exists("clientes.txt"))
                {
                    StreamReader srClientes = new StreamReader("clientes.txt");

                    //Leo si el ID esta repetido
                    while (!srClientes.EndOfStream)
                    {
                        string[] vecClientes = srClientes.ReadLine().Split(separador);

                        if (vecClientes[0] == varID)
                        {
                            repetido = true;
                        }
                    }

                    srClientes.Close();

                    if (!repetido)
                    {
                        StreamWriter swClientes = new StreamWriter("clientes.txt", true);
                        swClientes.WriteLine(varMensaje);
                        swClientes.Close();

                        mskID.Clear();
                        txtNombre.Clear();
                        mskID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("ID REPETIDA");
                        mskID.Focus();
                        mskID.SelectAll();
                    }

                    
                }

                //Si no existe primero creo el archivo
                else
                {
                    File.Create("clientes.txt");
                    StreamReader srClientes = new StreamReader("clientes.txt");

                    while (!srClientes.EndOfStream)
                    {
                        string[] vecClientes = srClientes.ReadLine().Split(separador);

                        if (vecClientes[0] == varID)
                        {
                            repetido = true;
                        }
                    }

                    srClientes.Close();

                    if (!repetido)
                    {
                        StreamWriter swClientes = new StreamWriter("clientes.txt", true);
                        swClientes.WriteLine(varMensaje);
                        swClientes.Close();

                        mskID.Clear();
                        txtNombre.Clear();
                        mskID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("ID REPETIDA");
                        mskID.Focus();
                        mskID.SelectAll();
                    }
                }

               

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
