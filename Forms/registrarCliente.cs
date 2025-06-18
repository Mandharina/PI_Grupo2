using PI_Grupo2.Entidades;
using PI_Grupo2.Forms;

namespace PI_Grupo2
{
    public partial class frmRegistrarCliente : Form
    {
        private int nuevoDni;
        public frmRegistrarCliente(int dni)
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
            nuevoDni = dni;
            txtDni.Text = nuevoDni.ToString();
        }


        private bool ValidarCampos()
        {
            if (!chkApto.Checked)
            {
                MessageBox.Show("No puede inscribirse si no presenta apto físico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDomicilio.Text) ||
                string.IsNullOrWhiteSpace(cboGenero.Text))
            {
                MessageBox.Show("Debe completar todos los datos requeridos", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!txtDni.Text.All(char.IsDigit) || txtDni.Text.Length < 8)
            {
                MessageBox.Show("El DNI debe contener solo números y al menos 8 dígitos.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!txtTelefono.Text.All(char.IsDigit) || txtTelefono.Text.Length < 8)
            {
                MessageBox.Show("El teléfono debe contener solo números y al menos 8 dígitos.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal principal = new frmPaginaPrincipal();
            principal.Show();
            this.Hide();

        }

        //VALIDACIONES DE ENTRADA DE DATOS
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (!int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultadoDNI = Datos.VerificadorCliente.VerificarDni(dni);
            if (resultadoDNI.Existe)
            {
                MessageBox.Show("El cliente ya está registrado con ese DNI.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            E_Socio socio = new E_Socio
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Dni = dni,
                NumCel = txtTelefono.Text,
                Genero = cboGenero.Text,
                FechaNac = dtpFechaNac.Value,
                Domicilio = txtDomicilio.Text,
                AptoFisico = chkApto.Checked,
                FechaIngreso = DateTime.Today,
                VencCuota = DateTime.Today
            };

            // REGISTRAR SOCIO EN BD Y OBTENER NroCarnet
            int carnetGenerado = new Datos.Clientes().RegistrarSocio(socio);
            socio.NroCarnet = carnetGenerado;
            this.Hide();

            // ABRIR MENU SOCIO PARA PAGO Y EMISION DE CARNET
            frmRegistroSocio socioDTO = new frmRegistroSocio(socio);
            var resultado = socioDTO.ShowDialog();


            if (resultado == DialogResult.OK)
            {
                // REGISTRO OK, VUEVLE AL INICIO
                this.Hide();
            }
            else
            {
                new Datos.Clientes().EliminarSocioPorDni(dni);
                this.Show();
            }

        }

        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int dni;
            if (!int.TryParse(txtDni.Text, out dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDAR SI EL DNI YA EXISTE EN LA BASE DE DATOS
            var resultado = Datos.VerificadorCliente.VerificarDni(dni);
            if (resultado.Existe)
            {
                MessageBox.Show("El cliente ya está registrado con ese DNI.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // CONTINUAR CON EL REGISTRO SI EL DNI NO EXISTE
            E_NoSocio noSocio = new E_NoSocio
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Dni = Convert.ToInt32(txtDni.Text),
                NumCel = txtTelefono.Text,
                Genero = cboGenero.Text,
                FechaNac = dtpFechaNac.Value,
                Domicilio = txtDomicilio.Text,
                AptoFisico = chkApto.Checked
            };

            Datos.Clientes datos = new Datos.Clientes();
            string respuesta = datos.RegistrarNoSocio(noSocio);

            bool esNumero = int.TryParse(respuesta, out int codigo);
            if (esNumero)
            {
                MessageBox.Show($"Cliente registrado como No Socio con éxito. Su número es {codigo}", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error: " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



