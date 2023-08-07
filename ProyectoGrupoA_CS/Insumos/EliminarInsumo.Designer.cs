namespace Insumos
{
    partial class EliminarInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarInsumo));
            this.DgvListadoEliminar = new System.Windows.Forms.DataGridView();
            this.LblEliminar = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.txtInsumo = new System.Windows.Forms.TextBox();
            this.LblInsumo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListadoEliminar
            // 
            this.DgvListadoEliminar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvListadoEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoEliminar.Location = new System.Drawing.Point(109, 134);
            this.DgvListadoEliminar.Name = "DgvListadoEliminar";
            this.DgvListadoEliminar.RowHeadersWidth = 51;
            this.DgvListadoEliminar.RowTemplate.Height = 24;
            this.DgvListadoEliminar.Size = new System.Drawing.Size(637, 291);
            this.DgvListadoEliminar.TabIndex = 0;
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblEliminar.Location = new System.Drawing.Point(319, 23);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(166, 23);
            this.LblEliminar.TabIndex = 1;
            this.LblEliminar.Text = "Eliminar Insumos";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.Location = new System.Drawing.Point(38, 23);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(33, 33);
            this.BtnRegresar.TabIndex = 41;
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.FlatAppearance.BorderSize = 3;
            this.BtnEliminar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Location = new System.Drawing.Point(553, 66);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(225, 50);
            this.BtnEliminar.TabIndex = 42;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txtInsumo
            // 
            this.txtInsumo.Location = new System.Drawing.Point(264, 93);
            this.txtInsumo.Name = "txtInsumo";
            this.txtInsumo.Size = new System.Drawing.Size(148, 22);
            this.txtInsumo.TabIndex = 43;
            // 
            // LblInsumo
            // 
            this.LblInsumo.AutoSize = true;
            this.LblInsumo.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblInsumo.Location = new System.Drawing.Point(71, 93);
            this.LblInsumo.Name = "LblInsumo";
            this.LblInsumo.Size = new System.Drawing.Size(178, 23);
            this.LblInsumo.TabIndex = 44;
            this.LblInsumo.Text = "Insumo a Eliminar:";
            // 
            // EliminarInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(838, 470);
            this.Controls.Add(this.LblInsumo);
            this.Controls.Add(this.txtInsumo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.LblEliminar);
            this.Controls.Add(this.DgvListadoEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarInsumo";
            this.Load += new System.EventHandler(this.EliminarInsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListadoEliminar;
        private System.Windows.Forms.Label LblEliminar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox txtInsumo;
        private System.Windows.Forms.Label LblInsumo;
    }
}