using System;
using System.Windows.Forms;
using PI_Grupo2.Datos;
using PI_Grupo2.Entidades;
using PI_Grupo2.Forms;


namespace PI_Grupo2
{
    public partial class frmVerificarDni : Form
    {

        private readonly bool esParaRegistro;

        public frmVerificarDni(bool esParaRegistro)
        {
            InitializeComponent();
            this.esParaRegistro = esParaRegistro;
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

            var resultado = VerificadorCliente.VerificarDni(dni);

            if (esParaRegistro)
            {
                if (resultado.Existe)
                {
                    MessageBox.Show("El cliente ya está registrado.", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmRegistrarCliente registrar = new frmRegistrarCliente(dni);
                    registrar.Show();
                    this.Hide();
                }
            }
            else // es para pagos
            {
                if (!resultado.Existe)
                {
                    MessageBox.Show("El cliente no está registrado.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (resultado.NumeroIdentificador == null)
                {
                    MessageBox.Show("Error: no se pudo obtener el identificador del cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (resultado.EsSocio)
                {
                    Clientes datosCliente = new Clientes();
                    E_Socio? socioCompleto = datosCliente.BuscarSocioPorDniONro(resultado.NumeroIdentificador.Value);

                    if (socioCompleto == null)
                    {
                        MessageBox.Show("No se pudo cargar la información del socio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    frmPagarCuota pago = new frmPagarCuota(socioCompleto);
                    var resultadoPago = pago.ShowDialog(); 

                    if (resultadoPago == DialogResult.OK)
                    {
                        frmPaginaPrincipal principal = new frmPaginaPrincipal();
                        principal.Show();
                        this.Hide();
                    }
                }
                else
                {
                    E_NoSocio noSocioTemp = new E_NoSocio
                    {
                       NroNoSocio = resultado.NumeroIdentificador.Value,
                         
                    };
                    MessageBox.Show("El cliente está registrado pero no es socio.", "No Socio Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPagarActividad pagarActividad = new frmPagarActividad(noSocioTemp);
                    pagarActividad.Show();
                    this.Hide();
                }

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

        private void frmVerificarDni_Load(object sender, EventArgs e)
        {

        }
    }
}


