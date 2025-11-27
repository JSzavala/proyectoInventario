/*
 * Created by SharpDevelop.
 * User: compu1
 * Date: 24/11/2025
 * Time: 07:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using proyectoInventario.backEnd.conexionBd;
using proyectoInventario.backEnd.POCOS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoInventario
{
    /// <summary>
    /// Description of Login.
    /// </summary>
    public partial class Login : Form
    {
        public Login()
        {
      //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
        InitializeComponent();
    
      //
 // TODO: Add constructor code after the InitializeComponent() call.
         //
      }
    
        void LblTitleLoginClick(object sender, EventArgs e)
        {
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor ingresa usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsConsultas consultas = new clsConsultas();
            Usuario usuarioAutenticado = consultas.AutenticarUsuario(usuario, contrasena);

            if (usuarioAutenticado != null)
            {
                MessageBox.Show($"Bienvenido {usuarioAutenticado.Nombre} ({usuarioAutenticado.Rol})", "Acceso concedido");

                // Abrir menú principal según rol
                if (usuarioAutenticado.Rol == RolUsuario.Dueña)
                {
                    RegistrarVenta adminForm = new RegistrarVenta(RolUsuario.Dueña);
                    adminForm.Show();
                }
                else
                {
                    RegistrarVenta vendedorForm = new RegistrarVenta(RolUsuario.Empleado);
                    vendedorForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
