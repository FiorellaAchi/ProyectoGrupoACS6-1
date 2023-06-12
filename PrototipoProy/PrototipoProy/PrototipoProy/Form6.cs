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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }
        //evento que elimina el usuario en la base de datos
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Se establece la conexión con la base de datos.
                using (SqlConnection connection = DBHelper.GetConnection())
                {
                    //Se crea un comando SQL para ejecutar el procedimiento almacenado "sp_eliminar_usuario".
                    using (SqlCommand command = new SqlCommand("sp_eliminar_usuario", connection))
                    {
                        //Se asigna el valor del campo de texto al parámetro del comando.
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text);

                        //Se abre la conexión a la base de datos.
                        connection.Open();

                        //Se ejecuta el comando y se obtiene el número de filas afectadas por la eliminación.
                        int rowsAffected = command.ExecuteNonQuery();

                        //Se muestra un mensaje de éxito si se eliminó al menos una fila
                        //o un mensaje de que el usuario no existe si no se eliminó ninguna fila.
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario eliminado con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("El usuario no existe.");
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion");
            }
            catch(Exception ex)
            {
                  MessageBox.Show(ex.Message);
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
