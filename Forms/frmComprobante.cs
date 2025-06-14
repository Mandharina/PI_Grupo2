using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PI_Grupo2.Forms
{
    public partial class frmComprobante : Form
    {
        // Propiedades para recibir datos desde el formulario de pago
        public string NombreSocio { get; set; }
        public int NumeroCarnet { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double Importe { get; set; }
        public string MetodoPago { get; set; }
        public string CantCuotas { get; set; }
        public int NumeroComprobante { get; set; }

        public frmComprobante()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            Load += frmComprobante_Load;
        }

        private void frmComprobante_Load(object sender, EventArgs e)
        {
            
            lblSocio.Text = $"Socio: {NombreSocio}";
            lblCarnet.Text = $"Carnet N°: {NumeroCarnet}";
            lblPago.Text = $"Fecha de pago: {FechaPago.ToShortDateString()}";
            lblVencimiento.Text = $"Fecha de vencimiento: {FechaVencimiento.ToShortDateString()}";
            lblImporte.Text = $"Importe: ${Importe:N2}";
            lblMetodo.Text = $"Método de pago: {MetodoPago}";
            lblCuotas.Text = $"Cantidad de cuotas: {CantCuotas}";
            lblComprobante.Text = $"N° Comprobante: {NumeroComprobante}";
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