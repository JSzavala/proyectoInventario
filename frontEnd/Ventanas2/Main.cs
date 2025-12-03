/*
 * Created by SharpDevelop.
 * User: compu1
 * Date: 24/11/2025
 * Time: 07:59 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using proyectoInventario.backEnd.POCOS;
using proyectoInventario.frontEnd.Ventanas2;
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace proyectoInventario
{
    /// <summary>
    /// Description of Main.
    /// </summary>
    public partial class Main : Form
    {
        private string connectionString = "Server=localhost;Database=VENTAS;Uid=root;Pwd=pum@s941;";

        public Main()
        {
            InitializeComponent();
            this.Load += new EventHandler(Main_Load);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CargarProductos(); 
        }

        private void BtnRegistrarProducto_Click(object sender, EventArgs e)
 {
            RegistrarProducto frmRegistrarProducto = new RegistrarProducto();
 frmRegistrarProducto.Show();
 this.Hide();
      }
        
        private void BtnRegistrarCompra_Click(object sender, EventArgs e)
    {
    RegistrarCompra frmRegistrarCompra = new RegistrarCompra();
         frmRegistrarCompra.Show();
            this.Hide();
        }
     
   private void BtnBuscar_Click(object sender, EventArgs e)
        {
    Buscar frmBuscar = new Buscar();
 frmBuscar.Show();
            this.Hide();
      }
        
        private void BtnDescontinuar_Click(object sender, EventArgs e)
     {
      Descontinuar frmDescontinuar = new Descontinuar();
            frmDescontinuar.Show();
    this.Hide();
        }
  
        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
     {
 RegistrarVenta frmRegistrarVenta = new RegistrarVenta(RolUsuario.Dueña);
        frmRegistrarVenta.Show();
this.Hide();
        }
        
        private void BtnRegistrarUsuarios_Click(object sender, EventArgs e)
        {
  RegistrarUsuarios frmRegistrarUsuarios = new RegistrarUsuarios();
            frmRegistrarUsuarios.Show();
       this.Hide();
 }
        
    private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
       DialogResult resultado = MessageBox.Show(
   "¿Está seguro que desea cerrar sesión?", 
                "Confirmar cierre de sesión", 
     MessageBoxButtons.YesNo, 
            MessageBoxIcon.Question);
 
            if (resultado == DialogResult.Yes)
            {
       Login frmLogin = new Login();
   frmLogin.Show();
          this.Close();
            }
        }
     
        private void Button2Click(object sender, EventArgs e)
        {
    // Este método existe por compatibilidad con el designer anterior
   BtnDescontinuar_Click(sender, e);
        }
     
        private void Label1Click(object sender, EventArgs e)
        {
     // Evento del label (sin funcionalidad específica)
   }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
       // Redirigir al método correcto
       BtnBuscar_Click(sender, e);
    }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas frmEstadisticas = new Estadisticas();
            frmEstadisticas.Show();
            this.Hide();
        }

        private void CargarProductos()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT CLAVE, NOMBRE, DESCRIPCION, PRECIO, STOCK 
                             FROM Producto";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvProductos.DataSource = dt; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar productos: " + ex.Message);
                }
            }
        }

    }
}
