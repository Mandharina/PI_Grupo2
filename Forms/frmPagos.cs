using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_Grupo2.Entidades;

namespace PI_Grupo2.Forms
{
    public partial class frmPagos : Form
    {
        private E_Socio nuevoSocio;

        public frmPagos()
        {
            InitializeComponent();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            frmPagarCuota pago = new frmPagarCuota(nuevoSocio);
            var resultado = pago.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("El registro fue cancelado o no se completó el pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
