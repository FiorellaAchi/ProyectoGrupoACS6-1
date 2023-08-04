namespace Ambulancias
{
    partial class FrmEliminarAmbulancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarAmbulancia));
            this.dgvAmbulancia = new System.Windows.Forms.DataGridView();
            this.LblMenu = new System.Windows.Forms.Label();
            this.lblIngresarCodigo = new System.Windows.Forms.Label();
            this.txtCodigoAEliminar = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmbulancia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAmbulancia
            // 
            this.dgvAmbulancia.BackgroundColor = System.Drawing.Color.White;
            this.dgvAmbulancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmbulancia.Location = new System.Drawing.Point(48, 218);
            this.dgvAmbulancia.Name = "dgvAmbulancia";
            this.dgvAmbulancia.RowHeadersWidth = 51;
            this.dgvAmbulancia.RowTemplate.Height = 24;
            this.dgvAmbulancia.Size = new System.Drawing.Size(693, 351);
            this.dgvAmbulancia.TabIndex = 0;
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(370, 28);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(186, 29);
            this.LblMenu.TabIndex = 1;
            this.LblMenu.Text = "Menu Eliminar";
            // 
            // lblIngresarCodigo
            // 
            this.lblIngresarCodigo.AutoSize = true;
            this.lblIngresarCodigo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarCodigo.Location = new System.Drawing.Point(86, 126);
            this.lblIngresarCodigo.Name = "lblIngresarCodigo";
            this.lblIngresarCodigo.Size = new System.Drawing.Size(81, 24);
            this.lblIngresarCodigo.TabIndex = 2;
            this.lblIngresarCodigo.Text = "Codigo:";
            // 
            // txtCodigoAEliminar
            // 
            this.txtCodigoAEliminar.Location = new System.Drawing.Point(196, 121);
            this.txtCodigoAEliminar.Name = "txtCodigoAEliminar";
            this.txtCodigoAEliminar.Size = new System.Drawing.Size(233, 29);
            this.txtCodigoAEliminar.TabIndex = 3;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(525, 99);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(76, 72);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.Location = new System.Drawing.Point(48, 20);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(43, 37);
            this.BtnRegresar.TabIndex = 5;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // FrmEliminarAmbulancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(775, 591);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.txtCodigoAEliminar);
            this.Controls.Add(this.lblIngresarCodigo);
            this.Controls.Add(this.LblMenu);
            this.Controls.Add(this.dgvAmbulancia);
            this.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEliminarAmbulancia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEliminarAmbulancia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmbulancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAmbulancia;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Label lblIngresarCodigo;
        private System.Windows.Forms.TextBox txtCodigoAEliminar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnRegresar;
    }
}