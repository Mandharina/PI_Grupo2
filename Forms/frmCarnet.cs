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
using PI_Grupo2.Entidades;

namespace PI_Grupo2.Forms
{
    public partial class frmCarnet : Form
    {
        private E_Socio socio;


        public frmCarnet(E_Socio socio)
        {
            InitializeComponent();
            this.socio = socio;
        }


        private void frmCarnet_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre: " + socio.Nombre;
            lblApellido.Text = "Apellido: " + socio.Apellido;
            lblNroCarnet.Text = "NRO: " + socio.NroCarnet;
            lblFecha.Text = "Fecha emisión: " + DateTime.Today.ToShortDateString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirCarnet);
            pd.Print();

            btnImprimir.Visible = true;

            MessageBox.Show("Carnet impreso con éxito", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void ImprimirCarnet(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}
