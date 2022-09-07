namespace pryMoralesER
{
    partial class frmVendedores
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
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cbActivo = new System.Windows.Forms.CheckBox();
            this.cbComision = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(251, 203);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 35);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(47, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(237, 31);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Ingreso de Datos";
            // 
            // mskID
            // 
            this.mskID.Location = new System.Drawing.Point(183, 73);
            this.mskID.Mask = "99999";
            this.mskID.Name = "mskID";
            this.mskID.Size = new System.Drawing.Size(100, 26);
            this.mskID.TabIndex = 6;
            this.mskID.ValidatingType = typeof(int);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(164, 20);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre del vendedor:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(183, 117);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(19, 76);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(125, 20);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID del vendedor:";
            // 
            // cbActivo
            // 
            this.cbActivo.AutoSize = true;
            this.cbActivo.Location = new System.Drawing.Point(53, 162);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(71, 24);
            this.cbActivo.TabIndex = 12;
            this.cbActivo.Text = "Activo";
            this.cbActivo.UseVisualStyleBackColor = true;
            // 
            // cbComision
            // 
            this.cbComision.AutoSize = true;
            this.cbComision.Location = new System.Drawing.Point(160, 162);
            this.cbComision.Name = "cbComision";
            this.cbComision.Size = new System.Drawing.Size(137, 24);
            this.cbComision.TabIndex = 13;
            this.cbComision.Text = "Cobra comisión";
            this.cbComision.UseVisualStyleBackColor = true;
            // 
            // frmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 257);
            this.Controls.Add(this.cbComision);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mskID);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVendedores";
            this.Text = "Vendedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox mskID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.CheckBox cbActivo;
        private System.Windows.Forms.CheckBox cbComision;
    }
}