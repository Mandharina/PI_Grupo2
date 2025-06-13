using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                string query = @"INSERT INTO pagoActividad (NoSocio, Actividad, Monto, FechaPago)
                                 VALUES (@NoSocio, @Actividad, @Monto, @FechaPago);
                                 SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NoSocio", pago.NoSocio);
                    cmd.Parameters.AddWithValue("@Actividad", pago.Actividad);
                    cmd.Parameters.AddWithValue("@Monto", pago.Monto);
                    cmd.Parameters.AddWithValue("@FechaPago", pago.FechaPago);

                    nroPago = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return nroPago;
        }
    }
}
