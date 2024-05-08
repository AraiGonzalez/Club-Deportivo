using clubDeportivo1.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clubDeportivo1.Entidades;

namespace clubDeportivo1.Datos

{
    internal class Inscripcion
    {
        public string Inscribir(InscripcionE cliente)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                /* ----- Se crea una conexión a la base de datos ----- */
                sqlCon = Conexion.getInstancia().CrearConexion();

                /* ----- Se crea un comando para ejecutar el procedimiento almacenado "Inscribir" ----- */
                MySqlCommand comando = new MySqlCommand("InscribirCliente",
                sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value =
                cliente.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value =
                cliente.Apellido;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value =
                cliente.DNI;
                comando.Parameters.Add("Apt", MySqlDbType.Int32).Value =
                cliente.Aptitud;

                /* ----- Parametro para recibir el valor retornado por el procedimiento ----- */
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);

                /* --------------------------------------------------------------------------------
                Se abre la conexión a la base de datos, se ejecuta el procedimiento almacenado, 
                se obtiene el valor retornado por el procedimiento y se lo convierte a una cadena
                --------------------------------------------------------------------------------- */
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
                { sqlCon.Close(); };
            }
            /* ----- Devuelve el numero de socio o un mensaje de error ----- */
            return salida;
        }
    }
}