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
    public partial class Cliente : Form
    {
        public Cliente()
        {
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

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCelular.Text))
            {
                MessageBox.Show("Celular é obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCelular.Focus();
                txtCelular.SelectAll();
                return;
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email é obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                MessageBox.Show("CPF é obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                txtCpf.SelectAll();
                return;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente Cadastrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    }
