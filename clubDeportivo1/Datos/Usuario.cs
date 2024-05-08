using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubDeportivo1.Datos
{
    internal class Usuario
    {
        /* ----- Método que retorne una tabla con la informacion  ----- */
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                /* ----- Se crea una conexión a la base de datos ----- */
                sqlCon = Conexion.getInstancia().CrearConexion();

                /* ----- comando almacena el nombre del procedimiento almacenado
                                    y la referencia a la conexion  ------ */
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                /* ----- Parametros del procedimiento ----- */
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;
                
                /* ----- Se abre la conexion ----- */
                sqlCon.Open();

                /* ----- Se almacena el resultado en la variable
                            y se lo carga a la tabla ----- */
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;

                /* ----- Se asocia el metodo con el procedimiento que esta almacenado en MySQL ----- */
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                };
            }
        }
    }
}
