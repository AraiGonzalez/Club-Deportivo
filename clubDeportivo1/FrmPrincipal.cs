using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubDeportivo1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        internal string? rol;
        internal string? usuario;

        private async void FrmPrincipal_Load(object sender, EventArgs e)
        {
            await Task.Delay(1);
            btnInscripcion.Focus();
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        /* ----- Método para recuperar el nombre de usuario y rol 
                    y no perder su valor cuando se vuelva de algún
                        formulario al FrmPrincipal ----- */
        public void ActualizarUsuario(string nombre, string rol)
        {
            usuario = nombre;
            this.rol = rol;
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            FrmInscripcion inscripcion = new FrmInscripcion(this, usuario, rol);
            inscripcion.Show();
            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            FrmPago cobro = new FrmPago(usuario, rol);
            cobro.Show();
            this.Hide();
        }

        private void btnVerificarVencimientos_Click(object sender, EventArgs e)
        {
            FrmListado listado = new FrmListado(usuario, rol);
            if (listado.HayDatos())
            {
                listado.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No hay datos para la carga de la grilla");
            }
        }
    }
}
