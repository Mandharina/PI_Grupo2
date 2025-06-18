using System.Data;
using MySql.Data.MySqlClient;
using PI_Grupo2.Datos;

namespace PI_Grupo2.Forms
{
    public partial class frmListarCuotas : Form
    {
        public frmListarCuotas()
        {
            InitializeComponent();
        }

        private void listarCuotasfrm_Load(object sender, EventArgs e)
        {
            CargarGrilla();//llamamos al procedimiento para dibujar la grilla de las cuotas
        }

        private void CargarGrilla()
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "SELECT s.NroCarnet AS Socio,c.Importe,c.FechaVencimiento,IF(c.FechaPago IS NOT NULL, 'Paga', 'Pendiente') AS Estado FROM cuota c JOIN socio s ON c.NroSocio = s.NroCarnet WHERE c.FechaVencimiento = CURDATE()  ORDER BY c.FechaVencimiento;";
                //query a la base de datos para seleccionar los socios y las cuotas que vencen en el día
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvListarCuotas.Rows.Add();
                        dtgvListarCuotas.Rows[renglon].Cells[0].Value = reader.GetInt32(0);  // NroCarnet
                        dtgvListarCuotas.Rows[renglon].Cells[1].Value = reader.GetDouble(1); // Importe
                        dtgvListarCuotas.Rows[renglon].Cells[2].Value = reader.GetDateTime(2).ToShortDateString(); // FechaVenc
                        dtgvListarCuotas.Rows[renglon].Cells[3].Value = reader.GetString(3); // Estado
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY VENCIMIENTOS EN EL DÍA DE LA FECHA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }



    }
}

