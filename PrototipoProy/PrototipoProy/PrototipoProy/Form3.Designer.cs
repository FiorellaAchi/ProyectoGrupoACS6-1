namespace PrototipoProy
{
    partial class formInsertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInsertar));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DGVUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(264, 412);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(7);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 36);
            this.txtEmail.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 420);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(264, 333);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(7);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(228, 36);
            this.txtTelefono.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefono";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(264, 257);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(7);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(228, 36);
            this.txtCedula.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cedula";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(264, 185);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 36);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(264, 117);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(7);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(228, 36);
            this.txtCodigo.TabIndex = 13;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.FlatAppearance.BorderSize = 0;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearUsuario.Image")));
            this.btnCrearUsuario.Location = new System.Drawing.Point(264, 646);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(7);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(83, 70);
            this.btnCrearUsuario.TabIndex = 22;
            this.btnCrearUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(43, 32);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 44);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 732);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "Agregar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 493);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Contraseña provicional";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(324, 485);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(7);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(228, 36);
            this.txtContrasena.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 563);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 28);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tipo de usuario";
            // 
            // txtUserType
            // 
            this.txtUserType.Location = new System.Drawing.Point(293, 555);
            this.txtUserType.Margin = new System.Windows.Forms.Padding(7);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(228, 36);
            this.txtUserType.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(152, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(299, 28);
            this.label10.TabIndex = 30;
            this.label10.Text = "CREACION DE USUARIOS";
            // 
            // DGVUsuario
            // 
            this.DGVUsuario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuario.Location = new System.Drawing.Point(561, 143);
            this.DGVUsuario.Name = "DGVUsuario";
            this.DGVUsuario.RowHeadersWidth = 51;
            this.DGVUsuario.RowTemplate.Height = 24;
            this.DGVUsuario.Size = new System.Drawing.Size(727, 269);
            this.DGVUsuario.TabIndex = 31;
            // 
            // formInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1340, 780);
            this.Controls.Add(this.DGVUsuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Book Antiqua", 13.8F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "formInsertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar usuarios nuevos";
            this.Load += new System.EventHandler(this.formInsertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DGVUsuario;
    }
}