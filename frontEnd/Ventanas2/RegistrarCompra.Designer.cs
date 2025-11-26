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
            this.lblTitleMain = new System.Windows.Forms.Label();
        this.txtIDProducto = new System.Windows.Forms.TextBox();
      this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
     this.btnRegistrarCompra = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
      this.btnRegistrarProducto = new System.Windows.Forms.Button();
      this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
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
      this.btnRegistrarCompra.Location = new System.Drawing.Point(50, 428);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(155, 38);
   this.btnRegistrarCompra.TabIndex = 9;
   this.btnRegistrarCompra.Text = "Registrar Compra";
          this.btnRegistrarCompra.UseVisualStyleBackColor = false;
            // 
   // btnVolver
  // 
   this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
       this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(26, 22);
          this.btnVolver.Name = "btnVolver";
 this.btnVolver.Size = new System.Drawing.Size(75, 38);
       this.btnVolver.TabIndex = 10;
     this.btnVolver.Text = "Volver";
   this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
       // 
       // btnRegistrarProducto
            // 
   this.btnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(255)))));
    this.btnRegistrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
   this.btnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProducto.Location = new System.Drawing.Point(361, 125);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
       this.btnRegistrarProducto.Size = new System.Drawing.Size(155, 38);
  this.btnRegistrarProducto.TabIndex = 11;
this.btnRegistrarProducto.Text = "Añadir Producto";
            this.btnRegistrarProducto.UseVisualStyleBackColor = false;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
        // 
       // dgvProductos
      // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
  this.dgvProductos.Location = new System.Drawing.Point(50, 228);
            this.dgvProductos.Name = "dgvProductos";
   this.dgvProductos.Size = new System.Drawing.Size(481, 171);
      this.dgvProductos.TabIndex = 12;
            // 
    // RegistrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
     this.ClientSize = new System.Drawing.Size(581, 530);
            this.Controls.Add(this.dgvProductos);
      this.Controls.Add(this.btnRegistrarProducto);
      this.Controls.Add(this.btnVolver);
       this.Controls.Add(this.btnRegistrarCompra);
            this.Controls.Add(this.txtPrecioVenta);
      this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtIDProducto);
   this.Controls.Add(this.lblTitleMain);
      this.Name = "RegistrarCompra";
    this.Text = "Registrar Compra";
       ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
          this.PerformLayout();
        }
        
        private System.Windows.Forms.Button btnVolver;
     private System.Windows.Forms.Button btnRegistrarCompra;
   private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtIDProducto;
    private System.Windows.Forms.Label lblTitleMain;
        private System.Windows.Forms.Button btnRegistrarProducto;
    private System.Windows.Forms.DataGridView dgvProductos;
    }
}
