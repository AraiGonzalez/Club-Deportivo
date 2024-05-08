using clubDeportivo1.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clubDeportivo1.Datos
{
    internal class Socio : Cliente
    {
        public override bool VerificarExistencia(int IdInscripcion)
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = ($"SELECT count(*) FROM Socio " +
                        $"WHERE IdInscripcion = {IdInscripcion}");

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                // comando.CommandType = CommandType.Text;
                sqlCon.Open();

                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al acceder a la tabla Socio",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }

        public int ObtenerId(int IdInscrip)
        {
            int idSocio = 0;

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Ajusta la consulta para devolver solo un resultado
                string query = "SELECT IdSocio FROM Socio WHERE IdInscripcion = @IdInscrip";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@IdInscrip", IdInscrip);

                sqlCon.Open();

                // ExecuteScalar devuelve la primera columna de la primera fila
                object result = comando.ExecuteScalar();

                // Verificamos si se obtuvo un resultado no nulo
                if (result != null)
                {
                    idSocio = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return idSocio;
        }
    }
}
