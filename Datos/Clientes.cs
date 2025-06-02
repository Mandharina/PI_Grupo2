using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PI_Grupo2.Entidades;

namespace PI_Grupo2.Datos
{
    internal class Clientes
    {
        // Método para registrar NO SOCIO
        public string RegistrarNoSocio(E_NoSocio noSocio)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistrarNoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_nombre", MySqlDbType.VarChar).Value = noSocio.Nombre;
                comando.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value = noSocio.Apellido;
                comando.Parameters.Add("p_dni", MySqlDbType.Int32).Value = noSocio.Dni;
                comando.Parameters.Add("p_fechaNac", MySqlDbType.Date).Value = noSocio.FechaNac;
                comando.Parameters.Add("p_genero", MySqlDbType.VarChar).Value = noSocio.Genero;
                comando.Parameters.Add("p_numCel", MySqlDbType.VarChar).Value = noSocio.NumCel;
                comando.Parameters.Add("p_domicilio", MySqlDbType.VarChar).Value = noSocio.Domicilio;
                comando.Parameters.Add("p_aptoFisico", MySqlDbType.Bit).Value = noSocio.AptoFisico;

                MySqlParameter ParCodigo = new MySqlParameter("p_nroNoSocio", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Output
                };
                comando.Parameters.Add(ParCodigo);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = "Error: " + ex.Message;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }

            return salida;
        }

    
     // Método para registrar SOCIO
        public string RegistrarSocio(E_Socio socio)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("RegistrarSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_nombre", MySqlDbType.VarChar).Value = socio.Nombre;
                comando.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value = socio.Apellido;
                comando.Parameters.Add("p_dni", MySqlDbType.Int32).Value = socio.Dni;
                comando.Parameters.Add("p_fechaNac", MySqlDbType.Date).Value = socio.FechaNac;
                comando.Parameters.Add("p_genero", MySqlDbType.VarChar).Value = socio.Genero;
                comando.Parameters.Add("p_numCel", MySqlDbType.VarChar).Value = socio.NumCel;
                comando.Parameters.Add("p_domicilio", MySqlDbType.VarChar).Value = socio.Domicilio;
                comando.Parameters.Add("p_aptoFisico", MySqlDbType.Bit).Value = socio.AptoFisico;
                comando.Parameters.Add("p_fechaIngreso", MySqlDbType.Date).Value = socio.FechaIngreso;
                comando.Parameters.Add("p_vencCuota", MySqlDbType.Date).Value = socio.VencCuota;

                MySqlParameter ParCodigo = new MySqlParameter("p_nroCarnet", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Output
                };
                comando.Parameters.Add(ParCodigo);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = "Error: " + ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return salida;
        }
    }
}
