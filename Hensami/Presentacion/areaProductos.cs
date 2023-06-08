using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Datos.Conexion;
using Logica;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class areaProductos : Form
    {
        private Logica.Reglas regla;
        private DataTable dataTable;


        public areaProductos()
        {
            InitializeComponent();
            regla = new Logica.Reglas();
        }

        private void areaProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string codigoProducto = textBox1.Text.ToLower();
            string nombreProducto = textBox2.Text.ToLower();
            string cantidadProducto = textBox3.Text.ToLower();
            string precioProducto = textBox4.Text.ToLower();

            if (regla.VerificarExistenciaProducto(codigoProducto))
            {
                // Mostrar mensaje de código de producto duplicado
                MessageBox.Show("El código del producto ya existe. Introduce un código diferente.");
                return;
            }

            // Crear un objeto Producto con los valores ingresados
            Producto producto = new Producto(codigoProducto, nombreProducto, cantidadProducto, precioProducto);

            // Llamar al método de la Capa de Lógica para agregar el producto
            bool exito = regla.AgregarProducto(producto);

            if (exito)
            {
                //Muestra un mensaje si se agrego correctamente
                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpia los campos 
                LimpiarCampos();

                //vuelve a mostrar los productos
                CargarProductos();
            }
            else
            {
                //Muestra un mensaje
                MessageBox.Show("No se pudo agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el código del producto seleccionado
                string codigoProducto = dataGridView1.SelectedRows[0].Cells["codigoProducto"].Value.ToString();

                // Mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Llamar al método de la Capa de Lógica para eliminar el producto
                    bool exito = regla.EliminarProducto(codigoProducto);

                    if (exito)
                    {
                        // Mostrar mensaje de producto eliminado correctamente
                        MessageBox.Show("Producto eliminado correctamente.");

                        // Actualizar la tabla de productos
                        CargarProductos();
                    }
                    else
                    {
                        // Mostrar mensaje de error al eliminar el producto
                        MessageBox.Show("No se pudo eliminar el producto.");
                    }
                }
            }
            else
            {
                // Mostrar mensaje indicando que no se ha seleccionado ningún producto
                MessageBox.Show("No se ha seleccionado ningún producto.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener los valores de las celdas seleccionadas en el DataGridView
                string codigoProducto = dataGridView1.SelectedRows[0].Cells["codigoProducto"].Value.ToString();
                string nombreProducto = dataGridView1.SelectedRows[0].Cells["nombreProducto"].Value.ToString();
                string cantidadProducto = dataGridView1.SelectedRows[0].Cells["cantidadProducto"].Value.ToString();
                string precioProducto = dataGridView1.SelectedRows[0].Cells["precioProducto"].Value.ToString();

                // Obtener los nuevos valores ingresados en los TextBox
                string nuevoNombreProducto = textBox2.Text.ToLower();
                string nuevaCantidadProducto = textBox3.Text.ToLower();
                string nuevoPrecioProducto = textBox4.Text.ToLower();

                // Verificar si los campos nuevos no están vacíos
                if (!string.IsNullOrEmpty(nuevoNombreProducto) && !string.IsNullOrEmpty(nuevaCantidadProducto) && !string.IsNullOrEmpty(nuevoPrecioProducto))
                {

                    // Verifica si el código del producto contiene símbolos inválidos
                    if (!Regex.IsMatch(codigoProducto, @"^[a-zA-Z0-9]+$"))
                    {
                        MessageBox.Show("El código de producto contiene símbolos inválidos.");
                        return;
                    }

                    // Verificar si el nombre del producto contiene números o símbolos inválidos
                    if (!Regex.IsMatch(nuevoNombreProducto, @"^[a-zA-Z]+$"))
                    {
                        MessageBox.Show("El nombre de producto contiene números o símbolos inválidos.");
                        return;
                    }

                    // Verificar si la cantidad del producto contiene letras o símbolos inválidos
                    if (!Regex.IsMatch(nuevaCantidadProducto, @"^[0-9]+$"))
                    {
                        MessageBox.Show("La cantidad de producto contiene letras o símbolos inválidos.");
                        return;
                    }

                    // Verificar si el precio del producto contiene letras o símbolos inválidos
                    if (!Regex.IsMatch(nuevoPrecioProducto, @"^[0-9.]+$"))
                    {
                        MessageBox.Show("El precio de producto contiene letras o símbolos inválidos.");
                        return;
                    }

                    // Llamar al método ActualizarProducto de la clase regla y pasar los nuevos valores
                    bool exito = regla.ActualizarProducto(codigoProducto, nuevoNombreProducto, nuevaCantidadProducto, nuevoPrecioProducto);

                    if (exito)
                    {
                        //Muestra mensaje, limpia los campos y actualiza
                        MessageBox.Show("Producto actualizado correctamente.");
                        LimpiarCampos();
                        CargarProductos();
                    }
                    else
                    {
                        //muestra mensaje
                        MessageBox.Show("No se pudo actualizar el producto.");
                    }
                }
                else
                {
                    //muestra mensaje
                    MessageBox.Show("Por favor, ingrese valores en los campos de nombre, cantidad y precio del producto.");
                }
            }
            else
            { 
                //muestra mensaje
                MessageBox.Show("No se ha seleccionado ningún producto.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Muestra la venta panelMenu y se oculta esta
            this.Hide();
            panelMenu menu = new panelMenu();
            menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Termina el programa
            System.Environment.Exit(0);
        }

        private void CargarProductos()
        {
            //Muestra los productos
            dataTable = regla.ObtenerProductos();
            dataGridView1.DataSource = dataTable;
        }

        private void LimpiarCampos()
        {
            //Limpia los textbox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

    }
}
