/*
 * Created by SharpDevelop.
 * User: compu1
 * Date: 25/11/2025
 * Time: 07:51 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoInventario
{
	/// <summary>
	/// Description of RegistrarVenta.
	/// </summary>
	public partial class RegistrarVenta : Form
	{
		public RegistrarVenta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void BtnVolver_Click(object sender, EventArgs e)
		{
			Main frmMain = new Main();
			frmMain.Show();
			this.Close();
		}
		
		private void RegistrarVentaLoad(object sender, EventArgs e)
		{
			// Evento de carga del formulario
		}
	}
}
