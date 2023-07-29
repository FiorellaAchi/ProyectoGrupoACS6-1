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
    public partial class formInsertar : Form
    {
        public formInsertar()
        {
            InitializeComponent();
        }

        //btnCrearUsuario_Click: Es el evento de clic del botón "guardar"..
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Crea una conexión a la base de datos utilizando la clase DBHelper
                // El método GetConnection() devuelve una nueva instancia de SqlConnection que representa una conexión a la base de datos.
                using (SqlConnection connection = DBHelper.GetConnection())
                {
                    //Crea un comando SQL para ejecutar el procedimiento almacenado sp_crear_usuario en la base de datos.
                    using (SqlCommand command = new SqlCommand("sp_crear_usuario", connection))
                    {
                        // command.CommandType = CommandType.StoredProcedure nos Indica que el comando es un procedimiento almacenado.
                        command.CommandType = CommandType.StoredProcedure;
                        // Agrega el valor del campo txtCodigoUsuario, como parámetro @codigo en el comando. y asi sucesivamente 
                        command.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@cedula", txtCedula.Text);
                        command.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        // con connection.Open();: Se abre la conexión a la base de datos.
                        connection.Open();
                        //command.ExecuteNonQuery() nos ejecuta el comando en la base de datos sin esperar un resultado.
                        command.ExecuteNonQuery();
                        //este ultimo comando nos muestra un mensaje al usuario indicando que el usuario se ha creado correctamente.
                        MessageBox.Show("Usuario creado con éxito.");
                    }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
