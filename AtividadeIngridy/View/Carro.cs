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
    public partial class Carro : Form
    {
        public Carro()
        {
            InitializeComponent();
        }

        private void txtCarro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCarro.Text))
            {
                MessageBox.Show("Nome Carro é obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCarro.Focus();
                txtCarro.SelectAll();
                return;
            }
        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCor.Text))
            {
                MessageBox.Show("Cor do Carro é obrigatoria.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCor.Focus();
                txtCor.SelectAll();
                return;
            }
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Marca do carro é obrigatoria.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                txtMarca.SelectAll();
                return;
            }
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("Placa do carro é obrigatoria.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlaca.Focus();
                txtPlaca.SelectAll();
                return;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carro cadastrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}