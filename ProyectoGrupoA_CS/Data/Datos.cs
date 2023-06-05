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

        String connectionString = "Data Source=DESKTOP-8LBI3IO;Initial Catalog=BaseDatos_GrupoA_Proyecto;Integrated Security=True";
        

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



    }
}
