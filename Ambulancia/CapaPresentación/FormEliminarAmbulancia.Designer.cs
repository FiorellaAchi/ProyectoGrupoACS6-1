namespace CapaPresentación
{
    partial class FormEliminarAmbulancia
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
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAmbulancia).BeginInit();
            SuspendLayout();
            // 
            // dgvAmbulancia
            // 
            dgvAmbulancia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAmbulancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmbulancia.Location = new Point(18, 40);
            dgvAmbulancia.Name = "dgvAmbulancia";
            dgvAmbulancia.RowTemplate.Height = 25;
            dgvAmbulancia.Size = new Size(753, 212);
            dgvAmbulancia.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(270, 294);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(351, 294);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(189, 294);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 3;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // FormEliminarAmbulancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvAmbulancia);
            Name = "FormEliminarAmbulancia";
            Text = "Eliminar Ambulancia";
            ((System.ComponentModel.ISupportInitialize)dgvAmbulancia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAmbulancia;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnCargar;
    }
}