/*
 * Created by SharpDevelop.
 * User: compu1
 * Date: 24/11/2025
 * Time: 09:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyectoInventario
{
    partial class RegistrarUsuarios
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
       System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuarios));
  this.lblTitleMain = new System.Windows.Forms.Label();
 this.txtIDUsuario = new System.Windows.Forms.TextBox();
this.txtNombreUsuario = new System.Windows.Forms.TextBox();
       this.txtContraseña = new System.Windows.Forms.TextBox();
    this.cmbRol = new System.Windows.Forms.ComboBox();
this.btnRegistrarCompra = new System.Windows.Forms.Button();
   this.btnVolver = new System.Windows.Forms.Button();
  this.SuspendLayout();
// 
// lblTitleMain
     // 
   this.lblTitleMain.AutoSize = true;
   this.lblTitleMain.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
 this.lblTitleMain.ForeColor = System.Drawing.Color.White;
    this.lblTitleMain.Location = new System.Drawing.Point(108, 34);
 this.lblTitleMain.Name = "lblTitleMain";
    this.lblTitleMain.Size = new System.Drawing.Size(172, 25);
    this.lblTitleMain.TabIndex = 5;
this.lblTitleMain.Text = "Registrar Usuarios";
// 
   // txtIDUsuario
// 
this.txtIDUsuario.Location = new System.Drawing.Point(47, 83);
   this.txtIDUsuario.Name = "txtIDUsuario";
this.txtIDUsuario.Size = new System.Drawing.Size(280, 20);
   this.txtIDUsuario.TabIndex = 6;
 // 
// txtNombreUsuario
// 
this.txtNombreUsuario.Location = new System.Drawing.Point(47, 119);
this.txtNombreUsuario.Name = "txtNombreUsuario";
this.txtNombreUsuario.Size = new System.Drawing.Size(280, 20);
  this.txtNombreUsuario.TabIndex = 7;
   // 
// txtContraseña
    // 
this.txtContraseña.Location = new System.Drawing.Point(47, 156);
this.txtContraseña.Name = "txtContraseña";
 this.txtContraseña.Size = new System.Drawing.Size(280, 20);
  this.txtContraseña.TabIndex = 8;
   // 
  // cmbRol
     // 
 this.cmbRol.FormattingEnabled = true;
 this.cmbRol.Items.AddRange(new object[] {
    "Dueño",
"Empleado"});
this.cmbRol.Location = new System.Drawing.Point(47, 195);
  this.cmbRol.Name = "cmbRol";
this.cmbRol.Size = new System.Drawing.Size(280, 21);
    this.cmbRol.TabIndex = 9;
// 
    // btnRegistrarCompra
    // 
    this.btnRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(255)))));
    this.btnRegistrarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
  this.btnRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
 this.btnRegistrarCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
  this.btnRegistrarCompra.ForeColor = System.Drawing.Color.White;
this.btnRegistrarCompra.Location = new System.Drawing.Point(110, 262);
     this.btnRegistrarCompra.Name = "btnRegistrarCompra";
 this.btnRegistrarCompra.Size = new System.Drawing.Size(155, 38);
this.btnRegistrarCompra.TabIndex = 10;
  this.btnRegistrarCompra.Text = "Registrar Usuario";
    this.btnRegistrarCompra.UseVisualStyleBackColor = false;
     // 
        // btnVolver
     // 
  this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
  this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
    this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
   this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
     this.btnVolver.Location = new System.Drawing.Point(12, 12);
this.btnVolver.Name = "btnVolver";
  this.btnVolver.Size = new System.Drawing.Size(46, 38);
  this.btnVolver.TabIndex = 14;
   this.btnVolver.UseVisualStyleBackColor = false;
   // 
        // RegistrarUsuarios
// 
this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
  this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
   this.ClientSize = new System.Drawing.Size(375, 368);
    this.Controls.Add(this.btnVolver);
  this.Controls.Add(this.btnRegistrarCompra);
this.Controls.Add(this.cmbRol);
  this.Controls.Add(this.txtContraseña);
  this.Controls.Add(this.txtNombreUsuario);
this.Controls.Add(this.txtIDUsuario);
  this.Controls.Add(this.lblTitleMain);
    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
 this.Name = "RegistrarUsuarios";
this.Text = "Registrar Usuarios";
this.ResumeLayout(false);
   this.PerformLayout();
  }
     private System.Windows.Forms.Button btnVolver;
 private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.ComboBox cmbRol;
    private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtIDUsuario;
  private System.Windows.Forms.Label lblTitleMain;
  }
}
