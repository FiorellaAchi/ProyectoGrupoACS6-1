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
        private static string connectionString = "Data Source=DESKTOP-8LBI3IO;Initial Catalog=BaseDatos_GrupoA_Proyecto;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
