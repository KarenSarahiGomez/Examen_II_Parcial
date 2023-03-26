using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Examen_II_LP3_KSGG
{
    public partial class BuscarclienteForm : Form
    {
        public BuscarclienteForm()
        {
            InitializeComponent();
        }

        ClienteDB clienteDB = new ClienteDB();

        public Cliente cliente = new Cliente();


        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ClientedataGridView.SelectedRows.Count > 0)
            {
                cliente.Identidad = ClientedataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                cliente.Nombre = ClientedataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                cliente.Telefono = ClientedataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                cliente.Correo = ClientedataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                cliente.Direccion = ClientedataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                cliente.FechaNacimiento = Convert.ToDateTime(ClientedataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                cliente.EstaActivo = Convert.ToBoolean(ClientedataGridView.CurrentRow.Cells["EstaActivo"].Value);
                this.Close();
            }
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClientedataGridView.DataSource = clienteDB.DevolverClientesPorNombre(NombretextBox.Text);
        }

        private void BuscarclienteForm_Load(object sender, EventArgs e)
        {
            ClientedataGridView.DataSource = clienteDB.DevolverClientes();
        }
    }
}
