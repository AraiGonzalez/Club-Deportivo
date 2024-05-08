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
using MySqlX.XDevAPI.Relational;

namespace clubDeportivo1
{
    public partial class FrmCarnet : Form
    {

        public int IdCarnet;
        public string? NombreCompleto;
        public string? Vencimiento;

        internal string? Rol;
        internal string? Usuario;


        public FrmCarnet()
        {
            InitializeComponent();
        }

        public void ObtenerCredenciales(string usuario, string rol)
        {
            Usuario = usuario;
            Rol = rol;
        }


        private void FrmCarnet_Load(object sender, EventArgs e)
        {
            lblID.Text = Convert.ToString(IdCarnet);
            lblNombreCompleto.Text = NombreCompleto;
            lblVencimiento.Text = Convert.ToString(Vencimiento);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPago cobro = new FrmPago(Usuario, Rol);
            cobro.Show();
            this.Close();
        }
    }
}
