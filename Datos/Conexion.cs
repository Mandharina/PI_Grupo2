using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace PI_Grupo2.Datos
{
   public class Conexion
    {
        // Declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;
        private Conexion() // Asignamos valores a las variables de la conexion
            {
                baseDatos = "Proyecto";
                servidor = "localhost";
                puerto = "3306";
                usuario = "root";
                clave = ""; // Agregar contraseña si es que el servidor lo requiere
            }
        // Proceso de interacción
        public MySqlConnection CrearConexion()
            {
            // Instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // El bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + servidor +
                ";port=" + puerto +
                ";username=" + usuario +
                ";password=" + clave +
                ";Database=" + baseDatos;

            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }
        // Para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // Quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // Se crea una nueva
            }
            return con;
        }
    }

}
