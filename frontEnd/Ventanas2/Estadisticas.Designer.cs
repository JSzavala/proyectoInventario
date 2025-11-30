namespace proyectoInventario.frontEnd.Ventanas2
{
    partial class Estadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitleMain = new System.Windows.Forms.Label();
            this.lblClaveProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalProductos = new System.Windows.Forms.TextBox();
            this.txtTotalStock = new System.Windows.Forms.TextBox();
            this.txtValorInventario = new System.Windows.Forms.TextBox();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.txtValorTotalVendido = new System.Windows.Forms.TextBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
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
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // lblTitleMain
            // 
            this.lblTitleMain.AutoSize = true;
            this.lblTitleMain.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleMain.ForeColor = System.Drawing.Color.White;
            this.lblTitleMain.Location = new System.Drawing.Point(173, 34);
            this.lblTitleMain.Name = "lblTitleMain";
            this.lblTitleMain.Size = new System.Drawing.Size(111, 25);
            this.lblTitleMain.TabIndex = 13;
            this.lblTitleMain.Text = "Estadísticas";
            // 
            // lblClaveProducto
            // 
            this.lblClaveProducto.AutoSize = true;
            this.lblClaveProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveProducto.ForeColor = System.Drawing.Color.White;
            this.lblClaveProducto.Location = new System.Drawing.Point(54, 105);
            this.lblClaveProducto.Name = "lblClaveProducto";
            this.lblClaveProducto.Size = new System.Drawing.Size(105, 15);
            this.lblClaveProducto.TabIndex = 14;
            this.lblClaveProducto.Text = "Total de Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Valor de Inventario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total de Ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Valor Total Vendido";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Historial de Ventas";
            // 
            // txtTotalProductos
            // 
            this.txtTotalProductos.Location = new System.Drawing.Point(211, 105);
            this.txtTotalProductos.Name = "txtTotalProductos";
            this.txtTotalProductos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalProductos.TabIndex = 21;
            // 
            // txtTotalStock
            // 
            this.txtTotalStock.Location = new System.Drawing.Point(211, 130);
            this.txtTotalStock.Name = "txtTotalStock";
            this.txtTotalStock.Size = new System.Drawing.Size(100, 20);
            this.txtTotalStock.TabIndex = 22;
            // 
            // txtValorInventario
            // 
            this.txtValorInventario.Location = new System.Drawing.Point(211, 156);
            this.txtValorInventario.Name = "txtValorInventario";
            this.txtValorInventario.Size = new System.Drawing.Size(100, 20);
            this.txtValorInventario.TabIndex = 23;
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Location = new System.Drawing.Point(211, 195);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(100, 20);
            this.txtTotalVentas.TabIndex = 24;
            // 
            // txtValorTotalVendido
            // 
            this.txtValorTotalVendido.Location = new System.Drawing.Point(211, 228);
            this.txtValorTotalVendido.Name = "txtValorTotalVendido";
            this.txtValorTotalVendido.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotalVendido.TabIndex = 25;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(21, 312);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(658, 150);
            this.dgvHistorial.TabIndex = 26;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(706, 502);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.txtValorTotalVendido);
            this.Controls.Add(this.txtTotalVentas);
            this.Controls.Add(this.txtValorInventario);
            this.Controls.Add(this.txtTotalStock);
            this.Controls.Add(this.txtTotalProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClaveProducto);
            this.Controls.Add(this.lblTitleMain);
            this.Controls.Add(this.btnVolver);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitleMain;
        private System.Windows.Forms.Label lblClaveProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalProductos;
        private System.Windows.Forms.TextBox txtTotalStock;
        private System.Windows.Forms.TextBox txtValorInventario;
        private System.Windows.Forms.TextBox txtTotalVentas;
        private System.Windows.Forms.TextBox txtValorTotalVendido;
        private System.Windows.Forms.DataGridView dgvHistorial;
    }
}