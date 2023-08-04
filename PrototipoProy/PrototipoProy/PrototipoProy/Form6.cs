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
    public partial class frmEliminar : Form
    {
        Datos datos = new Datos();
        public frmEliminar()
        {
            InitializeComponent();
            DGVUsuarios.DataSource = datos.ListarUsuarios();
        }
        //evento que elimina el usuario en la base de datos
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try //Con esta ejecucion podemos eliminar un usuario
            {
                datos.EliminarUsuario(txtNombre.Text);
                DGVUsuarios.DataSource = datos.ListarUsuarios(); //Se actualizan los datos
            }catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario" + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Comando que oculta la ventana actual
            this.Hide();
            //Crea una instancia para q nos muestre el formulario de inicio 
            FormInicio Principal = new FormInicio();
            Principal.Show();
        }
    }
}
