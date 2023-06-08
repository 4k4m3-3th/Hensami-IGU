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
    public partial class panelMenu : Form
    {
        public panelMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Muestra la venta areaProductos y se oculta esta
            areaProductos area = new areaProductos();
            this.Hide();
            area.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Muestra la venta areaVenta y se oculta esta
            areaVenta venta = new areaVenta();
            this.Hide();
            venta.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Muestra la venta login y se oculta esta
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //termina la ejecucion del programa
            System.Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Muestra la venta areaInversion y se oculta esta
            areaInversion inversion = new areaInversion();
            this.Hide();
            inversion.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Muestra la venta areaCreditos y se oculta esta
            areaCreditos creditos = new areaCreditos();
            this.Hide();
            creditos.Show();
        }
    }
}
