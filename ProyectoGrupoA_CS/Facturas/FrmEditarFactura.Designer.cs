namespace Facturas
{
    partial class FrmEditarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarFactura));
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmision = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.DGVListarFacturas = new System.Windows.Forms.DataGridView();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.DTPEmision = new System.Windows.Forms.DateTimePicker();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListarFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblModificar.Location = new System.Drawing.Point(113, 36);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(165, 23);
            this.lblModificar.TabIndex = 1;
            this.lblModificar.Text = "Modificar Factura";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(52, 426);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(114, 23);
            this.lblDescripcion.TabIndex = 17;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDomicilio.Location = new System.Drawing.Point(52, 374);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(97, 23);
            this.lblDomicilio.TabIndex = 16;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(52, 317);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 23);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblEmision
            // 
            this.lblEmision.AutoSize = true;
            this.lblEmision.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEmision.Location = new System.Drawing.Point(50, 257);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(87, 23);
            this.lblEmision.TabIndex = 14;
            this.lblEmision.Text = "Emision:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblNombre.Location = new System.Drawing.Point(51, 204);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(88, 23);
            this.LblNombre.TabIndex = 13;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblCedula.Location = new System.Drawing.Point(50, 151);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(79, 23);
            this.LblCedula.TabIndex = 12;
            this.LblCedula.Text = "Cédula:";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblCodigo.Location = new System.Drawing.Point(50, 100);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(80, 23);
            this.LblCodigo.TabIndex = 11;
            this.LblCodigo.Text = "Código:";
            // 
            // DGVListarFacturas
            // 
            this.DGVListarFacturas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVListarFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListarFacturas.Location = new System.Drawing.Point(348, 65);
            this.DGVListarFacturas.Name = "DGVListarFacturas";
            this.DGVListarFacturas.RowHeadersWidth = 51;
            this.DGVListarFacturas.RowTemplate.Height = 24;
            this.DGVListarFacturas.Size = new System.Drawing.Size(542, 263);
            this.DGVListarFacturas.TabIndex = 18;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(56, 452);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(359, 117);
            this.TxtDescripcion.TabIndex = 25;
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Location = new System.Drawing.Point(172, 374);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(147, 22);
            this.TxtDomicilio.TabIndex = 24;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(156, 319);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(147, 22);
            this.TxtTelefono.TabIndex = 23;
            // 
            // DTPEmision
            // 
            this.DTPEmision.Location = new System.Drawing.Point(147, 258);
            this.DTPEmision.Name = "DTPEmision";
            this.DTPEmision.Size = new System.Drawing.Size(182, 22);
            this.DTPEmision.TabIndex = 22;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(147, 206);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(147, 22);
            this.TxtNombre.TabIndex = 21;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(138, 151);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(147, 22);
            this.TxtCedula.TabIndex = 20;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(138, 100);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(147, 22);
            this.TxtCodigo.TabIndex = 19;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(21, 19);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(46, 40);
            this.BtnSalir.TabIndex = 26;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(602, 385);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(119, 109);
            this.BtnEditar.TabIndex = 27;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // FrmEditarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(914, 618);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.DTPEmision);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.DGVListarFacturas);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmision);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.lblModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarFactura";
            this.Text = "FrmEditarFactura";
            ((System.ComponentModel.ISupportInitialize)(this.DGVListarFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmision;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.DataGridView DGVListarFacturas;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.DateTimePicker DTPEmision;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEditar;
    }
}