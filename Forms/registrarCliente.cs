using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using PI_Grupo2.Datos;
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

            return true;
        }
        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtDomicilio.Text = "";
            cboGenero.SelectedIndex = -1;
            chkApto.Checked = false;
            dtpFechaNac.Value = DateTime.Today.AddYears(-30);
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal principal = new frmPaginaPrincipal();
            principal.Show();
            this.Hide();

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
                VencCuota = DateTime.Today.AddMonths(1)
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
                frmPaginaPrincipal principal = new frmPaginaPrincipal();
                principal.Show();
            }
            else
            {
                // PAGO CANCELADO O RECHAZADO - ELIMINAR SOCIO
                bool eliminado = new Datos.Clientes().EliminarSocioPorDni(dni);

                if (eliminado)
                {
                    MessageBox.Show("El registro fue cancelado o no se completó el pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el socio. Verifique la base de datos.", "ERROR AL ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Error: " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


    
    