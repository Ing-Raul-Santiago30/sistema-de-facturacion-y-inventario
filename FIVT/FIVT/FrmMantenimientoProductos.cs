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
    public partial class FrmMantenimientoProductos : Form
    {
        public FrmMantenimientoProductos(string nombre)
        {
            InitializeComponent();
            this.NombreUsuario = nombre;
        }
        string NombreUsuario;
        ConexionBD cn = new ConexionBD();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmMantenimientoProductos_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = NombreUsuario;

            DTVIUD();
            KeyPreview = true;
            mktCedulaBuscar.Visible = false;
            ControlBox = false;
                MaximizeBox=false;
            MinimizeBox=false;
            dataGridView1.ReadOnly = true;

            // Invocamos motodo que `pasa los  datos para el data griview
            guardar();

            // desabilito estos campos
           txtFecha.Enabled = false;
           this.txtIDProducto.Enabled = false;

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




        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
                   
            

            }

        private void Salir ()
        {
            if (MessageBox.Show("Deseas salir  ", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {

                this.Hide();
                this.Close();
                this.Dispose();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salir();
           
        }
        private void Eliminar()
        {

            if (txtIDProducto.Text != "")
            {
                if (MessageBox.Show("Seguro que desea eliminar este dato", "Advertencia ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    try
                    {
                        cn.MiConexion.Open();
                        // igualamos nuestra conecion con sqlcomand
                        cn.ComandoSql.Connection = cn.MiConexion;

                        cn.ComandoSql.CommandText = "delete  from tblProductos where IdProducto ='" + txtIDProducto.Text + "'";
                        cn.ComandoSql.ExecuteNonQuery();
                        cn.da.Fill(cn.ds, "IdProducto");
                        cn.MiConexion.Close();
                        this.dataGridView1.DataSource = cn.ds.Tables[0];


                        // Limpiare los Campos

                        this.txtIDProducto.Text = "";
                        this.txtNombreProducto.Text = "";
                        this.txtDescripcion.Text = "";
                        this.txtCantidad.Text = "";
                        this.txtPrecioUnitario.Text = "";
                        this.txtFecha.Text = "";
                        cmbSeleccion.Focus();

                        MessageBox.Show("Dato Eliminado", "Exelente ");
                        this.guardar();
                        this.dataGridView1.RefreshEdit();
                    }// try fin

                    catch (Exception)
                    {
                        if (MessageBox.Show("Esta Accion No se pudo realizar Por que Usted intento Editar la Información si deseas continuar Precione Aceptar ", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                            cn.MiConexion.Close();

                        this.txtIDProducto.Text = "";
                        this.txtNombreProducto.Text = "";
                        this.txtDescripcion.Text = "";
                        this.txtCantidad.Text = "";
                        this.txtPrecioUnitario.Text = "";
                        this.txtFecha.Text = "";



                    }







                }


            }

            else
            {

                MessageBox.Show("Selecione el Dato a Eliminar en el Registros de Productos ", "Aviso ");
            }
 
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Eliminar();

            
                      

            

        }
        private void Actualizar()
        {

            if (txtIDProducto.Text != "")
            {
                if (MessageBox.Show("Seguro que desea Actualizar este dato", "Advertencia ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                   try
                    {

                        cn.MiConexion.Open();

                        cn.ComandoSql.CommandText = "UPDATE  Tbl_Productos  SET   PNombres =@PNombres  , PDescripción =@PDescripción , PCantidadPorUnidad = @PCantidadPorUnidad , PPrecioUnidad =@PPrecioUnidad , PFechaEntrada =@PFechaEntrada   WHERE PId =@PId";

                        cn.ComandoSql.Connection = cn.MiConexion;
                        // debemos limpiar todos los parametros primero 
                        cn.ComandoSql.Parameters.Clear();
                        cn.ComandoSql.Parameters.AddWithValue("@PId", txtIDProducto.Text);
                        cn.ComandoSql.Parameters.AddWithValue("@PNombres", txtNombreProducto.Text);
                        cn.ComandoSql.Parameters.AddWithValue("@PDescripción", txtDescripcion.Text);
                        cn.ComandoSql.Parameters.AddWithValue("@PCantidadPorUnidad", txtCantidad.Text);
                        cn.ComandoSql.Parameters.AddWithValue("@PPrecioUnidad", txtPrecioUnitario.Text);
                        cn.ComandoSql.Parameters.AddWithValue("@PFechaEntrada", txtFecha.Text);

                        cn.ComandoSql.ExecuteNonQuery();
                        cn.MiConexion.Close();


                        MessageBox.Show("Dactos Actualizado Exitosamente");
                        cn.MiConexion.Close();
                        // este metodo vuelve a cargar 
                        this.guardar();
                        this.dataGridView1.RefreshEdit();

                        this.txtIDProducto.Text = "";
                        this.txtNombreProducto.Text = "";
                        this.txtDescripcion.Text = "";
                        this.txtCantidad.Text = "";
                        this.txtPrecioUnitario.Text = "";
                        this.txtFecha.Text = "";


                    }

                    catch (Exception)
                    {
                        if (MessageBox.Show("No se pudo conectar", "  ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                        {
                            cn.MiConexion.Close();



                            this.txtIDProducto.Text = "";
                            this.txtNombreProducto.Text = "";
                            this.txtDescripcion.Text = "";
                            this.txtCantidad.Text = "";
                            this.txtPrecioUnitario.Text = "";
                            this.txtFecha.Text = "";


                        }
                    }
                }
            }


            else
            {

                MessageBox.Show("Selecione el Dato a Actualizar en el Registro de Productos ", "Aviso ");
            }

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            Actualizar();      
             
              
             
             
            
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

             else if (cmbSeleccion.Text == "Fecha"  )
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
                       
            cn.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM Tbl_Productos  WHERE PId  LIKE '%" + this.txtDatoBuscar.Text + "%'", cn.MiConexion);
            DataSet ds = new DataSet();

            cn.da.Fill(ds, "PId");
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

        // por fecha
        private void BuscarFecha()
        {

            cn.MiConexion.Open();
            cn.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM Tbl_Productos  WHERE PFechaEntrada  LIKE '%" + this.mktCedulaBuscar.Text + "%'", cn.MiConexion);
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
        // nombre de producto
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


            try
            {
                /* this.txtIDProducto.Text = "";
                this.txtNombreProducto.Text = "";
               this.txtDescripcion.Text = "";
                this.txtCantidad.Text = "";
                this.txtPrecioUnitario.Text = "";
                this.txtFecha.Text = "";
                 */




                DataTable dt = new DataTable();
                cn.da = new System.Data.SqlClient.SqlDataAdapter(" Select * from Tbl_Productos  where PId=" + Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) + "", cn.MiConexion);
                cn.da.Fill(dt);

                // cuanndo agamo doblec clic pasaremos los datos a los txtbox//

                this.txtIDProducto.Text = dt.Rows[0][0].ToString();
                 this.txtNombreProducto.Text = dt.Rows[0][1].ToString();
                this.txtDescripcion.Text = dt.Rows[0][2].ToString();
                this.txtCantidad.Text = dt.Rows[0][3].ToString();
                 this.txtPrecioUnitario.Text = dt.Rows[0][4].ToString();
                 this.txtFecha.Text = dt.Rows[0][5].ToString();
               

                cn.MiConexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                cn.MiConexion.Close();

                this.txtIDProducto.Text = "";
                this.txtNombreProducto.Text = "";
               this.txtDescripcion.Text = "";
                this.txtCantidad.Text = "";
                this.txtPrecioUnitario.Text = "";
                this.txtFecha.Text = "";
                
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

            

             private void dataGridView1_DoubleClick(object sender, EventArgs e)
             {
                  try
            {
                 this.txtIDProducto.Text = "";
                this.txtNombreProducto.Text = "";
               this.txtDescripcion.Text = "";
                this.txtCantidad.Text = "";
                this.txtPrecioUnitario.Text = "";
                this.txtFecha.Text = "";
                 




                DataTable dt = new DataTable();
                cn.da = new System.Data.SqlClient.SqlDataAdapter(" Select * from Tbl_Productos  where PId=" + Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) + "", cn.MiConexion);
                cn.da.Fill(dt);

                // cuanndo agamo doblec clic pasaremos los datos a los txtbox//

                this.txtIDProducto.Text = dt.Rows[0][0].ToString();
                 this.txtNombreProducto.Text = dt.Rows[0][1].ToString();
                this.txtDescripcion.Text = dt.Rows[0][2].ToString();
                this.txtCantidad.Text = dt.Rows[0][3].ToString();
                 this.txtPrecioUnitario.Text = dt.Rows[0][4].ToString();
                 this.txtFecha.Text = dt.Rows[0][5].ToString();
               

                cn.MiConexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                cn.MiConexion.Close();

                this.txtIDProducto.Text = "";
                this.txtNombreProducto.Text = "";
               this.txtDescripcion.Text = "";
                this.txtCantidad.Text = "";
                this.txtPrecioUnitario.Text = "";
                this.txtFecha.Text = "";
                
            
        }

             }
             private void Limpiar()
             {
                 this.txtIDProducto.Text = "";
                 this.txtNombreProducto.Text = "";
                 this.txtDescripcion.Text = "";
                 this.txtCantidad.Text = "";
                 this.txtPrecioUnitario.Text = "";
                 this.txtFecha.Text = "";
             }

             private void button4_Click(object sender, EventArgs e)
             {
                 Limpiar();
                 
             }

             private void button3_Click(object sender, EventArgs e)
             {

             }

             private void lblUsuario_Click(object sender, EventArgs e)
             {

             }

             private void FrmMantenimientoProductos_KeyDown(object sender, KeyEventArgs e)
             {
                 if (e.KeyCode == Keys.F1)
                 {
                     Actualizar();
                 }

                 else if (e.KeyCode == Keys.F2)
                 {
                     Eliminar();
                 }
                 else if (e.KeyCode == Keys.F3)
                 {
                     Salir();
                 }
                 else if (e.KeyCode == Keys.F4)
                 {
                     Limpiar();
                 }
             }




        }

    }

