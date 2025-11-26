/*
 * Created by SharpDevelop.
 * User: compu1
 * Date: 24/11/2025
 * Time: 08:30 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoInventario
{
    /// <summary>
    /// Description of RegistrarProducto.
    /// </summary>
    public partial class RegistrarProducto : Form
    {
        public RegistrarProducto()
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
    }
}
