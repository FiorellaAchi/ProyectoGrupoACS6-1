namespace Facturas
{
    partial class EliminarFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarFacturas));
            this.lblIngresar = new System.Windows.Forms.Label();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblIngresar.Location = new System.Drawing.Point(298, 28);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(163, 23);
            this.lblIngresar.TabIndex = 4;
            this.lblIngresar.Text = "Eliminar Facturas";
            // 
            // DGVListado
            // 
            this.DGVListado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Location = new System.Drawing.Point(60, 156);
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.RowHeadersWidth = 51;
            this.DGVListado.RowTemplate.Height = 24;
            this.DGVListado.Size = new System.Drawing.Size(701, 324);
            this.DGVListado.TabIndex = 5;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(49, 28);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(46, 40);
            this.BtnSalir.TabIndex = 27;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(198, 105);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(147, 22);
            this.TxtCodigo.TabIndex = 29;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblCodigo.Location = new System.Drawing.Point(110, 105);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(80, 23);
            this.LblCodigo.TabIndex = 28;
            this.LblCodigo.Text = "Código:";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(580, 86);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(59, 60);
            this.BtnEliminar.TabIndex = 30;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // EliminarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.DGVListado);
            this.Controls.Add(this.lblIngresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnEliminar;
    }
}