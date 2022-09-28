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
    public partial class frmConsultaVendedores : Form
    {
        public frmConsultaVendedores()
        {
            InitializeComponent();
        }

        private void frmConsultaVendedores_Load(object sender, EventArgs e)
        {
            if (File.Exists("vendedores.txt"))
            {
                char separador = Convert.ToChar(",");
                int contador = 0;

                StreamReader srConsultaVendedores = new StreamReader("vendedores.txt");
                
                while (!srConsultaVendedores.EndOfStream)
                {
                    string[] vecConsultaVendedores = srConsultaVendedores.ReadLine().Split(separador);

                    dgvVendedores.Rows.Add();

                    dgvVendedores.Rows[contador].Cells[0].Value = vecConsultaVendedores[0];
                    dgvVendedores.Rows[contador].Cells[1].Value = vecConsultaVendedores[1];
                    dgvVendedores.Rows[contador].Cells[2].Value = vecConsultaVendedores[2];
                    dgvVendedores.Rows[contador].Cells[3].Value = vecConsultaVendedores[3];

                    contador++;
                }

                srConsultaVendedores.Close();
            }
            else
            {
                MessageBox.Show("Error, debe registrar los datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
