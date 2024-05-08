namespace clubDeportivo1
{
    partial class FrmCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarnet));
            btnVolver = new Button();
            lblVencimiento = new Label();
            lblNombreCompleto = new Label();
            lblID = new Label();
            pnlFrente = new Panel();
            pnlDorso = new Panel();
            pnlDorso.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Black;
            btnVolver.BackgroundImageLayout = ImageLayout.None;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Cascadia Code", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(1, 0);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(22, 24);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "<";
            btnVolver.TextAlign = ContentAlignment.TopLeft;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblVencimiento
            // 
            lblVencimiento.Anchor = AnchorStyles.None;
            lblVencimiento.AutoSize = true;
            lblVencimiento.BackColor = Color.Transparent;
            lblVencimiento.Font = new Font("Cascadia Code Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVencimiento.Location = new Point(295, 138);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(48, 17);
            lblVencimiento.TabIndex = 21;
            lblVencimiento.Text = "fecha";
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.Anchor = AnchorStyles.None;
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.BackColor = Color.Transparent;
            lblNombreCompleto.Font = new Font("Cascadia Code Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreCompleto.Location = new Point(254, 102);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(56, 17);
            lblNombreCompleto.TabIndex = 20;
            lblNombreCompleto.Text = "nombre";
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.None;
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Cascadia Code Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(214, 67);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 17);
            lblID.TabIndex = 19;
            lblID.Text = "id";
            // 
            // pnlFrente
            // 
            pnlFrente.Anchor = AnchorStyles.None;
            pnlFrente.BackgroundImage = (Image)resources.GetObject("pnlFrente.BackgroundImage");
            pnlFrente.BackgroundImageLayout = ImageLayout.Stretch;
            pnlFrente.BorderStyle = BorderStyle.Fixed3D;
            pnlFrente.Location = new Point(22, 1);
            pnlFrente.Name = "pnlFrente";
            pnlFrente.Size = new Size(445, 227);
            pnlFrente.TabIndex = 22;
            // 
            // pnlDorso
            // 
            pnlDorso.Anchor = AnchorStyles.None;
            pnlDorso.BackgroundImage = (Image)resources.GetObject("pnlDorso.BackgroundImage");
            pnlDorso.BackgroundImageLayout = ImageLayout.Stretch;
            pnlDorso.BorderStyle = BorderStyle.Fixed3D;
            pnlDorso.Controls.Add(lblVencimiento);
            pnlDorso.Controls.Add(lblNombreCompleto);
            pnlDorso.Controls.Add(lblID);
            pnlDorso.Location = new Point(22, 233);
            pnlDorso.Name = "pnlDorso";
            pnlDorso.Size = new Size(445, 227);
            pnlDorso.TabIndex = 23;
            // 
            // FrmCarnet
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(467, 459);
            Controls.Add(pnlDorso);
            Controls.Add(pnlFrente);
            Controls.Add(btnVolver);
            DoubleBuffered = true;
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carnet";
            Load += FrmCarnet_Load;
            pnlDorso.ResumeLayout(false);
            pnlDorso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnVolver;
        private Label lblVencimiento;
        private Label lblNombreCompleto;
        private Label lblID;
        private Panel pnlFrente;
        private Panel pnlDorso;
    }
}