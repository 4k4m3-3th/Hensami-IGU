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
    public partial class areaCreditos : Form
    {
        public areaCreditos()
        {
            InitializeComponent();
        }

        private void areaCreditos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Muestra la venta panelMenu y se oculta esta
            panelMenu menu = new panelMenu();
            this.Hide();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //termina la ejecucion del programa
            System.Environment.Exit(0);
        }
    }
}
