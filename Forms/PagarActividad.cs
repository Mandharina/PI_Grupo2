﻿using System;
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
                MessageBox.Show("No hay cupos disponibles para esta actividad.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"¿Confirmar pago de la actividad '{actividad.Nombre}' por un monto de ${actividad.Costo:0.00}?",
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

                if (nroPago == -1)
                {
                    MessageBox.Show("Ya realizó un pago para esta actividad el día de hoy.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (nroPago > 0)
                {
                    bool reducido = actividadDatos.ReducirCupo(actividad.NroActividad);
                    var resultado = MessageBox.Show(
                   $"Pago exitoso. Comprobante de pago Nº: {nroPago}\n¿Desea imprimir el comprobante?",
                   "AVISO DEL SISTEMA",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
               );

                    if (resultado == DialogResult.Yes)
                    {
                        frmComprobanteActividad comprobante = new frmComprobanteActividad
                        {
                            NombreActividad = actividad.Nombre,
                            NroCliente = noSocio.NroNoSocio,
                            NombreCliente = noSocio.Nombre,
                            ApellidoCliente = noSocio.Apellido,
                            Importe = pago.Monto,
                            FechaPago = pago.FechaPago,
                            NumeroComprobante = nroPago,
                        };

                        comprobante.ShowDialog();
                    }

                    this.DialogResult = DialogResult.OK;

                    CargarActividades();
                }
                else
                {
                    MessageBox.Show("Error al registrar el pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void frmPagarActividad_Load(object sender, EventArgs e)
        {
            CargarActividades();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
