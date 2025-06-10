using System;
using System.Windows.Forms;


namespace PI_Grupo2
{
    public partial class frmVerificarDni : Form
    {
        public frmVerificarDni()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor ingrese un DNI.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDni.Text.Length < 8)
            {
                MessageBox.Show("El DNI debe tener al menos 8 dígitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool existe = Datos.VerificadorCliente.VerificarDni(dni);

            if (existe)
            {
                MessageBox.Show("El cliente ya está registrado.", "Cliente existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Puede continuar con el registro.", "Cliente inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmRegistrarCliente registar_cliente = new frmRegistrarCliente(dni);
                registar_cliente.Show();
                this.Hide();
            }
        }


        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y no espacios
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                MessageBox.Show("Solo se permiten números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal principal = new frmPaginaPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}


