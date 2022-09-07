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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

            char separador = Convert.ToChar(",");

            StreamReader srClientes = new StreamReader("clientes.txt");

            while (!srClientes.EndOfStream)
            {
                string[] vecCliente = srClientes.ReadLine().Split(separador);
                cboIDCliente.Items.Add(vecCliente[0]);
            }

            srClientes.Close();

            StreamReader srVendedores = new StreamReader("vendedores.txt");

            while (!srVendedores.EndOfStream)
            {
                string[] vecVendedores = srVendedores.ReadLine().Split(separador);
                cboIDVendedor.Items.Add(vecVendedores[0]);
            }

            srVendedores.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            string varFactura = cboTipo.Text;
            string varIDCliente = cboIDCliente.Text;
            string varIDVendedor = cboIDVendedor.Text;
            string varNumero = cboTipo.Text;
            DateTime varFecha = dtpFecha.Value.Date;
            string varMonto = mskMonto.Text;
            string varMensaje;

            varMensaje = varFactura + "," + varNumero + "," + varFecha + "," + varIDCliente + "," + varIDVendedor + "," + varMonto; 


            StreamWriter swVentas = new StreamWriter("ventas.txt", true);
            swVentas.Write(varMensaje);
            swVentas.Close();





        }

      
    }
}
