namespace pryMoralesER
{
    partial class frmConsultaVendedores
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
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.idVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AllowUserToAddRows = false;
            this.dgvVendedores.AllowUserToDeleteRows = false;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendedor,
            this.nombreVendedor,
            this.activo,
            this.comision});
            this.dgvVendedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVendedores.Location = new System.Drawing.Point(0, 0);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.ReadOnly = true;
            this.dgvVendedores.Size = new System.Drawing.Size(677, 432);
            this.dgvVendedores.TabIndex = 0;
            // 
            // idVendedor
            // 
            this.idVendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idVendedor.HeaderText = "ID Vendedor";
            this.idVendedor.Name = "idVendedor";
            this.idVendedor.ReadOnly = true;
            this.idVendedor.Width = 115;
            // 
            // nombreVendedor
            // 
            this.nombreVendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreVendedor.HeaderText = "Nombre del vendor";
            this.nombreVendedor.Name = "nombreVendedor";
            this.nombreVendedor.ReadOnly = true;
            // 
            // activo
            // 
            this.activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.activo.HeaderText = "Esta activo?";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            // 
            // comision
            // 
            this.comision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comision.HeaderText = "Cobra comisión?";
            this.comision.Name = "comision";
            this.comision.ReadOnly = true;
            // 
            // frmConsultaVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 432);
            this.Controls.Add(this.dgvVendedores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultaVendedores";
            this.Text = "Consulta - Vendedores";
            this.Load += new System.EventHandler(this.frmConsultaVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
    }
}