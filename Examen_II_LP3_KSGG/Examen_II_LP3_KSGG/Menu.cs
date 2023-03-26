using System;
using System.Windows.Forms;

namespace Examen_II_LP3_KSGG
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripButton1_Click(object sender, EventArgs e)
        {
            UsuarioForm userForm = new UsuarioForm();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void ClientesToolStripButton1_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.MdiParent = this;
            clienteForm.Show();
        }

        private void TicketsToolStripButton2_Click(object sender, EventArgs e)
        {
            TicketsForm ticketForm = new TicketsForm();
            ticketForm.MdiParent = this;
            ticketForm.Show();
        }
    }
}
