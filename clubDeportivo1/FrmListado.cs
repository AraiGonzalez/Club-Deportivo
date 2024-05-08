    using clubDeportivo1.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubDeportivo1
{
    public partial class FrmListado : Form
    {
        private string usuario;
        private string rol;
        public FrmListado(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;

        }

        private void Vencimiento_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        /* ----- Método que carga un listado de los socios con su fecha de vencimiento ----- */
        public void CargarGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = ("select distinct s.idsocio, i.nombre, i.apellido, c.vencimiento " +
                    "from inscripcion i inner join socio s on i.idinscripcion = s.idinscripcion " +
                    "left join carnet c on s.idsocio = c.idsocio");

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string fechaActual = DateTime.UtcNow.ToShortDateString();
                        string vencimiento = reader.GetString(3);
                        int renglon = dtgvListado.Rows.Add();
                        dtgvListado.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        dtgvListado.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvListado.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dtgvListado.Rows[renglon].Cells[3].Value = reader.GetString(3);
                        dtgvListado.Rows[renglon].Cells[4].Value = fechaActual == vencimiento ? "Baja" : "Alta";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal Principal = new FrmPrincipal();
            Principal.ActualizarUsuario(usuario, rol);
            Principal.Show();
            this.Hide();
        }

        public bool HayDatos()
        {
            return dtgvListado.Rows.Count >= 1;
        }
    }
}