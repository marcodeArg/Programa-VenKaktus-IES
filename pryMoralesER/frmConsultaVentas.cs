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
    public partial class frmConsultaVentas : Form
    {
        public frmConsultaVentas()
        {
            InitializeComponent();
        }

        private void frmConsultaVentas_Load(object sender, EventArgs e)
        {
            if (File.Exists("ventas.txt"))
            {
                char separador = Convert.ToChar(",");
                int contador = 0;

                StreamReader srConsultaVentas = new StreamReader("ventas.txt");

                while (!srConsultaVentas.EndOfStream)
                {
                    string[] vecConsultaVentas = srConsultaVentas.ReadLine().Split(separador);

                    dgvVentas.Rows.Add();

                    dgvVentas.Rows[contador].Cells[0].Value = vecConsultaVentas[0];
                    dgvVentas.Rows[contador].Cells[1].Value = vecConsultaVentas[1];
                    dgvVentas.Rows[contador].Cells[2].Value = vecConsultaVentas[2];
                    dgvVentas.Rows[contador].Cells[3].Value = vecConsultaVentas[3];
                    dgvVentas.Rows[contador].Cells[4].Value = vecConsultaVentas[4];
                    dgvVentas.Rows[contador].Cells[5].Value = vecConsultaVentas[5];

                    contador++;

                }

                srConsultaVentas.Close();
            }
            else
            {
                MessageBox.Show("Error, debe registrar los datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
