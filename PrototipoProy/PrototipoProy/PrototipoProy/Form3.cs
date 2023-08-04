using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoProy
{
    public partial class formInsertar : Form
    {
        Datos datos = new Datos(); //Instancia de la clase Datos
        public formInsertar()
        {
            InitializeComponent();
            DGVUsuario.DataSource = datos.ListarUsuarios(); //Muestra los usuarios en el DataGridView
            
        }

        //btnCrearUsuario_Click: Es el evento de clic del botón "guardar"..
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                datos.CrearUsuario(txtCodigo.Text, txtNombre.Text, txtCedula.Text, txtTelefono.Text, txtEmail.Text, txtContrasena.Text, txtUserType.Text);
                //Se ingresan los datos correspondientes.
                DGVUsuario.DataSource = datos.ListarUsuarios(); //Muestra los usuarios que hemos creado
            }catch(Exception ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message);
            }

        }
        //evento clic q nos permite regresar a la anterior pagina 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio Principal = new FormInicio();
            Principal.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void formInsertar_Load(object sender, EventArgs e)
        {

        }
    }
}
