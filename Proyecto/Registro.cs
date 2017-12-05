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
    public partial class Registro : Form
    {
        public static int id;

        public static int GenerarID()
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            int ultimo = 0;
            OleDbCommand buscaU = new OleDbCommand();
            buscaU.Connection = Bienvenido.con;
            buscaU.CommandText = @"SELECT ID FROM USUARIOS";
            OleDbDataReader reader = buscaU.ExecuteReader();
            while (reader.Read())
            {
                string algo = reader.GetValue(0).ToString();
                ultimo = Convert.ToInt16(algo);
            }
            ultimo += 1;
            Bienvenido.con.Close();
            return ultimo;
        }

        public void Registrar(int id, string usuario, string contra, string correo, string rango)
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand guardar = new OleDbCommand();
            guardar.Connection = Bienvenido.con;
            guardar.CommandText = @"INSERT INTO USUARIOS VALUES('" + id + "','" + usuario + "','" + contra + "','" + correo + "','" + rango + "')"; 
            guardar.ExecuteNonQuery();
            Bienvenido.con.Close();
        }

        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contras = tbContras.Text;
            string ccontras = tbCContras.Text;
            string correo = tbCorreo.Text;
            int id = GenerarID();
            if (usuario == "" || contras == "" || ccontras == "" || correo == "" || (cbRangoAdmin.Checked == false && cbRangoUsuario.Checked == false))
            {
                MessageBox.Show("No puede dejar campos vacíos");
            }
            else
            {
                if (contras == ccontras)
                {
                    if (cbRangoAdmin.Checked)
                    {
                        string rango = "Administrador";
                        Registrar(id,usuario, contras, correo, rango);
                        MessageBox.Show("Registro Exitoso");
                    }
                    else if (cbRangoUsuario.Checked)
                    {
                        string rango = "Usuario";
                        Registrar(id,usuario, contras, correo, rango);
                        MessageBox.Show("Registro Exitoso");
                    }
                }
                else
                {
                    MessageBox.Show("Las Contraseñas no Coinciden");
                }
            }
            tbUsuario.Clear();
            tbContras.Clear();
            tbCContras.Clear();
            tbCorreo.Clear();
            cbRangoAdmin.Checked = false;
            cbRangoUsuario.Checked = false;
            tbUsuario.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbUsuario.Clear();
            tbContras.Clear();
            tbCContras.Clear();
            tbCorreo.Clear();
            cbRangoAdmin.Checked = false;
            cbRangoUsuario.Checked = false;
            tbUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
