using System;
using System.Windows.Forms;


namespace PI_Grupo2
{
    public partial class frmVerificarDni : Form
    {
        public frmVerificarDni()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor ingrese un DNI.");
                return;
            }

            if (!int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.");
                return;
            }

            bool existe = Datos.VerificadorCliente.VerificarDni(dni);

            if (existe)
            {
                MessageBox.Show("El cliente ya está registrado.");
            }
            else
            {
                MessageBox.Show("DNI no registrado. Puede continuar con el registro.");

                frmRegistrarCliente registar_cliente = new frmRegistrarCliente();
                registar_cliente.Show();
                this.Hide();
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}


