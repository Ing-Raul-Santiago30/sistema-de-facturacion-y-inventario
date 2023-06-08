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
    public partial class FrmReporteClientesID : Form
    {
        public FrmReporteClientesID(string valor)
        {
            InitializeComponent();
            this.a = valor;
        }
        string a;
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {

            ConexionBD BD = new ConexionBD();
            BD.MiConexion.Open();

            String Query = "SELECT * FROM Tbl_Cliente where CID='" + Convert.ToInt32(a) + "'"; // ESTE ES NUESTRO QUERY

            BD.da = new System.Data.SqlClient.SqlDataAdapter(Query, BD.MiConexion);

            BDFacturacionDataSet Ds = new BDFacturacionDataSet(); // ESTE ES EL NOMBRE DE NUESTRO DATASET
            BD.da.Fill(Ds, "Tbl_Cliente"); // ESTE Reportes ES EL NOMBRE DE NUESTRA TABLA DE DATOS QUE ESTA DENTRO DE NUESTRO DATASET


           CrystalReportGeneralCliente rpt1 = new CrystalReportGeneralCliente ();
            rpt1.SetDataSource(Ds);

            if (rpt1.Rows.Count != 0)
            {
                {
                    crystalReportViewer1.ReportSource = rpt1;
                }

            }
            else
            {
                if (MessageBox.Show("No existe Ingrese otro ID", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    this.Hide();
                    this.Close();

                }

            }
            BD.MiConexion.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmReporteClientesID_Load(object sender, EventArgs e)
        {

        } // fin del metodo loaad del crystaldocument

    }
}
