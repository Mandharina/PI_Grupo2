using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //frmRegistrarCliente registar_cliente = new frmRegistrarCliente();
            //registar_cliente.Show();
            frmVerificarDni verificar_cliente = new frmVerificarDni();
            verificar_cliente.Show();

            this.Hide();
        }

    }
}
