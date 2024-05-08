namespace clubDeportivo1
{
    partial class FrmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            btnPagar = new Button();
            btnVolver = new Button();
            gboxPago = new GroupBox();
            optTarjeta = new RadioButton();
            optEfectivo = new RadioButton();
            optTres = new RadioButton();
            optSeis = new RadioButton();
            btnComprobante = new Button();
            btnCarnet = new Button();
            gboxPlan = new GroupBox();
            optDiario = new RadioButton();
            optMensual = new RadioButton();
            lblTitulo = new Label();
            gboxPago.SuspendLayout();
            gboxPlan.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.None;
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigo.ForeColor = SystemColors.ControlText;
            lblCodigo.Location = new Point(139, 117);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(271, 21);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Ingrese Código de Inscripción";
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.None;
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(192, 151);
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(165, 28);
            txtCodigo.TabIndex = 1;
            // 
            // btnPagar
            // 
            btnPagar.Anchor = AnchorStyles.None;
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.FlatStyle = FlatStyle.Popup;
            btnPagar.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.Location = new Point(192, 355);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(165, 45);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(377, 547);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(165, 45);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // gboxPago
            // 
            gboxPago.Anchor = AnchorStyles.None;
            gboxPago.BackColor = Color.Transparent;
            gboxPago.Controls.Add(optTarjeta);
            gboxPago.Controls.Add(optEfectivo);
            gboxPago.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gboxPago.ForeColor = SystemColors.ControlText;
            gboxPago.Location = new Point(100, 196);
            gboxPago.Name = "gboxPago";
            gboxPago.Size = new Size(170, 135);
            gboxPago.TabIndex = 4;
            gboxPago.TabStop = false;
            gboxPago.Text = "Forma de Pago";
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(21, 58);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(91, 25);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            optTarjeta.CheckedChanged += optTarjeta_CheckedChanged;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(21, 34);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(100, 25);
            optEfectivo.TabIndex = 0;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            optEfectivo.CheckedChanged += optEfectivo_CheckedChanged;
            // 
            // optTres
            // 
            optTres.Anchor = AnchorStyles.None;
            optTres.AutoSize = true;
            optTres.BackColor = Color.Transparent;
            optTres.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            optTres.ForeColor = SystemColors.ControlText;
            optTres.Location = new Point(139, 278);
            optTres.Name = "optTres";
            optTres.Size = new Size(100, 25);
            optTres.TabIndex = 8;
            optTres.TabStop = true;
            optTres.Text = "3 cuotas";
            optTres.UseVisualStyleBackColor = false;
            optTres.Visible = false;
            // 
            // optSeis
            // 
            optSeis.Anchor = AnchorStyles.None;
            optSeis.AutoSize = true;
            optSeis.BackColor = Color.Transparent;
            optSeis.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            optSeis.ForeColor = SystemColors.ControlText;
            optSeis.Location = new Point(139, 299);
            optSeis.Name = "optSeis";
            optSeis.Size = new Size(100, 25);
            optSeis.TabIndex = 7;
            optSeis.TabStop = true;
            optSeis.Text = "6 cuotas";
            optSeis.UseVisualStyleBackColor = false;
            optSeis.Visible = false;
            // 
            // btnComprobante
            // 
            btnComprobante.Anchor = AnchorStyles.None;
            btnComprobante.Cursor = Cursors.Hand;
            btnComprobante.Enabled = false;
            btnComprobante.FlatStyle = FlatStyle.Popup;
            btnComprobante.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprobante.Location = new Point(192, 406);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(165, 45);
            btnComprobante.TabIndex = 5;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnCarnet
            // 
            btnCarnet.Anchor = AnchorStyles.None;
            btnCarnet.Cursor = Cursors.Hand;
            btnCarnet.Enabled = false;
            btnCarnet.FlatStyle = FlatStyle.Popup;
            btnCarnet.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarnet.Location = new Point(192, 457);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(165, 45);
            btnCarnet.TabIndex = 6;
            btnCarnet.Text = "Emitir Carnet";
            btnCarnet.UseVisualStyleBackColor = true;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // gboxPlan
            // 
            gboxPlan.Anchor = AnchorStyles.None;
            gboxPlan.BackColor = Color.Transparent;
            gboxPlan.Controls.Add(optDiario);
            gboxPlan.Controls.Add(optMensual);
            gboxPlan.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gboxPlan.ForeColor = SystemColors.ControlText;
            gboxPlan.Location = new Point(285, 196);
            gboxPlan.Name = "gboxPlan";
            gboxPlan.Size = new Size(170, 100);
            gboxPlan.TabIndex = 5;
            gboxPlan.TabStop = false;
            gboxPlan.Text = "Plan";
            // 
            // optDiario
            // 
            optDiario.AutoSize = true;
            optDiario.Location = new Point(21, 62);
            optDiario.Name = "optDiario";
            optDiario.Size = new Size(82, 25);
            optDiario.TabIndex = 1;
            optDiario.TabStop = true;
            optDiario.Text = "Diario";
            optDiario.UseVisualStyleBackColor = true;
            // 
            // optMensual
            // 
            optMensual.AutoSize = true;
            optMensual.Location = new Point(21, 38);
            optMensual.Name = "optMensual";
            optMensual.Size = new Size(91, 25);
            optMensual.TabIndex = 0;
            optMensual.TabStop = true;
            optMensual.Text = "Mensual";
            optMensual.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(193, 58);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(168, 28);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Pago de Cuota";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(554, 604);
            Controls.Add(lblTitulo);
            Controls.Add(optTres);
            Controls.Add(optSeis);
            Controls.Add(gboxPlan);
            Controls.Add(btnCarnet);
            Controls.Add(btnComprobante);
            Controls.Add(lblCodigo);
            Controls.Add(gboxPago);
            Controls.Add(btnVolver);
            Controls.Add(btnPagar);
            Controls.Add(txtCodigo);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar cuota";
            Load += FrmPago_Load;
            gboxPago.ResumeLayout(false);
            gboxPago.PerformLayout();
            gboxPlan.ResumeLayout(false);
            gboxPlan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Button btnPagar;
        private Button btnVolver;
        private GroupBox gboxPago;
        private RadioButton optTarjeta;
        private RadioButton optEfectivo;
        private Button btnComprobante;
        private Button btnCarnet;
        private GroupBox gboxPlan;
        private RadioButton optDiario;
        private RadioButton optMensual;
        private RadioButton optSeis;
        private RadioButton optTres;
        private Label lblTitulo;
    }
}