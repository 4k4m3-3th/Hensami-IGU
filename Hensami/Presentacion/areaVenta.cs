using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Logica;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class areaVenta : Form
    {
        private Reglas regla;
        public areaVenta()
        {
            InitializeComponent();
            regla = new Reglas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigoProducto = textBox1.Text.ToLower();

            bool existeProducto = regla.VerificarExistenciaProducto(codigoProducto);

            if (existeProducto)
            {
                MessageBox.Show("El producto está disponible para la venta.");
            }
            else
            {
                MessageBox.Show("El producto no existe o no está disponible para la venta.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int siguienteIdVenta = Reglas.ObtenerUltimoIdVenta();
            // Asignar el siguienteIdVenta al campo idVenta en el DataGridView
            string codigoProducto = textBox1.Text;
            int cantidadProducto = int.Parse(textBox2.Text);

            if (Reglas.ValidarExistenciaProducto(codigoProducto))
            {
                if (Reglas.ValidarCantidadDisponible(codigoProducto, cantidadProducto))
                {
                    DataTable producto = Reglas.ObtenerProducto(codigoProducto);

                    
                    dataGridView1.Rows.Add(siguienteIdVenta,producto.Rows[0]["CODIGOPRODUCTO"], producto.Rows[0]["NOMBREPRODUCTO"], cantidadProducto, producto.Rows[0]["PRECIOPRODUCTO"]);
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada supera la cantidad disponible del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El código de producto ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFilaSeleccionada = dataGridView1.SelectedRows[0].Index;

                // Eliminar la fila del DataGridView
                dataGridView1.Rows.RemoveAt(indiceFilaSeleccionada);

                MessageBox.Show("Producto eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar el producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Obtener los valores de las celdas de la fila actual en el DataGridView
                    string codigoProducto = row.Cells["codigoProducto"].Value != DBNull.Value ? row.Cells["codigoProducto"].Value.ToString() : string.Empty;
                    string nombreProducto = row.Cells["nombreProducto"].Value != DBNull.Value ? row.Cells["nombreProducto"].Value.ToString() : string.Empty;

                    // Verificar si se puede convertir el valor de la celda "cantidadProducto" a un entero
                    if (int.TryParse(row.Cells["cantidadProducto"].Value != DBNull.Value ? row.Cells["cantidadProducto"].Value.ToString() : "0", out int cantidadVenta))
                    {
                        // Verificar si se puede convertir el valor de la celda "precioProducto" a un decimal
                        if (decimal.TryParse(row.Cells["precioProducto"].Value != DBNull.Value ? row.Cells["precioProducto"].Value.ToString() : "0", out decimal precioVenta))
                        {
                            // Llamar al método RegistrarVenta de la clase Reglas y pasar los valores obtenidos
                            Reglas.RegistrarVenta(codigoProducto, nombreProducto, cantidadVenta, precioVenta);

                            // Llamar al método ActualizarCantidadProducto de la clase Reglas para actualizar la cantidad del producto
                            Reglas.ActualizarCantidadProducto(codigoProducto, cantidadVenta);

                        }
                        else
                        {
                            //Muestra mensaje
                            MessageBox.Show("El valor del precio de venta no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Muestra mensaje
                        MessageBox.Show("El valor de la cantidad de venta no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //Muestra mensaje
            MessageBox.Show("Venta realizada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Limpiar DataGridView después de pagar
            dataGridView1.Rows.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }


        private void areaVenta_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Muestra la venta panelMenu y se oculta esta
            this.Hide();
            panelMenu menu = new panelMenu();
            menu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Termina la ejecucion del programa
            System.Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                // Obtener el índice de la columna "cantidadProducto" en el DataGridView
                int indiceCantidad = dataGridView1.Columns["cantidadProducto"].Index;

                // Obtener la cantidad ingresada en el TextBox
                int nuevaCantidad = int.Parse(textBox2.Text);

                // Actualizar la cantidad en el DataGridView
                filaSeleccionada.Cells[indiceCantidad].Value = nuevaCantidad;

                //Muestra mensaje
                MessageBox.Show("Cantidad actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Muestra mensaje
                MessageBox.Show("Seleccione una fila para actualizar la cantidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
