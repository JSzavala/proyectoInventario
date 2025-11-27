/*
 * Created by SharpDevelop.
 * User: compu1
 * Date: 24/11/2025
 * Time: 09:05 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using proyectoInventario.backEnd.conexionBd;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoInventario
{
    /// <summary>
    /// Description of Descontinuar.
    /// </summary>
    public partial class Descontinuar : Form
    {
  public Descontinuar()
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


        private void LblTitleMainClick(object sender, EventArgs e)
                {
            // Evento del label (sin funcionalidad específica)
         }
    // Evento del label (sin funcionalidad específica)
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
              
        }
    }
}
