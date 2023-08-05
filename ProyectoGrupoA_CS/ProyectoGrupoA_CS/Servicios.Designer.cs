namespace ProyectoGrupoA_CS
{
    partial class Servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios));
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEliminarCancelarServicio = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnEmergencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(249, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Volver";
            // 
            // BtnEliminarCancelarServicio
            // 
            this.BtnEliminarCancelarServicio.FlatAppearance.BorderSize = 0;
            this.BtnEliminarCancelarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarCancelarServicio.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarCancelarServicio.Image")));
            this.BtnEliminarCancelarServicio.Location = new System.Drawing.Point(240, 185);
            this.BtnEliminarCancelarServicio.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminarCancelarServicio.Name = "BtnEliminarCancelarServicio";
            this.BtnEliminarCancelarServicio.Size = new System.Drawing.Size(111, 85);
            this.BtnEliminarCancelarServicio.TabIndex = 14;
            this.BtnEliminarCancelarServicio.UseVisualStyleBackColor = true;
            this.BtnEliminarCancelarServicio.Click += new System.EventHandler(this.BtnEliminarCancelarServicio_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.Location = new System.Drawing.Point(242, 49);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(101, 89);
            this.BtnRegresar.TabIndex = 13;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnEmergencia
            // 
            this.BtnEmergencia.FlatAppearance.BorderSize = 0;
            this.BtnEmergencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmergencia.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmergencia.Image")));
            this.BtnEmergencia.Location = new System.Drawing.Point(13, 99);
            this.BtnEmergencia.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEmergencia.Name = "BtnEmergencia";
            this.BtnEmergencia.Size = new System.Drawing.Size(188, 166);
            this.BtnEmergencia.TabIndex = 12;
            this.BtnEmergencia.UseVisualStyleBackColor = true;
            this.BtnEmergencia.Click += new System.EventHandler(this.BtnEmergencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Servicios";
            // 
            // Cancelar
            // 
            this.Cancelar.AutoSize = true;
            this.Cancelar.Font = new System.Drawing.Font("Book Antiqua", 13.8F);
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(249, 274);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(102, 28);
            this.Cancelar.TabIndex = 16;
            this.Cancelar.Text = "Cancelar";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(398, 321);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEliminarCancelarServicio);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnEmergencia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEliminarCancelarServicio;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnEmergencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cancelar;
    }
}