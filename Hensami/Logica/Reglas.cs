using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Datos;
using static Datos.Conexion;

namespace Logica
{
    public class Reglas
    {
        private Conexion conexion;

        public Reglas()
        {
            conexion = new Conexion();
        }

        //---------------------------------------------------------------------------------------------------------------
        //| CODIGOS EN EL AREA LOGIN EMPIEZAN DESDE AQUI                                                                |
        //---------------------------------------------------------------------------------------------------------------

        public bool VerificarCredenciales(string usuario, string contrasena)
        {
            //llama de la clase conexion, al metodo verificarCredenciales
            return conexion.VerificarCredenciales(usuario, contrasena);
        }


        //---------------------------------------------------------------------------------------------------------------
        //| CODGIOS EN EL AREA PRODUCTOS EMPIEZAN DESDE AQUI                                                            |
        //---------------------------------------------------------------------------------------------------------------


        public DataTable ObtenerProductos()
        {
            //llama de la clase conexion, al metodo obtener productos
            return conexion.ObtenerProductos();
        }


        public bool VerificarExistenciaProducto(string codigoProducto)
        {
            //llama de la clase conexion al metodo verificarExistenciaProducto
            return conexion.VerificarExistenciaProducto(codigoProducto);
        }

        public bool AgregarProducto(Producto producto)
        {
            // Realizar las validaciones necesarias en la Capa de Lógica antes de agregar el producto en la Capa de Datos

            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(producto.CodigoProducto) ||
                string.IsNullOrWhiteSpace(producto.NombreProducto) ||
                string.IsNullOrWhiteSpace(producto.CantidadProducto) ||
                string.IsNullOrWhiteSpace(producto.PrecioProducto))
            {
                return false;
            }

            // Validar que no haya símbolos o números en el código de producto
            if (!EsCodigoProductoValido(producto.CodigoProducto))
            {
                return false;
            }

            // Validar que no haya símbolos o números en el nombre del producto
            if (!EsNombreProductoValido(producto.NombreProducto))
            {
                return false;
            }

            // Validar que no haya símbolos o letras en la cantidad del producto
            if (!EsCantidadProductoValida(producto.CantidadProducto))
            {
                return false;
            }

            // Validar que no haya símbolos o letras en el precio del producto
            if (!EsPrecioProductoValido(producto.PrecioProducto))
            {
                return false;
            }

            // Llamar al método de la Capa de Datos para agregar el producto
            return conexion.AgregarProducto(producto);
        }

        private bool EsCodigoProductoValido(string codigoProducto)
        {
            // Validar que no haya símbolos en el código de producto
            return !Regex.IsMatch(codigoProducto, @"[^a-zA-Z0-9]");
        }

        private bool EsNombreProductoValido(string nombreProducto)
        {
            // Validar que no haya símbolos o números en el nombre del producto
            return !Regex.IsMatch(nombreProducto, @"[^a-zA-Z]");
        }

        private bool EsCantidadProductoValida(string cantidadProducto)
        {
            // Validar que no haya símbolos o letras en la cantidad del producto
            return !Regex.IsMatch(cantidadProducto, @"[^0-9]");
        }

        private bool EsPrecioProductoValido(string precioProducto)
        {
            // Validar que no haya símbolos o letras en el precio del producto
            return !Regex.IsMatch(precioProducto, @"[^0-9.]");
        }

        public bool EliminarProducto(string codigoProducto)
        {
            //llama a la clase conexion, al metodo EliminarProducto
            return conexion.EliminarProducto(codigoProducto);
        }

        public bool ActualizarProducto(string codigoProducto, string nuevoNombreProducto, string nuevaCantidadProducto, string nuevoPrecioProducto)
        {
            // Realizar las validaciones aquí
            if (!Regex.IsMatch(codigoProducto, @"^[a-zA-Z0-9]+$"))
            {
                // El código de producto contiene símbolos inválidos
                return false;
            }

            if (!Regex.IsMatch(nuevoNombreProducto, @"^[a-zA-Z]+$"))
            {
                // El nombre de producto contiene números o símbolos inválidos
                return false;
            }

            if (!Regex.IsMatch(nuevaCantidadProducto, @"^[0-9]+$"))
            {
                // La cantidad de producto contiene letras o símbolos inválidos
                return false;
            }

            if (!Regex.IsMatch(nuevoPrecioProducto, @"^[0-9.]+$"))
            {
                // El precio de producto contiene letras o símbolos inválidos
                return false;
            }

            //llama de la clase conexion al metodo actualizar producto
            return conexion.ActualizarProducto(codigoProducto, nuevoNombreProducto, nuevaCantidadProducto, nuevoPrecioProducto);
        }


