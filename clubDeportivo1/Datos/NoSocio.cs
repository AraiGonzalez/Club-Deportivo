using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubDeportivo1.Datos
{
    internal class NoSocio : Cliente
    {
        public override bool VerificarExistencia(int IdInscripcion)
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = ($"SELECT count(*) FROM NoSocio " +
                        $"WHERE IdInscripcion = {IdInscripcion}");

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                // comando.CommandType = CommandType.Text;
                sqlCon.Open();

                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al acceder a la tabla NoSocio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }
    }
}
