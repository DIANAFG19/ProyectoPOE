using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro registrar = new Registro();
            registrar.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            editar.Show();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar busqueda = new Buscar();
            busqueda.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
