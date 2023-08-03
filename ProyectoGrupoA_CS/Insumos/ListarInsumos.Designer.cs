namespace Insumos
{
    partial class ListarInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarInsumos));
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.lblListar = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListado
            // 
            this.DgvListado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Location = new System.Drawing.Point(65, 97);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.Size = new System.Drawing.Size(679, 346);
            this.DgvListado.TabIndex = 0;
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.lblListar.Location = new System.Drawing.Point(249, 19);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(283, 35);
            this.lblListar.TabIndex = 1;
            this.lblListar.Text = "Listado de Insumos";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.Location = new System.Drawing.Point(39, 19);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(60, 52);
            this.BtnRegresar.TabIndex = 7;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // ListarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.DgvListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarInsumos";
            this.Load += new System.EventHandler(this.ListarInsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.Button BtnRegresar;
    }
}