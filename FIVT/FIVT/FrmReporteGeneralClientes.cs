using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FIVT
{
    public partial class FrmReporteGeneralClientes : Form
    {
        
        public FrmReporteGeneralClientes()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {     
            try
            {
                 String ConnStr = @"Data Source=GEIDISON;Initial Catalog=BDFacturacion;Integrated Security=True";

                // LA DE ARRIBA ES NUESTRA CADENA DE CONEXION DEL SERVIDOR

                SqlConnection myConnection = new SqlConnection(ConnStr); // TIENEN QUE UTILIZAR EN EL USING LA CLASE DE System.Data.SqlClient

                String Query = "SELECT * FROM Tbl_Cliente"; // ESTE ES NUESTRO QUERY

                SqlDataAdapter adapter = new SqlDataAdapter(Query, ConnStr);

                BDFacturacionDataSet Ds = new BDFacturacionDataSet   (); // ESTE ES EL NOMBRE DE NUESTRO DATASET
                adapter.Fill(Ds, "Tbl_Cliente"); // ESTE Reportes ES EL NOMBRE DE NUESTRA TABLA DE DATOS QUE ESTA DENTRO DE NUESTRO DATASET

               CrystalReportGeneralCliente rpt1 = new CrystalReportGeneralCliente ();
                rpt1.SetDataSource(Ds);

                crystalReportViewer1.ReportSource = rpt1;



            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // fin del metodo loaad del crystaldocument


        private void FrmReporteGeneralClientes_Load(object sender, EventArgs e)
        {

        }

      

            

       
    }
}
