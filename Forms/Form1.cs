using System;
using System.Data;
using PI_Grupo2.Datos;

namespace PI_Grupo2
{
    public partial class frmPaginaInicio : Form
    {
        public frmPaginaInicio()
        {
            //Inicializa la pantalla formulario
            InitializeComponent();
            // Al cerrar la ventana se finaliza el sistema
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingresá tu usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingresá tu usuario";
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Ingresá tu contraseña")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Ingresá tu contraseña";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // Es la que recibe los  datos desde el formulario
            Usuarios dato = new Usuarios(); // Instanciamos un objeto de tipo usuarios
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPassword.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // Quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso");
                frmPaginaPrincipal principal = new frmPaginaPrincipal();
                principal.Show(); // Mostramos la nueva pantalla

                this.Hide(); // Se oculta la pantalla de login
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

