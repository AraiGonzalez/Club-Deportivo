namespace clubDeportivo1
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnPagarCuota = new Button();
            btnVerificarVencimientos = new Button();
            btnInscripcion = new Button();
            btnSalir = new Button();
            lblTitulo = new Label();
            lblIngreso = new Label();
            SuspendLayout();
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.Anchor = AnchorStyles.None;
            btnPagarCuota.BackColor = SystemColors.ControlLightLight;
            btnPagarCuota.Cursor = Cursors.Hand;
            btnPagarCuota.FlatStyle = FlatStyle.Popup;
            btnPagarCuota.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagarCuota.Location = new Point(199, 313);
            btnPagarCuota.Margin = new Padding(2);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(210, 70);
            btnPagarCuota.TabIndex = 1;
            btnPagarCuota.Text = "Pagar cuota";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnVerificarVencimientos
            // 
            btnVerificarVencimientos.Anchor = AnchorStyles.None;
            btnVerificarVencimientos.BackColor = SystemColors.ControlLightLight;
            btnVerificarVencimientos.Cursor = Cursors.Hand;
            btnVerificarVencimientos.FlatStyle = FlatStyle.Popup;
            btnVerificarVencimientos.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerificarVencimientos.Location = new Point(199, 226);
            btnVerificarVencimientos.Margin = new Padding(2);
            btnVerificarVencimientos.Name = "btnVerificarVencimientos";
            btnVerificarVencimientos.Size = new Size(210, 61);
            btnVerificarVencimientos.TabIndex = 2;
            btnVerificarVencimientos.Text = "Verificar vencimientos";
            btnVerificarVencimientos.UseVisualStyleBackColor = false;
            btnVerificarVencimientos.Click += btnVerificarVencimientos_Click;
            // 
            // btnInscripcion
            // 
            btnInscripcion.Anchor = AnchorStyles.None;
            btnInscripcion.BackColor = SystemColors.ControlLightLight;
            btnInscripcion.Cursor = Cursors.Hand;
            btnInscripcion.FlatStyle = FlatStyle.Popup;
            btnInscripcion.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscripcion.Location = new Point(199, 140);
            btnInscripcion.Margin = new Padding(2);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(210, 70);
            btnInscripcion.TabIndex = 4;
            btnInscripcion.Text = "Inscribir Cliente";
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = SystemColors.ControlLightLight;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(433, 520);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(165, 45);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(214, 58);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(180, 28);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Club Deportivo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.BackColor = Color.Transparent;
            lblIngreso.Font = new Font("Cascadia Code Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngreso.Location = new Point(11, 9);
            lblIngreso.Margin = new Padding(2, 0, 2, 0);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(0, 17);
            lblIngreso.TabIndex = 7;
            lblIngreso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(609, 576);
            Controls.Add(lblIngreso);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(btnInscripcion);
            Controls.Add(btnVerificarVencimientos);
            Controls.Add(btnPagarCuota);
            DoubleBuffered = true;
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.InactiveCaptionText;
            Margin = new Padding(2);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPagarCuota;
        private Button btnVerificarVencimientos;
        private Button btnInscripcion;
        private Button btnSalir;
        private Label lblTitulo;
        private Label lblIngreso;
    }
}