namespace clubDeportivo1
{
    partial class FrmListado
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListado));
            dtgvListado = new DataGridView();
            dtgvId = new DataGridViewTextBoxColumn();
            dtgvNombre = new DataGridViewTextBoxColumn();
            dtgvApellido = new DataGridViewTextBoxColumn();
            dtgvVencimiento = new DataGridViewTextBoxColumn();
            dtgvEstado = new DataGridViewTextBoxColumn();
            conexionBindingSource = new BindingSource(components);
            lblTitulo = new Label();
            conexionBindingSource1 = new BindingSource(components);
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvListado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dtgvListado
            // 
            dtgvListado.Anchor = AnchorStyles.None;
            dtgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListado.Columns.AddRange(new DataGridViewColumn[] { dtgvId, dtgvNombre, dtgvApellido, dtgvVencimiento, dtgvEstado });
            dtgvListado.Location = new Point(112, 137);
            dtgvListado.Margin = new Padding(4);
            dtgvListado.Name = "dtgvListado";
            dtgvListado.ReadOnly = true;
            dtgvListado.RowTemplate.Height = 25;
            dtgvListado.Size = new Size(593, 298);
            dtgvListado.TabIndex = 0;
            // 
            // dtgvId
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvId.DefaultCellStyle = dataGridViewCellStyle1;
            dtgvId.HeaderText = "ID Socio";
            dtgvId.Name = "dtgvId";
            dtgvId.ReadOnly = true;
            // 
            // dtgvNombre
            // 
            dtgvNombre.HeaderText = "Nombre";
            dtgvNombre.Name = "dtgvNombre";
            dtgvNombre.ReadOnly = true;
            // 
            // dtgvApellido
            // 
            dtgvApellido.HeaderText = "Apellido";
            dtgvApellido.Name = "dtgvApellido";
            dtgvApellido.ReadOnly = true;
            // 
            // dtgvVencimiento
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvVencimiento.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvVencimiento.HeaderText = "Fecha de vencimiento";
            dtgvVencimiento.Name = "dtgvVencimiento";
            dtgvVencimiento.ReadOnly = true;
            dtgvVencimiento.Width = 150;
            // 
            // dtgvEstado
            // 
            dtgvEstado.HeaderText = "Estado";
            dtgvEstado.Name = "dtgvEstado";
            dtgvEstado.ReadOnly = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(210, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(396, 28);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Listado de fecha de vencimientos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVolver.Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(638, 569);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(165, 45);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmListado
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(816, 627);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Controls.Add(dtgvListado);
            Font = new Font("Cascadia Code Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmListado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verificacion de fecha de vencimiento";
            Load += Vencimiento_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvListado).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvListado;
        private BindingSource conexionBindingSource;
        private Label lblTitulo;
        private BindingSource conexionBindingSource1;
        private Button btnVolver;
        private DataGridViewTextBoxColumn dtgvId;
        private DataGridViewTextBoxColumn dtgvNombre;
        private DataGridViewTextBoxColumn dtgvApellido;
        private DataGridViewTextBoxColumn dtgvVencimiento;
        private DataGridViewTextBoxColumn dtgvEstado;
    }
}