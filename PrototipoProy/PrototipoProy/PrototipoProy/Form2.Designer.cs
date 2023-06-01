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
            this.button1.Location = new System.Drawing.Point(279, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir del sistema";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem,
            this.modificarUsuarioDelSistemaToolStripMenuItem,
            this.listarUsuariosEnElSistemaToolStripMenuItem,
            this.eliminarUsuariosEnElSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertarUsuarioNuevoAlSistemaToolStripMenuItem
            // 
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem.Name = "insertarUsuarioNuevoAlSistemaToolStripMenuItem";
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem.Size = new System.Drawing.Size(191, 20);
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem.Text = "Insertar usuario nuevo al sistema";
            this.insertarUsuarioNuevoAlSistemaToolStripMenuItem.Click += new System.EventHandler(this.insertarUsuarioNuevoAlSistemaToolStripMenuItem_Click);
            // 
            // modificarUsuarioDelSistemaToolStripMenuItem
            // 
            this.modificarUsuarioDelSistemaToolStripMenuItem.Name = "modificarUsuarioDelSistemaToolStripMenuItem";
            this.modificarUsuarioDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.modificarUsuarioDelSistemaToolStripMenuItem.Text = "Listar usuarios del sistema";
            this.modificarUsuarioDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioDelSistemaToolStripMenuItem_Click);
            // 
            // listarUsuariosEnElSistemaToolStripMenuItem
            // 
            this.listarUsuariosEnElSistemaToolStripMenuItem.Name = "listarUsuariosEnElSistemaToolStripMenuItem";
            this.listarUsuariosEnElSistemaToolStripMenuItem.Size = new System.Drawing.Size(188, 20);
            this.listarUsuariosEnElSistemaToolStripMenuItem.Text = "Modificar usuarios en el sistema";
            this.listarUsuariosEnElSistemaToolStripMenuItem.Click += new System.EventHandler(this.listarUsuariosEnElSistemaToolStripMenuItem_Click);
            // 
            // eliminarUsuariosEnElSistemaToolStripMenuItem
            // 
            this.eliminarUsuariosEnElSistemaToolStripMenuItem.Name = "eliminarUsuariosEnElSistemaToolStripMenuItem";
            this.eliminarUsuariosEnElSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 20);
            this.eliminarUsuariosEnElSistemaToolStripMenuItem.Text = "Eliminar usuarios en el sistema";
            this.eliminarUsuariosEnElSistemaToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuariosEnElSistemaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(715, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 330);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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