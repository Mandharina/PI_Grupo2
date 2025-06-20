﻿using PI_Grupo2.Entidades;

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
                MessageBox.Show("Registro exitoso. Nro de Socio: " + nuevoSocio.NroCarnet + ".", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEmitir.Enabled = true;
                btnEmitir.BackColor = Color.DarkOrange;
                btnPagar.Enabled = false;
                btnPagar.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("El registro fue cancelado por falta de pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El registro fue cancelado.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {

            frmCarnet carnet = new frmCarnet(nuevoSocio);
            carnet.ShowDialog();

            MessageBox.Show("El socio se registró y su carnet se emitió correctamente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmRegistroSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
