using clubDeportivo1.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubDeportivo1.Datos
{
    internal class Cliente
    {
        public string RegistrarCliente(ClienteE cliente, string plan)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                /* ----- Se crea una conexión a la base de datos ----- */
                sqlCon = Conexion.getInstancia().CrearConexion();

                /* ----- Se crea un comando para ejecutar el procedimiento almacenado "Inscribir" ----- */
                MySqlCommand comando = new MySqlCommand("RegistrarSocioNoSocio",
                sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("IdInscripcion", MySqlDbType.Int32).Value =
                cliente.IdInscripcion;
                comando.Parameters.Add("Plan", MySqlDbType.VarChar).Value =
                plan;

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
                { sqlCon.Close(); };
            }
            /* ----- Devuelve el numero de socio o un mensaje de error ----- */
            return salida;
        }

        public virtual bool VerificarExistencia(int IdInscripcion)
        {
            return true;
        }
    }
}
