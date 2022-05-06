using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agendamento
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Int32 codigocarro;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dtTable = new DataTable();
            clsAgenda age = new clsAgenda();
            age.placa = txtPlaca.Text;
            dtTable = age.Consulta();

            if (dtTable.Rows.Count != 0)
            {
                foreach (DataRow valor in dtTable.Rows)
                {
                    codigocarro = Convert.ToInt32(valor[0]);
                }
            }
            else
            {
                MessageBox.Show("Placa não encontrada", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCadastrarAgenda_Click(object sender, EventArgs e)
        {
            string mensagem;
            clsAgenda age = new clsAgenda();
            age.Data = txtData.Text;
            age.Hora = txtHora.Text;
            age.Km = Convert.ToInt32(txtKmAgenda.Text);
            age.Codigocarro = codigocarro;



            mensagem = age.Cadastrar();



            MessageBox.Show(mensagem);
        }
    }
}
