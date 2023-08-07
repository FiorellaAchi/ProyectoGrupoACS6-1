namespace Insumos
{
    partial class EditarInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarInsumos));
            this.label1 = new System.Windows.Forms.Label();
            this.LblCodigoInsumoNew = new System.Windows.Forms.Label();
            this.txtCodigoNew = new System.Windows.Forms.TextBox();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInsumo = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.DgvListadoEditar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(123, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Insumos";
            // 
            // LblCodigoInsumoNew
            // 
            this.LblCodigoInsumoNew.AutoSize = true;
            this.LblCodigoInsumoNew.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.LblCodigoInsumoNew.Location = new System.Drawing.Point(65, 103);
            this.LblCodigoInsumoNew.Name = "LblCodigoInsumoNew";
            this.LblCodigoInsumoNew.Size = new System.Drawing.Size(80, 23);
            this.LblCodigoInsumoNew.TabIndex = 2;
            this.LblCodigoInsumoNew.Text = "Código:";
            // 
            // txtCodigoNew
            // 
            this.txtCodigoNew.Location = new System.Drawing.Point(177, 105);
            this.txtCodigoNew.Name = "txtCodigoNew";
            this.txtCodigoNew.Size = new System.Drawing.Size(154, 22);
            this.txtCodigoNew.TabIndex = 3;
            // 
            // lblInsumo
            // 
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblInsumo.Location = new System.Drawing.Point(65, 161);
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(82, 23);
            this.lblInsumo.TabIndex = 4;
            this.lblInsumo.Text = "Insumo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(65, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha:";
            // 
            // txtInsumo
            // 
            this.txtInsumo.Location = new System.Drawing.Point(177, 161);
            this.txtInsumo.Name = "txtInsumo";
            this.txtInsumo.Size = new System.Drawing.Size(154, 22);
            this.txtInsumo.TabIndex = 6;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(177, 282);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(154, 22);
            this.txtProveedor.TabIndex = 7;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblProveedor.Location = new System.Drawing.Point(65, 282);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(106, 23);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(177, 220);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(154, 22);
            this.DTPFecha.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(65, 339);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(74, 23);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "PENDIENTE",
            "PROCESADO",
            "COMPLETADO"});
            this.cmbEstado.Location = new System.Drawing.Point(177, 338);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(154, 24);
            this.cmbEstado.TabIndex = 11;
            // 
            // BtnEditar
            // 
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(177, 408);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(69, 78);
            this.BtnEditar.TabIndex = 12;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.Location = new System.Drawing.Point(32, 24);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(35, 33);
            this.BtnRegresar.TabIndex = 41;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // DgvListadoEditar
            // 
            this.DgvListadoEditar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvListadoEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoEditar.Location = new System.Drawing.Point(402, 103);
            this.DgvListadoEditar.Name = "DgvListadoEditar";
            this.DgvListadoEditar.RowHeadersWidth = 51;
            this.DgvListadoEditar.RowTemplate.Height = 24;
            this.DgvListadoEditar.Size = new System.Drawing.Size(509, 259);
            this.DgvListadoEditar.TabIndex = 42;
            this.DgvListadoEditar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoEditar_CellClick);
            // 
            // EditarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1023, 512);
            this.Controls.Add(this.DgvListadoEditar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtInsumo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInsumo);
            this.Controls.Add(this.txtCodigoNew);
            this.Controls.Add(this.LblCodigoInsumoNew);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarInsumos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCodigoInsumoNew;
        private System.Windows.Forms.TextBox txtCodigoNew;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInsumo;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView DgvListadoEditar;
    }
}