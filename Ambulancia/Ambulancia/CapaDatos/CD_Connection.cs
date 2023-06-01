using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Connection
    {
        private SqlConnection DB_Connection = new SqlConnection("Server = Luis; Database = ProyectoAmbulancia1; Integrated Security = true");

        public SqlConnection OpenConnection()
        {
            if (DB_Connection.State == ConnectionState.Closed)
            {
                DB_Connection.Open();
            }

            return DB_Connection;
        }

        public SqlConnection CloseConnection()
        {

            if (DB_Connection.State == ConnectionState.Open)
            {
                DB_Connection.Close();
            }
            return DB_Connection;
        }

    }
}
