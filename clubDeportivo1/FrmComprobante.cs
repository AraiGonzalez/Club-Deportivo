using clubDeportivo1.Datos;
using clubDeportivo1.Entidades;
using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubDeportivo1
{
    public partial class FrmComprobante : Form
    {
        public int id;
        public string? nombre;
        public string? apellido;
        public string? fecha;
        public string? forma;
        public double monto;

        internal string? Rol;
        internal string? Usuario;


        public FrmComprobante()
        {
            InitializeComponent();

        }

        public void ObtenerCredenciales(string usuario, string rol)
        {
            Usuario = usuario;
            Rol = rol;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimir.Visible = true;

            MessageBox.Show("Operacion exitosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmPago cobro = new FrmPago(Usuario, Rol);

            cobro.Show();

            this.Hide();
        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void FrmComprobante_Load(object sender, EventArgs e)
        {
            lblId.Text = Convert.ToString(id);
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblFecha.Text = fecha;
            lblForma.Text = forma;
            lblMonto.Text = Convert.ToString(monto);
        }
    }
}
