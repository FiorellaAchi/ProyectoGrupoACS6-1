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
        public frmEditar()
        {
            InitializeComponent();
        }
        //evento que modifica el usuario en la base de datos
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Se establece la conexión con la base de datos.
                using (SqlConnection connection = DBHelper.GetConnection())
                {
                    //Se crea un comando SQL para ejecutar el procedimiento almacenado "sp_modificar_usuario".
                    using (SqlCommand command = new SqlCommand("sp_modificar_usuario", connection))
                    {
                        //Se asignan los valores de los campos de texto a los parámetros del comando.
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@cedula", txtCedula.Text);
                        command.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        command.Parameters.AddWithValue("@email", txtEmail.Text);

                        //Se abre la conexión a la base de datos.
                        connection.Open();
                        //Se ejecuta el comando y se obtiene el número de filas afectadas por la modificación.
                        int rowsAffected = command.ExecuteNonQuery();

                        //Se muestra un mensaje de éxito si se modificó al menos una fila
                        //o un mensaje de que no se encontró el usuario si no se modificó ninguna fila.
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario modificado con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el usuario con el código especificado.");
                        }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio Principal = new FormInicio();
            Principal.Show();
        }
    }
}
