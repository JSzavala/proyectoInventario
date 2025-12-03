/*
 * Created by SharpDevelop.
 * User: compu1
 * Date: 24/11/2025
 * Time: 09:00 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyectoInventario
{
    public partial class Buscar : Form
    {
        private string connectionString = "Server=localhost;Database=VENTAS;Uid=root;Pwd=pum@s941;";

        public Buscar()
        {
            InitializeComponent();
            this.Load += new EventHandler(Buscar_Load);

            // Agregamos el evento que faltaba
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            BuscarProducto(""); // muestra todos los productos al iniciar
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Main frmMain = new Main();
            frmMain.Show();
            this.Close();
        }

        private void BuscarProducto(string texto)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT CLAVE, NOMBRE, DESCRIPCION, PRECIO, STOCK 
                             FROM Producto
                             WHERE CLAVE LIKE @valor OR NOMBRE LIKE @valor";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@valor", "%" + texto + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Verificar si no hubo resultados
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "No existe ningún producto con esa clave o nombre.",
                            "Sin resultados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return; 
                    }

                    // Si hay resultados, actualiza el DataGrid
                    dgvProductos.DataSource = null;
                    dgvProductos.Rows.Clear();
                    dgvProductos.Refresh();

                    dgvProductos.AutoGenerateColumns = true;
                    dgvProductos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtIDProducto.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Por favor ingresa una clave o nombre del producto.");
                return;
            }

            BuscarProducto(texto);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtIDProducto.Text = "";
            BuscarProducto("");
        }
    }
}
