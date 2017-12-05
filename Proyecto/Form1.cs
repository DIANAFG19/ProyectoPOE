using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace Proyecto
{
    public partial class Bienvenido : Form
    {
        public static OleDbConnection con;
        public static string direccion;
        public int intentos = 1;
        public Bienvenido()
        {
            InitializeComponent();
        }

        public static bool ConectarBD(string direccion)
        {
            bool permitir = false;
            string stringConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + direccion;
            try
            {
                con = new OleDbConnection(@stringConexion);
                con.Open();
                permitir = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            return permitir;
        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            etiquetaFecha.Text = DateTime.Today.ToLongDateString();
            btnAcceso.Enabled = false;
            btnRegistro.Enabled = false;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            Acceso acceso = new Acceso();
            acceso.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (intentos < 3)
            {
                direccion = textBox1.Text;
                if (direccion == "")
                {
                    MessageBox.Show("Tienes que ingresar la dirección de tu Base de Datos");
                }
                else
                {
                    if (ConectarBD(direccion) == true)
                    {
                        MessageBox.Show("Conexión a la Base de Datos exitosa");
                        btnRegistro.Enabled = true;
                        btnAcceso.Enabled = true;
                    }
                }
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Haz desperdiciado tus intentos de conectarte");
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            intentos += 1;
        }
    }
}
