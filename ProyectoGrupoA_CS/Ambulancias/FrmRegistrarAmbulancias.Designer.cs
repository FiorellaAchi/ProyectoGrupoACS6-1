namespace Ambulancias
{
    partial class FrmRegistrarAmbulancias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarAmbulancias));
            this.txtIdConductor = new System.Windows.Forms.TextBox();
            this.lblConductor = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblIdConductor = new System.Windows.Forms.Label();
            this.LblMenu = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.DGVAmbulancias = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNumeroPlaca = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAmbulancias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdConductor
            // 
            this.txtIdConductor.Location = new System.Drawing.Point(164, 155);
            this.txtIdConductor.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdConductor.Name = "txtIdConductor";
            this.txtIdConductor.Size = new System.Drawing.Size(298, 29);
            this.txtIdConductor.TabIndex = 15;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.Location = new System.Drawing.Point(25, 213);
            this.lblConductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(80, 23);
            this.lblConductor.TabIndex = 25;
            this.lblConductor.Text = "Codigo:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(25, 403);
            this.lblAnio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(53, 23);
            this.lblAnio.TabIndex = 24;
            this.lblAnio.Text = "Año:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(25, 337);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(166, 23);
            this.lblPlaca.TabIndex = 23;
            this.lblPlaca.Text = "Numero de placa:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(25, 284);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(69, 23);
            this.lblMarca.TabIndex = 22;
            this.lblMarca.Text = "Marca:";
            // 
            // lblIdConductor
            // 
            this.lblIdConductor.AutoSize = true;
            this.lblIdConductor.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdConductor.Location = new System.Drawing.Point(24, 157);
            this.lblIdConductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdConductor.Name = "lblIdConductor";
            this.lblIdConductor.Size = new System.Drawing.Size(137, 23);
            this.lblIdConductor.TabIndex = 21;
            this.lblIdConductor.Text = "Id Conductor: ";
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.LblMenu.Location = new System.Drawing.Point(409, 47);
            this.LblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(306, 35);
            this.LblMenu.TabIndex = 26;
            this.LblMenu.Text = "Menu Ingresar Datos";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(165, 490);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(97, 72);
            this.BtnAgregar.TabIndex = 27;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.Location = new System.Drawing.Point(53, 44);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(41, 38);
            this.BtnRegresar.TabIndex = 28;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // DGVAmbulancias
            // 
            this.DGVAmbulancias.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVAmbulancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAmbulancias.Location = new System.Drawing.Point(498, 154);
            this.DGVAmbulancias.Name = "DGVAmbulancias";
            this.DGVAmbulancias.RowHeadersWidth = 51;
            this.DGVAmbulancias.RowTemplate.Height = 24;
            this.DGVAmbulancias.Size = new System.Drawing.Size(557, 272);
            this.DGVAmbulancias.TabIndex = 29;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(164, 211);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(298, 29);
            this.txtCodigo.TabIndex = 30;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(164, 278);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(298, 29);
            this.txtMarca.TabIndex = 31;
            // 
            // txtNumeroPlaca
            // 
            this.txtNumeroPlaca.Location = new System.Drawing.Point(207, 337);
            this.txtNumeroPlaca.Name = "txtNumeroPlaca";
            this.txtNumeroPlaca.Size = new System.Drawing.Size(255, 29);
            this.txtNumeroPlaca.TabIndex = 32;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(164, 403);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(298, 29);
            this.txtAnio.TabIndex = 33;
            // 
            // FrmRegistrarAmbulancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 612);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtNumeroPlaca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.DGVAmbulancias);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LblMenu);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblIdConductor);
            this.Controls.Add(this.txtIdConductor);
            this.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistrarAmbulancias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrarAmbulancias";
            ((System.ComponentModel.ISupportInitialize)(this.DGVAmbulancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdConductor;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblIdConductor;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView DGVAmbulancias;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNumeroPlaca;
        private System.Windows.Forms.TextBox txtAnio;
    }
}