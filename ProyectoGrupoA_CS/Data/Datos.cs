using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Datos
    {
        //Creacion de conexion para base de datos en sql server
        //public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-8Q4QJ8I;Initial Catalog=Prueba;Integrated Security=True");
        String connectionString = "Data Source=DESKTOP-3SRGPP9;Initial Catalog=ProyectoAmbulancia1;Integrated Security=True";
        

        public void InsertarConductor(int id,String nombre, String cedula, String telefono, String licencia, String direccion, String unidad, int diasLaborados)
        {
            String nombreSp = "sp_crear_conductor";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@licencia", licencia);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@unidad", unidad);
                    command.Parameters.AddWithValue("@diasLaborados", diasLaborados);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarConductor(int id) {
            String nombreSp = "sp_eliminar_conductor";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarConductor(int id, String nombre, String cedula, String telefono, String licencia, String direccion, String unidad, int diasLaborados)
        {
            String nombreSp = "sp_modificar_conductor";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@licencia", licencia);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@unidad", unidad);
                    command.Parameters.AddWithValue("@diasLaborados", diasLaborados);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ListarConductores()
        {
            String nombreSp = "sp_listar_conductor";
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

        public void InsertarAmbulancia(int codigo,String marca, String numero_placa, int anio,int id_conductor)
        {
            String nombreSp = "sp_crear_ambulancia";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@marca", marca);
                    command.Parameters.AddWithValue("@numero_placa", numero_placa);
                    command.Parameters.AddWithValue("@anio", anio);
                    command.Parameters.AddWithValue("@id_conductor", id_conductor);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarAmbulancia(int codigo)
        {
            String nombreSp = "sp_eliminar_ambulancia";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        
        public void ActualizarAmbulancia(int codigo, String marca, String numero_placa, int anio, int id_conductor)
        {
            String nombreSp = "sp_modificar_ambulancia";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@marca", marca);
                    command.Parameters.AddWithValue("@numero_placa", numero_placa);
                    command.Parameters.AddWithValue("@anio", anio);
                    command.Parameters.AddWithValue("@id_conductor", id_conductor);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ListarAmbulancias()
        {
            String nombreSp = "sp_listar_ambulancia";
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
