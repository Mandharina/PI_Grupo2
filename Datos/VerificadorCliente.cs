using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PI_Grupo2.Datos
{
    public class VerificadorCliente
    {
        public static bool VerificarDni(int dni)
        {
            bool existe = false;
            MySqlConnection con = Conexion.getInstancia().CrearConexion();

            try
            {
                MySqlCommand cmd = new MySqlCommand("verificar_dni", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_dni", dni);

                MySqlParameter paramExiste = new MySqlParameter("@existe", MySqlDbType.Bit);
                paramExiste.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(paramExiste);

                con.Open();
                cmd.ExecuteNonQuery();

                existe = Convert.ToBoolean(paramExiste.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar DNI: " + ex.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }

            return existe;
        }
    }
}
