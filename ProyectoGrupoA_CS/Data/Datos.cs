﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Datos
    {
        //Creacion de conexion para base de datos en sql server
        String connectionString = "Data Source=DESKTOP-3SRGPP9;Initial Catalog=ProyectoAmbulancia1;Integrated Security=True";

        private static Datos datos = new Datos(); //Se crea un metodo estatico para poder acceder a los metodos de la clase
        public Datos() { } // Constructor vacìo de la clase

        private String userName; //Variable username para hacer el login
        public static Datos getObject() //Metodo para obtener la clase como objeto
        {
            return datos;
        }

        public void InsertarConductor(int id,String nombre, String cedula, String telefono, String licencia, String direccion, String unidad, int diasLaborados) //Metodo insertar conductor
        {
            String nombreSp = "sp_crear_conductor";
            using (SqlConnection connection = new SqlConnection(connectionString)) //Se crea una conexion con la base de datos
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))//Se crea un comando para ejecutar el procedimiento almacenado
                {
                    command.CommandType = CommandType.StoredProcedure; //Se especifica que el comando es un procedimiento almacenado
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre); //Se agregan los parametros del procedimiento almacenado
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@licencia", licencia);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@unidad", unidad);
                    command.Parameters.AddWithValue("@diasLaborados", diasLaborados);
                    connection.Open(); //Se abre la conexion
                    command.ExecuteNonQuery(); //Se ejecuta el comando
                }
            }
        }

        public void EliminarConductor(int id) { //Metodo eliminar conductor
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
        { //Metodo actualizar conductor
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

        public DataTable ListarConductores() //Metodo listar conductores
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

        public void InsertarAmbulancia(int codigo,String marca, String numero_placa, int anio,int id_conductor) //insertar ambulancia
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

        public void EliminarAmbulancia(int codigo) //eliminar ambulancia
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

        
        public void ActualizarAmbulancia(int codigo, String marca, String numero_placa, int anio, int id_conductor) //actualizar ambulancia
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

        public DataTable ListarAmbulancias() //Presenta las ambulancias creadas
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

        public void InsertarPaciente(String codigo, String nombre, String apellido, String edad, String direccion, String fechaIngreso, String tutor) //Procedimiento almacenado que registra pacientes
        {
            String nombreSp = "sp_crear_pacientes";
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

        public void EliminarPaciente(String nombre) //Procedimiento que indica que un paciente esta dado de alta
        {
            String nombreSp = "sp_eliminar_pacientes";
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

        public void ActualizarPaciente(String codigo, String nombre, String apellido, String edad, String direccion, String fechaIngreso, String tutor)
        { //Permite modificar los datos del paciente
            String nombreSp = "sp_modificar_pacientes";
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

        public DataTable ListarPacientes() //Lista a todos los pacientes
        {
            String nombreSp = "sp_listar_pacientes";
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

        public void InsertarInsumos(String codigo, String insumo, String fecha, String proveedor, String estado) //Procedimiento que registra los insumos
        {
            String nombreSp = "sp_crear_insumos";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@insumo", insumo);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@proveedor", proveedor);
                    command.Parameters.AddWithValue("@estado", estado);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarInsumos(String insumo) // Procedimiento que indica que un insumo es inexistente
        {
            String nombreSp = "sp_eliminar_insumos";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@insumo", insumo);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarInsumos(String codigo, String insumo, String fecha, String proveedor, String estado)
        { //Actualiza los datos de los insumos e indica si los que estan en proceso ya finalizaron
            String nombreSp = "sp_modificar_insumos";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@insumo", insumo);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@proveedor", proveedor);
                    command.Parameters.AddWithValue("@estado", estado);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ListarInsumos() //Lista todos los insumos
        {
            String nombreSp = "sp_listar_insumos";
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

        public void CrearFacturas(String codigo, String cedula, String nombre, String emision, String telefono, String domicilio, String descripcion)
        { //Procedimiento para crear las facturas
            String nombreSp = "sp_crear_factura";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@emision", emision);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@domicilio", domicilio);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }

        public void EliminarFacturas(String codigo)
        { //Procedimiento para eliminar las facturas
            String nombreSp = "sp_eliminar_factura";
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

       public void ActualizarFacturas(String codigo, String cedula, String nombre, String emision, String telefono, String domicilio, String descripcion)
       { //Procedimiento para actualizar las facturas
            String nombreSp = "sp_modificar_factura";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(nombreSp, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@emision", emision);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@domicilio", domicilio);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }   
        }

        public DataTable ListarFacturas()
        { //Procedimiento para listar las facturas
            String nombreSp = "sp_listar_factura";
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
        { //Procedimiento para insertar los servicios
            String nombre = userName + "";
            String descripcion = "Servicio de ambulancias";
            /*precio ramdon en un margen de 25 a 70*/
            Random rnd = new Random();
            int preciot = rnd.Next(25, 70);
            String precio = preciot.ToString();
            String codigo = nombre + "_SA" + precio;
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

        public void EliminarServicio() //Elimina los servicios
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
        { //Actualiza los servicios
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
        { //Lista los servicios
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
        { //Procedimiento para el login
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



        public int CheckUserType(string usuario, string password) //Procedimiento para verificar el tipo de usuario
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

