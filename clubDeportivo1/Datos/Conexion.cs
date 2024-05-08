using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// --------------------
// Referencia a MySQL (se agrega como libreria)
using MySql.Data.MySqlClient;
namespace clubDeportivo1.Datos
{
    public class Conexion // la clase debe ser PUBLICA
    {
        // declaramos las variables 
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;
        private Conexion() // asignamos valores a las variables de la conexion
        {
            // variables usadas para larepetición de líneas de código
            bool correcto = false;
            int mensaje;
            // creamos las variables para recibir los datos desde el  teclado
            string T_servidor;
            string T_puerto;
            string T_usuario;
            string T_clave; // se antepuso la T para indicar que vienen desde TECLADO
            while (correcto != true)
            {
                // Armamos los cuadros de dialogo para el ingreso de datos
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese servidor", "Ingrese los datos de conexión a MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese puerto", "Ingrese los datos de conexión a MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese usuario", "Ingrese los datos de conexión a MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese clave", "Ingrese los datos de conexión a MySQL");
                /* 
                ________________________________________________________
                ________________
                * controlamos que los datos ingresados para acceder a 
                MySQL sean correctos
                * 
                ________________________________________________________
                __________________ */
                mensaje = (int)MessageBox.Show("Su ingreso: SERVIDOR: " +
                T_servidor + " PUERTO: " + T_puerto + " USUARIO: " +
                T_usuario + " CLAVE: " + T_clave,
                "AVISO DEL SISTEMA", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                    // reemplazamos los datos concretos que teniamos por las variables
                    this.baseDatos = "ClubDeportivo";
                    this.servidor = T_servidor; // "localhost";
                    this.puerto = T_puerto; //"3306";
                    this.usuario = T_usuario; // "root";
                    this.clave = T_clave; // "";
                }
            }

        }
        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
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
                throw;
            }
            return cadena;
        }
        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }
    }
}