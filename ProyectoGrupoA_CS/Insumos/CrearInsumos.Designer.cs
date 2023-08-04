namespace Insumos
{
    partial class CrearInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearInsumos));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.txtInsumo = new System.Windows.Forms.TextBox();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DtpFechaIngresoInsumo = new System.Windows.Forms.DateTimePicker();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.BtnAgregarInsumo = new System.Windows.Forms.Button();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(171, 96);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(206, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblCodigo.Location = new System.Drawing.Point(64, 96);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(80, 23);
            this.LblCodigo.TabIndex = 1;
            this.LblCodigo.Text = "Código:";
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblIngresar.Location = new System.Drawing.Point(167, 31);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(162, 23);
            this.lblIngresar.TabIndex = 2;
            this.lblIngresar.Text = "Ingresar Insumos";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnRegresar.Location = new System.Drawing.Point(14, 9);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(83, 70);
            this.BtnRegresar.TabIndex = 40;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // txtInsumo
            // 
            this.txtInsumo.Location = new System.Drawing.Point(171, 162);
            this.txtInsumo.Name = "txtInsumo";
            this.txtInsumo.Size = new System.Drawing.Size(206, 22);
            this.txtInsumo.TabIndex = 42;
            // 
            // lblInsumo
            // 
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblInsumo.Location = new System.Drawing.Point(64, 160);
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(82, 23);
            this.lblInsumo.TabIndex = 41;
            this.lblInsumo.Text = "Insumo:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblFecha.Location = new System.Drawing.Point(64, 233);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(66, 23);
            this.LblFecha.TabIndex = 43;
            this.LblFecha.Text = "Fecha:";
            // 
            // DtpFechaIngresoInsumo
            // 
            this.DtpFechaIngresoInsumo.Location = new System.Drawing.Point(171, 233);
            this.DtpFechaIngresoInsumo.Name = "DtpFechaIngresoInsumo";
            this.DtpFechaIngresoInsumo.Size = new System.Drawing.Size(206, 22);
            this.DtpFechaIngresoInsumo.TabIndex = 44;
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblProveedor.Location = new System.Drawing.Point(64, 289);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(106, 23);
            this.LblProveedor.TabIndex = 45;
            this.LblProveedor.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(176, 291);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(206, 22);
            this.txtProveedor.TabIndex = 46;
            // 
            // BtnAgregarInsumo
            // 
            this.BtnAgregarInsumo.FlatAppearance.BorderSize = 0;
            this.BtnAgregarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarInsumo.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarInsumo.Image")));
            this.BtnAgregarInsumo.Location = new System.Drawing.Point(171, 403);
            this.BtnAgregarInsumo.Name = "BtnAgregarInsumo";
            this.BtnAgregarInsumo.Size = new System.Drawing.Size(102, 76);
            this.BtnAgregarInsumo.TabIndex = 47;
            this.BtnAgregarInsumo.UseVisualStyleBackColor = true;
            this.BtnAgregarInsumo.Click += new System.EventHandler(this.BtnAgregarInsumo_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblEstado.Location = new System.Drawing.Point(64, 351);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(74, 23);
            this.LblEstado.TabIndex = 48;
            this.LblEstado.Text = "Estado:";
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "",
            "PENDIENTE",
            "PROCESO",
            "COMPLETADO"});
            this.CmbEstado.Location = new System.Drawing.Point(176, 349);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(206, 24);
            this.CmbEstado.TabIndex = 49;
            // 
            // CrearInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(462, 514);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.BtnAgregarInsumo);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.LblProveedor);
            this.Controls.Add(this.DtpFechaIngresoInsumo);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.txtInsumo);
            this.Controls.Add(this.lblInsumo);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearInsumos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.TextBox txtInsumo;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker DtpFechaIngresoInsumo;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button BtnAgregarInsumo;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CmbEstado;
    }
}