namespace ProyectoGrupoA_CS
{
    partial class FormAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.lblLABEL = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblAmbulancia = new System.Windows.Forms.Label();
            this.lblConductor = new System.Windows.Forms.Label();
            this.Salir2 = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Button();
            this.btnConductor = new System.Windows.Forms.Button();
            this.btnAmbulancia = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.BtnInsumos = new System.Windows.Forms.Button();
            this.LblInsumos = new System.Windows.Forms.Label();
            this.BtnFacturas = new System.Windows.Forms.Button();
            this.LblFacturas = new System.Windows.Forms.Label();
            this.BtnListarServicios = new System.Windows.Forms.Button();
            this.lblListar = new System.Windows.Forms.Label();
            this.BtnPacientes = new System.Windows.Forms.Button();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLABEL
            // 
            this.lblLABEL.AutoSize = true;
            this.lblLABEL.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLABEL.Location = new System.Drawing.Point(243, 46);
            this.lblLABEL.Name = "lblLABEL";
            this.lblLABEL.Size = new System.Drawing.Size(246, 41);
            this.lblLABEL.TabIndex = 0;
            this.lblLABEL.Text = "Menu Principal";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(85, 210);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(95, 28);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblAmbulancia
            // 
            this.lblAmbulancia.AutoSize = true;
            this.lblAmbulancia.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmbulancia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAmbulancia.Location = new System.Drawing.Point(296, 210);
            this.lblAmbulancia.Name = "lblAmbulancia";
            this.lblAmbulancia.Size = new System.Drawing.Size(148, 28);
            this.lblAmbulancia.TabIndex = 4;
            this.lblAmbulancia.Text = "Ambulancias";
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblConductor.Location = new System.Drawing.Point(83, 350);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(122, 28);
            this.lblConductor.TabIndex = 6;
            this.lblConductor.Text = "Conductor";
            // 
            // Salir2
            // 
            this.Salir2.AutoSize = true;
            this.Salir2.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Salir2.Location = new System.Drawing.Point(701, 363);
            this.Salir2.Name = "Salir2";
            this.Salir2.Size = new System.Drawing.Size(59, 28);
            this.Salir2.TabIndex = 8;
            this.Salir2.Text = "Salir";
            // 
            // lblSalir
            // 
            this.lblSalir.FlatAppearance.BorderSize = 0;
            this.lblSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalir.Image = ((System.Drawing.Image)(resources.GetObject("lblSalir.Image")));
            this.lblSalir.Location = new System.Drawing.Point(672, 266);
            this.lblSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(120, 80);
            this.lblSalir.TabIndex = 7;
            this.lblSalir.UseVisualStyleBackColor = true;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // btnConductor
            // 
            this.btnConductor.FlatAppearance.BorderSize = 0;
            this.btnConductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductor.Image = ((System.Drawing.Image)(resources.GetObject("btnConductor.Image")));
            this.btnConductor.Location = new System.Drawing.Point(100, 266);
            this.btnConductor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConductor.Name = "btnConductor";
            this.btnConductor.Size = new System.Drawing.Size(91, 80);
            this.btnConductor.TabIndex = 5;
            this.btnConductor.UseVisualStyleBackColor = true;
            this.btnConductor.Click += new System.EventHandler(this.btnConductor_Click);
            // 
            // btnAmbulancia
            // 
            this.btnAmbulancia.FlatAppearance.BorderSize = 0;
            this.btnAmbulancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmbulancia.Image = ((System.Drawing.Image)(resources.GetObject("btnAmbulancia.Image")));
            this.btnAmbulancia.Location = new System.Drawing.Point(329, 137);
            this.btnAmbulancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAmbulancia.Name = "btnAmbulancia";
            this.btnAmbulancia.Size = new System.Drawing.Size(95, 71);
            this.btnAmbulancia.TabIndex = 3;
            this.btnAmbulancia.UseVisualStyleBackColor = true;
            this.btnAmbulancia.Click += new System.EventHandler(this.btnAmbulancia_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(88, 127);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(93, 89);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // BtnInsumos
            // 
            this.BtnInsumos.FlatAppearance.BorderSize = 0;
            this.BtnInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsumos.Image = ((System.Drawing.Image)(resources.GetObject("BtnInsumos.Image")));
            this.BtnInsumos.Location = new System.Drawing.Point(301, 266);
            this.BtnInsumos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInsumos.Name = "BtnInsumos";
            this.BtnInsumos.Size = new System.Drawing.Size(124, 84);
            this.BtnInsumos.TabIndex = 9;
            this.BtnInsumos.UseVisualStyleBackColor = true;
            this.BtnInsumos.Click += new System.EventHandler(this.BtnInsumos_Click);
            // 
            // LblInsumos
            // 
            this.LblInsumos.AutoSize = true;
            this.LblInsumos.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInsumos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblInsumos.Location = new System.Drawing.Point(312, 353);
            this.LblInsumos.Name = "LblInsumos";
            this.LblInsumos.Size = new System.Drawing.Size(100, 28);
            this.LblInsumos.TabIndex = 10;
            this.LblInsumos.Text = "Insumos";
            // 
            // BtnFacturas
            // 
            this.BtnFacturas.FlatAppearance.BorderSize = 0;
            this.BtnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturas.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacturas.Image")));
            this.BtnFacturas.Location = new System.Drawing.Point(521, 129);
            this.BtnFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFacturas.Name = "BtnFacturas";
            this.BtnFacturas.Size = new System.Drawing.Size(100, 90);
            this.BtnFacturas.TabIndex = 11;
            this.BtnFacturas.UseVisualStyleBackColor = true;
            this.BtnFacturas.Click += new System.EventHandler(this.BtnFacturas_Click);
            // 
            // LblFacturas
            // 
            this.LblFacturas.AutoSize = true;
            this.LblFacturas.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFacturas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblFacturas.Location = new System.Drawing.Point(521, 219);
            this.LblFacturas.Name = "LblFacturas";
            this.LblFacturas.Size = new System.Drawing.Size(100, 28);
            this.LblFacturas.TabIndex = 12;
            this.LblFacturas.Text = "Facturas";
            // 
            // BtnListarServicios
            // 
            this.BtnListarServicios.FlatAppearance.BorderSize = 0;
            this.BtnListarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListarServicios.Image = ((System.Drawing.Image)(resources.GetObject("BtnListarServicios.Image")));
            this.BtnListarServicios.Location = new System.Drawing.Point(501, 270);
            this.BtnListarServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnListarServicios.Name = "BtnListarServicios";
            this.BtnListarServicios.Size = new System.Drawing.Size(120, 80);
            this.BtnListarServicios.TabIndex = 13;
            this.BtnListarServicios.UseVisualStyleBackColor = true;
            this.BtnListarServicios.Click += new System.EventHandler(this.BtnListarServicios_Click);
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListar.Location = new System.Drawing.Point(469, 352);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(170, 28);
            this.lblListar.TabIndex = 14;
            this.lblListar.Text = "Listar Servicios";
            // 
            // BtnPacientes
            // 
            this.BtnPacientes.FlatAppearance.BorderSize = 0;
            this.BtnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnPacientes.Image")));
            this.BtnPacientes.Location = new System.Drawing.Point(689, 139);
            this.BtnPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPacientes.Name = "BtnPacientes";
            this.BtnPacientes.Size = new System.Drawing.Size(91, 69);
            this.BtnPacientes.TabIndex = 15;
            this.BtnPacientes.UseVisualStyleBackColor = true;
            this.BtnPacientes.Click += new System.EventHandler(this.BtnPacientes_Click);
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPacientes.Location = new System.Drawing.Point(684, 219);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(108, 28);
            this.lblPacientes.TabIndex = 16;
            this.lblPacientes.Text = "Pacientes";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(934, 440);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.BtnPacientes);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.BtnListarServicios);
            this.Controls.Add(this.LblFacturas);
            this.Controls.Add(this.BtnFacturas);
            this.Controls.Add(this.LblInsumos);
            this.Controls.Add(this.BtnInsumos);
            this.Controls.Add(this.Salir2);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.btnConductor);
            this.Controls.Add(this.lblAmbulancia);
            this.Controls.Add(this.btnAmbulancia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.lblLABEL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLABEL;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnAmbulancia;
        private System.Windows.Forms.Label lblAmbulancia;
        private System.Windows.Forms.Button btnConductor;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.Button lblSalir;
        private System.Windows.Forms.Label Salir2;
        private System.Windows.Forms.Button BtnInsumos;
        private System.Windows.Forms.Label LblInsumos;
        private System.Windows.Forms.Button BtnFacturas;
        private System.Windows.Forms.Label LblFacturas;
        private System.Windows.Forms.Button BtnListarServicios;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.Button BtnPacientes;
        private System.Windows.Forms.Label lblPacientes;
    }
}

