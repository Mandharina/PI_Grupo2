using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Grupo2.Forms
{
    public partial class frmComprobanteActividad : Form
    {

        // Propiedades para recibir datos desde el formulario de pago
        public string NombreActividad { get; set; }
        public int NroCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public DateTime FechaPago { get; set; }
        public double Importe { get; set; }
        public int NumeroComprobante { get; set; }

        public frmComprobanteActividad()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            Load += frmComprobanteActividad_Load;
        }

        private void frmComprobanteActividad_Load(object sender, EventArgs e)
        {

            lblActividad.Text = $"Actividad: {NombreActividad}";
            lblNroCliente.Text = $"Nro de  Cliente: {NroCliente}";
            lblCliente.Text = $"Cliente: {NombreCliente} {ApellidoCliente}";
            lblImporte.Text = $"Importe: ${Importe:N2}";
            lblPago.Text = $"Fecha de pago: {FechaPago.ToShortDateString()}";
            lblComprobante.Text = $"Nro de Comprobante: {NumeroComprobante}";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                Bitmap bmp = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
                ev.Graphics.DrawImage(bmp, 50, 50);
            };

            try
            {
                pd.Print();
                MessageBox.Show("Impresión enviada correctamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
