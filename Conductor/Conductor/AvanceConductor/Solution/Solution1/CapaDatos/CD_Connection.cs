using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Connection
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=DOMBRI;Initial Catalog=CONDUCTOR_DB;User ID=sa;Password=0931123806;";
         
        // Método para abrir la conexión con la base de datos
        public SqlConnection OpenConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        // Método para cerrar la conexión con la base de datos
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
