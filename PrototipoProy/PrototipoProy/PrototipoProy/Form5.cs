using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoProy
{
    public partial class frmEditar : Form
    {
        Datos datos = new Datos();
        public frmEditar()
        {
            InitializeComponent();
            DGVUsuarios.DataSource = datos.ListarUsuarios(); //llena el datagridview con los datos de la base de datos
        }
        //evento que modifica el usuario en la base de datos
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Comando que modifica el usuario en la base de datos
                datos.ActualizarUsuario(txtCodigo.Text, txtNombre.Text, txtCedula.Text, txtTelefono.Text, txtEmail.Text, txtContrasena.Text);
                DGVUsuarios.DataSource = datos.ListarUsuarios(); //actualiza el datagridview
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio Principal = new FormInicio();
            Principal.Show();
        }

        private void frmEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
