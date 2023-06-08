using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class areaInversion : Form
    {
        public areaInversion()
        {
            InitializeComponent();
        }

        private void areaInversion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Muestra la venta panelMenu y se oculta esta
            panelMenu menu = new panelMenu();
            this.Hide();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //termina la ejecucion del programa
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //obtiene los datos ingresados en los textbox
                decimal inversion = decimal.Parse(textBox1.Text);
                decimal gastos = decimal.Parse(textBox2.Text);

                //realiza una operacion basica
                decimal resultado = inversion - gastos;

                //muestra mensaje
                MessageBox.Show($"Su balance es: {resultado}", "Resultado");
            }
            catch (Exception ex)
            {
                //muestra mensaje
                MessageBox.Show($"Error al calcular el resultado: {ex.Message}", "Error");
            }
        }
    }
}
