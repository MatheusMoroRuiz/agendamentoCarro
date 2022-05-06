using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agendamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsAgenda age = new clsAgenda();
            dt = age.ConsultaTodos();
            dgvAgenda.DataSource = dt;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            Form4 agenda = new Form4();
            agenda.ShowDialog();
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            frmCarro carro = new frmCarro();
            carro.ShowDialog();
        }

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
