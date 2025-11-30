using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyectoInventario.frontEnd.Ventanas2
{
    public partial class Estadisticas : Form
    {
        private string connectionString = "Server=localhost;Database=VENTAS;Uid=root;Pwd=pum@s941;";
        public Estadisticas()
        {
            InitializeComponent();
            this.Load += Estadisticas_Load;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
            CargarHistorialVentas();
        }

        private void CargarEstadisticas()
        {
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                cn.Open();

                // Total de Productos
                string sqlProductos = "SELECT COUNT(*) FROM Producto";
                using (MySqlCommand cmd = new MySqlCommand(sqlProductos, cn))
                {
                    object res = cmd.ExecuteScalar();
                    txtTotalProductos.Text = res != DBNull.Value ? res.ToString() : "0";
                }

                // Total Stock
                string sqlStock = "SELECT SUM(STOCK) FROM Producto";
                using (MySqlCommand cmd = new MySqlCommand(sqlStock, cn))
                {
                    object res = cmd.ExecuteScalar();
                    txtTotalStock.Text = res != DBNull.Value ? res.ToString() : "0";
                }

                // Valor de Inventario (PRECIO * STOCK)
                string sqlValorInvent = "SELECT SUM(PRECIO * STOCK) FROM Producto";
                using (MySqlCommand cmd = new MySqlCommand(sqlValorInvent, cn))
                {
                    object result = cmd.ExecuteScalar();
                    decimal valorInv = 0m;
                    if (result != DBNull.Value && result != null)
                        decimal.TryParse(result.ToString(), out valorInv);

                    txtValorInventario.Text = valorInv.ToString("0.00");
                }

                // Total de Ventas (cantidad de facturas/ventas registradas)
                string sqlTotalVentas = "SELECT COUNT(*) FROM Venta";
                using (MySqlCommand cmd = new MySqlCommand(sqlTotalVentas, cn))
                {
                    object res = cmd.ExecuteScalar();
                    txtTotalVentas.Text = res != DBNull.Value ? res.ToString() : "0";
                }

                // Valor total vendido (SUMA de todos los totales)
                string sqlTotalVendido = "SELECT SUM(Total) FROM Venta";
                using (MySqlCommand cmd = new MySqlCommand(sqlTotalVendido, cn))
                {
                    object result = cmd.ExecuteScalar();
                    decimal totalVendido = 0m;
                    if (result != DBNull.Value && result != null)
                        decimal.TryParse(result.ToString(), out totalVendido);

                    txtValorTotalVendido.Text = totalVendido.ToString("0.00");
                }
            }
        }


        private void CargarHistorialVentas()
        {
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                cn.Open();

                string query =
                    "SELECT DV.ID_DetalleVenta, DV.ID_Venta, DV.CLAVE_Producto, P.NOMBRE AS Producto, " +
                    "DV.Cantidad, DV.PrecioUnitario, DV.Subtotal " +
                    "FROM DetalleVenta DV " +
                    "INNER JOIN Producto P ON DV.CLAVE_Producto = P.CLAVE";

                using (MySqlDataAdapter da = new MySqlDataAdapter(query, cn))
                {
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    dgvHistorial.DataSource = tabla;

                    // Opcional: renombrar encabezados para que se vean mejor
                    if (dgvHistorial.Columns["ID_DetalleVenta"] != null) dgvHistorial.Columns["ID_DetalleVenta"].HeaderText = "Detalle ID";
                    if (dgvHistorial.Columns["ID_Venta"] != null) dgvHistorial.Columns["ID_Venta"].HeaderText = "Venta ID";
                    if (dgvHistorial.Columns["CLAVE_Producto"] != null) dgvHistorial.Columns["CLAVE_Producto"].HeaderText = "Clave";
                    if (dgvHistorial.Columns["Producto"] != null) dgvHistorial.Columns["Producto"].HeaderText = "Producto";
                    if (dgvHistorial.Columns["Cantidad"] != null) dgvHistorial.Columns["Cantidad"].HeaderText = "Cantidad";
                    if (dgvHistorial.Columns["PrecioUnitario"] != null) dgvHistorial.Columns["PrecioUnitario"].HeaderText = "Precio Unit.";
                    if (dgvHistorial.Columns["Subtotal"] != null) dgvHistorial.Columns["Subtotal"].HeaderText = "Subtotal";

                    // Formato numérico para columnas monetarias (si existen)
                    if (dgvHistorial.Columns["PrecioUnitario"] != null) dgvHistorial.Columns["PrecioUnitario"].DefaultCellStyle.Format = "0.00";
                    if (dgvHistorial.Columns["Subtotal"] != null) dgvHistorial.Columns["Subtotal"].DefaultCellStyle.Format = "0.00";
                }
            }
        }


        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            Main frmMain = new Main();
            frmMain.Show();
            this.Close();
        }
    }
}
