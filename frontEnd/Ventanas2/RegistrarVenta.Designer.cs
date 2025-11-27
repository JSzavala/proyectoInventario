/*
 * Created by SharpDevelop.
 * User: compu1
 * Date: 25/11/2025
 * Time: 07:51 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyectoInventario
{
	partial class RegistrarVenta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVenta));
			this.lblTitleMain = new System.Windows.Forms.Label();
			this.txtIDProducto = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.btnRegistrarVenta = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			this.lblClaveProducto = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitleMain
			// 
			this.lblTitleMain.AutoSize = true;
			this.lblTitleMain.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.lblTitleMain.ForeColor = System.Drawing.Color.White;
			this.lblTitleMain.Location = new System.Drawing.Point(113, 44);
			this.lblTitleMain.Name = "lblTitleMain";
			this.lblTitleMain.Size = new System.Drawing.Size(148, 25);
			this.lblTitleMain.TabIndex = 5;
			this.lblTitleMain.Text = "Registrar Venta";
			// 
			// lblClaveProducto
			// 
			this.lblClaveProducto.AutoSize = true;
			this.lblClaveProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClaveProducto.ForeColor = System.Drawing.Color.White;
			this.lblClaveProducto.Location = new System.Drawing.Point(48, 86);
			this.lblClaveProducto.Name = "lblClaveProducto";
			this.lblClaveProducto.Size = new System.Drawing.Size(117, 15);
			this.lblClaveProducto.TabIndex = 12;
			this.lblClaveProducto.Text = "Clave del Producto:";
			// 
			// txtIDProducto
			// 
			this.txtIDProducto.Location = new System.Drawing.Point(48, 104);
			this.txtIDProducto.Name = "txtIDProducto";
			this.txtIDProducto.Size = new System.Drawing.Size(280, 20);
			this.txtIDProducto.TabIndex = 6;
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.ForeColor = System.Drawing.Color.White;
			this.lblCantidad.Location = new System.Drawing.Point(48, 127);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(58, 15);
			this.lblCantidad.TabIndex = 13;
			this.lblCantidad.Text = "Cantidad:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(48, 145);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(280, 20);
			this.txtCantidad.TabIndex = 7;
			// 
			// btnRegistrarVenta
			// 
			this.btnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(255)))));
			this.btnRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
			this.btnRegistrarVenta.Location = new System.Drawing.Point(113, 195);
			this.btnRegistrarVenta.Name = "btnRegistrarVenta";
			this.btnRegistrarVenta.Size = new System.Drawing.Size(155, 38);
			this.btnRegistrarVenta.TabIndex = 10;
			this.btnRegistrarVenta.Text = "Registrar Venta";
			this.btnRegistrarVenta.UseVisualStyleBackColor = false;
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
			this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.Color.White;
			this.btnVolver.Location = new System.Drawing.Point(12, 12);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(75, 38);
			this.btnVolver.TabIndex = 11;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = false;
			this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
			// 
			// RegistrarVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(375, 280);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.lblClaveProducto);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnRegistrarVenta);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtIDProducto);
			this.Controls.Add(this.lblTitleMain);
			//this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "RegistrarVenta";
			this.Text = "Registrar Venta";
			this.Load += new System.EventHandler(this.RegistrarVentaLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.Button btnRegistrarVenta;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtIDProducto;
		private System.Windows.Forms.Label lblTitleMain;
		private System.Windows.Forms.Label lblClaveProducto;
		private System.Windows.Forms.Label lblCantidad;
	}
}