namespace pryMoralesER
{
    partial class frmClientes
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(16, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(105, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID del cliente:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 118);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(144, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre del cliente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // mskID
            // 
            this.mskID.Location = new System.Drawing.Point(180, 71);
            this.mskID.Mask = "99999";
            this.mskID.Name = "mskID";
            this.mskID.Size = new System.Drawing.Size(100, 26);
            this.mskID.TabIndex = 1;
            this.mskID.ValidatingType = typeof(int);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(44, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(237, 31);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Ingreso de Datos";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(248, 156);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 35);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 208);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mskID);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mskID;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCargar;
    }
}