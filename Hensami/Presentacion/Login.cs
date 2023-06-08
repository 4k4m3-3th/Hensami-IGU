using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Logica;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class Login : Form
    {
        private Reglas regla;


        public Login()
        {
            InitializeComponent();
            regla = new Reglas();
        }

        private void btoLogin_Click(object sender, EventArgs e)
        {
            //obtiene el usuario y contraseña ingresada por el usuario
            string usuario = txtUser.Text.ToLower();
            string contrasena = txtPass.Text.ToLower();

            //llama a la clase regla, metodo verificar credenciales
            if (regla.VerificarCredenciales(usuario, contrasena))
            {
                // Las credenciales son válidas, puedes abrir la siguiente interfaz
                panelMenu formPanelMenu = new panelMenu();
                formPanelMenu.Show();
                this.Hide();
            }
            else
            {
                // Las credenciales no son válidas, muestra un mensaje de error al usuario
                MessageBox.Show("Credenciales inválidas. Inténtalo de nuevo.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Termina la ejecucion del programa
            System.Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
