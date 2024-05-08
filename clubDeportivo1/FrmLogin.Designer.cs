namespace clubDeportivo1
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            picUsuario = new PictureBox();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnIngresar = new Button();
            picUser = new PictureBox();
            picPass = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)picUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPass).BeginInit();
            SuspendLayout();
            // 
            // picUsuario
            // 
            picUsuario.Anchor = AnchorStyles.None;
            picUsuario.BackColor = Color.Transparent;
            picUsuario.Image = (Image)resources.GetObject("picUsuario.Image");
            picUsuario.Location = new Point(123, 145);
            picUsuario.Margin = new Padding(2);
            picUsuario.Name = "picUsuario";
            picUsuario.Size = new Size(189, 154);
            picUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            picUsuario.TabIndex = 1;
            picUsuario.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.ControlText;
            txtUsuario.Location = new Point(103, 310);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su usuario";
            txtUsuario.Size = new Size(230, 26);
            txtUsuario.TabIndex = 2;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.None;
            txtPass.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = SystemColors.ControlText;
            txtPass.Location = new Point(103, 360);
            txtPass.Margin = new Padding(2);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Ingrese su contraseña";
            txtPass.Size = new Size(230, 26);
            txtPass.TabIndex = 3;
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = SystemColors.ControlLightLight;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(102, 410);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(230, 45);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // picUser
            // 
            picUser.Anchor = AnchorStyles.None;
            picUser.BackColor = Color.Transparent;
            picUser.Image = (Image)resources.GetObject("picUser.Image");
            picUser.Location = new Point(73, 314);
            picUser.Margin = new Padding(2);
            picUser.Name = "picUser";
            picUser.Size = new Size(26, 22);
            picUser.SizeMode = PictureBoxSizeMode.Zoom;
            picUser.TabIndex = 5;
            picUser.TabStop = false;
            // 
            // picPass
            // 
            picPass.Anchor = AnchorStyles.None;
            picPass.BackColor = Color.Transparent;
            picPass.Image = (Image)resources.GetObject("picPass.Image");
            picPass.Location = new Point(73, 364);
            picPass.Margin = new Padding(2);
            picPass.Name = "picPass";
            picPass.Size = new Size(26, 22);
            picPass.SizeMode = PictureBoxSizeMode.Zoom;
            picPass.TabIndex = 6;
            picPass.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(115, 60);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(204, 28);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Inicio de sesión";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(434, 511);
            Controls.Add(lblTitulo);
            Controls.Add(picPass);
            Controls.Add(picUser);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(picUsuario);
            DoubleBuffered = true;
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)picUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picUsuario;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnIngresar;
        private PictureBox picUser;
        private PictureBox picPass;
        private Label lblTitulo;
    }
}