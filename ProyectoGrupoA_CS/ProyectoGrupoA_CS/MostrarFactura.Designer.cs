namespace ProyectoGrupoA_CS
{
    partial class MostrarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarFactura));
            this.lblParaFactura = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblConductorID = new System.Windows.Forms.Label();
            this.lblAmbulancia = new System.Windows.Forms.Label();
            this.lblInsumosUtilizados = new System.Windows.Forms.Label();
            this.ServiciosOcupados = new System.Windows.Forms.Label();
            this.lblDomicilioCliente = new System.Windows.Forms.Label();
            this.lblDescripcionFactura = new System.Windows.Forms.Label();
            this.lblEmisionFactura = new System.Windows.Forms.Label();
            this.lblSubtotalFactura = new System.Windows.Forms.Label();
            this.lblTotalAPagarFactura = new System.Windows.Forms.Label();
            this.lblConductor = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblInsumos = new System.Windows.Forms.Label();
            this.lblServicios = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEmision = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.DgvFacturas = new System.Windows.Forms.DataGridView();
            this.lblIDConductor = new System.Windows.Forms.Label();
            this.idConductorName = new System.Windows.Forms.Label();
            this.lblCodigoAmbulancia = new System.Windows.Forms.Label();
            this.lblIdAmbulancia = new System.Windows.Forms.Label();
            this.lblIDInsumo = new System.Windows.Forms.Label();
            this.lblIDServicio = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblIDPaciente = new System.Windows.Forms.Label();
            this.BtnGenerarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParaFactura
            // 
            this.lblParaFactura.AutoSize = true;
            this.lblParaFactura.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParaFactura.Location = new System.Drawing.Point(47, 152);
            this.lblParaFactura.Name = "lblParaFactura";
            this.lblParaFactura.Size = new System.Drawing.Size(109, 24);
            this.lblParaFactura.TabIndex = 0;
            this.lblParaFactura.Text = "ID Factura:";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(252, 152);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(15, 24);
            this.lblFactura.TabIndex = 1;
            this.lblFactura.Text = ".";
            // 
            // lblConductorID
            // 
            this.lblConductorID.AutoSize = true;
            this.lblConductorID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductorID.Location = new System.Drawing.Point(47, 226);
            this.lblConductorID.Name = "lblConductorID";
            this.lblConductorID.Size = new System.Drawing.Size(106, 24);
            this.lblConductorID.TabIndex = 2;
            this.lblConductorID.Text = "Conductor";
            // 
            // lblAmbulancia
            // 
            this.lblAmbulancia.AutoSize = true;
            this.lblAmbulancia.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmbulancia.Location = new System.Drawing.Point(47, 270);
            this.lblAmbulancia.Name = "lblAmbulancia";
            this.lblAmbulancia.Size = new System.Drawing.Size(125, 24);
            this.lblAmbulancia.TabIndex = 3;
            this.lblAmbulancia.Text = "Ambulancia:";
            // 
            // lblInsumosUtilizados
            // 
            this.lblInsumosUtilizados.AutoSize = true;
            this.lblInsumosUtilizados.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsumosUtilizados.Location = new System.Drawing.Point(47, 322);
            this.lblInsumosUtilizados.Name = "lblInsumosUtilizados";
            this.lblInsumosUtilizados.Size = new System.Drawing.Size(188, 24);
            this.lblInsumosUtilizados.TabIndex = 4;
            this.lblInsumosUtilizados.Text = "Insumos Utilizados:";
            // 
            // ServiciosOcupados
            // 
            this.ServiciosOcupados.AutoSize = true;
            this.ServiciosOcupados.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiciosOcupados.Location = new System.Drawing.Point(47, 367);
            this.ServiciosOcupados.Name = "ServiciosOcupados";
            this.ServiciosOcupados.Size = new System.Drawing.Size(95, 24);
            this.ServiciosOcupados.TabIndex = 5;
            this.ServiciosOcupados.Text = "Servicios:";
            // 
            // lblDomicilioCliente
            // 
            this.lblDomicilioCliente.AutoSize = true;
            this.lblDomicilioCliente.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilioCliente.Location = new System.Drawing.Point(47, 410);
            this.lblDomicilioCliente.Name = "lblDomicilioCliente";
            this.lblDomicilioCliente.Size = new System.Drawing.Size(103, 24);
            this.lblDomicilioCliente.TabIndex = 6;
            this.lblDomicilioCliente.Text = "Domicilio:";
            // 
            // lblDescripcionFactura
            // 
            this.lblDescripcionFactura.AutoSize = true;
            this.lblDescripcionFactura.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionFactura.Location = new System.Drawing.Point(47, 449);
            this.lblDescripcionFactura.Name = "lblDescripcionFactura";
            this.lblDescripcionFactura.Size = new System.Drawing.Size(121, 24);
            this.lblDescripcionFactura.TabIndex = 7;
            this.lblDescripcionFactura.Text = "Descripción:";
            // 
            // lblEmisionFactura
            // 
            this.lblEmisionFactura.AutoSize = true;
            this.lblEmisionFactura.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmisionFactura.Location = new System.Drawing.Point(47, 488);
            this.lblEmisionFactura.Name = "lblEmisionFactura";
            this.lblEmisionFactura.Size = new System.Drawing.Size(88, 24);
            this.lblEmisionFactura.TabIndex = 8;
            this.lblEmisionFactura.Text = "Emisión:";
            // 
            // lblSubtotalFactura
            // 
            this.lblSubtotalFactura.AutoSize = true;
            this.lblSubtotalFactura.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalFactura.Location = new System.Drawing.Point(47, 528);
            this.lblSubtotalFactura.Name = "lblSubtotalFactura";
            this.lblSubtotalFactura.Size = new System.Drawing.Size(132, 24);
            this.lblSubtotalFactura.TabIndex = 9;
            this.lblSubtotalFactura.Text = "Subtotal 12%:";
            // 
            // lblTotalAPagarFactura
            // 
            this.lblTotalAPagarFactura.AutoSize = true;
            this.lblTotalAPagarFactura.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagarFactura.Location = new System.Drawing.Point(47, 578);
            this.lblTotalAPagarFactura.Name = "lblTotalAPagarFactura";
            this.lblTotalAPagarFactura.Size = new System.Drawing.Size(61, 24);
            this.lblTotalAPagarFactura.TabIndex = 10;
            this.lblTotalAPagarFactura.Text = "Total:";
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.Location = new System.Drawing.Point(252, 226);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(15, 24);
            this.lblConductor.TabIndex = 11;
            this.lblConductor.Text = ".";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(252, 270);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(15, 24);
            this.lblPlaca.TabIndex = 12;
            this.lblPlaca.Text = ".";
            // 
            // lblInsumos
            // 
            this.lblInsumos.AutoSize = true;
            this.lblInsumos.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsumos.Location = new System.Drawing.Point(252, 318);
            this.lblInsumos.Name = "lblInsumos";
            this.lblInsumos.Size = new System.Drawing.Size(15, 24);
            this.lblInsumos.TabIndex = 13;
            this.lblInsumos.Text = ".";
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicios.Location = new System.Drawing.Point(252, 367);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(15, 24);
            this.lblServicios.TabIndex = 14;
            this.lblServicios.Text = ".";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(252, 410);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(15, 24);
            this.lblDomicilio.TabIndex = 15;
            this.lblDomicilio.Text = ".";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(252, 449);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(15, 24);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = ".";
            // 
            // lblEmision
            // 
            this.lblEmision.AutoSize = true;
            this.lblEmision.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmision.Location = new System.Drawing.Point(252, 488);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(15, 24);
            this.lblEmision.TabIndex = 17;
            this.lblEmision.Text = ".";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(252, 528);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(15, 24);
            this.lblSubtotal.TabIndex = 18;
            this.lblSubtotal.Text = ".";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(252, 578);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 24);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = ".";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(199, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(238, 118);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 20;
            this.LogoPictureBox.TabStop = false;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.Location = new System.Drawing.Point(25, 12);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(27, 32);
            this.BtnRegresar.TabIndex = 21;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click_1);
            // 
            // DgvFacturas
            // 
            this.DgvFacturas.BackgroundColor = System.Drawing.Color.White;
            this.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturas.Location = new System.Drawing.Point(627, 187);
            this.DgvFacturas.Name = "DgvFacturas";
            this.DgvFacturas.RowHeadersWidth = 51;
            this.DgvFacturas.RowTemplate.Height = 24;
            this.DgvFacturas.Size = new System.Drawing.Size(252, 155);
            this.DgvFacturas.TabIndex = 22;
            this.DgvFacturas.SelectionChanged += new System.EventHandler(this.DgvFacturas_SelectionChanged);
            // 
            // lblIDConductor
            // 
            this.lblIDConductor.AutoSize = true;
            this.lblIDConductor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDConductor.Location = new System.Drawing.Point(1182, 538);
            this.lblIDConductor.Name = "lblIDConductor";
            this.lblIDConductor.Size = new System.Drawing.Size(15, 24);
            this.lblIDConductor.TabIndex = 24;
            this.lblIDConductor.Text = ".";
            // 
            // idConductorName
            // 
            this.idConductorName.AutoSize = true;
            this.idConductorName.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idConductorName.Location = new System.Drawing.Point(1095, 296);
            this.idConductorName.Name = "idConductorName";
            this.idConductorName.Size = new System.Drawing.Size(133, 24);
            this.idConductorName.TabIndex = 25;
            this.idConductorName.Text = "IDConductor:";
            // 
            // lblCodigoAmbulancia
            // 
            this.lblCodigoAmbulancia.AutoSize = true;
            this.lblCodigoAmbulancia.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAmbulancia.Location = new System.Drawing.Point(1116, 350);
            this.lblCodigoAmbulancia.Name = "lblCodigoAmbulancia";
            this.lblCodigoAmbulancia.Size = new System.Drawing.Size(152, 24);
            this.lblCodigoAmbulancia.TabIndex = 26;
            this.lblCodigoAmbulancia.Text = "ID Ambulancia:";
            // 
            // lblIdAmbulancia
            // 
            this.lblIdAmbulancia.AutoSize = true;
            this.lblIdAmbulancia.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAmbulancia.Location = new System.Drawing.Point(1133, 538);
            this.lblIdAmbulancia.Name = "lblIdAmbulancia";
            this.lblIdAmbulancia.Size = new System.Drawing.Size(15, 24);
            this.lblIdAmbulancia.TabIndex = 27;
            this.lblIdAmbulancia.Text = ".";
            // 
            // lblIDInsumo
            // 
            this.lblIDInsumo.AutoSize = true;
            this.lblIDInsumo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDInsumo.Location = new System.Drawing.Point(1065, 434);
            this.lblIDInsumo.Name = "lblIDInsumo";
            this.lblIDInsumo.Size = new System.Drawing.Size(188, 24);
            this.lblIDInsumo.TabIndex = 28;
            this.lblIDInsumo.Text = "Insumos Utilizados:";
            // 
            // lblIDServicio
            // 
            this.lblIDServicio.AutoSize = true;
            this.lblIDServicio.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDServicio.Location = new System.Drawing.Point(1133, 502);
            this.lblIDServicio.Name = "lblIDServicio";
            this.lblIDServicio.Size = new System.Drawing.Size(95, 24);
            this.lblIDServicio.TabIndex = 29;
            this.lblIDServicio.Text = "Servicios:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.lblPaciente.Location = new System.Drawing.Point(49, 189);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(86, 24);
            this.lblPaciente.TabIndex = 30;
            this.lblPaciente.Text = "Paciente";
            // 
            // lblIDPaciente
            // 
            this.lblIDPaciente.AutoSize = true;
            this.lblIDPaciente.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.lblIDPaciente.Location = new System.Drawing.Point(252, 189);
            this.lblIDPaciente.Name = "lblIDPaciente";
            this.lblIDPaciente.Size = new System.Drawing.Size(15, 24);
            this.lblIDPaciente.TabIndex = 31;
            this.lblIDPaciente.Text = ".";
            // 
            // BtnGenerarFactura
            // 
            this.BtnGenerarFactura.FlatAppearance.BorderSize = 0;
            this.BtnGenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarFactura.Image = ((System.Drawing.Image)(resources.GetObject("BtnGenerarFactura.Image")));
            this.BtnGenerarFactura.Location = new System.Drawing.Point(199, 650);
            this.BtnGenerarFactura.Name = "BtnGenerarFactura";
            this.BtnGenerarFactura.Size = new System.Drawing.Size(94, 70);
            this.BtnGenerarFactura.TabIndex = 32;
            this.BtnGenerarFactura.UseVisualStyleBackColor = true;
            this.BtnGenerarFactura.Click += new System.EventHandler(this.BtnGenerarFactura_Click);
            // 
            // MostrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 732);
            this.Controls.Add(this.BtnGenerarFactura);
            this.Controls.Add(this.lblIDPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblIDServicio);
            this.Controls.Add(this.lblIDInsumo);
            this.Controls.Add(this.lblIdAmbulancia);
            this.Controls.Add(this.lblCodigoAmbulancia);
            this.Controls.Add(this.idConductorName);
            this.Controls.Add(this.lblIDConductor);
            this.Controls.Add(this.DgvFacturas);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblEmision);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblServicios);
            this.Controls.Add(this.lblInsumos);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.lblTotalAPagarFactura);
            this.Controls.Add(this.lblSubtotalFactura);
            this.Controls.Add(this.lblEmisionFactura);
            this.Controls.Add(this.lblDescripcionFactura);
            this.Controls.Add(this.lblDomicilioCliente);
            this.Controls.Add(this.ServiciosOcupados);
            this.Controls.Add(this.lblInsumosUtilizados);
            this.Controls.Add(this.lblAmbulancia);
            this.Controls.Add(this.lblConductorID);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.lblParaFactura);
            this.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarFactura";
            this.Load += new System.EventHandler(this.MostrarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParaFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblConductorID;
        private System.Windows.Forms.Label lblAmbulancia;
        private System.Windows.Forms.Label lblInsumosUtilizados;
        private System.Windows.Forms.Label ServiciosOcupados;
        private System.Windows.Forms.Label lblDomicilioCliente;
        private System.Windows.Forms.Label lblDescripcionFactura;
        private System.Windows.Forms.Label lblEmisionFactura;
        private System.Windows.Forms.Label lblSubtotalFactura;
        private System.Windows.Forms.Label lblTotalAPagarFactura;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblInsumos;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEmision;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView DgvFacturas;
        private System.Windows.Forms.Label lblIDConductor;
        private System.Windows.Forms.Label idConductorName;
        private System.Windows.Forms.Label lblCodigoAmbulancia;
        private System.Windows.Forms.Label lblIdAmbulancia;
        private System.Windows.Forms.Label lblIDInsumo;
        private System.Windows.Forms.Label lblIDServicio;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblIDPaciente;
        private System.Windows.Forms.Button BtnGenerarFactura;
    }
}