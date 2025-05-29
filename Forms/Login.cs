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
            // Validación de campos vacíos o con texto por defecto
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtUsuario.Text == "Ingresá tu usuario")
            {
                MessageBox.Show("Por favor, ingresá tu usuario.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == "Ingresá tu contraseña")
            {
                MessageBox.Show("Por favor, ingresá tu contraseña.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar iniciar sesión:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

