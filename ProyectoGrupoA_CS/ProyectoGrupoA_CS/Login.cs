using Data;
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

        Datos data= Datos.getObject();
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
            if (data.Login(usuario, password))
            {
                if(data.CheckUserType(usuario, password)==1)
                {
                    FormAdmin frm = new FormAdmin();
                    frm.Show();
                    this.Hide();
                    return;
                }
                if (data.CheckUserType(usuario, password) == 0)
                {
                    frmServicios frm = new frmServicios();
                    frm.Show();
                    this.Hide();
                    return;
                }
                MessageBox.Show("El usuario no tiene asignado un rol actualmente");
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
