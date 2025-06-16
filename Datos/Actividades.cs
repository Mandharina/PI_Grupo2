using MySql.Data.MySqlClient;
using PI_Grupo2.Entidades;

namespace PI_Grupo2.Datos
{
    public class Actividades
    {
        public List<E_Actividad> ListarActividades()
        {
            List<E_Actividad> lista = new List<E_Actividad>();

            try
            {
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();
                    string query = "SELECT * FROM actividad";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            E_Actividad act = new E_Actividad()
                            {
                                NroActividad = Convert.ToInt32(dr["NroActividad"]),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Costo = Convert.ToDouble(dr["Costo"]),
                                Dia = dr["Dia"].ToString(),
                                Horario = dr["Horario"].ToString(),
                                Cupos = Convert.ToInt32(dr["Cupos"])
                            };

                            lista.Add(act);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener actividades: " + ex.Message);
            }

            return lista;
        }

        public bool ReducirCupo(int nroActividad)
        {
            using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
            {
                conexion.Open();

                string query = @"UPDATE actividad 
                         SET Cupos = Cupos - 1 
                         WHERE NroActividad = @nroActividad AND Cupos > 0";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nroActividad", nroActividad);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}
