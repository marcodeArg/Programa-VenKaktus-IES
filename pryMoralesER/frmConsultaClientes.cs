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
    public partial class frmConsultaClientes : Form
    {
        public frmConsultaClientes()
        {
            InitializeComponent();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            if (File.Exists("clientes.txt"))
            {
                char separador = Convert.ToChar(",");
                int contador = 0;

                StreamReader srConsultaClientes = new StreamReader("clientes.txt");

                while (!srConsultaClientes.EndOfStream)
                {
                    string[] vecConsultaVentas = srConsultaClientes.ReadLine().Split(separador);

                    dgvClientes.Rows.Add();

                    dgvClientes.Rows[contador].Cells[0].Value = vecConsultaVentas[0];
                    dgvClientes.Rows[contador].Cells[1].Value = vecConsultaVentas[1];

                    contador++;
                }

                srConsultaClientes.Close();
            }
            else
            {
                MessageBox.Show("Error, debe registrar los datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
