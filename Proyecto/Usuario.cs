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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void pbDulces_Click(object sender, EventArgs e)
        {
            Dulceria dulces = new Dulceria();
            dulces.Show();
        }

        private void pbSalas_Click(object sender, EventArgs e)
        {
            Salas sala = new Salas();
            sala.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
