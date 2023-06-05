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
            this.SuspendLayout();
            // 
            // lblLABEL
            // 
            this.lblLABEL.AutoSize = true;
            this.lblLABEL.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLABEL.Location = new System.Drawing.Point(101, 37);
            this.lblLABEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLABEL.Name = "lblLABEL";
            this.lblLABEL.Size = new System.Drawing.Size(201, 32);
            this.lblLABEL.TabIndex = 0;
            this.lblLABEL.Text = "Menu Principal";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(64, 171);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(78, 23);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblAmbulancia
            // 
            this.lblAmbulancia.AutoSize = true;
            this.lblAmbulancia.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmbulancia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAmbulancia.Location = new System.Drawing.Point(222, 171);
            this.lblAmbulancia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmbulancia.Name = "lblAmbulancia";
            this.lblAmbulancia.Size = new System.Drawing.Size(123, 23);
            this.lblAmbulancia.TabIndex = 4;
            this.lblAmbulancia.Text = "Ambulancias";
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblConductor.Location = new System.Drawing.Point(62, 284);
            this.lblConductor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(99, 23);
            this.lblConductor.TabIndex = 6;
            this.lblConductor.Text = "Conductor";
            // 
            // Salir2
            // 
            this.Salir2.AutoSize = true;
            this.Salir2.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Salir2.Location = new System.Drawing.Point(245, 284);
            this.Salir2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Salir2.Name = "Salir2";
            this.Salir2.Size = new System.Drawing.Size(50, 23);
            this.Salir2.TabIndex = 8;
            this.Salir2.Text = "Salir";
            // 
            // lblSalir
            // 
            this.lblSalir.FlatAppearance.BorderSize = 0;
            this.lblSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalir.Image = ((System.Drawing.Image)(resources.GetObject("lblSalir.Image")));
            this.lblSalir.Location = new System.Drawing.Point(228, 217);
            this.lblSalir.Margin = new System.Windows.Forms.Padding(2);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(90, 65);
            this.lblSalir.TabIndex = 7;
            this.lblSalir.UseVisualStyleBackColor = true;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // btnConductor
            // 
            this.btnConductor.FlatAppearance.BorderSize = 0;
            this.btnConductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductor.Image = ((System.Drawing.Image)(resources.GetObject("btnConductor.Image")));
            this.btnConductor.Location = new System.Drawing.Point(67, 216);
            this.btnConductor.Margin = new System.Windows.Forms.Padding(2);
            this.btnConductor.Name = "btnConductor";
            this.btnConductor.Size = new System.Drawing.Size(68, 65);
            this.btnConductor.TabIndex = 5;
            this.btnConductor.UseVisualStyleBackColor = true;
            this.btnConductor.Click += new System.EventHandler(this.btnConductor_Click);
            // 
            // btnAmbulancia
            // 
            this.btnAmbulancia.FlatAppearance.BorderSize = 0;
            this.btnAmbulancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmbulancia.Image = ((System.Drawing.Image)(resources.GetObject("btnAmbulancia.Image")));
            this.btnAmbulancia.Location = new System.Drawing.Point(241, 110);
            this.btnAmbulancia.Margin = new System.Windows.Forms.Padding(2);
            this.btnAmbulancia.Name = "btnAmbulancia";
            this.btnAmbulancia.Size = new System.Drawing.Size(56, 58);
            this.btnAmbulancia.TabIndex = 3;
            this.btnAmbulancia.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(66, 103);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(70, 72);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(391, 358);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

