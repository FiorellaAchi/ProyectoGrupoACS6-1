using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CapaDatos
{
    public class CD_GetData
    {
        private CD_Connection connectionManager;

        public CD_GetData()
        {
            connectionManager = new CD_Connection();
        }
        // Método para guardar los datos de un conductor en la base de datos
        public void GuardarConductor(string nombre, string cedula, string celular, string licencia, string direccion, string unidadCargo, int diasLaborados)
        {

            // Abre una nueva conexión utilizando el connectionManager
            using (SqlConnection connection = connectionManager.OpenConnection())
            {// Consulta SQL para insertar los datos en la tabla "Conductores"
                string query = "INSERT INTO Conductores (Nombre, Cedula, Celular, Licencia, Direccion, UnidadCargo, DiasLaborados) " +
                               "VALUES (@Nombre, @Cedula, @Celular, @Licencia, @Direccion, @UnidadCargo, @DiasLaborados)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {// Asigna los parámetros de la consulta con los valores proporcionados
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Cedula", cedula);
                    command.Parameters.AddWithValue("@Celular", celular);
                    command.Parameters.AddWithValue("@Licencia", licencia);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@UnidadCargo", unidadCargo);
                    command.Parameters.AddWithValue("@DiasLaborados", diasLaborados);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}



