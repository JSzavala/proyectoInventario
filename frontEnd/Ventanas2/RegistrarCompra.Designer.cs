/*
 * Created by SharpDevelop.
 * User: compu1
 * Date: 24/11/2025
 * Time: 08:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyectoInventario
{
    partial class RegistrarCompra
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
    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarCompra));
       this.lblTitleMain = new System.Windows.Forms.Label();
    this.txtIDProducto = new System.Windows.Forms.TextBox();
     this.txtCantidad = new System.Windows.Forms.TextBox();
 this.txtPrecioVenta = new System.Windows.Forms.TextBox();
  this.btnRegistrarCompra = new System.Windows.Forms.Button();
this.btnVolver = new System.Windows.Forms.Button();
  this.SuspendLayout();
        // 
// lblTitleMain
     // 
    this.lblTitleMain.AutoSize = true;
      this.lblTitleMain.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
 this.lblTitleMain.ForeColor = System.Drawing.Color.White;
  this.lblTitleMain.Location = new System.Drawing.Point(104, 46);
  this.lblTitleMain.Name = "lblTitleMain";
this.lblTitleMain.Size = new System.Drawing.Size(168, 25);
 this.lblTitleMain.TabIndex = 4;
   this.lblTitleMain.Text = "Registrar Compra";
     // 
   // txtIDProducto
    // 
  this.txtIDProducto.Location = new System.Drawing.Point(50, 101);
        this.txtIDProducto.Name = "txtIDProducto";
       this.txtIDProducto.Size = new System.Drawing.Size(280, 20);
   this.txtIDProducto.TabIndex = 5;
  // 
    // txtCantidad
    // 
 this.txtCantidad.Location = new System.Drawing.Point(50, 136);
  this.txtCantidad.Name = "txtCantidad";
      this.txtCantidad.Size = new System.Drawing.Size(280, 20);
   this.txtCantidad.TabIndex = 6;
// 
  // txtPrecioVenta
// 
 this.txtPrecioVenta.Location = new System.Drawing.Point(50, 174);
this.txtPrecioVenta.Name = "txtPrecioVenta";
      this.txtPrecioVenta.Size = new System.Drawing.Size(280, 20);
 this.txtPrecioVenta.TabIndex = 7;
  // 
       // btnRegistrarCompra
        // 
    this.btnRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(255)))));
     this.btnRegistrarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
this.btnRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.btnRegistrarCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
     this.btnRegistrarCompra.ForeColor = System.Drawing.Color.White;
    this.btnRegistrarCompra.Location = new System.Drawing.Point(117, 244);
   this.btnRegistrarCompra.Name = "btnRegistrarCompra";
 this.btnRegistrarCompra.Size = new System.Drawing.Size(155, 38);
    this.btnRegistrarCompra.TabIndex = 9;
     this.btnRegistrarCompra.Text = "Registrar Compra";
        this.btnRegistrarCompra.UseVisualStyleBackColor = false;
   // 
     // btnVolver
   // 
   this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
     this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
  this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
  this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
  this.btnVolver.Location = new System.Drawing.Point(26, 22);
  this.btnVolver.Name = "btnVolver";
    this.btnVolver.Size = new System.Drawing.Size(46, 38);
this.btnVolver.TabIndex = 10;
  this.btnVolver.UseVisualStyleBackColor = false;
  // 
  // RegistrarCompra
        // 
  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
 this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
this.ClientSize = new System.Drawing.Size(375, 368);
this.Controls.Add(this.btnVolver);
       this.Controls.Add(this.btnRegistrarCompra);
      this.Controls.Add(this.txtPrecioVenta);
  this.Controls.Add(this.txtCantidad);
 this.Controls.Add(this.txtIDProducto);
   this.Controls.Add(this.lblTitleMain);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
    this.Name = "RegistrarCompra";
   this.Text = "Registrar Compra";
    this.ResumeLayout(false);
this.PerformLayout();
   }
 private System.Windows.Forms.Button btnVolver;
      private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
 private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtIDProducto;
        private System.Windows.Forms.Label lblTitleMain;
    }
}
