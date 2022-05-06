using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agendamento
{
    public partial class frmCarro : Form
    {
        public frmCarro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {

        }

        public Int32 codigoCliente;
        private void btnConsultarCpf_Click(object sender, EventArgs e)
        {
            DataTable dtTable = new DataTable();
            clsCarro car = new clsCarro();
            car.Placa = txtPlaca.Text;
            dtTable = car.Consulta();

            if (dtTable.Rows.Count != 0)
            {
                foreach (DataRow valor in dtTable.Rows)
                {
                    codigocarro = Convert.ToInt32(valor[0]);
                    txtMarca.Text = valor[1].ToString();
                    txtModelo.Text = valor[2].ToString();
                    txtPlaca.Text = valor[3].ToString();
                    txtKm.Text = valor[4].ToString();
                }
            }
            else
            {
                MessageBox.Show("Cliente não encontrado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCadastrarCarro_Click_1(object sender, EventArgs e)
        {
            string mensagem;
            clsCarro car = new clsCarro();
            car.Marca = txtMarca.Text;
            car.Modelo = txtModelo.Text;
            car.Placa = txtPlaca.Text;
            car.Km = Convert.ToInt32(txtKm.Text);
            car.CodigoCliente = codigoCliente;



            mensagem = car.Cadastrar();



            MessageBox.Show(mensagem);
        }

        public Int32 codigocarro;
        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem;
            clsCarro car = new clsCarro();
            car.Marca = txtMarca.Text;
            car.Modelo = txtModelo.Text;
            car.Km = Convert.ToInt32(txtKm.Text);
            car.Placa = txtPlaca.Text;
            car.Codigocarro = codigocarro;


            mensagem = car.EditarCarro();



            MessageBox.Show(mensagem);
        }
    }
}
