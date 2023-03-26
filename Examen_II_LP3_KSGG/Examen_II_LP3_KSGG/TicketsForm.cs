using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Examen_II_LP3_KSGG
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }
        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();
        List<DetalleFactura> ListaDetalles = new List<DetalleFactura>();

        decimal subTotal = 0;
        decimal isv = 0;
        decimal totalAPagar = 0;
        decimal descuento = 0;



        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdentidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IdentidadTextBox.Text))
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverClientesPorIdentidad(IdentidadTextBox.Text);
                NombreClienteTextBox.Text = miCliente.Nombre;
            }
            else
            {
                miCliente = null;
                NombreClienteTextBox.Clear();
            }
        }

        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            BuscarclienteForm form = new BuscarclienteForm();
            form.ShowDialog();

            miCliente = new Cliente();
            miCliente = form.cliente;
            IdentidadTextBox.Text = miCliente.Identidad;
            NombreClienteTextBox.Text = miCliente.Nombre;
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(PrecioTextBox.Text))
            {
                DetalleFactura detalle = new DetalleFactura();
                detalle.Tiposoporte = TiposoportecomboBox.Text;
                detalle.Descripcionsolicitud = DescripcionsolicitudTextBox.Text;
                detalle.Descripcionrespuesta = DescripcionrespuestaTextBox.Text;
                detalle.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                detalle.Total = detalle.Precio;

                subTotal += detalle.Precio;
                isv = subTotal * 0.15M;
                totalAPagar = subTotal + isv - descuento;

                ListaDetalles.Add(detalle);
                DetalleDataGridView.DataSource = null;
                DetalleDataGridView.DataSource = ListaDetalles;

                SubTotaltextBox.Text = subTotal.ToString();
                ISVTextBox.Text = isv.ToString();
                DescuentoTextBox.Text = descuento.ToString();
                TotalTextBox.Text = totalAPagar.ToString();
            }
        }
    }
}
