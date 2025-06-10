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
    public partial class frmRegistroSocio : Form
    {
        private E_Socio nuevoSocio;
        public frmRegistroSocio(E_Socio socio)
        {
            InitializeComponent();
            nuevoSocio = socio;
            btnEmitir.BackColor = Color.White;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmPagarCuota pago = new frmPagarCuota(nuevoSocio);
            var resultado = pago.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                btnEmitir.Enabled = true;
                btnEmitir.BackColor = Color.DarkOrange;
                btnPagar.Enabled = false;
                btnPagar.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("El registro fue cancelado o no se completó el pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            //ACA LOGICA PARA MOSTRAR CARNET A IMPRIMIR
  
            MessageBox.Show("El carnet de socio se emitió correctamente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
