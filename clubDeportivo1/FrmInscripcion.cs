using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clubDeportivo1.Datos;
using clubDeportivo1.Entidades;


namespace clubDeportivo1
{
    public partial class FrmInscripcion : Form
    {
        /* ----- Atributos para almacenar información del usuario y rol ----- */
        private string usuario;
        private string rol;
        private FrmPrincipal Principal;

        public FrmInscripcion(FrmPrincipal principal, string usuario, string rol)
        {
            InitializeComponent();
            this.Principal = principal;
            this.usuario = usuario;
            this.rol = rol;
        }

        private void FrmInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void btnInscribir_Click_1(object sender, EventArgs e)
        {
            /* ----- ----- */
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDocumento.Text == "" || !chkAptitud.Checked)
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                /* ----- Registro de cliente ----- */
                string respuesta;
                InscripcionE inscripto = new InscripcionE();
                inscripto.Nombre = txtNombre.Text;
                inscripto.Apellido = txtApellido.Text;
                inscripto.DNI = Convert.ToInt32(txtDocumento.Text);
                inscripto.Aptitud = chkAptitud.Checked;

                /* ----- Se instancia Inscripcion para usar su metodo ----- */
                Datos.Inscripcion inscriptos = new Datos.Inscripcion();
                respuesta = inscriptos.Inscribir(inscripto);
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("El cliente ya existe", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se realizo con exito la inscripcion con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                    }
                }
                /* ----- Limpiar campos despues de la inscripcion ----- */
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDocumento.Text = "";
                chkAptitud.Checked = false;
                txtNombre.Focus();

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal.ActualizarUsuario(usuario, rol);
            Principal.Show();
            this.Hide();
        }
    }
}

