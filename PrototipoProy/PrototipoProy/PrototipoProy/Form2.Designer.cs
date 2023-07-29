namespace PrototipoProy
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuariosEnElSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuariosEnElSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(727, 535);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 76);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem,
            this.modificarUsuarioDelSistemaToolStripMenuItem,
            this.listarUsuariosEnElSistemaToolStripMenuItem,
            this.eliminarUsuariosEnElSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1437, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertarUsuarioNuevoAlSistemaToolStripMenuItem
            // 
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem.Name = "insertarUsuarioNuevoAlSistemaToolStripMenuItem";
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem.Size = new System.Drawing.Size(370, 32);
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem.Text = "Insertar usuario nuevo al sistema";
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem.Click += new System.EventHandler(this.insertarUsuarioNuevoAlSistemaToolStripMenuItem_Click);
            // 
            // modificarUsuarioDelSistemaToolStripMenuItem
            // 
            this.modificarUsuarioDelSistemaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.modificarUsuarioDelSistemaToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarUsuarioDelSistemaToolStripMenuItem.Name = "modificarUsuarioDelSistemaToolStripMenuItem";
            this.modificarUsuarioDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.modificarUsuarioDelSistemaToolStripMenuItem.Text = "Listar usuarios del sistema";
            this.modificarUsuarioDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioDelSistemaToolStripMenuItem_Click);
            // 
            // listarUsuariosEnElSistemaToolStripMenuItem
            // 
            this.listarUsuariosEnElSistemaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.listarUsuariosEnElSistemaToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarUsuariosEnElSistemaToolStripMenuItem.Name = "listarUsuariosEnElSistemaToolStripMenuItem";
            this.listarUsuariosEnElSistemaToolStripMenuItem.Size = new System.Drawing.Size(361, 32);
            this.listarUsuariosEnElSistemaToolStripMenuItem.Text = "Modificar usuarios en el sistema";
            this.listarUsuariosEnElSistemaToolStripMenuItem.Click += new System.EventHandler(this.listarUsuariosEnElSistemaToolStripMenuItem_Click);
            // 
            // eliminarUsuariosEnElSistemaToolStripMenuItem
            // 
            this.eliminarUsuariosEnElSistemaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.eliminarUsuariosEnElSistemaToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarUsuariosEnElSistemaToolStripMenuItem.Name = "eliminarUsuariosEnElSistemaToolStripMenuItem";
            this.eliminarUsuariosEnElSistemaToolStripMenuItem.Size = new System.Drawing.Size(348, 32);
            this.eliminarUsuariosEnElSistemaToolStripMenuItem.Text = "Eliminar usuarios en el sistema";
            this.eliminarUsuariosEnElSistemaToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuariosEnElSistemaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1393, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1437, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al sistema";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertarUsuarioNuevoAlSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUsuariosEnElSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuariosEnElSistemaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}