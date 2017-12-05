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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        public static string BuscarFacturaPro(int id)
        {
            string mostrar = "";
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand busqueda = new OleDbCommand();
            busqueda.Connection = Bienvenido.con;
            busqueda.CommandText = @"SELECT * FROM Facturas";
            OleDbDataReader reader = busqueda.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToString(id) == reader.GetValue(0).ToString())
                {
                    mostrar += "    " + reader.GetValue(1).ToString() + "\r\n";
                }
            }
            Bienvenido.con.Close();
            return mostrar;
        }

        public static string BuscarFacturaPre(int id)
        {
            string mostrar = "";
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand busqueda = new OleDbCommand();
            busqueda.Connection = Bienvenido.con;
            busqueda.CommandText = @"SELECT * FROM Facturas";
            OleDbDataReader reader = busqueda.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToString(id) == reader.GetValue(0).ToString())
                {
                    mostrar += "  $  " + reader.GetValue(2).ToString() + "\r\n";
                }
            }
            Bienvenido.con.Close();
            return mostrar;
        }

        public static float Total(int id)
        {
            float total = 0f;
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand busqueda = new OleDbCommand();
            busqueda.Connection = Bienvenido.con;
            busqueda.CommandText = @"SELECT * FROM Facturas";
            OleDbDataReader reader = busqueda.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToString(id) == reader.GetValue(0).ToString())
                {
                    string mostrar = reader.GetValue(2).ToString();
                    total += Convert.ToSingle(mostrar);
                }
            }
            Bienvenido.con.Close();
            return total;
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            tbProducto.Clear();
            tbPrecio.Clear();
            labelFecha.Text = DateTime.Today.ToLongDateString();
            labelNombre.Text = Acceso.usuario;
            labelTotal.Text = " $ " + Convert.ToString(Total(Dulceria.id)) + " pesos";
            labelFactura.Text = Convert.ToString(Dulceria.id);
            tbProducto.Text = BuscarFacturaPro(Dulceria.id);
            tbPrecio.Text = BuscarFacturaPre(Dulceria.id);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
