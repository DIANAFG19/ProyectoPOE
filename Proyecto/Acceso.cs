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
    public partial class Acceso : Form
    {
        public static OleDbConnection con;
        public static string usuario;
        public int intentos = 1;
        public Acceso()
        {
            InitializeComponent();
        }

        public int Ingreso(string usuario, string contra)
        {
            int validar = 0;
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand buscar = new OleDbCommand();
            buscar.Connection = Bienvenido.con;
            buscar.CommandText = @"SELECT * FROM USUARIOS";
            OleDbDataReader reader = buscar.ExecuteReader();
            while (reader.Read())
            {
                if (usuario == reader.GetValue(1).ToString() && contra == reader.GetValue(2).ToString())
                {
                    if (reader.GetValue(4).ToString() == "Administrador")
                    {
                        int algo = 1;
                        validar = algo;
                    }
                    else if (reader.GetValue(4).ToString() == "Usuario")
                    {
                        int algo = 2;
                        validar = algo;
                    }
                }
            }
            Bienvenido.con.Close();
            return validar;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (intentos < 3)
            {
                usuario = tbUsuario.Text;
                string contras = tbContras.Text;
                if (usuario == "" || contras == "")
                {
                    MessageBox.Show("Por favor, debe de ingresar usuario y/o contraseña");
                }
                else
                {
                    if (Ingreso(usuario, contras) == 1)
                    {
                        MessageBox.Show("Bienvenido Administrador");
                        Administrador administrador = new Administrador();
                        administrador.Show();
                    }
                    else if (Ingreso(usuario, contras) == 2)
                    {
                        MessageBox.Show("Bienvenido Usuario");
                        Usuario user = new Usuario();
                        user.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario y/o la contraseña estan incorrectos o el usuario no existe");
                    }
                }
                tbUsuario.Clear();
                tbContras.Clear();
            }
            else
            {
                MessageBox.Show("Haz desperdiciado tus intentos de Accesar");
                tbContras.Enabled = false;
                tbUsuario.Enabled = false;
                btnIngresar.Enabled = false;
            }
            intentos += 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
