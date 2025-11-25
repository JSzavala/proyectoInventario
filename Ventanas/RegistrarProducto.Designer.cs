/*
 * Created by SharpDevelop.
 * User: compu1
 * Date: 24/11/2025
 * Time: 08:30 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoEfren2
{
	partial class RegistrarProducto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarProducto));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblTitleMain = new System.Windows.Forms.Label();
			this.txtIDProducto = new System.Windows.Forms.TextBox();
			this.txtNombreProducto = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtStockInicial = new System.Windows.Forms.TextBox();
			this.btnAgregarInv = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitleMain
			// 
			this.lblTitleMain.AutoSize = true;
			this.lblTitleMain.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.lblTitleMain.ForeColor = System.Drawing.Color.White;
			this.lblTitleMain.Location = new System.Drawing.Point(96, 43);
			this.lblTitleMain.Name = "lblTitleMain";
			this.lblTitleMain.Size = new System.Drawing.Size(181, 25);
			this.lblTitleMain.TabIndex = 3;
			this.lblTitleMain.Text = "Registrar Producto";
			// 
			// txtIDProducto
			// 
			this.txtIDProducto.Location = new System.Drawing.Point(49, 91);
			this.txtIDProducto.Name = "txtIDProducto";
			this.txtIDProducto.Size = new System.Drawing.Size(280, 20);
			this.txtIDProducto.TabIndex = 4;
			// 
			// txtNombreProducto
			// 
			this.txtNombreProducto.Location = new System.Drawing.Point(49, 129);
			this.txtNombreProducto.Name = "txtNombreProducto";
			this.txtNombreProducto.Size = new System.Drawing.Size(280, 20);
			this.txtNombreProducto.TabIndex = 5;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(49, 168);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(280, 20);
			this.txtPrecio.TabIndex = 6;
			// 
			// txtStockInicial
			// 
			this.txtStockInicial.Location = new System.Drawing.Point(49, 204);
			this.txtStockInicial.Name = "txtStockInicial";
			this.txtStockInicial.Size = new System.Drawing.Size(280, 20);
			this.txtStockInicial.TabIndex = 7;
			// 
			// btnAgregarInv
			// 
			this.btnAgregarInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(255)))));
			this.btnAgregarInv.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregarInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarInv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarInv.ForeColor = System.Drawing.Color.White;
			this.btnAgregarInv.Location = new System.Drawing.Point(110, 242);
			this.btnAgregarInv.Name = "btnAgregarInv";
			this.btnAgregarInv.Size = new System.Drawing.Size(143, 31);
			this.btnAgregarInv.TabIndex = 8;
			this.btnAgregarInv.Text = "Agregar al Inventario";
			this.btnAgregarInv.UseVisualStyleBackColor = false;
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
			this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
			this.btnVolver.Location = new System.Drawing.Point(22, 21);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(46, 38);
			this.btnVolver.TabIndex = 0;
			this.btnVolver.UseVisualStyleBackColor = false;
			// 
			// dgvProductos
			// 
			this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
			this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuBar;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Location = new System.Drawing.Point(32, 311);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvProductos.Size = new System.Drawing.Size(799, 204);
			this.dgvProductos.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(49, 291);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 17);
			this.label1.TabIndex = 16;
			this.label1.Text = "Productos Registrados";
			// 
			// RegistrarProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(854, 527);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnAgregarInv);
			this.Controls.Add(this.txtStockInicial);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtNombreProducto);
			this.Controls.Add(this.txtIDProducto);
			this.Controls.Add(this.lblTitleMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "RegistrarProducto";
			this.Text = "Registrar Producto";
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.Button btnAgregarInv;
		private System.Windows.Forms.TextBox txtStockInicial;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtNombreProducto;
		private System.Windows.Forms.TextBox txtIDProducto;
		private System.Windows.Forms.Label lblTitleMain;
	}
}
