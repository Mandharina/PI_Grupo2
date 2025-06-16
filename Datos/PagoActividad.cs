using MySql.Data.MySqlClient;
using PI_Grupo2.Entidades;

namespace PI_Grupo2.Datos
{
    public class PagoActividad
    {
        public int RegistrarPago(E_PagoActividad pago)
        {
            int nroPago = 0;

            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();

                // Verificar si ya existe un pago en el día para esta actividad y este cliente
                string checkQuery = @"SELECT COUNT(*) FROM pagoActividad 
                              WHERE NoSocio = @NoSocio 
                              AND Actividad = @Actividad 
                              AND DATE(FechaPago) = CURDATE();";

                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@NoSocio", pago.NoSocio);
                    checkCmd.Parameters.AddWithValue("@Actividad", pago.Actividad);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        // Ya pagó por esta actividad hoy
                        return -1;
                    }
                }

                // Insertar el pago si no existe uno hoy
                string insertQuery = @"INSERT INTO pagoActividad (NoSocio, Actividad, Monto, FechaPago)
                               VALUES (@NoSocio, @Actividad, @Monto, @FechaPago);
                               SELECT LAST_INSERT_ID();";

                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@NoSocio", pago.NoSocio);
                    insertCmd.Parameters.AddWithValue("@Actividad", pago.Actividad);
                    insertCmd.Parameters.AddWithValue("@Monto", pago.Monto);
                    insertCmd.Parameters.AddWithValue("@FechaPago", pago.FechaPago);

                    nroPago = Convert.ToInt32(insertCmd.ExecuteScalar());
                }
            }

            return nroPago;
        }

    }
}
