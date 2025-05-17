using System.Data;
using MySql.Data.MySqlClient;
using PI_Grupo2.Entidades;

namespace PI_Grupo2.Datos
{
    internal class Clientes
    {
        public string Registrar_Cliente(E_Cliente cliente)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("ProcedureRegistrar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = cliente.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = cliente.Apellido;
                comando.Parameters.Add("pDni", MySqlDbType.Int32).Value = cliente.Dni;
                comando.Parameters.Add("Fec", MySqlDbType.Date).Value = cliente.Fecha_nac;
                comando.Parameters.Add("Gen", MySqlDbType.VarChar).Value = cliente.Genero;
                comando.Parameters.Add("Cel", MySqlDbType.VarChar).Value = cliente.NumCel;
                comando.Parameters.Add("Dom", MySqlDbType.VarChar).Value = cliente.Domicilio;
                

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }
    }

}