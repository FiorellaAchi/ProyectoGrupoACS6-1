namespace CapaPresentación
{
    partial class FormPrincipal
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
            menuStrip1 = new MenuStrip();
            agregarAmbulanciaToolStripMenuItem = new ToolStripMenuItem();
            listarAmbulanciasToolStripMenuItem = new ToolStripMenuItem();
            modificarAmbulanciaToolStripMenuItem = new ToolStripMenuItem();
            eliminarAmbulanciaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarAmbulanciaToolStripMenuItem, listarAmbulanciasToolStripMenuItem, modificarAmbulanciaToolStripMenuItem, eliminarAmbulanciaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarAmbulanciaToolStripMenuItem
            // 
            agregarAmbulanciaToolStripMenuItem.Name = "agregarAmbulanciaToolStripMenuItem";
            agregarAmbulanciaToolStripMenuItem.Size = new Size(128, 20);
            agregarAmbulanciaToolStripMenuItem.Text = "Agregar Ambulancia";
            agregarAmbulanciaToolStripMenuItem.Click += agregarAmbulanciaToolStripMenuItem_Click;
            // 
            // listarAmbulanciasToolStripMenuItem
            // 
            listarAmbulanciasToolStripMenuItem.Name = "listarAmbulanciasToolStripMenuItem";
            listarAmbulanciasToolStripMenuItem.Size = new Size(119, 20);
            listarAmbulanciasToolStripMenuItem.Text = "Listar Ambulancias";
            listarAmbulanciasToolStripMenuItem.Click += listarAmbulanciasToolStripMenuItem_Click;
            // 
            // modificarAmbulanciaToolStripMenuItem
            // 
            modificarAmbulanciaToolStripMenuItem.Name = "modificarAmbulanciaToolStripMenuItem";
            modificarAmbulanciaToolStripMenuItem.Size = new Size(137, 20);
            modificarAmbulanciaToolStripMenuItem.Text = "Modificar Ambulancia";
            modificarAmbulanciaToolStripMenuItem.Click += modificarAmbulanciaToolStripMenuItem_Click;
            // 
            // eliminarAmbulanciaToolStripMenuItem
            // 
            eliminarAmbulanciaToolStripMenuItem.Name = "eliminarAmbulanciaToolStripMenuItem";
            eliminarAmbulanciaToolStripMenuItem.Size = new Size(129, 20);
            eliminarAmbulanciaToolStripMenuItem.Text = "Eliminar Ambulancia";
            eliminarAmbulanciaToolStripMenuItem.Click += eliminarAmbulanciaToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarAmbulanciaToolStripMenuItem;
        private ToolStripMenuItem listarAmbulanciasToolStripMenuItem;
        private ToolStripMenuItem modificarAmbulanciaToolStripMenuItem;
        private ToolStripMenuItem eliminarAmbulanciaToolStripMenuItem;
    }
}