using System;
using System.Collections.Generic;
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
    }
}
