using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtividadeIngridy.View;

namespace AtividadeIngridy.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            carro.Show();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Show();
        }
    }
}       
   
