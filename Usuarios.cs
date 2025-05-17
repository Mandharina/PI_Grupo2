using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace PI_Grupo2
{
    internal class Usuarios
    {
        // Creamos un metodo que retorne una tabla con la informacion
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            
            MySqlDataReader resultado; // Variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                // El comando es un elemento que almacena en este caso el nombre
                // Del procedimiento almacenado y la referencia a la conexion
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                // Definimos los parametros que tiene el procedure
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;
                // Abrimos la conexion
                sqlCon.Open();
                resultado = comando.ExecuteReader(); // Almacenamos el resulatdo en la variable
                tabla.Load(resultado); // Cargamos la tabla con el resultado
                return tabla;
                // De esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL
            }
            catch (Exception ex)
            {
                throw ex;
            }
            // Como proceso final cerramos la conexión
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }
        }
    }
}