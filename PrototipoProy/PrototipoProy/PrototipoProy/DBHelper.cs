using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProy
{
    internal class DBHelper
    {
        private static string connectionString = "Data Source=DESKTOP-3SRGPP9;Initial Catalog=ProyectoAmbulancia1;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable ListarUsuarios() //Proceso mediante el cual se muestran todos los usuarios en un datagridview
        {
            String nombreSp = "sp_listar_usuario";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
