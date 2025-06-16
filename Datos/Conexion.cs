using Microsoft.VisualBasic;

using MySql.Data.MySqlClient;

namespace PI_Grupo2.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {
            bool correcto = false;
            int mensaje;

            // Variables temporales para datos ingresados
            string T_servidor = "";
            string T_puerto = "";
            string T_usuario = "";
            string T_clave = "";

            // Loop para reintentar si el usuario no confirma
            while (!correcto)
            {
                T_servidor = Interaction.InputBox("Ingrese servidor", "DATOS DE INSTALACIÓN MySQL", "localhost");
                T_puerto = Interaction.InputBox("Ingrese puerto", "DATOS DE INSTALACIÓN MySQL", "3306");
                T_usuario = Interaction.InputBox("Ingrese usuario", "DATOS DE INSTALACIÓN MySQL", "root");
                T_clave = Interaction.InputBox("Ingrese clave", "DATOS DE INSTALACIÓN MySQL", "");

                mensaje = (int)MessageBox.Show(
                    $"Su ingreso:\nSERVIDOR = {T_servidor}\nPUERTO = {T_puerto}\nUSUARIO = {T_usuario}\nCLAVE = {T_clave}",
                    "CONFIRMAR DATOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                correcto = (mensaje == (int)DialogResult.Yes);
            }

            // Asignar datos ingresados
            this.baseDatos = "Proyecto";
            this.servidor = T_servidor;
            this.puerto = T_puerto;
            this.usuario = T_usuario;
            this.clave = T_clave;
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
