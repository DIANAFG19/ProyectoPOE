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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        public static void EliminarBD(int id)
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand eliminar = new OleDbCommand();
            eliminar.Connection = Bienvenido.con;
            eliminar.CommandText = @"DELETE FROM USUARIOS WHERE ID = " + id;
            eliminar.ExecuteNonQuery();
            Bienvenido.con.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tbMostrar.Text += Buscar.BuscarBD(tbUsuario.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbUsuario.Clear();
            tbMostrar.Clear();
            tbUsuario.Focus();
            tbID.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(tbID.Text);
            EliminarBD(id);
            MessageBox.Show("Usuario Eliminado con éxito");
            tbUsuario.Clear();
            tbMostrar.Clear();
            tbUsuario.Focus();
            tbID.Clear();
        }
    }
}
