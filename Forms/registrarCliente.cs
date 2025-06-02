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

namespace PI_Grupo2
{
    public partial class frmRegistrarCliente : Form
    {
        public frmRegistrarCliente()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
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
            dtpFechaNac.Value = DateTime.Today;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal principal = new frmPaginaPrincipal();
            principal.Show();
            this.Hide();

        }

        /* private void btnIngresar_Click(object sender, EventArgs e)
         {
             if (!chkApto.Checked)
             {
                 MessageBox.Show(
                 "No puede inscribirse si no presenta apto físico",
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                 return;
             }



             if (txtNombre.Text == "" || txtApellido.Text == "" ||
             txtDni.Text == "" || txtTelefono.Text == "" || txtDomicilio.Text == "" || cboGenero.Text == "")
             {
                 MessageBox.Show("Debe completar todos los datos requeridos",
                 "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
             }
             else
             {
                 string respuesta;
                 E_Cliente cliente = new E_Cliente();
                 cliente.Nombre = txtNombre.Text;
                 cliente.Apellido = txtApellido.Text;
                 cliente.Dni = Convert.ToInt32(txtDni.Text);
                 cliente.NumCel = txtTelefono.Text;
                 cliente.Genero = cboGenero.Text;
                 cliente.Fecha_nac = dtpFechaNac.Value;
                 cliente.Domicilio = txtDomicilio.Text;

                 // instanciamos para usar el método dentro de Clientes
                 Datos.Clientes datos = new Datos.Clientes();
                 respuesta = datos.Registrar_Cliente(cliente);

                 bool esnumero = int.TryParse(respuesta, out int codigo);
                 if (esnumero)
                 {
                     if (codigo == 1)
                     {
                         MessageBox.Show("CLIENTE YA EXISTE", "AVISO DEL SISTEMA",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                     else
                     {
                         cliente.NroCarnet = codigo;
                         MessageBox.Show("Cliente creado con éxito.Su número de carnet es" + respuesta,
                         "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                 }
                 else
                 {
                     MessageBox.Show("Error: " + respuesta, "AVISO DEL SISTEMA",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
         }
        */


        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            // FALTA DEFINIR PANTALLA DE PAGO, ENTIDAD CUOTA, METODOS Y PROCEDURE
            /*   frmPagoSocio pago = new frmPagoSocio();
               var resultado = pago.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    E_Socio socio = new E_Socio
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Dni = Convert.ToInt32(txtDni.Text),
                        NumCel = txtTelefono.Text,
                        Genero = cboGenero.Text,
                        FechaNac = dtpFechaNac.Value,
                        Domicilio = txtDomicilio.Text,
                        AptoFisico = chkApto.Checked,
                        FechaIngreso = DateTime.Today,
                        VencCuota = DateTime.Today.AddMonths(1),
                        EsActivo = true,
                        CarnetEntregado = true
                    };

                    Datos.Clientes datos = new Datos.Clientes();
                    string respuesta = datos.RegistrarSocio(socio);

                    bool esNumero = int.TryParse(respuesta, out int codigo);
                    if (esNumero)
                    {
                        MessageBox.Show($"Socio registrado con éxito. Su número de carnet es {codigo}", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }*/
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
            if (Datos.VerificadorCliente.VerificarDni(dni))
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


    
    