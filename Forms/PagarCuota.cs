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
    public partial class frmPagarCuota : Form
    {
        private E_Socio nuevoSocio;
        private E_Cuota ultimaCuota;
        private int ultimoComprobante;

        public frmPagarCuota(E_Socio socio)
        {
            InitializeComponent();
            nuevoSocio = socio;
            txtImporte.Text = "15000";
            rbtnEfectivo.CheckedChanged += MetodoPago_CheckedChanged;
            rbtnTarjeta.CheckedChanged += MetodoPago_CheckedChanged;
            btnImprimirComprobante.Enabled = false; // Desactiva el botón al iniciar el form
        }

        private void MetodoPago_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTarjeta.Checked)
            {
                gbxCuotas.Visible = true;
            }
            else
            {
                gbxCuotas.Visible = false;
            }
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            string metodoPago;
            string cuotas = "1";

            if (rbtnEfectivo.Checked)
            {
                metodoPago = "Efectivo";
                gbxCuotas.Visible = false;
                cuotas = "1"; // Por defecto en efectivo es 1 cuota
            }
            else if (rbtnTarjeta.Checked)
            {
                metodoPago = "Tarjeta";
                gbxCuotas.Visible = true;

                // Determinar cantidad de cuotas
                if (rbtn1.Checked)
                {
                    cuotas = "1";
                }
                else if (rbtn3.Checked)
                {
                    cuotas = "3";
                }
                else if (rbtn6.Checked)
                {
                    cuotas = "6";
                }
                else
                {
                    MessageBox.Show("Seleccione la cantidad de cuotas.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un método de pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Validar importe
            if (!double.TryParse(txtImporte.Text.Replace("$", "").Trim(), out double importe))
            {
                MessageBox.Show("Ingrese un importe válido.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            E_Cuota cuota = new E_Cuota
            {
                NroSocio = nuevoSocio.NroCarnet,
                FechaPago = DateTime.Now,
                FechaVencimiento = nuevoSocio.VencCuota,
                Importe = importe,
                MetodoPago = metodoPago,
                CantCuotas = cuotas
            };

            Cuotas datosCuota = new Cuotas();

            int nroComprobante = datosCuota.RegistrarCuota(cuota);
            ultimaCuota = cuota;
            ultimoComprobante = nroComprobante;

            var resultado = MessageBox.Show($"Pago exitoso. Comprobante de pago Nº: {nroComprobante}\n¿Desea imprimir el comprobante?","AVISO DEL SISTEMA",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                btnImprimirComprobante.Enabled = true;
                // El usuario debe presionar el botón manualmente
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                frmPaginaPrincipal principal = new frmPaginaPrincipal();
                principal.Show();
                this.Close();
            }
                      

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnImprimirComprobante_Click(object sender, EventArgs e)
        {

            frmComprobante comprobante = new frmComprobante
            {
                NombreSocio = nuevoSocio.Nombre,
                NumeroCarnet = nuevoSocio.NroCarnet,
                FechaPago = ultimaCuota.FechaPago,
                FechaVencimiento = ultimaCuota.FechaVencimiento,
                Importe = ultimaCuota.Importe,
                MetodoPago = ultimaCuota.MetodoPago,
                CantCuotas = ultimaCuota.CantCuotas,
                NumeroComprobante = ultimoComprobante
            };

            comprobante.ShowDialog();
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }
    }
}
