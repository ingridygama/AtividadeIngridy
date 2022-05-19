using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeIngridy.View
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            // InitializeComponent();
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                txtNome.SelectAll();
                return;
            }
        }

        private void txtRetiro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRetiro.Text))
            {
                MessageBox.Show("Data de retiro é obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRetiro.Focus();
                txtRetiro.SelectAll();
                return;
            }
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("Placa é obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlaca.Focus();
                txtPlaca.SelectAll();
                return;
            }
        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCor.Text))
            {
                MessageBox.Show("Cor é obrigatorio.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCor.Focus();
                txtCor.SelectAll();
                return;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket Cadastrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}