using clubDeportivo1.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clubDeportivo1.Entidades;
using System.Data;
using MySqlX.XDevAPI;

namespace clubDeportivo1.Datos
{
    internal class Pago
    {
        public string RegistrarPago(PagoE pago)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                /* ----- Se crea una conexión a la base de datos ----- */
                sqlCon = Conexion.getInstancia().CrearConexion();

                /* ----- Se crea un comando para ejecutar el procedimiento almacenado "RegistrarPago" ----- */
                MySqlCommand comando = new MySqlCommand("RegistrarPago",
                sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("IdInscripcion", MySqlDbType.VarChar).Value =
                pago.IdInscripcion;
                comando.Parameters.Add("FormaPago", MySqlDbType.VarChar).Value =
                pago.FormaPago;
                comando.Parameters.Add("Plan", MySqlDbType.VarChar).Value =
                pago.Plan;
                comando.Parameters.Add("Monto", MySqlDbType.VarChar).Value =
                pago.Monto;
                comando.Parameters.Add("Cuotas", MySqlDbType.VarChar).Value =
                pago.Cuotas;
                comando.Parameters.Add("Fecha", MySqlDbType.VarChar).Value =
                pago.Fecha;


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
    }
}
