/*
 * Created by SharpDevelop.
 * User: compu1
 * Date: 24/11/2025
 * Time: 07:59 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEfren2
{
	partial class Main
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.lblTitleMain = new System.Windows.Forms.Label();
			this.btnRegistrarProducto = new System.Windows.Forms.Button();
			this.btnRegistrarCompra = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnDescontinuar = new System.Windows.Forms.Button();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.btnRegistrarUsuarios = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitleMain
			// 
			this.lblTitleMain.AutoSize = true;
			this.lblTitleMain.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.lblTitleMain.ForeColor = System.Drawing.Color.White;
			this.lblTitleMain.Location = new System.Drawing.Point(25, 25);
			this.lblTitleMain.Name = "lblTitleMain";
			this.lblTitleMain.Size = new System.Drawing.Size(112, 25);
			this.lblTitleMain.TabIndex = 2;
			this.lblTitleMain.Text = "Bienvenido";
			// 
			// btnRegistrarProducto
			// 
			this.btnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(255)))));
			this.btnRegistrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarProducto.ForeColor = System.Drawing.Color.White;
			this.btnRegistrarProducto.Location = new System.Drawing.Point(199, 25);
			this.btnRegistrarProducto.Name = "btnRegistrarProducto";
			this.btnRegistrarProducto.Size = new System.Drawing.Size(106, 25);
			this.btnRegistrarProducto.TabIndex = 4;
			this.btnRegistrarProducto.Text = "Registrar Producto";
			this.btnRegistrarProducto.UseVisualStyleBackColor = false;
			// 
			// btnRegistrarCompra
			// 
			this.btnRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(255)))));
			this.btnRegistrarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarCompra.ForeColor = System.Drawing.Color.White;
			this.btnRegistrarCompra.Location = new System.Drawing.Point(321, 25);
			this.btnRegistrarCompra.Name = "btnRegistrarCompra";
			this.btnRegistrarCompra.Size = new System.Drawing.Size(106, 25);
			this.btnRegistrarCompra.TabIndex = 5;
			this.btnRegistrarCompra.Text = "Registrar Compra";
			this.btnRegistrarCompra.UseVisualStyleBackColor = false;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(255)))));
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(443, 25);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(105, 25);
			this.btnBuscar.TabIndex = 6;
			this.btnBuscar.Text = "Buscar Producto";
			this.btnBuscar.UseVisualStyleBackColor = false;
			// 
			// btnDescontinuar
			// 
			this.btnDescontinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(255)))));
			this.btnDescontinuar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDescontinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDescontinuar.ForeColor = System.Drawing.Color.White;
			this.btnDescontinuar.Location = new System.Drawing.Point(563, 25);
			this.btnDescontinuar.Name = "btnDescontinuar";
			this.btnDescontinuar.Size = new System.Drawing.Size(132, 25);
			this.btnDescontinuar.TabIndex = 7;
			this.btnDescontinuar.Text = "Descontinuar Producto";
			this.btnDescontinuar.UseVisualStyleBackColor = false;
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
			this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
			this.btnCerrarSesion.Location = new System.Drawing.Point(718, 25);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(106, 25);
			this.btnCerrarSesion.TabIndex = 8;
			this.btnCerrarSesion.Text = "Cerrar sesión\r\n";
			this.btnCerrarSesion.UseVisualStyleBackColor = false;
			this.btnCerrarSesion.Click += new System.EventHandler(this.Button2Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(25, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Productos";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// dgvProductos
			// 
			this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
			this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Location = new System.Drawing.Point(25, 123);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvProductos.Size = new System.Drawing.Size(799, 252);
			this.dgvProductos.TabIndex = 10;
			// 
			// btnRegistrarUsuarios
			// 
			this.btnRegistrarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(255)))));
			this.btnRegistrarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarUsuarios.ForeColor = System.Drawing.Color.White;
			this.btnRegistrarUsuarios.Location = new System.Drawing.Point(718, 68);
			this.btnRegistrarUsuarios.Name = "btnRegistrarUsuarios";
			this.btnRegistrarUsuarios.Size = new System.Drawing.Size(106, 25);
			this.btnRegistrarUsuarios.TabIndex = 11;
			this.btnRegistrarUsuarios.Text = "Registrar Usuarios";
			this.btnRegistrarUsuarios.UseVisualStyleBackColor = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(854, 409);
			this.Controls.Add(this.btnRegistrarUsuarios);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCerrarSesion);
			this.Controls.Add(this.btnDescontinuar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnRegistrarCompra);
			this.Controls.Add(this.btnRegistrarProducto);
			this.Controls.Add(this.lblTitleMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Main";
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnRegistrarUsuarios;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.Button btnDescontinuar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnRegistrarCompra;
		private System.Windows.Forms.Button btnRegistrarProducto;
		private System.Windows.Forms.Label lblTitleMain;
	}
}
