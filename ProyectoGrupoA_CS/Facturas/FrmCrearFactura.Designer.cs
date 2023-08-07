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
            this.LblIdConductores = new System.Windows.Forms.Label();
            this.lblEmision = new System.Windows.Forms.Label();
            this.lblAmbulancia = new System.Windows.Forms.Label();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.txtConductorID = new System.Windows.Forms.TextBox();
            this.DTPEmision = new System.Windows.Forms.DateTimePicker();
            this.TxtAmbulancia = new System.Windows.Forms.TextBox();
            this.txtInsumo = new System.Windows.Forms.TextBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.lblFechaSeleccionada = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDPaciente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnIngresar.Image")));
            this.BtnIngresar.Location = new System.Drawing.Point(337, 281);
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
            this.LblCodigo.Location = new System.Drawing.Point(28, 77);
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
            this.LblCedula.Location = new System.Drawing.Point(25, 126);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(79, 23);
            this.LblCedula.TabIndex = 5;
            this.LblCedula.Text = "Cédula:";
            // 
            // LblIdConductores
            // 
            this.LblIdConductores.AutoSize = true;
            this.LblIdConductores.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblIdConductores.Location = new System.Drawing.Point(25, 172);
            this.LblIdConductores.Name = "LblIdConductores";
            this.LblIdConductores.Size = new System.Drawing.Size(132, 23);
            this.LblIdConductores.TabIndex = 6;
            this.LblIdConductores.Text = "Id Conductor:";
            // 
            // lblEmision
            // 
            this.lblEmision.AutoSize = true;
            this.lblEmision.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEmision.Location = new System.Drawing.Point(28, 413);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(87, 23);
            this.lblEmision.TabIndex = 7;
            this.lblEmision.Text = "Emision:";
            // 
            // lblAmbulancia
            // 
            this.lblAmbulancia.AutoSize = true;
            this.lblAmbulancia.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAmbulancia.Location = new System.Drawing.Point(28, 252);
            this.lblAmbulancia.Name = "lblAmbulancia";
            this.lblAmbulancia.Size = new System.Drawing.Size(188, 23);
            this.lblAmbulancia.TabIndex = 8;
            this.lblAmbulancia.Text = "Codigo Ambulancia";
            // 
            // lblInsumo
            // 
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblInsumo.Location = new System.Drawing.Point(28, 303);
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(106, 23);
            this.lblInsumo.TabIndex = 9;
            this.lblInsumo.Text = "Id Insumo:";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblServicio.Location = new System.Drawing.Point(28, 356);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(114, 23);
            this.lblServicio.TabIndex = 10;
            this.lblServicio.Text = "ID Servicio:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(114, 79);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(147, 22);
            this.TxtCodigo.TabIndex = 11;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(120, 126);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(147, 22);
            this.TxtCedula.TabIndex = 12;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // txtConductorID
            // 
            this.txtConductorID.Location = new System.Drawing.Point(164, 172);
            this.txtConductorID.Name = "txtConductorID";
            this.txtConductorID.Size = new System.Drawing.Size(147, 22);
            this.txtConductorID.TabIndex = 13;
            this.txtConductorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // DTPEmision
            // 
            this.DTPEmision.Location = new System.Drawing.Point(140, 413);
            this.DTPEmision.Name = "DTPEmision";
            this.DTPEmision.Size = new System.Drawing.Size(182, 22);
            this.DTPEmision.TabIndex = 14;
            // 
            // TxtAmbulancia
            // 
            this.TxtAmbulancia.Location = new System.Drawing.Point(222, 254);
            this.TxtAmbulancia.Name = "TxtAmbulancia";
            this.TxtAmbulancia.Size = new System.Drawing.Size(147, 22);
            this.TxtAmbulancia.TabIndex = 15;
            this.TxtAmbulancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // txtInsumo
            // 
            this.txtInsumo.Location = new System.Drawing.Point(165, 303);
            this.txtInsumo.Name = "txtInsumo";
            this.txtInsumo.Size = new System.Drawing.Size(147, 22);
            this.txtInsumo.TabIndex = 16;
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(165, 356);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(147, 22);
            this.txtServicio.TabIndex = 17;
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
            this.lblFechaSeleccionada.Location = new System.Drawing.Point(137, 442);
            this.lblFechaSeleccionada.Name = "lblFechaSeleccionada";
            this.lblFechaSeleccionada.Size = new System.Drawing.Size(15, 23);
            this.lblFechaSeleccionada.TabIndex = 19;
            this.lblFechaSeleccionada.Text = ".";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(172, 490);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(147, 22);
            this.txtDomicilio.TabIndex = 20;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDomicilio.Location = new System.Drawing.Point(35, 490);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(102, 23);
            this.lblDomicilio.TabIndex = 21;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(35, 535);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(119, 23);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(172, 535);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(147, 22);
            this.txtDescripcion.TabIndex = 23;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(175, 581);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(147, 22);
            this.txtSubtotal.TabIndex = 25;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.Location = new System.Drawing.Point(35, 581);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(90, 23);
            this.lblSubtotal.TabIndex = 24;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Id Paciente:";
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.Location = new System.Drawing.Point(164, 219);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.Size = new System.Drawing.Size(148, 22);
            this.txtIDPaciente.TabIndex = 27;
            // 
            // FrmCrearFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(440, 737);
            this.Controls.Add(this.txtIDPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lblFechaSeleccionada);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.txtInsumo);
            this.Controls.Add(this.TxtAmbulancia);
            this.Controls.Add(this.DTPEmision);
            this.Controls.Add(this.txtConductorID);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.lblInsumo);
            this.Controls.Add(this.lblAmbulancia);
            this.Controls.Add(this.lblEmision);
            this.Controls.Add(this.LblIdConductores);
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
        private System.Windows.Forms.Label LblIdConductores;
        private System.Windows.Forms.Label lblEmision;
        private System.Windows.Forms.Label lblAmbulancia;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox txtConductorID;
        private System.Windows.Forms.DateTimePicker DTPEmision;
        private System.Windows.Forms.TextBox TxtAmbulancia;
        private System.Windows.Forms.TextBox txtInsumo;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label lblFechaSeleccionada;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDPaciente;
    }
}