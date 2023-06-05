namespace CapaPresentación
{
    partial class FormListarAmbulancias
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
            btnListar = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAmbulancia).BeginInit();
            SuspendLayout();
            // 
            // dgvAmbulancia
            // 
            dgvAmbulancia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAmbulancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmbulancia.Location = new Point(12, 12);
            dgvAmbulancia.Name = "dgvAmbulancia";
            dgvAmbulancia.RowTemplate.Height = 25;
            dgvAmbulancia.Size = new Size(764, 174);
            dgvAmbulancia.TabIndex = 0;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(254, 228);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(365, 228);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FormListarAmbulancias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(btnListar);
            Controls.Add(dgvAmbulancia);
            Name = "FormListarAmbulancias";
            Text = "Listar Ambulancias";
            ((System.ComponentModel.ISupportInitialize)dgvAmbulancia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAmbulancia;
        private Button btnListar;
        private Button btnRegresar;
    }
}