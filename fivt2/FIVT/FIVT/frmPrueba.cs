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
    public partial class frmPrueba : Form
    {
        public frmPrueba()
        {
            InitializeComponent();
        }

        SqlConnection MiConexion = new SqlConnection("Data Source=GEIDISON;Initial Catalog=BDFacturacion;Integrated Security=True");
        
        

           




       
    
        
              
        








        private void frmPrueba_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM tblCliente  WHERE Nombres  LIKE '%" + this.textBox1.Text + "%'", MiConexion);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Nombres ");
            this.dataGridView1.DataSource = ds.Tables[0];







        }

        private void frmPrueba_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDFacturacionDataSet.tblCliente' Puede moverla o quitarla según sea necesario.
            this.tblClienteTableAdapter.Fill(this.bDFacturacionDataSet.tblCliente);

        }
    }
}
