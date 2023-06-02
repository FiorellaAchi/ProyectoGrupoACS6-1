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
            this.btnCliente = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnAmbulancia = new System.Windows.Forms.Button();
            this.lblAmbulancia = new System.Windows.Forms.Label();
            this.btnConductor = new System.Windows.Forms.Button();
            this.lblConductor = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Button();
            this.Salir2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLABEL
            // 
            this.lblLABEL.AutoSize = true;
            this.lblLABEL.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLABEL.Location = new System.Drawing.Point(135, 45);
            this.lblLABEL.Name = "lblLABEL";
            this.lblLABEL.Size = new System.Drawing.Size(246, 41);
            this.lblLABEL.TabIndex = 0;
            this.lblLABEL.Text = "Menu Principal";
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(88, 127);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(93, 89);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(86, 210);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(95, 28);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnAmbulancia
            // 
            this.btnAmbulancia.FlatAppearance.BorderSize = 0;
            this.btnAmbulancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmbulancia.Image = ((System.Drawing.Image)(resources.GetObject("btnAmbulancia.Image")));
            this.btnAmbulancia.Location = new System.Drawing.Point(321, 136);
            this.btnAmbulancia.Name = "btnAmbulancia";
            this.btnAmbulancia.Size = new System.Drawing.Size(75, 71);
            this.btnAmbulancia.TabIndex = 3;
            this.btnAmbulancia.UseVisualStyleBackColor = true;
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
            // btnConductor
            // 
            this.btnConductor.FlatAppearance.BorderSize = 0;
            this.btnConductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductor.Image = ((System.Drawing.Image)(resources.GetObject("btnConductor.Image")));
            this.btnConductor.Location = new System.Drawing.Point(89, 266);
            this.btnConductor.Name = "btnConductor";
            this.btnConductor.Size = new System.Drawing.Size(90, 80);
            this.btnConductor.TabIndex = 5;
            this.btnConductor.UseVisualStyleBackColor = true;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblConductor.Location = new System.Drawing.Point(83, 349);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(122, 28);
            this.lblConductor.TabIndex = 6;
            this.lblConductor.Text = "Conductor";
            // 
            // lblSalir
            // 
            this.lblSalir.FlatAppearance.BorderSize = 0;
            this.lblSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalir.Image = ((System.Drawing.Image)(resources.GetObject("lblSalir.Image")));
            this.lblSalir.Location = new System.Drawing.Point(321, 266);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(75, 80);
            this.lblSalir.TabIndex = 7;
            this.lblSalir.UseVisualStyleBackColor = true;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // Salir2
            // 
            this.Salir2.AutoSize = true;
            this.Salir2.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Salir2.Location = new System.Drawing.Point(327, 349);
            this.Salir2.Name = "Salir2";
            this.Salir2.Size = new System.Drawing.Size(59, 28);
            this.Salir2.TabIndex = 8;
            this.Salir2.Text = "Salir";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(521, 441);
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
            this.Name = "FormAdmin";
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
    }
}

