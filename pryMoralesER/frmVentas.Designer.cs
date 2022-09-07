namespace pryMoralesER
{
    partial class frmVentas
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mskNumero = new System.Windows.Forms.MaskedTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.lblIDVendedor = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.mskMonto = new System.Windows.Forms.MaskedTextBox();
            this.cboIDCliente = new System.Windows.Forms.ComboBox();
            this.cboIDVendedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(218, 304);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 35);
            this.btnCargar.TabIndex = 17;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(39, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(237, 31);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Ingreso de Datos";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(21, 154);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(119, 20);
            this.lblTipo.TabIndex = 22;
            this.lblTipo.Text = "Tipo de factura:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cboTipo.Location = new System.Drawing.Point(172, 151);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(102, 28);
            this.cboTipo.TabIndex = 23;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(21, 193);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(145, 20);
            this.lblNumero.TabIndex = 24;
            this.lblNumero.Text = "Número de factura:";
            this.lblNumero.Click += new System.EventHandler(this.label2_Click);
            // 
            // mskNumero
            // 
            this.mskNumero.Location = new System.Drawing.Point(172, 193);
            this.mskNumero.Mask = "9999";
            this.mskNumero.Name = "mskNumero";
            this.mskNumero.Size = new System.Drawing.Size(42, 26);
            this.mskNumero.TabIndex = 25;
            this.mskNumero.ValidatingType = typeof(int);
            this.mskNumero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFecha.Location = new System.Drawing.Point(93, 236);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 26;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(21, 236);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 20);
            this.lblFecha.TabIndex = 27;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(21, 68);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(108, 20);
            this.lblIDCliente.TabIndex = 28;
            this.lblIDCliente.Text = "ID del Cliente:";
            // 
            // lblIDVendedor
            // 
            this.lblIDVendedor.AutoSize = true;
            this.lblIDVendedor.Location = new System.Drawing.Point(21, 110);
            this.lblIDVendedor.Name = "lblIDVendedor";
            this.lblIDVendedor.Size = new System.Drawing.Size(129, 20);
            this.lblIDVendedor.TabIndex = 29;
            this.lblIDVendedor.Text = "ID del Vendedor:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(21, 275);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(58, 20);
            this.lblMonto.TabIndex = 30;
            this.lblMonto.Text = "Monto:";
            // 
            // mskMonto
            // 
            this.mskMonto.Location = new System.Drawing.Point(93, 272);
            this.mskMonto.Mask = "99999";
            this.mskMonto.Name = "mskMonto";
            this.mskMonto.Size = new System.Drawing.Size(57, 26);
            this.mskMonto.TabIndex = 31;
            this.mskMonto.ValidatingType = typeof(int);
            // 
            // cboIDCliente
            // 
            this.cboIDCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDCliente.FormattingEnabled = true;
            this.cboIDCliente.Location = new System.Drawing.Point(172, 65);
            this.cboIDCliente.Name = "cboIDCliente";
            this.cboIDCliente.Size = new System.Drawing.Size(121, 28);
            this.cboIDCliente.TabIndex = 32;
            // 
            // cboIDVendedor
            // 
            this.cboIDVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDVendedor.FormattingEnabled = true;
            this.cboIDVendedor.Location = new System.Drawing.Point(172, 107);
            this.cboIDVendedor.Name = "cboIDVendedor";
            this.cboIDVendedor.Size = new System.Drawing.Size(121, 28);
            this.cboIDVendedor.TabIndex = 33;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 358);
            this.Controls.Add(this.cboIDVendedor);
            this.Controls.Add(this.cboIDCliente);
            this.Controls.Add(this.mskMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblIDVendedor);
            this.Controls.Add(this.lblIDCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.mskNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox mskNumero;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.Label lblIDVendedor;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.MaskedTextBox mskMonto;
        private System.Windows.Forms.ComboBox cboIDCliente;
        private System.Windows.Forms.ComboBox cboIDVendedor;
    }
}