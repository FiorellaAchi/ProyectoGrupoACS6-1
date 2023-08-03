namespace Facturas
{
    partial class ListarFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarFacturas));
            this.DGVListarFacturas = new System.Windows.Forms.DataGridView();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListarFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVListarFacturas
            // 
            this.DGVListarFacturas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVListarFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListarFacturas.Location = new System.Drawing.Point(64, 68);
            this.DGVListarFacturas.Name = "DGVListarFacturas";
            this.DGVListarFacturas.RowHeadersWidth = 51;
            this.DGVListarFacturas.RowTemplate.Height = 24;
            this.DGVListarFacturas.Size = new System.Drawing.Size(661, 336);
            this.DGVListarFacturas.TabIndex = 0;
            // 
            // BtnReturn
            // 
            this.BtnReturn.FlatAppearance.BorderSize = 0;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Image = ((System.Drawing.Image)(resources.GetObject("BtnReturn.Image")));
            this.BtnReturn.Location = new System.Drawing.Point(12, 12);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(40, 49);
            this.BtnReturn.TabIndex = 13;
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(268, 14);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(214, 35);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Listar Facturas";
            // 
            // ListarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.DGVListarFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVListarFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListarFacturas;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label lblTelefono;
    }
}