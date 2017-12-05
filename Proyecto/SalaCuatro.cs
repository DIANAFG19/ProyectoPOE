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
    public partial class SalaCuatro : Form
    {
        public float acumulador = 0f;
        public bool algo;
        public SalaCuatro()
        {
            InitializeComponent();
        }

        public static int BuscarA(int id)
        {
            int validar = 0;
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand busqueda = new OleDbCommand();
            busqueda.Connection = Bienvenido.con;
            busqueda.CommandText = @"SELECT * FROM SalaCuatro";
            OleDbDataReader reader = busqueda.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToString(id) == reader.GetValue(0).ToString())
                {
                    if (reader.GetValue(1).ToString() == "Disponible")
                    {
                        int algo = 1;
                        validar = algo;
                    }
                    else if (reader.GetValue(1).ToString() == "Ocupado")
                    {
                        int algo = 2;
                        validar = algo;
                    }
                }
            }
            Bienvenido.con.Close();
            return validar;
        }

        public void ActualizarEstado(int id, string estado)
        {
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand actualizar = new OleDbCommand();
            actualizar.Connection = Bienvenido.con;
            actualizar.CommandText = @"UPDATE SalaCuatro SET Estado = '" + estado + "' WHERE ID = " + id;
            actualizar.ExecuteNonQuery();
            Bienvenido.con.Close();
        }

        public string Asientos(int id)
        {
            string compra = "";
            if (BuscarA(id) == 1)
            {
                MessageBox.Show("Asiento Comprado");
                ActualizarEstado(id, "Ocupado");
                compra += "Asiento: " + id + "\r\n";
            }
            else if (BuscarA(id) == 2)
            {
                MessageBox.Show("Asiento NO Disponible");
            }
            else
            {
                MessageBox.Show("ERROR 443");
            }
            return compra;
        }

        public string AsientoCancelar(int id)
        {
            string cancelar = "";
            if (BuscarA(id) == 1)
            {
                MessageBox.Show("Asiento Comprado");
                ActualizarEstado(id, "Ocupado");
                cancelar += "Asiento " + id + "\r\n";
            }
            else if (BuscarA(id) == 2)
            {
                MessageBox.Show("Asiento Cancelado");
                ActualizarEstado(id, "Disponible");
            }
            else
            {
                MessageBox.Show("ERROR 443");
            }
            return cancelar;
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
                    mostrar += "    " + reader.GetValue(1).ToString() + "\r\n";
                }
            }
            Bienvenido.con.Close();
            return mostrar;
        }

        public string BuscarTodos()
        {
            string mostrar = "";
            Bienvenido.ConectarBD(Bienvenido.direccion);
            OleDbCommand busqueda = new OleDbCommand();
            busqueda.Connection = Bienvenido.con;
            busqueda.CommandText = @"SELECT * FROM SalaCuatro";
            OleDbDataReader reader = busqueda.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() == "Ocupado")
                {
                    mostrar = "YA NO HAY ASIENTOS DISPONIBLES";
                }
            }
            Bienvenido.con.Close();
            return mostrar;
        }

        public float PrecioAsientos()
        {
            float precio = 25.5f;
            return precio;
        }

        private void SalaCuatro_Load(object sender, EventArgs e)
        {
            algo = true;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            algo = true;
            tbCompra.Clear();
            MessageBox.Show("Su compra fue concluida con éxito");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbCompra.Clear();
            AsientoCancelar(Dulceria.id);
            string producto = Dulceria.BuscarUltimo();
            Dulceria.EliminarUltimo(Dulceria.id, producto);
            tbCompra.Text += BuscarId(Dulceria.id);
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbAsiento1_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(1);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #1", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #1", precio);
            }
        }

        private void pbAsiento2_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(2);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #2", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #2", precio);
            }
        }

        private void pbAsiento3_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(3);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #3", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #3", precio);
            }
        }

        private void pbAsiento4_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(4);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #4", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #4", precio);
            }
        }

        private void pbAsiento5_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(5);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #5", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #5", precio);
            }
        }

        private void pbAsiento6_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(6);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #6", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #6", precio);
            }
        }

        private void pbAsiento7_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(7);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #7", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #7", precio);
            }
        }

        private void pbAsiento8_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(8);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #8", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #8", precio);
            }
        }

        private void pbAsiento9_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(9);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #9", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #9", precio);
            }
        }

        private void pbAsiento10_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(10);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #10", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #10", precio);
            }
        }

        private void pbAsiento11_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(11);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #11", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #11", precio);
            }
        }

        private void pbAsiento12_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(12);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #12", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #12", precio);
            }
        }

        private void pbAsiento13_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(13);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #13", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #13", precio);
            }
        }

        private void pbAsiento14_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(14);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #14", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #14", precio);
            }
        }

        private void pbAsiento15_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(15);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #15", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #15", precio);
            }
        }

        private void pbAsiento16_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(16);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #16", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #16", precio);
            }
        }

        private void pbAsiento17_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(17);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #17", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #17", precio);
            }
        }

        private void pbAsiento18_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(18);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #18", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #18", precio);
            }
        }

        private void pbAsiento19_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(19);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #19", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #19", precio);
            }
        }

        private void pbAsiento20_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(20);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #20", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #20", precio);
            }
        }

        private void pbAsiento21_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(21);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #21", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #21", precio);
            }
        }

        private void pbAsiento22_Click(object sender, EventArgs e)
        {

        }

        private void pbAsiento23_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(23);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #23", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #23", precio);
            }
        }

        private void pbAsiento24_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(24);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #24", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #24", precio);
            }
        }

        private void pbAsiento25_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(25);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #25", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #25", precio);
            }
        }

        private void pbAsiento26_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(26);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #26", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #26", precio);
            }
        }

        private void pbAsiento27_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(27);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #27", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #27", precio);
            }
        }

        private void pbAsiento28_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(28);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #28", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #28", precio);
            }
        }

        private void pbAsiento29_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(25);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #29", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #29", precio);
            }
        }

        private void pbAsiento30_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(30);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #30", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #30", precio);
            }
        }

        private void pbAsiento31_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(31);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #31", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #31", precio);
            }
        }

        private void pbAsiento32_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(32);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #32", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #32", precio);
            }
        }

        private void pbAsiento33_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(33);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #33", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #33", precio);
            }
        }

        private void pbAsiento34_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(34);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #34", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #34", precio);
            }
        }

        private void pbAsiento35_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(35);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #35", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #35", precio);
            }
        }

        private void pbAsiento36_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(36);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #36", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #36", precio);
            }
        }

        private void pbAsiento37_Click(object sender, EventArgs e)
        {

        }

        private void pbAsiento38_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(38);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #38", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #38", precio);
            }
        }

        private void pbAsiento39_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(39);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #39", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #39", precio);
            }
        }

        private void pbAsiento40_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(40);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #40", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #40", precio);
            }
        }

        private void pbAsiento41_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(41);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #41", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #41", precio);
            }
        }

        private void pbAsiento42_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(42);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #42", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #42", precio);
            }
        }

        private void pbAsiento43_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(43);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #43", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #43", precio);
            }
        }

        private void pbAsiento44_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(44);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #44", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #44", precio);
            }
        }

        private void pbAsiento45_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(45);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #45", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #45", precio);
            }
        }

        private void pbAsiento46_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(46);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #46", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #46", precio);
            }
        }

        private void pbAsiento47_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(47);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #47", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #47", precio);
            }
        }

        private void pbAsiento48_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(48);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #48", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #48", precio);
            }
        }

        private void pbAsiento49_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(49);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #49", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #49", precio);
            }
        }

        private void pbAsiento50_Click(object sender, EventArgs e)
        {
            acumulador += PrecioAsientos();
            tbCompra.Text += Asientos(50);
            float precio = PrecioAsientos();
            if (algo == true)
            {
                Dulceria.id = Dulceria.IDFactura();
                Dulceria.Factura(Dulceria.id, "Asiento #50", precio);
                algo = false;
            }
            else
            {
                Dulceria.id = Dulceria.IDFacturaRepetida();
                Dulceria.Factura(Dulceria.id, "Asiento #50", precio);
            }
        }
    }
}
