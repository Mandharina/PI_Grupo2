using System;
using System.Data;
using PI_Grupo2.Datos;

namespace PI_Grupo2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            //Inicializa la pantalla formulario
            InitializeComponent();
            // Al cerrar la ventana se finaliza el sistema
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingres� tu usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingres� tu usuario";
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Ingres� tu contrase�a")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Ingres� tu contrase�a";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validaci�n de campos vac�os o con texto por defecto
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtUsuario.Text == "Ingres� tu usuario")
            {
                MessageBox.Show("Por favor, ingres� tu usuario.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == "Ingres� tu contrase�a")
            {
                MessageBox.Show("Por favor, ingres� tu contrase�a.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                Usuarios dato = new Usuarios();
                DataTable tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPassword.Text);

                if (tablaLogin.Rows.Count > 0)
                {
                    MessageBox.Show("Ingreso exitoso","Club Deportivo C#", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmPaginaPrincipal principal = new frmPaginaPrincipal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contrase�a incorrectos", "Error de autenticaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurri� un error al intentar iniciar sesi�n:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

