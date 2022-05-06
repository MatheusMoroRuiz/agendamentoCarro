using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agendamento
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string mensagem;
            clsCliente cli = new clsCliente();
            cli.Nome = txtNome.Text;
            cli.Cpf = txtCPF.Text;
            cli.Email = txtEmail.Text;
            cli.Telefone = Convert.ToInt64(txtTelefone.Text);



            mensagem = cli.Salvar();



            MessageBox.Show(mensagem);
        }

        public Int32 codigocliente;
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtTable = new DataTable();
            clsCliente cli = new clsCliente();
            cli.Cpf = txtCPF.Text;
            dtTable = cli.Consulta();

            if (dtTable.Rows.Count != 0)
            {
                foreach (DataRow valor in dtTable.Rows)
                {
                    txtNome.Text = valor[0].ToString();
                    txtEmail.Text = valor[1].ToString();
                    txtTelefone.Text = valor[2].ToString();
                    codigocliente = Convert.ToInt32(valor[3]);
                }
            }
            else
            {
                MessageBox.Show("Cliente não encontrado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string mensagem;
            clsCliente cli = new clsCliente();
            cli.Nome = txtNome.Text;
            cli.Cpf = txtCPF.Text;
            cli.Email = txtEmail.Text;
            cli.Telefone = Convert.ToInt64(txtTelefone.Text);
            cli.Codigocliente = codigocliente;


            mensagem = cli.EditarCliente();



            MessageBox.Show(mensagem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem;
            clsCliente cli = new clsCliente();
            cli.Codigocliente = codigocliente;

            mensagem = cli.ExcluiCliente();

            MessageBox.Show(mensagem);
        }
    }
}
