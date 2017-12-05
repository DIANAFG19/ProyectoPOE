using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proyecto
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        public static string BuscarBD(string usuario)
        {
            string mostrar="";
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand busqueda = new OleDbCommand();
            busqueda.Connection = Bienvenido.con;
            busqueda.CommandText = @"SELECT * FROM USUARIOS";
            OleDbDataReader reader = busqueda.ExecuteReader();
            while (reader.Read())
            {
                if (usuario == reader.GetValue(1).ToString())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        mostrar += "    " + reader.GetValue(i).ToString() + "\r\n";
                    }
                }
            }
            Bienvenido.con.Close();
            return mostrar;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string usuario = tbNombre.Text;
            if (usuario == "")
            {
                MessageBox.Show("Ingrese el nombre de un usuario");
            }
            else
            {
                tbMostrar.Text += BuscarBD(usuario);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbMostrar.Clear();
            tbNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
