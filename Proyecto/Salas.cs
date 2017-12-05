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
    public partial class Salas : Form
    {
        public Salas()
        {
            InitializeComponent();
        }

        private void pbSala1_Click(object sender, EventArgs e)
        {
            SalaUno salaUno = new SalaUno();
            salaUno.Show();
        }

        private void pbSala2_Click(object sender, EventArgs e)
        {
            SalaDos salaDos = new SalaDos();
            salaDos.Show();
        }

        private void pbSala3_Click(object sender, EventArgs e)
        {
            SalaTres salaTres = new SalaTres();
            salaTres.Show();
        }

        private void pbSala4_Click(object sender, EventArgs e)
        {
            SalaCuatro salaCuatro = new SalaCuatro();
            salaCuatro.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
