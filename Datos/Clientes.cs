﻿using System.Data;
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

        public int RegistrarSocio(E_Socio socio)
        {
            int nroCarnet = -1;

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
                nroCarnet = Convert.ToInt32(comando.Parameters["p_nroCarnet"].Value);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar socio: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return nroCarnet;
        }

        public bool ActualizarVencimiento(int nroSocio, DateTime nuevoVencimiento)
        {
            using var con = Conexion.getInstancia().CrearConexion();
            string query = "UPDATE socio SET VencCuota = @nuevoVenc WHERE NroCarnet = @nro";
            var cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nuevoVenc", nuevoVencimiento);
            cmd.Parameters.AddWithValue("@nro", nroSocio);

            con.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
        }

        public E_Socio? BuscarSocioPorDniONro(int valor)
        {
            E_Socio? socio = null;

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    string query = @"
                SELECT 
                    NroCarnet, Nombre, Apellido, Dni, FechaNac, Genero, NumCel, 
                    Domicilio, AptoFisico, FechaIngreso, VencCuota, EsActivo, CarnetEntregado
                FROM socio 
                WHERE Dni = @valor OR NroCarnet = @valor";

                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@valor", valor);

                    sqlCon.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        socio = new E_Socio
                        {
                            NroCarnet = Convert.ToInt32(reader["NroCarnet"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Dni = Convert.ToInt32(reader["Dni"]),
                            FechaNac = Convert.ToDateTime(reader["FechaNac"]),
                            Genero = reader["Genero"].ToString(),
                            NumCel = reader["NumCel"].ToString(),
                            Domicilio = reader["Domicilio"].ToString(),
                            AptoFisico = Convert.ToBoolean(reader["AptoFisico"]),
                            FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]),
                            VencCuota = Convert.ToDateTime(reader["VencCuota"]),
                            EsActivo = Convert.ToBoolean(reader["EsActivo"]),
                            CarnetEntregado = Convert.ToBoolean(reader["CarnetEntregado"])
                        };
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return socio;
        }

        public static E_NoSocio ObtenerNoSocioPorId(int id)
        {
            E_NoSocio noSocio = null;

            using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
            {
                conexion.Open();
                string query = "SELECT * FROM noSocio WHERE nroNoSocio = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            noSocio = new E_NoSocio
                            {
                                NroNoSocio = Convert.ToInt32(dr["nroNoSocio"]),
                                Nombre = dr["nombre"].ToString(),
                                Apellido = dr["apellido"].ToString()
                            };
                        }
                    }
                }
            }

            return noSocio;
        }


        public bool EliminarSocioPorDni(int dni)
        {
            using (MySqlConnection con = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM socio WHERE Dni = @dni";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@dni", dni);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

    }
}
