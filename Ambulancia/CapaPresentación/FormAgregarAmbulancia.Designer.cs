namespace CapaPresentación
{
    partial class FormAgregarAmbulancia
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCod = new TextBox();
            txtAnio = new TextBox();
            txtNumPlaca = new TextBox();
            txtMarca = new TextBox();
            txtConductor = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 75);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 114);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Número de placa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 153);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Año:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 189);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Conductor:";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(144, 28);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(270, 23);
            txtCod.TabIndex = 5;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(144, 150);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(270, 23);
            txtAnio.TabIndex = 6;
            // 
            // txtNumPlaca
            // 
            txtNumPlaca.Location = new Point(144, 111);
            txtNumPlaca.Name = "txtNumPlaca";
            txtNumPlaca.Size = new Size(270, 23);
            txtNumPlaca.TabIndex = 7;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(144, 72);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(270, 23);
            txtMarca.TabIndex = 8;
            // 
            // txtConductor
            // 
            txtConductor.Location = new Point(144, 189);
            txtConductor.Name = "txtConductor";
            txtConductor.Size = new Size(270, 23);
            txtConductor.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(182, 255);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(295, 255);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAgregarAmbulancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtConductor);
            Controls.Add(txtMarca);
            Controls.Add(txtNumPlaca);
            Controls.Add(txtAnio);
            Controls.Add(txtCod);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAgregarAmbulancia";
            Text = "Agregar Ambulancia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCod;
        private TextBox txtAnio;
        private TextBox txtNumPlaca;
        private TextBox txtMarca;
        private TextBox txtConductor;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}