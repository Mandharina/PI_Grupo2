using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PI_Grupo2.Entidades;

namespace PI_Grupo2.Datos
{
    public class VerificadorCliente
    {
        public static VerificadorResultado VerificarDni(int dni)
        {
            VerificadorResultado resultado = new VerificadorResultado();

            using (MySqlConnection con = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("VerificarDni", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_dni", dni);

                    var paramExiste = new MySqlParameter("@existe", MySqlDbType.Bit)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    cmd.Parameters.Add(paramExiste);

                    var paramEsSocio = new MySqlParameter("@es_socio", MySqlDbType.Bit)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    cmd.Parameters.Add(paramEsSocio);

                    var paramNumero = new MySqlParameter("@numero_identificador", MySqlDbType.Int32)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    cmd.Parameters.Add(paramNumero);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    resultado.Existe = Convert.ToBoolean(paramExiste.Value);
                    resultado.EsSocio = Convert.ToBoolean(paramEsSocio.Value);
                    resultado.NumeroIdentificador = paramNumero.Value != DBNull.Value ? Convert.ToInt32(paramNumero.Value) : (int?)null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar DNI: " + ex.Message);
                }
            }

            return resultado;
        }
    }
}
