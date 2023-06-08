using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FIVT
{
    public partial class FrmReporteGeneralVentas : Form
    {
        public FrmReporteGeneralVentas()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
            ConexionBD BD = new ConexionBD();
            BD.MiConexion.Open();
          
            String Query = "SELECT * FROM Tbl_Ventas"; // ESTE ES NUESTRO QUERY

            BD.da = new System.Data.SqlClient.SqlDataAdapter (Query, BD.MiConexion);

            BDFacturacionDataSet Ds = new BDFacturacionDataSet(); // ESTE ES EL NOMBRE DE NUESTRO DATASET
            BD.da.Fill(Ds, "Tbl_Ventas"); // ESTE Reportes ES EL NOMBRE DE NUESTRA TABLA DE DATOS QUE ESTA DENTRO DE NUESTRO DATASET

             CrystalReportGenerarVentas rpt1 = new  CrystalReportGenerarVentas ();
            rpt1.SetDataSource(Ds);

            crystalReportViewer1.ReportSource = rpt1;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // fin del metodo loaad del crystaldocument

        

       
    }
}
