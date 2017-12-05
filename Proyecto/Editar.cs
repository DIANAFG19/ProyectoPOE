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
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(int id, string nombre)
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand actuNombre = new OleDbCommand();
            actuNombre.Connection = Bienvenido.con;
            actuNombre.CommandText = @"UPDATE USUARIOS SET NOMBRE = '" + nombre + "' WHERE ID = " + id;
            actuNombre.ExecuteNonQuery();
            Bienvenido.con.Close();
        }
        public void ActualizarContra(int id, string contras)
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand actuContra = new OleDbCommand();
            actuContra.Connection = Bienvenido.con;
            actuContra.CommandText = @"UPDATE USUARIOS SET PASSWORD = '" + contras + "' WHERE ID = " + id;
            actuContra.ExecuteNonQuery();
            Bienvenido.con.Close();
        }
        public void ActualizarCorreo(int id, string correo)
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand actuCorreo = new OleDbCommand();
            actuCorreo.Connection = Bienvenido.con;
            actuCorreo.CommandText = @"UPDATE USUARIOS SET CORREO = '" + correo + "' WHERE ID = " + id;
            actuCorreo.ExecuteNonQuery();
            Bienvenido.con.Close();
        }
        public void ActualizarRango(int id, string rango)
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand actuRango = new OleDbCommand();
            actuRango.Connection = Bienvenido.con;
            actuRango.CommandText = @"UPDATE USUARIOS SET RANGO = '" + rango + "' WHERE ID = " + id;
            actuRango.ExecuteNonQuery();
            Bienvenido.con.Close();
        }

        public static string BuscarId(int id)
        {
            string mostrar = "";
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand busqueda = new OleDbCommand();
            busqueda.Connection = Bienvenido.con;
            busqueda.CommandText = @"SELECT * FROM USUARIOS";
            OleDbDataReader reader = busqueda.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToString(id) == reader.GetValue(0).ToString())
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
            if(tbUsuario.Text == "")
            {
                MessageBox.Show("Ingrese por favor, un usuario");
            }
            else
            {
                tbMostrar.Text += Buscar.BuscarBD(tbUsuario.Text);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbUsuario.Clear();
            tbNuevoNombre.Clear();
            tbNuevaContra.Clear();
            tbRNuevaContra.Clear();
            tbNuevoCorreo.Clear();
            cbUsuario.Checked = false;
            cbContra.Checked = false;
            cbCorreo.Checked = false;
            cbRango.Checked = false;
            cbNRangoAdmin.Checked = false;
            cbNRangoUsuario.Checked = false;
            tbUsuario.Focus();
            tbMostrar.Clear();
            tbId.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbId.Text);
            string nombre = tbNuevoNombre.Text;
            string contras = tbNuevaContra.Text;
            string correo = tbNuevaContra.Text;
            if (cbUsuario.Checked)
            {
                ActualizarNombre(id, nombre);
                MessageBox.Show("Actualización de Datos exitosa");
            }
            if (cbContra.Checked)
            {
                if (tbNuevaContra.Text == tbRNuevaContra.Text)
                {
                    ActualizarContra(id, contras);
                    MessageBox.Show("Actualización de Datos exitosa");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            if (cbCorreo.Checked)
            {
                ActualizarCorreo(id, correo);
                MessageBox.Show("Actualización de Datos exitosa");
            }
            if (cbRango.Checked)
            {
                if (cbNRangoAdmin.Checked)
                {
                    string rango = "Administrador";
                    ActualizarRango(id, rango);
                    MessageBox.Show("Actualización de Datos exitosa");
                }
                else if (cbNRangoUsuario.Checked)
                {
                    string rango = "Usuario";
                    ActualizarRango(id, rango);
                    MessageBox.Show("Actualización de Datos exitosa");
                }
            }
            tbMostrar.Clear();
            tbMostrar.Text += BuscarId(id);
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            tbNuevoNombre.Enabled = false;
            tbNuevaContra.Enabled = false;
            tbRNuevaContra.Enabled = false;
            tbNuevoCorreo.Enabled = false;
            cbNRangoAdmin.Enabled = false;
            cbNRangoUsuario.Enabled = false;
            if (cbUsuario.Checked)
            {
                tbNuevoNombre.Enabled = true;
            }
            if (cbContra.Checked)
            {
                tbNuevaContra.Enabled = true;
                tbRNuevaContra.Enabled = true;
            }
            if (cbCorreo.Checked)
            {
                tbNuevoCorreo.Enabled = true;
            }
            if (cbRango.Checked)
            {
                cbNRangoAdmin.Enabled = true;
                cbNRangoUsuario.Enabled = true;
            }
        }
    }
}
