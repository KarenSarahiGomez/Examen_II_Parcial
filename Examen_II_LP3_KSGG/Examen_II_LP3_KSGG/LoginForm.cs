using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Examen_II_LP3_KSGG
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (UsuariotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsuariotextBox, "Ingrese un usuario");
                UsuariotextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                errorProvider1.SetError(ContraseñatextBox, "Ingrese una contraseña");
                ContraseñatextBox.Focus();
                return;
            }
            errorProvider1.Clear();
        }



        //Validar la base de datos
        Login login = new Login();
        Usuario usuario = new Usuario();
        UsuarioDB usuarioDB = new UsuarioDB();

        usuario = usuarioDB.Autenticar(login);

        if (usuario != null)
        {
            if (Usuario.EstaActivo)
            {
                 Menu menuFormulario = new Menu();
        Hide();
        menuFormulario.Show();
                }
                 else
                { 
                     MessageBox.Show("El usuario no esta activo, "Error", MessageButtons.Ok, MessageBoxIcon.Error");

                }
             else
{
    MessageBox.Show("Datos de usuario incorrectos, "Error", MessageButtons.Ok, MessageBoxIcon.Error");
}



private void Mostrarbutton_Click(object sender, EventArgs e)
{
    if (ContraseñatextBox.PasswordChar == '*')
    {
        ContraseñatextBox.PasswordChar = '\0';
    }
    else
    {
        ContraseñatextBox.PasswordChar = '*';
    }
}
    }
}
