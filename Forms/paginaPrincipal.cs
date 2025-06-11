using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_Grupo2.Forms;

namespace PI_Grupo2
{
    public partial class frmPaginaPrincipal : Form
    {
        public frmPaginaPrincipal()
        {
            //Se inicializa el componente/pantalla
            InitializeComponent();
            // Al cerrar la ventana se finaliza el sistema
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            frmVerificarDni verificar = new frmVerificarDni(true); // modo registro
            verificar.Show();
            this.Hide();
        }


        private void btnListarCuotas_Click(object sender, EventArgs e)
        {
            frmListarCuotas listarCuotas = new frmListarCuotas();
            listarCuotas.Show();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmVerificarDni verificar = new frmVerificarDni(false); // modo pagos
            verificar.Show();
            this.Hide();
        }
    }
}
