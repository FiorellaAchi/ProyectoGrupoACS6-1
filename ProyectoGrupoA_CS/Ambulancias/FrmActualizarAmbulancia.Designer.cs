namespace Ambulancias
{
    partial class FrmActualizarAmbulancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarAmbulancia));
            this.txtAnioAmbulancia = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtMarcaAmbulancias = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvAmbulancia = new System.Windows.Forms.DataGridView();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.LblMenu = new System.Windows.Forms.Label();
            this.lblConductor = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblIdConductor = new System.Windows.Forms.Label();
            this.txtConductorID = new System.Windows.Forms.TextBox();
            this.lblModificar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmbulancia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnioAmbulancia
            // 
            this.txtAnioAmbulancia.Location = new System.Drawing.Point(146, 371);
            this.txtAnioAmbulancia.Name = "txtAnioAmbulancia";
            this.txtAnioAmbulancia.Size = new System.Drawing.Size(298, 22);
            this.txtAnioAmbulancia.TabIndex = 47;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(189, 305);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(255, 22);
            this.txtPlaca.TabIndex = 46;
            // 
            // txtMarcaAmbulancias
            // 
            this.txtMarcaAmbulancias.Location = new System.Drawing.Point(146, 246);
            this.txtMarcaAmbulancias.Name = "txtMarcaAmbulancias";
            this.txtMarcaAmbulancias.Size = new System.Drawing.Size(298, 22);
            this.txtMarcaAmbulancias.TabIndex = 45;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(146, 179);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(298, 22);
            this.txtCodigo.TabIndex = 44;
            // 
            // dgvAmbulancia
            // 
            this.dgvAmbulancia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAmbulancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmbulancia.Location = new System.Drawing.Point(480, 122);
            this.dgvAmbulancia.Name = "dgvAmbulancia";
            this.dgvAmbulancia.RowHeadersWidth = 51;
            this.dgvAmbulancia.RowTemplate.Height = 24;
            this.dgvAmbulancia.Size = new System.Drawing.Size(557, 272);
            this.dgvAmbulancia.TabIndex = 43;
            this.dgvAmbulancia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAmbulancia_CellClick);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.Location = new System.Drawing.Point(46, 18);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(41, 38);
            this.BtnRegresar.TabIndex = 42;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.Location = new System.Drawing.Point(189, 438);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(97, 72);
            this.BtnModificar.TabIndex = 41;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.LblMenu.Location = new System.Drawing.Point(391, 15);
            this.LblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(275, 35);
            this.LblMenu.TabIndex = 40;
            this.LblMenu.Text = "Menu Editar Datos";
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.Location = new System.Drawing.Point(7, 181);
            this.lblConductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(80, 23);
            this.lblConductor.TabIndex = 39;
            this.lblConductor.Text = "Codigo:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(7, 371);
            this.lblAnio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(53, 23);
            this.lblAnio.TabIndex = 38;
            this.lblAnio.Text = "Año:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(7, 305);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(166, 23);
            this.lblPlaca.TabIndex = 37;
            this.lblPlaca.Text = "Numero de placa:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(7, 245);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(69, 23);
            this.lblMarca.TabIndex = 36;
            this.lblMarca.Text = "Marca:";
            // 
            // lblIdConductor
            // 
            this.lblIdConductor.AutoSize = true;
            this.lblIdConductor.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdConductor.Location = new System.Drawing.Point(6, 125);
            this.lblIdConductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdConductor.Name = "lblIdConductor";
            this.lblIdConductor.Size = new System.Drawing.Size(137, 23);
            this.lblIdConductor.TabIndex = 35;
            this.lblIdConductor.Text = "Id Conductor: ";
            // 
            // txtConductorID
            // 
            this.txtConductorID.Location = new System.Drawing.Point(146, 123);
            this.txtConductorID.Margin = new System.Windows.Forms.Padding(4);
            this.txtConductorID.Name = "txtConductorID";
            this.txtConductorID.Size = new System.Drawing.Size(298, 22);
            this.txtConductorID.TabIndex = 34;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.lblModificar.Location = new System.Drawing.Point(185, 513);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(102, 24);
            this.lblModificar.TabIndex = 48;
            this.lblModificar.Text = "Modificar";
            // 
            // FrmActualizarAmbulancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1117, 587);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.txtAnioAmbulancia);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtMarcaAmbulancias);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dgvAmbulancia);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.LblMenu);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblIdConductor);
            this.Controls.Add(this.txtConductorID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmActualizarAmbulancia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmActualizarAmbulancia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmbulancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnioAmbulancia;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMarcaAmbulancias;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvAmbulancia;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblIdConductor;
        private System.Windows.Forms.TextBox txtConductorID;
        private System.Windows.Forms.Label lblModificar;
    }
}