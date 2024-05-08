using clubDeportivo1.Datos;
using System.Data;
using System.Security.Cryptography;

namespace clubDeportivo1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void FrmLogin_Load(object sender, EventArgs e)
        {
            await Task.Delay(1);
            picUsuario.Focus();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.PlaceholderText == "Ingrese su usuario")
            {
                txtUsuario.PlaceholderText = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.PlaceholderText == "")
            {
                txtUsuario.PlaceholderText = "Ingrese su usuario";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.PlaceholderText == "Ingrese su contraseña")
            {
                txtPass.PlaceholderText = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.PlaceholderText == "")
            {
                txtPass.PlaceholderText = "Ingrese su contraseña";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Usuario dato = new Datos.Usuario();
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmPrincipal Principal = new FrmPrincipal();

                Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                Principal.usuario = Convert.ToString(txtUsuario.Text);

                Principal.ActualizarUsuario(Principal.usuario, Principal.rol);

                Principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }
    }
}