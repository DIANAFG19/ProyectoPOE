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
    public partial class Dulceria : Form
    {
        public static float acumulador = 0f;
        public static int id;
        public bool algo = false;
        public Dulceria()
        {
            InitializeComponent();
        }

        public static float precioPalomitas(string tamano)
        {
            float precio = 0f;
            if (tamano == "Chico")
            {
                precio = 20f;
            }
            else if (tamano == "Mediano")
            {
                precio = 35f;
            }
            else if (tamano == "Grande")
            {
                precio = 45.5f;
            }
            return precio;
        }
        public static float precioRefrescos(string tamano)
        {
            float precio = 0f;
            if (tamano == "Chico")
            {
                precio = 15f;
            }
            else if (tamano == "Mediano")
            {
                precio = 20f;
            }
            else if (tamano == "Grande")
            {
                precio = 35f;
            }
            return precio;
        }
        public static float precioNachos(string tamano)
        {
            float precio = 0f;
            if (tamano == "Chico")
            {
                precio = 20f;
            }
            else if (tamano == "Mediano")
            {
                precio = 25.5f;
            }
            else if (tamano == "Grande")
            {
                precio = 35.5f;
            }
            return precio;
        }
        public static float precioChocolate(string marca)
        {
            float precio = 0f;
            if (marca == "Snikers")
            {
                precio = 15.75f;
            }
            else if (marca == "Abuelita")
            {
                precio = 12.5f;
            }
            else if (marca == "Carlos V")
            {
                precio = 13f;
            }
            else if (marca == "Kranky")
            {
                precio = 9.5f;
            }
            else if (marca == "Bubu Lubu")
            {
                precio = 10.75f;
            }
            else if (marca == "Trufas")
            {
                precio = 18.5f;
            }
            return precio;
        }
        public static float precioGomitas(string tamano)
        {
            float precio = 0f;
            if (tamano == "Chicas")
            {
                precio = 8.5f;
            }
            else if (tamano == "Medianas")
            {
                precio = 15f;
            }
            else if (tamano == "Grandes")
            {
                precio = 22.75f;
            }
            return precio;
        }
        public static float precioPapas(string tamano)
        {
            float precio = 0f;
            if (tamano == "Chicas")
            {
                precio = 13.5f;
            }
            else if (tamano == "Medianas")
            {
                precio = 20f;
            }
            else if (tamano == "Grandes")
            {
                precio = 30f;
            }
            return precio;
        }

        public static int IDFactura()
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            int ultimo = 100;
            OleDbCommand buscaU = new OleDbCommand();
            buscaU.Connection = Bienvenido.con;
            buscaU.CommandText = @"SELECT * FROM Facturas";
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

        public static int IDFacturaRepetida()
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            int ultimo = 0;
            int ultimoR;
            OleDbCommand buscaU = new OleDbCommand();
            buscaU.Connection = Bienvenido.con;
            buscaU.CommandText = @"SELECT * FROM Facturas";
            OleDbDataReader reader = buscaU.ExecuteReader();
            while (reader.Read())
            {
                string algo = reader.GetValue(0).ToString();
                ultimo = Convert.ToInt16(algo);
            }
            ultimoR = ultimo;
            Bienvenido.con.Close();
            return ultimoR;
        }

        public static void Factura(int id, string producto, float precio)
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand guardar = new OleDbCommand();
            guardar.Connection = Bienvenido.con;
            guardar.CommandText = @"INSERT INTO Facturas VALUES('" + id + "','" + producto + "','" + precio + "')";
            guardar.ExecuteNonQuery();
            Bienvenido.con.Close();
        }

        public static string BuscarUltimo()
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            string ultimo = "";
            string eliminado;
            OleDbCommand buscaU = new OleDbCommand();
            buscaU.Connection = Bienvenido.con;
            buscaU.CommandText = @"SELECT * FROM Facturas";
            OleDbDataReader reader = buscaU.ExecuteReader();
            while (reader.Read())
            {
                string algo = reader.GetValue(1).ToString();
                ultimo = algo;
            }
            eliminado = ultimo;
            Bienvenido.con.Close();
            return eliminado;
        }
        public static void EliminarUltimo(int id, string producto)
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand eliminar = new OleDbCommand();
            eliminar.Connection = Bienvenido.con;
            eliminar.CommandText = @"DELETE FROM Facturas WHERE Producto = '" + producto + "' AND Id = " + id;
            eliminar.ExecuteNonQuery();
            Bienvenido.con.Close();
        }
        public string BuscarId(int id)
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
                    mostrar += "    " + reader.GetValue(2).ToString() + "\r\n";
                }
            }
            Bienvenido.con.Close();
            return mostrar;
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            algo = true;
            tbCompras.Clear();
            Factura factura = new Factura();
            factura.Show();
        }
        private void Dulceria_Load(object sender, EventArgs e)
        {
            algo = true;
        }

        private void SelectIndexChanged_cbPalomitas(object sender, EventArgs e)
        {
            acumulador += precioPalomitas(cbPalomitas.Text);
            tbCompras.Text += Convert.ToString(precioPalomitas(cbPalomitas.Text)) + "\r\n";
            if (algo == true)
            {
                id = IDFactura();
                float precio = precioPalomitas(cbPalomitas.Text);
                Factura(id, "Palomitas", precio);
                algo = false;
            }
            else
            {
                id = IDFacturaRepetida();
                float precio = precioPalomitas(cbPalomitas.Text);
                Factura(id, "Palomitas", precio);
            }
        }

        private void SelectIndexChanged_cbRefrescos(object sender, EventArgs e)
        {
            acumulador += precioRefrescos(cbRefrescos.Text);
            tbCompras.Text += Convert.ToString(precioRefrescos(cbRefrescos.Text)) + "\r\n"; ;
            if (algo == true)
            {
                id = IDFactura();
                float precio = precioRefrescos(cbRefrescos.Text);
                Factura(id, "Refresco", precio);
                algo = false;
            }
            else
            {
                id = IDFacturaRepetida();
                float precio = precioRefrescos(cbRefrescos.Text);
                Factura(id, "Refresco", precio);
            }
        }

        private void SelectIndezChanged_cbNachos(object sender, EventArgs e)
        {
            acumulador += precioNachos(cbNachos.Text);
            tbCompras.Text += Convert.ToString(precioNachos(cbNachos.Text)) + "\r\n";
            if (algo == true)
            {
                id = IDFactura();
                float precio = precioNachos(cbNachos.Text);
                Factura(id, "Nachos", precio);
                algo = false;
            }
            else
            {
                id = IDFacturaRepetida();
                float precio = precioNachos(cbNachos.Text);
                Factura(id, "Nachos", precio);
            }
        }

        private void SelectIndezChanged_cbChocolate(object sender, EventArgs e)
        {
            acumulador += precioChocolate(cbChocolate.Text);
            tbCompras.Text += Convert.ToString(precioChocolate(cbChocolate.Text)) + "\r\n";
            if (algo == true)
            {
                id = IDFactura();
                float precio = precioChocolate(cbChocolate.Text);
                Factura(id, "Chocolate", precio);
                algo = false;
            }
            else
            {
                id = IDFacturaRepetida();
                float precio = precioChocolate(cbChocolate.Text);
                Factura(id, "Chocolate", precio);
            }
        }

        private void SelectIndexChanged_cbGomitas(object sender, EventArgs e)
        {
            acumulador += precioGomitas(cbGomitas.Text);
            tbCompras.Text += Convert.ToString(precioGomitas(cbGomitas.Text)) + "\r\n";
            if (algo == true)
            {
                id = IDFactura();
                float precio = precioGomitas(cbGomitas.Text);
                Factura(id, "Gomitas", precio);
                algo = false;
            }
            else
            {
                id = IDFacturaRepetida();
                float precio = precioGomitas(cbGomitas.Text);
                Factura(id, "Gomitas", precio);
            }
        }

        private void SelectIndexChange_cbPapas(object sender, EventArgs e)
        {
            acumulador += precioPapas(cbPapas.Text);
            tbCompras.Text += Convert.ToString(precioPapas(cbPapas.Text)) + "\r\n";
            if (algo == true)
            {
                id = IDFactura();
                float precio = precioPapas(cbPapas.Text);
                Factura(id, "Papas a la Francesa", precio);
                algo = false;
            }
            else
            {
                id = IDFacturaRepetida();
                float precio = precioPapas(cbPapas.Text);
                Factura(id, "Papas a la Francesa", precio);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbPalomitas.Text = null;
            cbRefrescos.Text = null;
            cbChocolate.Text = null;
            cbNachos.Text = null;
            cbGomitas.Text = null;
            cbPapas.Text = null;
            tbCompras.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbCompras.Clear();
            string producto = BuscarUltimo();
            EliminarUltimo(id, producto);
            tbCompras.Text += BuscarId(id);
        }
    }
}
