namespace clubDeportivo1
{
    partial class FrmInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscripcion));
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDocumento = new Label();
            lblTitulo = new Label();
            btnVolver = new Button();
            btnInscribir = new Button();
            lblAptitud = new Label();
            chkAptitud = new CheckBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(315, 171);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 28);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(315, 241);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(204, 28);
            txtApellido.TabIndex = 1;
            // 
            // txtDocumento
            // 
            txtDocumento.Anchor = AnchorStyles.None;
            txtDocumento.BorderStyle = BorderStyle.None;
            txtDocumento.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(315, 319);
            txtDocumento.Margin = new Padding(3, 2, 3, 2);
            txtDocumento.Multiline = true;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(204, 28);
            txtDocumento.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlText;
            lblNombre.Location = new Point(313, 148);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 21);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.ForeColor = SystemColors.ControlText;
            lblApellido.Location = new Point(314, 218);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 21);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido";
            lblApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDocumento
            // 
            lblDocumento.Anchor = AnchorStyles.None;
            lblDocumento.AutoSize = true;
            lblDocumento.BackColor = Color.Transparent;
            lblDocumento.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocumento.ForeColor = SystemColors.ControlText;
            lblDocumento.Location = new Point(313, 296);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(91, 21);
            lblDocumento.TabIndex = 9;
            lblDocumento.Text = "Documento";
            lblDocumento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(279, 58);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(276, 28);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Inscripcion de Cliente";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(658, 506);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(165, 45);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.Anchor = AnchorStyles.None;
            btnInscribir.Cursor = Cursors.Hand;
            btnInscribir.FlatStyle = FlatStyle.Popup;
            btnInscribir.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscribir.Location = new Point(315, 439);
            btnInscribir.Margin = new Padding(3, 2, 3, 2);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(204, 45);
            btnInscribir.TabIndex = 11;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click_1;
            // 
            // lblAptitud
            // 
            lblAptitud.Anchor = AnchorStyles.None;
            lblAptitud.AutoSize = true;
            lblAptitud.BackColor = Color.Transparent;
            lblAptitud.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAptitud.ForeColor = SystemColors.ControlText;
            lblAptitud.Location = new Point(314, 375);
            lblAptitud.Name = "lblAptitud";
            lblAptitud.Size = new Size(136, 21);
            lblAptitud.TabIndex = 12;
            lblAptitud.Text = "Aptitud Fisica";
            lblAptitud.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkAptitud
            // 
            chkAptitud.Anchor = AnchorStyles.None;
            chkAptitud.AutoSize = true;
            chkAptitud.CheckAlign = ContentAlignment.MiddleCenter;
            chkAptitud.Cursor = Cursors.Hand;
            chkAptitud.FlatAppearance.BorderColor = Color.Black;
            chkAptitud.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkAptitud.FlatStyle = FlatStyle.Popup;
            chkAptitud.Font = new Font("Cascadia Code Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkAptitud.Location = new Point(500, 378);
            chkAptitud.Margin = new Padding(4);
            chkAptitud.Name = "chkAptitud";
            chkAptitud.Padding = new Padding(4, 3, 2, 2);
            chkAptitud.Size = new Size(19, 17);
            chkAptitud.TabIndex = 3;
            chkAptitud.TextAlign = ContentAlignment.MiddleCenter;
            chkAptitud.UseVisualStyleBackColor = true;
            // 
            // FrmInscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(835, 562);
            Controls.Add(chkAptitud);
            Controls.Add(lblAptitud);
            Controls.Add(btnInscribir);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Controls.Add(lblDocumento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            DoubleBuffered = true;
            Font = new Font("Cascadia Code Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripcion";
            Load += FrmInscripcion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private Label lblTitulo;
        private Button btnVolver;
        private Button btnInscribir;
        private Label lblAptitud;
        private CheckBox chkAptitud;
    }
}