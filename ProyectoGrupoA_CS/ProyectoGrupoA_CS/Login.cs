using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupoA_CS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = txtUser.Text;
            String password = txtPassword.Text;

            if (usuario.Equals("admin") && password.Equals("admin"))
            {
                FormAdmin frm = new FormAdmin();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
