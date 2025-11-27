using MySql.Data.MySqlClient;
using proyectoInventario;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Prpyecto_de_Taller
{
    public partial class RegistrarUsuarios : Form
    {
        string conexion = "Server=localhost;Database=VENTAS;Uid=root;Pwd=;";

        // Labels que haremos servir como placeholders
        private Label phID;
        private Label phNombre;
        private Label phPass;

        public RegistrarUsuarios()
        {
            InitializeComponent();
            // Configuramos placeholders después de InitializeComponent
            CrearPlaceholders();
        }

        private void RegistrarUsuarios_Load(object sender, EventArgs e)
        {
            CargarRoles();
            ActualizarPlaceholdersVisibilidad();
        }

        // --- Crear labels que simulan placeholder ---
        private void CrearPlaceholders()
        {
            // phID
            phID = CrearPlaceholderLabel(txtIDUsuario, "ID de usuario");
            phNombre = CrearPlaceholderLabel(txtNombreUsuario, "Nombre de usuario");
            phPass = CrearPlaceholderLabel(txtContraseña, "Contraseña");

            // Añadir a Controls (los añadimos después para que queden sobre los textboxes)
            this.Controls.Add(phID);
            this.Controls.Add(phNombre);
            this.Controls.Add(phPass);

            // Eventos para sincronizar visibilidad
            txtIDUsuario.TextChanged += (s, e) => ActualizarPlaceholdersVisibilidad();
            txtNombreUsuario.TextChanged += (s, e) => ActualizarPlaceholdersVisibilidad();
            txtContraseña.TextChanged += (s, e) => ActualizarPlaceholdersVisibilidad();

            txtIDUsuario.GotFocus += (s, e) => ActualizarPlaceholdersVisibilidad();
            txtNombreUsuario.GotFocus += (s, e) => ActualizarPlaceholdersVisibilidad();
            txtContraseña.GotFocus += (s, e) => ActualizarPlaceholdersVisibilidad();

            txtIDUsuario.LostFocus += (s, e) => ActualizarPlaceholdersVisibilidad();
            txtNombreUsuario.LostFocus += (s, e) => ActualizarPlaceholdersVisibilidad();
            txtContraseña.LostFocus += (s, e) => ActualizarPlaceholdersVisibilidad();

            // Si el formulario cambia de tamaño (o el diseñador mueve controles), reposicionar
            this.Resize += (s, e) => ReposicionarPlaceholders();
        }

        // Crea una Label posicionada sobre el textbox dado
        private Label CrearPlaceholderLabel(TextBox textbox, string texto)
        {
            var lbl = new Label();
            lbl.Text = texto;
            lbl.ForeColor = Color.FromArgb(150, 150, 150);
            lbl.Font = new Font(textbox.Font, FontStyle.Regular);
            lbl.AutoSize = false;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.BackColor = Color.Transparent;

            // Tamaño y posición igual al textbox (ligera corrección para padding)
            lbl.SetBounds(textbox.Left + 4, textbox.Top + 1, textbox.Width - 8, textbox.Height);

            // Cuando se hace clic en el label, pasamos el foco al textbox
            lbl.Cursor = Cursors.IBeam;
            lbl.Click += (s, e) => textbox.Focus();

            // Hacer que el label no reciba tab stops
            lbl.TabStop = false;

            return lbl;
        }

        // Mostrar u ocultar según contenido o foco
        private void ActualizarPlaceholdersVisibilidad()
        {
            phID.Visible = string.IsNullOrEmpty(txtIDUsuario.Text) && !txtIDUsuario.Focused;
            phNombre.Visible = string.IsNullOrEmpty(txtNombreUsuario.Text) && !txtNombreUsuario.Focused;
            phPass.Visible = string.IsNullOrEmpty(txtContraseña.Text) && !txtContraseña.Focused;
        }

        private void ReposicionarPlaceholders()
        {
            if (phID != null) phID.SetBounds(txtIDUsuario.Left + 4, txtIDUsuario.Top + 1, txtIDUsuario.Width - 8, txtIDUsuario.Height);
            if (phNombre != null) phNombre.SetBounds(txtNombreUsuario.Left + 4, txtNombreUsuario.Top + 1, txtNombreUsuario.Width - 8, txtNombreUsuario.Height);
            if (phPass != null) phPass.SetBounds(txtContraseña.Left + 4, txtContraseña.Top + 1, txtContraseña.Width - 8, txtContraseña.Height);
        }

        // ----------------- resto del formulario (roles, registro, volver) -----------------

        private void CargarRoles()
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Empleado");
            cmbRol.Items.Add("Supervisor");
            cmbRol.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            string id = txtIDUsuario.Text.Trim();
            string nombre = txtNombreUsuario.Text.Trim();
            string pass = txtContraseña.Text;
            string rol = cmbRol.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Ingrese el ID del usuario.");
                return;
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese el nombre del usuario.");
                return;
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Ingrese la contraseña.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                string query = @"INSERT INTO Usuarios (ID, Nombre, Password, Rol)
                                 VALUES (@id, @nombre, @pass, @rol)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@rol", rol);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Usuario registrado con éxito.");

            txtIDUsuario.Clear();
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            cmbRol.SelectedIndex = 0;
            ActualizarPlaceholdersVisibilidad();
        }
    }
}
