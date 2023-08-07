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
            DGVUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //selecciona toda la fila
            DGVUsuarios.CellClick += DGVUsuarios_CellClick; //agrega un evento al datagridview
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

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se haya seleccionado una fila válida
            {
                DataGridViewRow row = DGVUsuarios.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["codigo"].Value.ToString();
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtCedula.Text = row.Cells["cedula"].Value.ToString();
                txtTelefono.Text = row.Cells["telefono"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtContrasena.Text = row.Cells["contrasena"].Value.ToString();
                
            }
        }
    }
}
