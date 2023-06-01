using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapaDatos
{
    public class CD_GetData
    {
        private CD_Connection db_connection = new CD_Connection();

        public DataTable GetData(String sql_Text)
        {
            DataTable tablaDatos = new DataTable();
            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adaptador;
            
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = sql_Text;
            adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tablaDatos);

            return tablaDatos;
        }

        public void CrearAmbulancia(int codigo, string marca, string numero_placa, int anio, int id_conductor)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "sp_crear_ambulancia";

            comando.CommandType = CommandType.StoredProcedure;


            comando.Parameters.AddWithValue("@codigo",codigo);
            comando.Parameters.AddWithValue("@marca",marca);
            comando.Parameters.AddWithValue("@numero_placa",numero_placa);
            comando.Parameters.AddWithValue("@anio",anio);
            comando.Parameters.AddWithValue("@id_conductor",id_conductor);

            comando.ExecuteNonQuery();
            //Cerrar la conexión
            db_connection.CloseConnection();
        } 

        public void ModificarAmbulancia(int codigo, string marca, string numero_placa, int anio, int id_conductor)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "sp_modificar_ambulancia";

            comando.CommandType = CommandType.StoredProcedure;


            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@numero_placa", numero_placa);
            comando.Parameters.AddWithValue("@anio", anio);
            comando.Parameters.AddWithValue("@id_conductor", id_conductor);

            comando.ExecuteNonQuery();
            //Cerrar la conexión
            db_connection.CloseConnection();
        }

        public void EliminarAmbulancia(int codigo)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "sp_modificar_ambulancia";

            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();

            db_connection.CloseConnection();

        }

    }
}