        //------------------------------------------------------------------------------------------------------------------
        //| CODIGOS EN EL AREA VENTA EMPIEZAN DESDE AQUI                                                                   |
        //------------------------------------------------------------------------------------------------------------------

        public bool VerificarExistProducto(string codigoProducto)
        {
            //llama de la clase conexion al metodo verificar existencia producto.
            return conexion.VerificarExistProducto(codigoProducto);
        }

        public static bool ValidarExistenciaProducto(string codigoProducto)
        {
            // Construir la consulta SQL para verificar la existencia del producto con el código proporcionado
            string consulta = $"SELECT COUNT(*) FROM Productos WHERE CODIGOPRODUCTO = '{codigoProducto}'";

            // Ejecutar la consulta y obtener el resultado en forma de DataTable
            // Extraer el valor del conteo de la primera fila y primera columna del resultado
            decimal countDecimal = (decimal)Conexion.EjecutarConsulta(consulta).Rows[0][0];

            // Convertir el valor decimal a entero
            int count = Convert.ToInt32(countDecimal);

            // Retornar verdadero si el conteo es mayor a cero, lo que indica que el producto existe
            return count > 0;
        }

        public static bool ValidarCantidadDisponible(string codigoProducto, int cantidadVenta)
        {
            // Construir la consulta SQL para obtener la cantidad disponible del producto con el código proporcionado
            string consulta = $"SELECT CANTIDADPRODUCTO FROM Productos WHERE CODIGOPRODUCTO = '{codigoProducto}'";

            // Ejecutar la consulta y obtener el resultado en forma de DataTable
            // Extraer la cantidad del producto de la primera fila y primera columna del resultado
            string cantidadProductoStr = Conexion.EjecutarConsulta(consulta).Rows[0][0].ToString();

            // Convertir la cantidad del producto a un entero
            int cantidadProducto = int.Parse(cantidadProductoStr);

            // Retornar verdadero si la cantidad de venta es menor o igual a la cantidad disponible del producto
            return cantidadVenta <= cantidadProducto;
        }

        public static DataTable ObtenerProducto(string codigoProducto)
        {
            // Construir la consulta SQL para obtener el producto con el código proporcionado
            string consulta = $"SELECT * FROM Productos WHERE CODIGOPRODUCTO = '{codigoProducto}'";

            // Ejecutar la consulta y obtener el resultado en forma de DataTable
            // Retornar el DataTable que contiene el resultado de la consulta
            return Conexion.EjecutarConsulta(consulta);
        }

        public static int RegistrarVenta(string codigoVenta, string nombreVenta, int cantidadVenta, decimal precioVenta)
        {
            // Obtener el último ID de venta
            int idVenta = Conexion.ObtenerUltimoIdVenta();

            // Construir el comando SQL para insertar la venta en la tabla Ventas
            string comando = $"INSERT INTO Ventas (CODIGOVENTAPRODUCTO, NOMBREVENTAPRODUCTO, CANTIDADVENTAPRODUCTO, PRECIOVENTAPRODUCTO, IDVENTA) " +
                $"VALUES ('{codigoVenta}', '{nombreVenta}', '{cantidadVenta}', '{precioVenta}', {idVenta})";

            // Ejecutar el comando y retornar el número de filas afectadas
            return Conexion.EjecutarComando(comando);
        }

        public static int ActualizarCantidadProducto(string codigoProducto, int cantidadVenta)
        {
            // Construir el comando SQL para actualizar la cantidad del producto
            string comando = $"UPDATE Productos SET CANTIDADPRODUCTO = CANTIDADPRODUCTO - {cantidadVenta} WHERE CODIGOPRODUCTO = '{codigoProducto}'";

            // Ejecutar el comando y retornar el número de filas afectadas
            return Conexion.EjecutarComando(comando);
        }

        public static int ObtenerUltimoIdVenta()
        {
            //llama de la clase conexion al metodo obtener ultimo idventa
            return Conexion.ObtenerUltimoIdVenta();
        }

    }
}
