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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Configuration;

namespace clubDeportivo1
{
    public partial class FrmPago : Form
    {
        /* ----- Atributos para almacenar información del usuario y rol ----- */
        private string usuario;
        private string rol;

        /* ----- Montos para el pago, podrían ser configurables en el futuro ----- */
        double montoDiario = 999;
        double montoMensual = 7999;



        public FrmPago(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
            btnCarnet.Enabled = true;
        }

        /* ----- Instancia de los formularios de carnet y comprobante ----- */
        FrmCarnet Carnet = new FrmCarnet();
        FrmComprobante comprobante = new FrmComprobante();

        private void FrmPago_Load(object sender, EventArgs e)
        {

        }
        /* ----- Manejadores de eventos para cambios en las opciones de pago ----- */
        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            optTres.Visible = true;
            optSeis.Visible = true;
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            optTres.Checked = false;
            optSeis.Checked = false;
            optTres.Visible = false;
            optSeis.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal Principal = new FrmPrincipal();
            Principal.ActualizarUsuario(usuario, rol);
            Principal.Show();
            this.Hide();

        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            /* ----- Clases relacionadas con la emisión de carnet y verificación de la existencia del socio ----- */
            Socio socios = new Socio();
            SocioE socio = new SocioE();
            PagoE pago = new PagoE();
            Carnet carnets = new Carnet();
            CarnetE carnet = new CarnetE();

            /* ----- Validación de entrada para el código de inscripción ----- */
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Se debe colocar codigo de inscripcion (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                /* ----- Configuración de información para el pago y el socio ----- */
                pago.IdInscripcion = Convert.ToInt32(txtCodigo.Text);
                socio.IdInscripcion = pago.IdInscripcion;
                bool existeSocio = socios.VerificarExistencia(socio.IdInscripcion);

                if (existeSocio == true)
                {
                    /* ----- Configuración de información para el carnet y emisión del mismo ----- */
                    carnet.IdSocio = socios.ObtenerId(socio.IdInscripcion);
                    carnet.Vencimiento = DateTime.UtcNow.AddMonths(1).ToShortDateString();

                    carnets.EmitirCarnet(carnet);

                    /* ----- Obtener datos del carnet emitido ----- */
                    Carnet = carnets.ObtenerDatos(socio.IdInscripcion);

                    /* ----- Mostrar formulario de carnet con las credenciales del usuario actual ----- */
                    Carnet.ObtenerCredenciales(usuario, rol);
                    Carnet.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Aun no eres socio (*) " + existeSocio,
                                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

            }


        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            comprobante.ObtenerCredenciales(usuario, rol);
            comprobante.Show();
            this.Hide();
        }

        /* ----- ----- */
        private void btnPagar_Click(object sender, EventArgs e)
        {
            /* ----- ----- */
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (!(optEfectivo.Checked || optTarjeta.Checked) || !(optDiario.Checked || optMensual.Checked))
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                /* ----- Configuración de información para el pago y el socio ----- */
                string respuesta;
                PagoE pago = new PagoE();
                SocioE socio = new SocioE();
                CarnetE carnet = new CarnetE();
                NoSocioE noSocio = new NoSocioE();

                /* ----- Configuración de información para el pago ----- */
                pago.IdInscripcion = Convert.ToInt32(txtCodigo.Text);
                pago.FormaPago = optEfectivo.Checked ? "Efectivo" : "Tarjeta";
                pago.Plan = optDiario.Checked ? "Diario" : "Mensual";
                pago.Monto = pago.Plan == "Diario" ? montoDiario : montoMensual;

                /* ----- Configuración de cuotas para el pago con tarjeta ----- */
                if (optTarjeta.Checked)
                {
                    if (optTres.Checked == false && optSeis.Checked == false)
                    {
                        pago.Cuotas = 1;
                    }
                    else
                    {
                        pago.Cuotas = optTres.Checked ? 3 : 6;
                    }
                }
                else
                {
                    pago.Cuotas = 1;
                }
                pago.Fecha = DateTime.UtcNow.ToShortDateString();

                /* ----- Configuración de información para el socio y no socio ----- */
                socio.IdInscripcion = pago.IdInscripcion;
                noSocio.IdInscripcion = pago.IdInscripcion;

                /* ----- Clases relacionadas con la gestión de pagos, socios y no socios ----- */
                Pago pagos = new Pago();
                Socio socios = new Socio();
                Carnet carnets = new Carnet();
                NoSocio noSocios = new NoSocio();

                /* ----- Verificación de existencia del socio y realización del pago ----- */
                bool existeSocio = socios.VerificarExistencia(socio.IdInscripcion);
                bool existeNoSocio = noSocios.VerificarExistencia(noSocio.IdInscripcion);

                respuesta = pagos.RegistrarPago(pago);

                /* ----- Validación y muestra de mensajes según el resultado del pago ----- */
                bool esnumero = int.TryParse(respuesta, out int res);
                if (esnumero)
                {
                    MessageBox.Show("Se almaceno con exito el pago Nro " + respuesta, "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);

                    /* ----- Verificación y registro del socio o no socio según el plan de pago ----- */
                    if (pago.Plan == "Mensual" && !existeSocio)
                    {

                        MessageBox.Show("Se ha registrado como Socio al cliente " + socio.IdInscripcion, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);

                        socios.RegistrarCliente(socio, pago.Plan);
                    }
                    else if (pago.Plan == "Diario" && !existeNoSocio)
                    {
                        MessageBox.Show("Se ha registrado como No Socio al cliente " + noSocio.IdInscripcion, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                        noSocios.RegistrarCliente(noSocio, pago.Plan);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el pago", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                }

                MySqlConnection sqlCon = new MySqlConnection();

                try
                {
                    string query;
                    sqlCon = Conexion.getInstancia().CrearConexion();

                    /* ----- Consulta para obtener detalles del pago e inscripción ----- */
                    query = ("select i.idinscripcion, i.nombre, i.apellido, p.fecha, p.formapago, p.monto " +
                             "from inscripcion i left join pago p on i.idinscripcion = p.idinscripcion " +
                             "where i.idinscripcion = " + pago.IdInscripcion);

                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.CommandType = CommandType.Text;
                    sqlCon.Open();
                    MySqlDataReader reader;
                    reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        /* ----- Configuración de información para el comprobante ----- */
                        comprobante.id = Convert.ToInt32(reader.GetString(0));
                        comprobante.nombre = reader.GetString(1);
                        comprobante.apellido = reader.GetString(2);
                        comprobante.fecha = reader.GetString(3);
                        comprobante.forma = reader.GetString(4);
                        comprobante.monto = Convert.ToDouble(reader.GetString(5));

                        btnComprobante.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al intentar acceder a la consulta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    { sqlCon.Close(); };
                }
            }
            txtCodigo.Focus();

        }

    }
}
