namespace Insumos
{
    partial class FrmMenuInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuInsumos));
            this.BtnIngresarInsumos = new System.Windows.Forms.Button();
            this.LblIngresarInsumos = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.LblEditar = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblEliminar = new System.Windows.Forms.Label();
            this.LblListarInsumos = new System.Windows.Forms.Label();
            this.BtnListar = new System.Windows.Forms.Button();
            this.LblParaMenu = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnIngresarInsumos
            // 
            this.BtnIngresarInsumos.FlatAppearance.BorderSize = 0;
            this.BtnIngresarInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresarInsumos.Image = ((System.Drawing.Image)(resources.GetObject("BtnIngresarInsumos.Image")));
            this.BtnIngresarInsumos.Location = new System.Drawing.Point(94, 120);
            this.BtnIngresarInsumos.Name = "BtnIngresarInsumos";
            this.BtnIngresarInsumos.Size = new System.Drawing.Size(77, 75);
            this.BtnIngresarInsumos.TabIndex = 0;
            this.BtnIngresarInsumos.UseVisualStyleBackColor = true;
            this.BtnIngresarInsumos.Click += new System.EventHandler(this.BtnIngresarInsumos_Click);
            // 
            // LblIngresarInsumos
            // 
            this.LblIngresarInsumos.AutoSize = true;
            this.LblIngresarInsumos.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblIngresarInsumos.Location = new System.Drawing.Point(63, 201);
            this.LblIngresarInsumos.Name = "LblIngresarInsumos";
            this.LblIngresarInsumos.Size = new System.Drawing.Size(162, 23);
            this.LblIngresarInsumos.TabIndex = 1;
            this.LblIngresarInsumos.Text = "Ingresar Insumos";
            // 
            // BtnEditar
            // 
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(290, 120);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(97, 90);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // LblEditar
            // 
            this.LblEditar.AutoSize = true;
            this.LblEditar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblEditar.Location = new System.Drawing.Point(268, 201);
            this.LblEditar.Name = "LblEditar";
            this.LblEditar.Size = new System.Drawing.Size(143, 23);
            this.LblEditar.TabIndex = 3;
            this.LblEditar.Text = "Editar Insumos";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(94, 287);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 83);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblEliminar.Location = new System.Drawing.Point(59, 378);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(166, 23);
            this.LblEliminar.TabIndex = 5;
            this.LblEliminar.Text = "Eliminar Insumos";
            // 
            // LblListarInsumos
            // 
            this.LblListarInsumos.AutoSize = true;
            this.LblListarInsumos.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblListarInsumos.Location = new System.Drawing.Point(286, 378);
            this.LblListarInsumos.Name = "LblListarInsumos";
            this.LblListarInsumos.Size = new System.Drawing.Size(139, 23);
            this.LblListarInsumos.TabIndex = 6;
            this.LblListarInsumos.Text = "Listar Insumos";
            // 
            // BtnListar
            // 
            this.BtnListar.FlatAppearance.BorderSize = 0;
            this.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListar.Image = ((System.Drawing.Image)(resources.GetObject("BtnListar.Image")));
            this.BtnListar.Location = new System.Drawing.Point(290, 292);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(102, 73);
            this.BtnListar.TabIndex = 7;
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // LblParaMenu
            // 
            this.LblParaMenu.AutoSize = true;
            this.LblParaMenu.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblParaMenu.Location = new System.Drawing.Point(134, 59);
            this.LblParaMenu.Name = "LblParaMenu";
            this.LblParaMenu.Size = new System.Drawing.Size(207, 23);
            this.LblParaMenu.TabIndex = 8;
            this.LblParaMenu.Text = "MENU DE INSUMOS";
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(31, 36);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(50, 46);
            this.btnRegresar.TabIndex = 37;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmMenuInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(469, 460);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.LblParaMenu);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.LblListarInsumos);
            this.Controls.Add(this.LblEliminar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.LblEditar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.LblIngresarInsumos);
            this.Controls.Add(this.BtnIngresarInsumos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuInsumos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIngresarInsumos;
        private System.Windows.Forms.Label LblIngresarInsumos;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label LblEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblEliminar;
        private System.Windows.Forms.Label LblListarInsumos;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Label LblParaMenu;
        private System.Windows.Forms.Button btnRegresar;
    }
}