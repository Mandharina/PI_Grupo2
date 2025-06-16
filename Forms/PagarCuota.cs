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

            // Valores iniciales
            lblNroSocio.Text = "Socio Nº: " + nuevoSocio.NroCarnet;
            txtImporte.Text = "15000";
            txtImporteFinal.Text = "$15000.00";
            lblVencimiento.Text = "Vence el: "+ nuevoSocio.VencCuota;

            // Eventos
            rbtnEfectivo.CheckedChanged += MetodoPago_CheckedChanged;
            rbtnTarjeta.CheckedChanged += MetodoPago_CheckedChanged;

            rbtn1.CheckedChanged += Cuotas_CheckedChanged;
            rbtn3.CheckedChanged += Cuotas_CheckedChanged;
            rbtn6.CheckedChanged += Cuotas_CheckedChanged;
            rbtn9.CheckedChanged += Cuotas_CheckedChanged;
            rbtn12.CheckedChanged += Cuotas_CheckedChanged;
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

        private void Cuotas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarImporteFinal();
        }

        private void ActualizarImporteFinal()
        {
            if (!double.TryParse(txtImporte.Text.Replace("$", "").Trim(), out double importeBase))
            {
                txtImporteFinal.Text = "Error";
                return;
            }

            double interes = 0;

            if (rbtnTarjeta.Checked)
            {
                if (rbtn9.Checked || rbtn12.Checked)
                {
                    interes = 0.20;
                }
            }

            double importeFinal = importeBase + (importeBase * interes);
            txtImporteFinal.Text = $"${importeFinal:0.00}";
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            string metodoPago = "";
            double importeBase;
            double importeFinal;
            int cuotas = 1;

            // Verificar si el socio puede pagar (faltan 30 días o menos para el vencimiento)
            TimeSpan diferencia = nuevoSocio.VencCuota - DateTime.Today;
            if (diferencia.TotalDays > 30)
            {
                MessageBox.Show("La cuota aún no puede pagarse. Faltan más de 30 días para el vencimiento.",
                                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validar importe
            if (!double.TryParse(txtImporte.Text.Replace("$", "").Trim(), out importeBase))
            {
                MessageBox.Show("Ingrese un importe válido.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            importeFinal = importeBase;

            if (rbtnEfectivo.Checked)
            {
                metodoPago = "Efectivo";
                cuotas = 1;
            }
            else if (rbtnTarjeta.Checked)
            {
                metodoPago = "Tarjeta";
                double interes = 0;

                if (rbtn1.Checked) cuotas = 1;
                else if (rbtn3.Checked) cuotas = 3;
                else if (rbtn6.Checked) cuotas = 6;
                else if (rbtn9.Checked) { cuotas = 9; interes = 0.20; }
                else if (rbtn12.Checked) { cuotas = 12; interes = 0.20; }
                else
                {
                    MessageBox.Show("Seleccione la cantidad de cuotas.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                importeFinal += importeBase * interes;
            }
            else
            {
                MessageBox.Show("Seleccione un método de pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar el importe final calculado
            txtImporteFinal.Text = $"${importeFinal:0.00}";

            // Crear cuota con vencimiento actual
            E_Cuota cuota = new E_Cuota
            {
                NroSocio = nuevoSocio.NroCarnet,
                FechaPago = DateTime.Now,
                FechaVencimiento = nuevoSocio.VencCuota,
                Importe = importeFinal,
                MetodoPago = metodoPago,
                CantCuotas = cuotas
            };

            Cuotas datosCuota = new Cuotas();
            int nroComprobante = datosCuota.RegistrarCuota(cuota);

            // Actualizar fecha de vencimiento del socio (sumar 1 mes)
            Clientes cliente = new Clientes();
            DateTime nuevoVenc = nuevoSocio.VencCuota.AddMonths(1);
            bool actualizado = cliente.ActualizarVencimiento(nuevoSocio.NroCarnet, nuevoVenc);

            if (!actualizado)
            {
                MessageBox.Show("No se pudo actualizar la fecha de vencimiento del socio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ACTUALIZACIÓN LOCAL del objeto socio
                nuevoSocio.VencCuota = nuevoVenc;
            }

            ultimaCuota = cuota;
            ultimoComprobante = nroComprobante;

            var resultado = MessageBox.Show(
                $"Pago exitoso. Comprobante de pago Nº: {nroComprobante}\n¿Desea imprimir el comprobante?",
                "AVISO DEL SISTEMA",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
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
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
       
    }
}
