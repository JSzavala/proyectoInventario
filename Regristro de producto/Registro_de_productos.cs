using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyectoInventario
{
    public partial class RegistrarProducto : Form
    {
        string conexion = "Server=localhost;Database=VENTAS;Uid=root;Pwd=;";

        public RegistrarProducto()
        {
            InitializeComponent();
            CargarProductos();
        }

        // ==========================================
        //           OBTENER PRODUCTOS
        // ==========================================
        public List<Producto> ObtenerProductos()
        {
            List<Producto> lista = new List<Producto>();

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                string query = "SELECT CLAVE, NOMBRE, PRECIO, STOCK FROM Producto";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Producto
                    {
                        Clave = dr.GetString("CLAVE"),
                        Nombre = dr.GetString("NOMBRE"),
                        Precio = dr.GetDecimal("PRECIO"),
                        Stock = dr.GetInt32("STOCK")
                    });
                }
            }

            return lista;
        }

        // ==========================================
        //           CARGAR DATOS AL GRID
        // ==========================================
        public void CargarProductos()
        {
            dgvProductos.DataSource = ObtenerProductos();
        }

        // ==========================================
        //           BOTÓN VOLVER
        // ==========================================
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Main ventanaPrincipal = new Main();  // Nombre correcto tu ventana inicial
            ventanaPrincipal.Show();
            this.Close();
        }

        // ==========================================
        //         AGREGAR PRODUCTO NUEVO
        // ==========================================
        private void btnAgregarInv_Click(object sender, EventArgs e)
        {
            string id = txtIDProducto.Text;
            string nombre = txtNombreProducto.Text;
            decimal precio;
            int stock;

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Ingrese un ID de producto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese un nombre de producto.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            if (!int.TryParse(txtStockInicial.Text, out stock))
            {
                MessageBox.Show("Ingrese un stock inicial válido.");
                return;
            }

            // Revisar si ya existe
            var productos = ObtenerProductos();
            if (productos.Any(p => p.Clave == id))
            {
                MessageBox.Show("Este ID ya existe. Use otro.");
                return;
            }

            // Insertar en BD
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                string InsertQuery = @"INSERT INTO Producto (CLAVE, NOMBRE, PRECIO, STOCK)
                                       VALUES (@id, @nombre, @precio, @stock)";

                MySqlCommand cmd = new MySqlCommand(InsertQuery, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@stock", stock);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Producto registrado con éxito.");

            // Limpiar campos
            txtIDProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtStockInicial.Clear();

            CargarProductos();
        }
    }

    // ==========================================
    //              CLASE PRODUCTO
    // ==========================================
    public class Producto
    {
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
