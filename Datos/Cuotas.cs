using System.Data;
using MySql.Data.MySqlClient;
using PI_Grupo2.Entidades;

namespace PI_Grupo2.Datos
{
    public class Cuotas
    {
        public int RegistrarCuota(E_Cuota cuota)
        {
            using var con = Conexion.getInstancia().CrearConexion();
            var cmd = new MySqlCommand("RegistrarCuota", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("p_NroSocio", cuota.NroSocio);
            cmd.Parameters.AddWithValue("p_FechaVencimiento", cuota.FechaVencimiento);
            cmd.Parameters.AddWithValue("p_FechaPago", cuota.FechaPago);
            cmd.Parameters.AddWithValue("p_Importe", cuota.Importe);
            cmd.Parameters.AddWithValue("p_MetodoPago", cuota.MetodoPago);
            cmd.Parameters.AddWithValue("p_CantCuotas", cuota.CantCuotas);

            con.Open();
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return Convert.ToInt32(reader["nroCuota"]);
            }

            return -1;
        }
    }
}
