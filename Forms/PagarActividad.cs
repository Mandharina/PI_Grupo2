using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PI_Grupo2.Datos;
using PI_Grupo2.Entidades;

namespace PI_Grupo2.Forms
{
    public partial class frmPagarActividad : Form
    {
        private readonly E_NoSocio noSocio;
        private readonly Actividades actividadDatos = new Actividades();
        private readonly PagoActividad pagoDatos = new PagoActividad();


        public frmPagarActividad(E_NoSocio noSocio)
        {
            InitializeComponent();
            this.noSocio = noSocio;
            CargarActividades();
        }

        private void CargarActividades()
        {
            dgvActividades.Rows.Clear();
            List<E_Actividad> actividades = actividadDatos.ListarActividades();

            foreach (var act in actividades)
            {
                int index = dgvActividades.Rows.Add();
                dgvActividades.Rows[index].Cells["Nombre"].Value = act.Nombre;
                dgvActividades.Rows[index].Cells["Descripcion"].Value = act.Descripcion;
                dgvActividades.Rows[index].Cells["Costo"].Value = act.Costo;
                dgvActividades.Rows[index].Cells["Dia"].Value = act.Dia;
                dgvActividades.Rows[index].Cells["Horario"].Value = act.Horario;
                dgvActividades.Rows[index].Cells["Cupos"].Value = act.Cupos;
                dgvActividades.Rows[index].Tag = act;
            }
        }

        private void dgvActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvActividades.Columns[e.ColumnIndex].Name != "btnPagar")
                return;

            var actividad = dgvActividades.Rows[e.RowIndex].Tag as E_Actividad;

            if (actividad == null)
            {
                MessageBox.Show("Error al recuperar la actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (actividad.Cupos <= 0)
            {
                MessageBox.Show("No hay cupos disponibles para esta actividad.", "Sin Cupos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"¿Confirmar pago de la actividad '{actividad.Nombre}' por un monto de {actividad.Costo:C}?",
                "Confirmar Pago",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                var pago = new E_PagoActividad
                {
                    Actividad = actividad.NroActividad,
                    NoSocio = noSocio.NroNoSocio,
                    Monto = actividad.Costo,
                    FechaPago = DateTime.Now
                };

                int nroPago = pagoDatos.RegistrarPago(pago);

                if (nroPago > 0)
                {
                    actividadDatos.ReducirCupo(actividad.NroActividad);
                    MessageBox.Show($"Pago realizado con éxito. N° de comprobante: {nroPago}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarActividades();
                }
                else
                {
                    MessageBox.Show("Error al registrar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void frmPagarActividad_Load(object sender, EventArgs e)
        {
            CargarActividades();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPaginaPrincipal principal = new frmPaginaPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
