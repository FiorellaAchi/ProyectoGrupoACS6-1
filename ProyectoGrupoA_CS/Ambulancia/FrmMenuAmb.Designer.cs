namespace Ambulancia
{
    partial class FrmMenuAmb
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.ModificarAmbulancia = new System.Windows.Forms.Button();
            this.ListarAmbulancias = new System.Windows.Forms.Button();
            this.EliminarDatosAmbulancia = new System.Windows.Forms.Button();
            this.IngresoDatosAmbulancia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(317, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Modificar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(77, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Listar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(316, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Eliminar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(63, 171);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "Registrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(99, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "Menu Ambulancia";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Ambulancia.Properties.Resources.atras__1_;
            this.button5.Location = new System.Drawing.Point(28, 12);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 41);
            this.button5.TabIndex = 36;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ModificarAmbulancia
            // 
            this.ModificarAmbulancia.FlatAppearance.BorderSize = 0;
            this.ModificarAmbulancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarAmbulancia.Image = global::Ambulancia.Properties.Resources.Modificar;
            this.ModificarAmbulancia.Location = new System.Drawing.Point(320, 245);
            this.ModificarAmbulancia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModificarAmbulancia.Name = "ModificarAmbulancia";
            this.ModificarAmbulancia.Size = new System.Drawing.Size(95, 91);
            this.ModificarAmbulancia.TabIndex = 32;
            this.ModificarAmbulancia.UseVisualStyleBackColor = true;
            this.ModificarAmbulancia.Click += new System.EventHandler(this.ModificarAmbulancia_Click);
            // 
            // ListarAmbulancias
            // 
            this.ListarAmbulancias.FlatAppearance.BorderSize = 0;
            this.ListarAmbulancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListarAmbulancias.Image = global::Ambulancia.Properties.Resources.Listar;
            this.ListarAmbulancias.Location = new System.Drawing.Point(68, 245);
            this.ListarAmbulancias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListarAmbulancias.Name = "ListarAmbulancias";
            this.ListarAmbulancias.Size = new System.Drawing.Size(93, 91);
            this.ListarAmbulancias.TabIndex = 31;
            this.ListarAmbulancias.UseVisualStyleBackColor = true;
            this.ListarAmbulancias.Click += new System.EventHandler(this.ListarAmbulancias_Click);
            // 
            // EliminarDatosAmbulancia
            // 
            this.EliminarDatosAmbulancia.FlatAppearance.BorderSize = 0;
            this.EliminarDatosAmbulancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarDatosAmbulancia.Image = global::Ambulancia.Properties.Resources.cerrar;
            this.EliminarDatosAmbulancia.Location = new System.Drawing.Point(311, 75);
            this.EliminarDatosAmbulancia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EliminarDatosAmbulancia.Name = "EliminarDatosAmbulancia";
            this.EliminarDatosAmbulancia.Size = new System.Drawing.Size(104, 87);
            this.EliminarDatosAmbulancia.TabIndex = 30;
            this.EliminarDatosAmbulancia.UseVisualStyleBackColor = true;
            this.EliminarDatosAmbulancia.Click += new System.EventHandler(this.EliminarDatosAmbulancia_Click);
            // 
            // IngresoDatosAmbulancia
            // 
            this.IngresoDatosAmbulancia.FlatAppearance.BorderSize = 0;
            this.IngresoDatosAmbulancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngresoDatosAmbulancia.Image = global::Ambulancia.Properties.Resources.agregar;
            this.IngresoDatosAmbulancia.Location = new System.Drawing.Point(60, 69);
            this.IngresoDatosAmbulancia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IngresoDatosAmbulancia.Name = "IngresoDatosAmbulancia";
            this.IngresoDatosAmbulancia.Size = new System.Drawing.Size(99, 98);
            this.IngresoDatosAmbulancia.TabIndex = 27;
            this.IngresoDatosAmbulancia.UseVisualStyleBackColor = true;
            this.IngresoDatosAmbulancia.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMenuAmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(483, 399);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModificarAmbulancia);
            this.Controls.Add(this.ListarAmbulancias);
            this.Controls.Add(this.EliminarDatosAmbulancia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngresoDatosAmbulancia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenuAmb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ModificarAmbulancia;
        private System.Windows.Forms.Button ListarAmbulancias;
        private System.Windows.Forms.Button EliminarDatosAmbulancia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IngresoDatosAmbulancia;
    }
}

