using Datos;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Datos
{
    public class Conexion
    {
        private string cadenaConexion = "Data Source=xe ; User Id=Hensami ; Password=Hensami1 ;";


        //---------------------------------------------------------------------------------------------------------------
        //| CODIGOS EN EL AREA LOGIN EMPIEZAN DESDE AQUI                                                                |
        //---------------------------------------------------------------------------------------------------------------


        public bool VerificarCredenciales(string usuario, string contrasena)
        {
            //Se inicia credencialesValidas como falso
            bool credencialesValidas = false;

            using (OracleConnection connection = new OracleConnection(cadenaConexion))
            {
                //Se abre una conexion
                connection.Open();

                //Se realiza una consulta a la tabla Login de la base de datos donde se verifica el usuario y contraseña
                string sql = "SELECT COUNT(*) FROM Login WHERE Usuario = :usuario AND Clave = :contrasena";

                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    // Se agregan parámetros a la consulta para evitar la inyección de SQL
                    command.Parameters.Add(":usuario", OracleDbType.Varchar2).Value = usuario;
                    command.Parameters.Add(":contrasena", OracleDbType.Varchar2).Value = contrasena;

                    // Se ejecuta la consulta y se obtiene el resultado
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Se verifica si se encontró un registro que coincida con el usuario y la contraseña
                    if (count > 0)
                    {
                        //Si es usuario y clave coincide devuelve True;
                        credencialesValidas = true;
                    }
                }
            }
            // Se devuelve el resultado de la verificación de las credenciales
            return credencialesValidas;
        }


        //---------------------------------------------------------------------------------------------------------------
        //| CODGIOS EN EL AREA PRODUCTOS EMPIEZAN DESDE AQUI                                                            |
        //---------------------------------------------------------------------------------------------------------------


        public DataTable ObtenerProductos()
        {
            //Se crea un nuevo DataTable
            DataTable dataTable = new DataTable();

            try
            {
                using (OracleConnection connection = new OracleConnection(cadenaConexion))
                {
                    //Se abre una conexion
                    connection.Open();

                    //Se realiza una consulta a la tabla Productos de la base de datos
                    string sql = "SELECT codigoProducto, nombreProducto, cantidadProducto, precioProducto FROM Productos";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        // Se crea un adaptador de datos OracleDataAdapter para ejecutar la consulta y llenar el DataTable
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(dataTable); // Se llena el DataTable con los datos obtenidos de la consulta
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Se muestra el codigo y mensaje de la exepcion, si la consulta no fue exitosa
                Console.WriteLine(ex.Message);
            }
            // Se devuelve el DataTable que contiene los productos obtenidos de la base de datos
            return dataTable;
        }

        public bool VerificarExistenciaProducto(string codigoProducto)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(cadenaConexion))
                {
                    // Se abre una conexión a la base de datos
                    connection.Open();

                    // Se construye una consulta SQL para verificar la existencia del producto en la tabla Productos
                    string sql = "SELECT COUNT(*) FROM Productos WHERE codigoProducto = :codigo";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        // Se agrega un parámetro a la consulta para evitar la inyección de SQL
                        command.Parameters.Add(":codigo", OracleDbType.Varchar2).Value = codigoProducto;

                        // Se ejecuta la consulta y se obtiene el resultado
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // Se devuelve true si se encuentra al menos un producto con el código especificado, de lo contrario, se devuelve false
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Si se produce una excepción, se muestra el mensaje de error en la consola y se devuelve false
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public class Producto
        {
            // Propiedades del producto
            public string CodigoProducto { get; set; }
            public string NombreProducto { get; set; }
            public string CantidadProducto { get; set; }
            public string PrecioProducto { get; set; }

            // Constructor de la clase Producto
            public Producto(string codigoProducto, string nombreProducto, string cantidadProducto, string precioProducto)
            {
                // Asignar los valores proporcionados a las propiedades del producto
                CodigoProducto = codigoProducto;
                NombreProducto = nombreProducto;
                CantidadProducto = cantidadProducto;
                PrecioProducto = precioProducto;
            }
        }


        public bool AgregarProducto(Producto producto)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(cadenaConexion))
                {
                    // Se abre una conexión a la base de datos
                    connection.Open();

                    // Se construye una consulta SQL para insertar un nuevo producto en la tabla Productos
                    string sql = "INSERT INTO Productos (codigoProducto, nombreProducto, cantidadProducto, precioProducto) " +
                                 "VALUES (:codigo, :nombre, :cantidad, :precio)";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        // Se agregan parámetros a la consulta para evitar la inyección de SQL
                        command.Parameters.Add(":codigo", OracleDbType.Varchar2).Value = producto.CodigoProducto;
                        command.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = producto.NombreProducto;
                        command.Parameters.Add(":cantidad", OracleDbType.Varchar2).Value = producto.CantidadProducto;
                        command.Parameters.Add(":precio", OracleDbType.Varchar2).Value = producto.PrecioProducto;

                        // Se ejecuta la consulta y se obtiene el número de filas afectadas por la inserción
                        int rowsAffected = command.ExecuteNonQuery();

                        // Si al menos una fila es afectada, se considera que la inserción fue exitosa y se devuelve true
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Si se produce una excepción, se muestra el mensaje de error en la consola y se devuelve false
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool ActualizarProducto(string codigoProducto, string nuevoNombreProducto, string nuevaCantidadProducto, string nuevoPrecioProducto)
        {
            using (OracleConnection conexion = new OracleConnection(cadenaConexion))
            {
                try
                {
                    // Se abre una conexión a la base de datos
                    conexion.Open();
                    
                    // Se crea un comando de actualización para modificar los datos del producto en la tabla Productos
                    OracleCommand comando = new OracleCommand("UPDATE Productos SET nombreProducto = :nombre, cantidadProducto = :cantidad, precioProducto = :precio WHERE codigoProducto = :codigo", conexion);
                    
                    // Se agregan parámetros al comando para evitar la inyección de SQL
                    comando.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nuevoNombreProducto;
                    comando.Parameters.Add(":cantidad", OracleDbType.Varchar2).Value = nuevaCantidadProducto;
                    comando.Parameters.Add(":precio", OracleDbType.Varchar2).Value = nuevoPrecioProducto;
                    comando.Parameters.Add(":codigo", OracleDbType.Varchar2).Value = codigoProducto;

                    // Se ejecuta el comando de actualización
                    comando.ExecuteNonQuery();

                    // Se devuelve true para indicar que la actualización fue exitosa
                    return true;
                }
                catch
                {
                    // Si se produce alguna excepción, se devuelve false para indicar que la actualización falló
                    return false;
                }
            }
        }

        public bool EliminarProducto(string codigoProducto)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(cadenaConexion))
                {
                    // Se abre una conexión a la base de datos
                    connection.Open();

                    // Se construye una consulta SQL para eliminar el producto de la tabla Productos
                    string sql = "DELETE FROM Productos WHERE codigoProducto = :codigo";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        // Se agrega un parámetro a la consulta para evitar la inyección de SQL
                        command.Parameters.Add(":codigo", OracleDbType.Varchar2).Value = codigoProducto;

                        // Se ejecuta la consulta y se obtiene el número de filas afectadas por la eliminación
                        int rowsAffected = command.ExecuteNonQuery();

                        // Si al menos una fila es afectada, se considera que la eliminación fue exitosa y se devuelve true
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Si se produce una excepción, se muestra el mensaje de error en la consola y se devuelve false
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //------------------------------------------------------------------------------------------------------------------
        //| CODIGOS EN EL AREA VENTA EMPIEZAN DESDE AQUI                                                                   |
        //------------------------------------------------------------------------------------------------------------------

        public bool VerificarExistProducto(string codigoProducto)
        {
            using (OracleConnection connection = new OracleConnection(cadenaConexion))
            {
                // Se abre una conexión a la base de datos
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {
                    // Se configura el comando con la consulta SQL para verificar la existencia del producto
                    command.CommandText = "SELECT COUNT(*) FROM Productos WHERE codigoProducto = :codigoProducto AND cantidadProducto > 0";

                    // Se agrega un parámetro al comando para evitar la inyección de SQL
                    command.Parameters.Add(":codigoProducto", codigoProducto);

                    // Se ejecuta la consulta y se obtiene el resultado como un entero
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Si el contador es mayor a cero, significa que existe al menos un producto con el código dado y cantidad mayor a cero
                    // Por lo tanto, se devuelve true. De lo contrario, se devuelve false.
                    return count > 0;
                }
            }
        }

        private static string cadenaConexion1 = "Data Source=xe ; User Id=Hensami ; Password=Hensami1 ;";

        public static DataTable EjecutarConsulta(string consulta)
        {
            using (OracleConnection conexion = new OracleConnection(cadenaConexion1))
            {
                using (OracleCommand comando = new OracleCommand(consulta, conexion))
                {
                    // Se crea una instancia de OracleConnection utilizando la cadena de conexión cadenaConexion1
                    conexion.Open();  // Se abre la conexión a la base de datos
                    OracleDataAdapter adaptador = new OracleDataAdapter(comando); // Se crea un adaptador OracleDataAdapter
                    DataTable tabla = new DataTable(); // Se crea una nueva DataTable para almacenar los datos
                    adaptador.Fill(tabla); // Se llena la DataTable con los datos obtenidos de la consulta
                    return tabla; // Se devuelve la DataTable con los resultados de la consulta
                }
            }
        }

        public static int EjecutarComando(string comando)
        {
            using (OracleConnection conexion = new OracleConnection(cadenaConexion1))
            {
                using (OracleCommand cmd = new OracleCommand(comando, conexion))
                {
                    conexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int ObtenerUltimoIdVenta()
        {
            string comando = "SELECT MAX(IDVENTA) FROM Ventas";
            using (OracleConnection conexion = new OracleConnection(cadenaConexion1))
            {
                using (OracleCommand cmd = new OracleCommand(comando, conexion))
                {
                    // Se crea una instancia de OracleConnection utilizando la cadena de conexión cadenaConexion1

                    conexion.Open();  // Se abre la conexión a la base de datos

                    var result = cmd.ExecuteScalar(); // Se ejecuta la consulta y se obtiene el resultado

                    if (result != null && result != DBNull.Value)
                    {
                        // Si el resultado no es nulo ni DBNull, se convierte a entero y se le suma 1 para obtener el siguiente ID de venta
                        return Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        return 1; // Si no hay registros, se devuelve 1 para empezar desde el primer ID de venta
                    }
                }
            }
        }

    }
}
