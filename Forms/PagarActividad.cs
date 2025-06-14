using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_Grupo2.Datos;
using PI_Grupo2.Entidades;

namespace PI_Grupo2.Forms
{
    public partial class frmPagarActividad : Form
    {
        private E_NoSocio noSocio;
        public frmPagarActividad(E_NoSocio noSocio)
        {
            InitializeComponent();
            this.noSocio = noSocio;
        }
        private void frmPagarActividad_Load(object sender, EventArgs e)
        {
            CargarActividades(); // Se llama al métoro para traer la actividad para el combobox
        }
        private void CargarActividades()
        {
            Actividades datos = new Actividades();
            List<E_Actividad> lista = datos.ListarActividades();

            cboActividades.DataSource = lista;
            cboActividades.DisplayMember = "Nombre";
            cboActividades.ValueMember = "NroActividad";
        }

        private void cboActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboActividades.SelectedItem is E_Actividad actividadSeleccionada)
            {
                txtImporte.Text = actividadSeleccionada.Costo.ToString("N2");
            }
            else
            {
                txtImporte.Text = "";
            }
        }

        private void btnPagarActividad_Click(object sender, EventArgs e)
        {
            if (cboActividades.SelectedItem is E_Actividad actividadSeleccionada)
            {
                E_PagoActividad nuevoPago = new E_PagoActividad
                {
                    NoSocio = noSocio.NroNoSocio,
                    Actividad = actividadSeleccionada.NroActividad,
                    Monto = actividadSeleccionada.Costo,
                    FechaPago = DateTime.Today
                };

                PagoActividad datosPago = new PagoActividad();
                int nroPago = datosPago.RegistrarPago(nuevoPago);

                MessageBox.Show($"Pago exitoso. N° de comprobante: {nroPago}", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPaginaPrincipal principal = new frmPaginaPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seleccione una actividad válida.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El pago fue cancelado o no se completó.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmPaginaPrincipal principal = new frmPaginaPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnImprimirComprobante_Click(object sender, EventArgs e)
        {

        }
    }
}
