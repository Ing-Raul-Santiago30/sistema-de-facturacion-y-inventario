using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace FIVT
{
    public partial class FrmConsultaProducto : Form
    {
        public FrmConsultaProducto()//string nombre)
        {
            InitializeComponent();
            this.NombreUsuario = "nombre";
            
        }
        string NombreUsuario;
        ConexionBD cn=new ConexionBD ();
            


        

        private void Frm_ConsultaProducto_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = NombreUsuario;
            
                dataGridView1.ReadOnly = true;




                KeyPreview = true;
             
            

            // dataGridView1 eliminamos la ultima fila que por defecto aparece vacia con este metodo
            DTVIUD();

            // desabilitaremos la maskara cedula

            mktCedulaBuscar.Visible = false;
            MaximizeBox = false;
            ControlBox = false;
            MinimizeBox = false;



            // Invocamos motodo que `pasa los  datos para el data griview
            guardar();


            // y para que se pueda selecionar vamos a la propieda selecmode




           



            

        }

        // este metodo llena mi datagrid
        private void guardar()
        {
            try
            {


                DataTable dt = new DataTable();
                cn.da = new System.Data.SqlClient.SqlDataAdapter(" Select * from Tbl_Productos ", cn.MiConexion);
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

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseas Volver Atras", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {


                Hide();
                Dispose();
                Close();
               
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Salir()
        {
            if (MessageBox.Show("Deseas Volver Atras", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {


                Hide();
                Dispose();
                Close();

            }
        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
             if (cmbSeleccion.Text == "ID" && txtDatoBuscar.Text == "")
            {
                MessageBox.Show("Digite el ID y luego Buscar ");
                txtDatoBuscar.Focus();
            }

            else if (cmbSeleccion.Text == "ID" && txtDatoBuscar.Text != "")
            {
                btnBuscar.Focus();
                BuscarPorID();
                cn.MiConexion.Close();
            }

             else if (cmbSeleccion.Text == "Fecha")
            {
                mktCedulaBuscar.Focus();
                if (mktCedulaBuscar.MaskCompleted)
                {
                    btnBuscar.Focus();
                    BuscarFecha();
                    cn.MiConexion.Close();
                }
                else
                {
                    MessageBox.Show("Complete el Campo Fecha y luego Buscar ");
                    mktCedulaBuscar.Focus();
                    cn.MiConexion.Close();
                }
                                 
            }



             if (cmbSeleccion.Text == "Nombre de Productos" && txtDatoBuscar.Text == "")
            {
                MessageBox.Show("Digite el Nombre de Productos y luego Buscar ");
                txtDatoBuscar.Focus();
                cn.MiConexion.Close();

            }

             else if (cmbSeleccion.Text == "Nombre de Productos" && txtDatoBuscar.Text != "")
            {
                btnBuscar.Focus();
                BuscarNP();
                cn.MiConexion.Close();
            }

        }

        private void BuscarPorID()
        {
            try
            {
                cn.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM Tbl_Productos  WHERE PId  LIKE '%" + this.txtDatoBuscar.Text + "%'", cn.MiConexion);
                DataSet ds = new DataSet();

                cn.da.Fill(ds, "PId");
                cn.MiConexion.Close();

                this.txtDatoBuscar.Text = "";
                this.dataGridView1.DataSource = ds.Tables[0];
                // este codigo es para si no existe ese dato
            /*    if (dataGridView1.Rows.Count == 0)
                {
                    if (MessageBox.Show("No existe Ingrese otro ID ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        this.txtDatoBuscar.Text = "";
                    this.txtDatoBuscar.Focus();
                    this.guardar();
                    this.dataGridView1.RefreshEdit();

                }*/
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        // // Este metodo hace la busqueda por fecha
        private void BuscarFecha()
        {
           
            cn.MiConexion.Open();
            cn.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM Tbl_Productos  WHERE PFechaEntrada  LIKE '%" + this.mktCedulaBuscar.Text  + "%'", cn.MiConexion);
            DataSet ds = new DataSet();
             cn.da.Fill(ds, "PFechaEntrada");
            cn.MiConexion.Close();
            this.mktCedulaBuscar.Text = "";
            this.dataGridView1.DataSource = ds.Tables[0];

            if (dataGridView1.Rows.Count == 0)
            {
               if( MessageBox.Show("No existe Ingrese otra Fecha ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1)==DialogResult.OK)
                this.mktCedulaBuscar.Text = "";
                this.mktCedulaBuscar.Focus();
                this.guardar();
                this.dataGridView1.RefreshEdit();
            }
        }


        //Este metodo hace la busqueda por nombre de producto
        private void BuscarNP()
        {

           // cn.MiConexion.Open();
            cn.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM Tbl_Productos  WHERE PNombres  LIKE '%" + this.txtDatoBuscar.Text + "%'", cn.MiConexion);
            DataSet ds = new DataSet();

            cn.da.Fill(ds, "PNombres");
            cn.MiConexion.Close();
            this.txtDatoBuscar.Text = "";
            this.dataGridView1.DataSource = ds.Tables[0];


            if (dataGridView1.Rows.Count == 0)
            {
                if (MessageBox.Show("No existe Ingrese otro Nombre de Producto ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1)==DialogResult.OK)
                this.txtDatoBuscar.Text = "";
                this.txtDatoBuscar.Focus();
                this.guardar();
                this.dataGridView1.RefreshEdit();

            }
             }     
             
        
 private void DTVIUD()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {

                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }//con este for impiden ordenar el grid dando click en las columnas




            dataGridView1.AllowUserToAddRows = false;//con esto eliminamos la ultima fila que por defecto aparece vacia
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.MultiSelect = false;//con esto podemos seleccionar solo 1 fila
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//con esta linea seleccionamos toda la fila del grid





        }

 private void cmbSeleccion_SelectedValueChanged(object sender, EventArgs e)
 {    
                       
             
              if (cmbSeleccion.Text == "ID")
            {
                this.label7.Text = "Digite el ID";
                this.txtDatoBuscar.Visible = true;
                this.mktCedulaBuscar.Visible = false;
                this.lblFormatoFecha.Visible = false;
                this.lblFormatoFecha.Enabled = false;
                this.txtDatoBuscar.Focus();


            }

            else if (cmbSeleccion.Text == "Fecha")
            {
                this.label7.Text = "Digite la Fecha ";
                this.mktCedulaBuscar.Visible = true;
                this.txtDatoBuscar.Visible = false;
                this.lblFormatoFecha.Visible = true;
                this.lblFormatoFecha.Enabled = true; ;
                this.mktCedulaBuscar.Focus();
                
            }
            else if (cmbSeleccion.Text == "Nombre de Productos")
            {
                this.label7.Text = "Digite el Nombre del Producto";
                this.txtDatoBuscar.Visible = true;
                this.mktCedulaBuscar.Visible = false;
                this.lblFormatoFecha.Visible = false;
                this.lblFormatoFecha.Enabled = false;
                this.txtDatoBuscar.Focus();

            }

            else if (cmbSeleccion.Text == "")
            {
                MessageBox.Show("Escoja una Opcion ");
                this.cmbSeleccion.Focus();
            }

        }

 private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
 {
     dataGridView1.ReadOnly = true;

 }

 private void dataGridView1_Click(object sender, EventArgs e)
 {
     dataGridView1.ReadOnly = true;
 }

 private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
 {
     dataGridView1.ReadOnly = true;
 }

 private void groupBox1_Enter(object sender, EventArgs e)
 {

 }

 private void FrmConsultaProducto_KeyDown(object sender, KeyEventArgs e)
 {
     if (e.KeyCode == Keys.F3)
         Salir();
 }   


 }
     
    }

        
    

