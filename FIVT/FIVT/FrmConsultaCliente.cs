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
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente(string nombre)
        {
            InitializeComponent();
            this.NombreUsuario = nombre;
        }
        string NombreUsuario;
        ConexionBD cn = new ConexionBD();

        

       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tblClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           

        }
        

        private void btnBuscar_Click(object sender, EventArgs e)
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

            else if (cmbSeleccion.Text == "Cedula")
            {
                mktCedulaBuscar.Focus();
                if (mktCedulaBuscar.MaskCompleted)
                {
                    btnBuscar.Focus();
                    BuscarPorCedula();
                    cn.MiConexion.Close();
                }
                else
                {
                    MessageBox.Show("Complete el Campo Cedula y luego Buscar ");
                    mktCedulaBuscar.Focus();
                    cn.MiConexion.Close();

                    
                }

            }





            if (cmbSeleccion.Text == "Nombre" && txtDatoBuscar.Text == "")
            {
                MessageBox.Show("Digite el Nombre y luego Buscar ");
                txtDatoBuscar.Focus();
                cn.MiConexion.Close();

            }

            else if (cmbSeleccion.Text == "Nombre" && txtDatoBuscar.Text != "")
            {
                btnBuscar.Focus();
                BuscarPorNombre();
                cn.MiConexion.Close();
            }











           


           
        }


        // este metodo hace la busqueda por ID
        private void BuscarPorID()
        {

            
                cn.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM Tbl_Cliente  WHERE CId  LIKE '%" + this.txtDatoBuscar.Text + "%'", cn.MiConexion);
                DataSet ds = new DataSet();

                cn.da.Fill(ds, "CId");
                cn.MiConexion.Close();
                this.txtDatoBuscar.Text = "";
                
                
                this.dataGridView1.DataSource = ds.Tables[0];
            

          
                // este codigo es para si no existe ese dato
                if (dataGridView1.Rows.Count == 0)
                {
                   if( MessageBox.Show("No existe Ingrese otro ID ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1)==DialogResult.OK)
                this.txtDatoBuscar.Text = "";
                this.txtDatoBuscar.Focus();
                this.guardar();
                this.dataGridView1.RefreshEdit();
                 }




        }

        // este metodo hace la busqueda por Cedula
        private void BuscarPorCedula()
        {
            
                cn.MiConexion.Open();
                cn.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM Tbl_Cliente  WHERE CCedula  LIKE '%" + this.mktCedulaBuscar.Text + "%'", cn.MiConexion);
                DataSet ds = new DataSet();

                cn.da.Fill(ds, "CCedula");
                cn.MiConexion.Close();
                this.mktCedulaBuscar.Text = "";
                this.dataGridView1.DataSource = ds.Tables[0];
           
                if (dataGridView1.Rows.Count == 0)
                {
                    if (MessageBox.Show("No existe Ingrese otra Cedula ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1)==DialogResult.OK)
                    this.mktCedulaBuscar.Text = "";
                    this.mktCedulaBuscar.Focus();
                    this.guardar();
                    this.dataGridView1.RefreshEdit();
                }
                
            

        }

        private void BuscarPorNombre()
        {
            
                // cn.MiConexion.Open();
                cn.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM Tbl_Cliente  WHERE CNombres  LIKE '%" + this.txtDatoBuscar.Text + "%'", cn.MiConexion);
                DataSet ds = new DataSet();

                cn.da.Fill(ds, "CNombres");
                cn.MiConexion.Close();
                this.txtDatoBuscar.Text = "";
                this.dataGridView1.DataSource = ds.Tables[0];



                if (dataGridView1.Rows.Count == 0)
                {
                   if ( MessageBox.Show("No existe Ingrese otro Nombre ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1)==DialogResult.OK)
                    this.txtDatoBuscar.Text = "";
                    this.txtDatoBuscar.Focus();
                    this.guardar();
                    this.dataGridView1.RefreshEdit();
                }

            
           
        }
            
        private void Frm_ConsultaCliente_Load(object sender, EventArgs e)
        {
            
            lblUsuario.Text = NombreUsuario;
            // no editar dentro de las celdas
            dataGridView1.ReadOnly = true;
            KeyPreview = true;
            mktCedulaBuscar.Visible = false;
            MaximizeBox = false;
            ControlBox = false;
            MinimizeBox = false;


            // dataGridView1 eliminamos la ultima fila que por defecto aparece vacia
            DTVIUD();

            // Invocamos motodo que `pasa los  datos para el data griview
            guardar();





            // auto completar

            //cargar los datos para el autocomplete del textbox
            this.txtDatoBuscar.AutoCompleteCustomSource = AutoCompleClass.Autocomplete2();
            this.txtDatoBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtDatoBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
               

        }



         // este llena el  datagriviu o carga los datos al datagridviud

        private void guardar()
        {
            try
            {
                
                DataTable dt = new DataTable();
                cn.da = new System.Data.SqlClient.SqlDataAdapter(" Select * from Tbl_Cliente ", cn.MiConexion);
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
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }


        private void Salir()
    {  if (MessageBox.Show("Deseas Volver Atras", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                

               Hide();
                Dispose();
                Close();
                
            }}
        private void button2_Click(object sender, EventArgs e)
        {


            Salir();
        }

        private void cmbSeleccion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbSeleccion.Text == "ID")
            {
                this.label7.Text = "Digite el ID";
                this.txtDatoBuscar.Visible = true;
                this.mktCedulaBuscar.Visible = false;
                this.txtDatoBuscar.Focus();


            }

            else if (cmbSeleccion.Text == "Cedula")
            {
                this.label7.Text = "Digite la Cedula ";
                this.mktCedulaBuscar.Visible = true;
                this.txtDatoBuscar.Visible = false;
                this.mktCedulaBuscar.Focus();

            }
            else if (cmbSeleccion.Text == "Nombre")
            {
                this.label7.Text = "Digite el Nombre";
                this.txtDatoBuscar.Visible = true;
                this.mktCedulaBuscar.Visible = false;
                this.txtDatoBuscar.Focus();

            }

            else if (cmbSeleccion.Text == "")
            {
                MessageBox.Show("Escoja una Opcion ");
                this.cmbSeleccion.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmConsultaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
                Salir();
        }




        }

      
    }

