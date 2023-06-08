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
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }


        // este metodo llena mi datagrid
        private void guardar()
        {
            try
            {
                ConexionBD cn=new ConexionBD ();

                DataTable dt = new DataTable();
                cn.da = new System.Data.SqlClient.SqlDataAdapter(" Select * from TBL_ARTICULO ", cn.MiConexion);
                cn.da.Fill(dt);

                //

                dataGridView1.DataSource = dt.DefaultView;
            }
            // catch se usa apara enviar error o sea si no se cumple

            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
              ConexionBD cn=new ConexionBD ();
            cn.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM TBL_ARTICULO  WHERE ID  LIKE '%" + this.txtDatoBuscar.Text + "%'", cn.MiConexion);
                DataSet ds = new DataSet();

                cn.da.Fill(ds, "ID");
                cn.MiConexion.Close();

                this.txtDatoBuscar.Text = "";
                this.dataGridView1.DataSource = ds.Tables[0];
                // este codigo es para si no existe ese dato
                if (dataGridView1.Rows.Count == 0)
                {
                    if (MessageBox.Show("No existe Ingrese otro ID ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        this.txtDatoBuscar.Text = "";
                    this.txtDatoBuscar.Focus();
                    this.guardar();
                    this.dataGridView1.RefreshEdit();

                }
            
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
           guardar ();
        }
    }
}
