namespace Facturas
{
    partial class FrmCrearFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearFactura));
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.lblGenerarFacturas = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.lblEmision = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.DTPEmision = new System.Windows.Forms.DateTimePicker();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.lblFechaSeleccionada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnIngresar.Image")));
            this.BtnIngresar.Location = new System.Drawing.Point(335, 230);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(91, 76);
            this.BtnIngresar.TabIndex = 0;
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblCodigo.Location = new System.Drawing.Point(25, 97);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(80, 23);
            this.LblCodigo.TabIndex = 3;
            this.LblCodigo.Text = "Código:";
            // 
            // lblGenerarFacturas
            // 
            this.lblGenerarFacturas.AutoSize = true;
            this.lblGenerarFacturas.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblGenerarFacturas.Location = new System.Drawing.Point(93, 21);
            this.lblGenerarFacturas.Name = "lblGenerarFacturas";
            this.lblGenerarFacturas.Size = new System.Drawing.Size(183, 23);
            this.lblGenerarFacturas.TabIndex = 4;
            this.lblGenerarFacturas.Text = "Generando facturas";
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblCedula.Location = new System.Drawing.Point(25, 148);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(79, 23);
            this.LblCedula.TabIndex = 5;
            this.LblCedula.Text = "Cédula:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblNombre.Location = new System.Drawing.Point(26, 201);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(88, 23);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "Nombre:";
            // 
            // lblEmision
            // 
            this.lblEmision.AutoSize = true;
            this.lblEmision.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEmision.Location = new System.Drawing.Point(25, 254);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(87, 23);
            this.lblEmision.TabIndex = 7;
            this.lblEmision.Text = "Emision:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(28, 344);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 23);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDomicilio.Location = new System.Drawing.Point(28, 401);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(97, 23);
            this.lblDomicilio.TabIndex = 9;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(28, 453);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(114, 23);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripción";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(111, 97);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(147, 22);
            this.TxtCodigo.TabIndex = 11;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(111, 148);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(147, 22);
            this.TxtCedula.TabIndex = 12;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(120, 203);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(147, 22);
            this.TxtNombre.TabIndex = 13;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // DTPEmision
            // 
            this.DTPEmision.Location = new System.Drawing.Point(120, 255);
            this.DTPEmision.Name = "DTPEmision";
            this.DTPEmision.Size = new System.Drawing.Size(182, 22);
            this.DTPEmision.TabIndex = 14;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(130, 346);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(147, 22);
            this.TxtTelefono.TabIndex = 15;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Location = new System.Drawing.Point(146, 401);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(147, 22);
            this.TxtDomicilio.TabIndex = 16;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(30, 479);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(359, 117);
            this.TxtDescripcion.TabIndex = 17;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(12, 14);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(46, 40);
            this.BtnSalir.TabIndex = 18;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblFechaSeleccionada
            // 
            this.lblFechaSeleccionada.AutoSize = true;
            this.lblFechaSeleccionada.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaSeleccionada.Location = new System.Drawing.Point(28, 306);
            this.lblFechaSeleccionada.Name = "lblFechaSeleccionada";
            this.lblFechaSeleccionada.Size = new System.Drawing.Size(15, 23);
            this.lblFechaSeleccionada.TabIndex = 19;
            this.lblFechaSeleccionada.Text = ".";
            // 
            // FrmCrearFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(440, 608);
            this.Controls.Add(this.lblFechaSeleccionada);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.DTPEmision);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmision);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.lblGenerarFacturas);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.BtnIngresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label lblGenerarFacturas;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label lblEmision;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DateTimePicker DTPEmision;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label lblFechaSeleccionada;
    }
}