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

        private static Datos datos = new Datos();
        public Datos() { }
        public static Datos getObject()
        {
            return datos;
        }

        private String userName; 

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

        public void InsertarPaciente(String codigo, String nombre, String apellido, String edad, String direccion, String fechaIngreso, String tutor)
        {
            String nombreSp = "sp_crear_paciente";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                    command.Parameters.AddWithValue("@tutor",tutor);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }

        public void EliminarPaciente(String codigo)
        {
            String nombreSp = "sp_eliminar_paciente";
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

        public void ActualizarPaciente(String codigo, String nombre, String apellido, String edad, String direccion, String fechaIngreso, String tutor)
        {
            String nombreSp = "sp_modificar_paciente";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                    command.Parameters.AddWithValue("@tutor", tutor);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ListarPacientes()
        {
            String nombreSp = "sp_listar_paciente";
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

        public void InsertarServicio()
        {
            String nombre = userName+"";
            String descripcion = "Servicio de ambulancias";
            /*precio ramdon en un margen de 25 a 70*/
            Random rnd = new Random();
            int preciot = rnd.Next(25, 70);
            String precio= preciot.ToString();
            String codigo = nombre +"_SA"+precio;
            String nombreSp = "sp_crear_servicios";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@precio", precio);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarServicio()
        {
            String nombre = userName;
            String nombreSp = "sp_eliminar_servicios";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", nombre);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarServicio(String codigo, String nombre, String descripcion, String precio)
        {
            String nombreSp = "sp_modificar_servicios";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@precio", precio);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ListarServicios()
        {
            String nombreSp = "sp_listar_servicios";
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

        public bool Login(string usuario, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_login", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();

                    // Obtiene el valor de retorno del procedimiento almacenado
                    SqlParameter returnValueParam = new SqlParameter("@RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(returnValueParam);

                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();

                    // Obtiene el valor de retorno del procedimiento almacenado
                    int returnValue = Convert.ToInt32(command.Parameters["@RETURN_VALUE"].Value);

                    // Comprueba si el valor de retorno es 1 (inicio de sesión exitoso)
                    if (returnValue == 1)
                    {
                        userName = usuario;
                        return true;
                    }
                }
            }

            // El inicio de sesión del usuario falló
            return false;
        }



        public int CheckUserType(string usuario, string password)
        {
            int userType = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_check_user_type", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();

                    SqlParameter returnValueParam = new SqlParameter("@RETURN_VALUE", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(returnValueParam);

                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();

                    // Obtiene el valor de retorno del procedimiento almacenado
                    userType = Convert.ToInt32(command.Parameters["@RETURN_VALUE"].Value);
                }
            }
            return userType;
        }


    }
}
