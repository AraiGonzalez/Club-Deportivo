using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clubDeportivo1.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clubDeportivo1.Datos
{
    internal class Carnet
    {
        public string EmitirCarnet(CarnetE carnet) 
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                /* ----- Se crea una conexión a la base de datos ----- */
                sqlCon = Conexion.getInstancia().CrearConexion();

                /* ----- Se crea un comando para ejecutar el procedimiento almacenado "Inscribir" ----- */
                MySqlCommand comando = new MySqlCommand("EmitirCarnet",
                sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("SocioId", MySqlDbType.Int32).Value =
                carnet.IdSocio;
                comando.Parameters.Add("Vencimiento", MySqlDbType.VarChar).Value =
                carnet.Vencimiento;


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
            /* ----- Devuelve el ID de carnet de socio o un mensaje de error ----- */
            return salida;
        }

        public FrmCarnet ObtenerDatos(int IdInscrip)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();

                query = ("select c.idcarnet, concat(i.nombre, ' ', i.apellido) as nombreCompleto, c.vencimiento " +
                    "from carnet c left join socio s on c.idsocio = s.idsocio " +
                    "left join inscripcion i on s.idinscripcion = i.idinscripcion " +
                    "where i.idinscripcion = " + IdInscrip);

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    FrmCarnet datosCarnet = new FrmCarnet();
                    reader.Read();
                    {
                        datosCarnet.IdCarnet = Convert.ToInt32(reader.GetString(0));
                        datosCarnet.NombreCompleto = reader.GetString(1);
                        datosCarnet.Vencimiento = reader.GetString(2);
                    }
                    return datosCarnet;
                }
                else
                {
                    MessageBox.Show("Número de inscripción inexistente", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener los datos del carnet",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }
    }
}
