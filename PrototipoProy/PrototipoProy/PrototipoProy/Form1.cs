using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoProy
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string textousuario;
            string textocontrasena;

            textousuario = txtLogin.Text;
            textocontrasena = txtContrasena.Text;

            if ((textousuario=="Henry"&&(textocontrasena=="1234")))
            {
                this.Hide();
                FormInicio Principal = new FormInicio();
                Principal.Show();
            }
        }
    }
}
