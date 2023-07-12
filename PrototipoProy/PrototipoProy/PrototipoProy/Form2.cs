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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }
        //eventos clic que nos presentan los formularios a los que queremos ingresar
        private void button1_Click(object sender, EventArgs e)
        {
            //Comando que oculta la ventana actual
            this.Close();
        }

        private void modificarUsuarioDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Comando que oculta la ventana actual
            this.Hide();
            //Crea una instancia para q nos muestre el formulario de listar
            frmListar Principal = new frmListar();
            Principal.Show();
        }

        private void listarUsuariosEnElSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Comando que oculta la ventana actual
            this.Hide();
            //Crea una instancia para q nos muestre el formulario de editar
            frmEditar Principal = new frmEditar();
            Principal.Show();
        }

        private void eliminarUsuariosEnElSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Comando que oculta la ventana actual
            this.Hide();
            //Crea una instancia para q nos muestre el formulario de eliminar
            frmEliminar Principal = new frmEliminar();
            Principal.Show();
        }

        private void insertarUsuarioNuevoAlSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInsertar Principal = new formInsertar();
            Principal.Show();
        }
    }
}
