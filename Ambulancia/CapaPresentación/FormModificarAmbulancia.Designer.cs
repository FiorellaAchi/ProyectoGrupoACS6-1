namespace CapaPresentación
{
    partial class FormModificarAmbulancia
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
            dgvAmbulancia = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtCod = new TextBox();
            txtMarca = new TextBox();
            txtNumPlaca = new TextBox();
            txtAnio = new TextBox();
            txtConductor = new TextBox();
            btnCargar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAmbulancia).BeginInit();
            SuspendLayout();
            // 
            // dgvAmbulancia
            // 
            dgvAmbulancia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAmbulancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmbulancia.Location = new Point(27, 28);
            dgvAmbulancia.Name = "dgvAmbulancia";
            dgvAmbulancia.RowTemplate.Height = 25;
            dgvAmbulancia.Size = new Size(668, 161);
            dgvAmbulancia.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 252);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 282);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 3;
            label3.Text = "Número de placa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 308);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 4;
            label4.Text = "Año:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 335);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 5;
            label5.Text = "Conductor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 223);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 6;
            label1.Text = "Código:";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(127, 220);
            txtCod.Name = "txtCod";
            txtCod.ReadOnly = true;
            txtCod.Size = new Size(219, 23);
            txtCod.TabIndex = 7;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(127, 249);
            txtMarca.Name = "txtMarca";
            txtMarca.ReadOnly = true;
            txtMarca.Size = new Size(219, 23);
            txtMarca.TabIndex = 8;
            // 
            // txtNumPlaca
            // 
            txtNumPlaca.Location = new Point(127, 279);
            txtNumPlaca.Name = "txtNumPlaca";
            txtNumPlaca.ReadOnly = true;
            txtNumPlaca.Size = new Size(219, 23);
            txtNumPlaca.TabIndex = 9;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(127, 308);
            txtAnio.Name = "txtAnio";
            txtAnio.ReadOnly = true;
            txtAnio.Size = new Size(219, 23);
            txtAnio.TabIndex = 10;
            // 
            // txtConductor
            // 
            txtConductor.Location = new Point(127, 337);
            txtConductor.Name = "txtConductor";
            txtConductor.Size = new Size(219, 23);
            txtConductor.TabIndex = 11;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(701, 64);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 12;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(179, 376);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(271, 376);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(363, 376);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormModificarAmbulancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 431);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnCargar);
            Controls.Add(txtConductor);
            Controls.Add(txtAnio);
            Controls.Add(txtNumPlaca);
            Controls.Add(txtMarca);
            Controls.Add(txtCod);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvAmbulancia);
            Name = "FormModificarAmbulancia";
            Text = "Modificar Ambulancia";
            ((System.ComponentModel.ISupportInitialize)dgvAmbulancia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAmbulancia;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private TextBox txtCod;
        private TextBox txtMarca;
        private TextBox txtNumPlaca;
        private TextBox txtAnio;
        private TextBox txtConductor;
        private Button btnCargar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}