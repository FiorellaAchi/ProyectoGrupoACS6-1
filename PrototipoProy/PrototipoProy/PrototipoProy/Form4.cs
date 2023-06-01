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
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }
       //muestra todos los usuarios en un datagridview
        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {

            //Se establece la conexión con la base de datos.
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                //Se crea un comando SQL para ejecutar el procedimiento almacenado "sp_listar_usuario".
                using (SqlCommand command = new SqlCommand("sp_listar_usuario", connection))
                {
                    
                    command.CommandType = CommandType.StoredProcedure;

                    //Se abre la conexión a la base de datos.
                    connection.Open();

                    //Se crea un DataTable para almacenar los resultados de la consulta.
                    DataTable dataTable = new DataTable();

                    //Se utiliza un SqlDataAdapter para llenar el DataTable con los resultados de la consulta.

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                   
                    adapter.Fill(dataTable);

                    //Se asigna el DataTable como origen de datos del DataGridView.
                    dgvUsuarios.DataSource = dataTable;
                }
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
