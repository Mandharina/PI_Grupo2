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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal principal = new frmPaginaPrincipal();
            principal.Show();
            this.Hide();

        }
        private void btnIngresar_Click(object sender, EventArgs e)
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

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            cboGenero.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            chkApto.Checked = false;
        }
    }
}


    
    