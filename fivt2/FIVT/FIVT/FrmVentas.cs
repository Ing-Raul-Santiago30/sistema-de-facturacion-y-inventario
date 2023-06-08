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
    public partial class FrmVentas : Form
    {
        public FrmVentas(string nombre)
        {
            InitializeComponent();
            this.NombreUsuario = nombre;
        }

        string NombreUsuario;
        ConexionBD cn = new ConexionBD();

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // si seleciono ID
            if (cmbSeleccion.Text == "ID")
            {
                this.lblSeleciónCliente.Text = "Digite el ID";
                this.txtDatoBuscar.Visible = true;
                this.mktBuscarPorCedula.Visible = false;
                this.txtDatoBuscar.Focus();


            }

            else if (cmbSeleccion.Text == "Cedula")
            {
                this.lblSeleciónCliente.Text = "Digite la Cedula ";
                this.mktBuscarPorCedula.Visible = true;
                this.txtDatoBuscar.Visible = false;
                this.mktBuscarPorCedula.Focus();

            }
            else if (cmbSeleccion.Text == "Nombre")
            {
                this.lblSeleciónCliente.Text = "Digite el Nombre";
                this.txtDatoBuscar.Visible = true;
                this.mktBuscarPorCedula.Visible = false;
                this.txtDatoBuscar.Focus();

            }

            else if (cmbSeleccion.Text == "")
            {
                MessageBox.Show("Escoja una Opcion ");
                this.cmbSeleccion2.Focus();
            }

        }
        //este metodo carga el ultimo Id INsertado 
        private void prueba()
        {

            DataTable dt = new DataTable();

            cn.da = new System.Data.SqlClient.SqlDataAdapter(" SELECT * FROM Tbl_Cliente WHERE CId=(SELECT MAX(CId) from Tbl_Cliente);", cn.MiConexion);
            cn.da.Fill(dt);

            textBox2.Text = dt.Rows[0][0].ToString();
            cn.MiConexion.Close();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = NombreUsuario;
            //Auto ajustar los formuluarios
           this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            
           this.Size = Screen.PrimaryScreen.WorkingArea.Size;
           
           MinimizeBox = false;
           MaximizeBox = false;
           

            

            txtID.Enabled = false;
            mkTCedula.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;


            txtDatoBuscar.Visible = false;

           txtPrecio.Enabled = false;
            txtSubTotal.Enabled = false;
            txtDescuento.Enabled = false;

            txtTotal.Enabled = false;
            txtCambio.Enabled = false;



            // auto completar

            //cargar los datos para el autocomplete del textbox
            this.txtDatoBuscar.AutoCompleteCustomSource = AutoCompleClass.Autocomplete2();
            this.txtDatoBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtDatoBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }
        // Este metodo limpiara todo los campos
        private void Limpiar()
        {
            txtID.Clear();
            mkTCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDatoBuscar2.Clear();

           
            lblNProducto.ResetText();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtSubTotal.Clear();
            txtDescuento.Clear();
            txtPXC.Clear();
            txtTotal.Clear();
            txtEfectivo.Clear();
            //txtCambio.Clear();



        
        }

        private void Guardar()
        {
           if (txtID.Text != "" & mkTCedula.Text != "" & txtNombre.Text != "" & txtApellido.Text != "" & txtPrecio.Text != "" & lblNProducto.Text != "" & txtPrecio.Text != "" & txtCantidad.Text != "" & txtSubTotal.Text != "" & txtDescuento.Text != "" & txtPXC.Text != "" & txtTotal.Text != "" & txtEfectivo.Text != "" & txtCambio.Text != "")
                  {
                               
                
                try
                {

                    cn.MiConexion.Open();
                    //acsociamos comando sql con conexion 

                    cn.ComandoSql.Connection = cn.MiConexion;

                    cn.ComandoSql.CommandText = "Insert into Tbl_Ventas (VIdCliente,VCCedula,VCNombres,VCApellidos,VPNombre,VPPrecio,VCantidad,VSubTotal,VDescuento,VPrecioxC,VTotal,VPago,VCambio,VFechaPedido ) values ('" + txtID.Text + "' ,  '" + mkTCedula.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + lblNProducto.Text + "','" + txtPrecio.Text + "','" + txtCantidad.Text + "','" + txtSubTotal.Text + "','" + txtDescuento.Text + "','" + txtPXC.Text + "','" + txtTotal.Text + "','" + txtEfectivo.Text + "','" + txtCambio.Text + "','" + mktFechaFactura.Text + "')";
                    cn.ComandoSql.ExecuteNonQuery();
                    cn.ComandoSql.Clone();


                    MessageBox.Show("Factura Realizada Exitosamente !", "Exelente !");
                    this.cn.MiConexion.Close();
                    Limpiar();
                }


                catch (Exception)
                {
                    MessageBox.Show("Error de conexion Consulte un tecnico ");
                }

           }
                else
            {
                MessageBox.Show("Introdusca la Cantidad a Pagar");
            }

           }
           
                
        







        private void descuento()
        {
            float p = 0;//precio de producto
            int c = 0;// catidad digitada
            double PxC = 0; //precio por cantidad
            double subtotal = 0; // subtotal
            double descuento = 0; // descuento
            double total = 0;// total a pagar

            if (txtCantidad.Text != "")
            {
                if (txtCantidad.Text != "0")
                {
                    p = Convert.ToSingle(txtPrecio.Text.ToString());
                    c = Convert.ToInt32(txtCantidad.Text.ToString());
                    
                    if (c <= 3)
                    {
                        descuento = 0 * p * c;
                        txtDescuento.Text = Convert.ToString(Math.Round(descuento, 2));
                    }

                    else if (c >= 4 & c <= 7)
                    {
                        descuento = 0.05 * p * c;
                        txtDescuento.Text = Convert.ToString(Math.Round(descuento, 2));                        
                    }

                    else if (c >= 8 & c <= 11)
                    {
                        descuento = 0.09 * p * c;
                        txtDescuento.Text = Convert.ToString(Math.Round(descuento, 2));
                    }
                        
                    else if (c >= 12 & c <= 15)
                    {
                        descuento = 0.11 * p * c;
                        txtDescuento.Text = Convert.ToString(Math.Round(descuento, 2));
                    }

                    else if (c >= 16 & c <= 19)
                    {
                        descuento = 0.13 * p * c;
                        txtDescuento.Text = Convert.ToString(Math.Round(descuento, 2));
                    }

                    else if (c >= 20 & c <= 23)
                    {
                        descuento = 0.15 * p * c;
                        txtDescuento.Text = Convert.ToString(Math.Round(descuento, 2));

                    }

                    else if (c >= 24 & c <= 27)
                    {
                        descuento = 0.17 * p * c;
                        txtDescuento.Text = Convert.ToString(Math.Round(descuento, 2));
                        
                    }
                    else if (c >= 30)
                    {
                        descuento = 0.20 * p * c;
                        txtDescuento.Text = Convert.ToString(Math.Round(descuento, 2));

                    }

                    subtotal = p * c;
                    total = subtotal - descuento;
                    txtSubTotal.Text = Convert.ToString(Math.Round(subtotal, 2));
                    PxC = total / c; ;
                    txtPXC.Text = Convert.ToString(Math.Round(PxC, 2));
                    txtTotal.Text = Convert.ToString(Math.Round(total, 2));
                    txtEfectivo.Focus();
                }

                else
                {
                    if (MessageBox.Show("La cantidad no puede ser:(0) ", "error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                    {
                        txtCantidad.ResetText();
                        txtCantidad.Focus();
                    }
                }
            }

                    else
                    {
                        if (MessageBox.Show("Digite la Cantida a comprar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        {

                            txtCantidad.Focus();

                        }


                    }
                }
            
        
            

        private void Cobar()
        {
            double total = 0; //total a pagar
            int f;//efectivo a pagar
            
            double cambio = 0;// cambio devuelto
            if (txtEfectivo.Text != "")
            {//if0
                total = Convert.ToDouble(txtTotal.Text);
                  f = Convert.ToInt32(txtEfectivo.Text);
                                 
                      
                      if (f >= total)
                      {
                          cambio = f - total;
                          txtCambio.Text = Convert.ToString(Math.Round(cambio, 2));
                      }

                      else
                      {//0
                          if (MessageBox.Show("el pago debe ser igual o mas alto que el Total", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                          {
                              txtEfectivo.ResetText();
                              txtEfectivo.Focus();

                          }

                      }//0

                  }//if0
        }
                   
     

        //creamos un nuevo metodo
        private void AddCedula()
        {
            if (mktBuscarPorCedula.MaskCompleted)
            {

                ConexionBD cn = new ConexionBD();
                cn.MiConexion.Open();

                cn.ComandoSql.CommandText = ("Select * from Tbl_Cliente  where CCedula='" + Convert.ToString(mktBuscarPorCedula.Text) + "'");
                cn.ComandoSql.Connection = cn.MiConexion;
                cn.leerDatos = cn.ComandoSql.ExecuteReader();

                while (cn.leerDatos.Read())
                {

                    txtID.Text = (cn.leerDatos[0].ToString());
                    mkTCedula.Text = (cn.leerDatos[1].ToString());
                    txtNombre.Text = (cn.leerDatos[2].ToString());
                    txtApellido.Text = (cn.leerDatos[3].ToString());

                    txtDatoBuscar2.Focus();

                    mktBuscarPorCedula.ResetText();
                }

            }
        }
        // buscar por nombre
        private void AddNombre()
        {

            try
            {
                DataTable dt = new DataTable();

                cn.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM Tbl_Cliente  WHERE CNombres  LIKE '%" + this.txtDatoBuscar.Text + "%'", cn.MiConexion);

                cn.da.Fill(dt);

                txtDatoBuscar.Clear();

                txtID.Text = dt.Rows[0][0].ToString();
                mkTCedula.Text = dt.Rows[0][1].ToString();
                txtNombre.Text = dt.Rows[0][2].ToString();
                txtApellido.Text = dt.Rows[0][3].ToString();
                txtDatoBuscar2.ResetText();
                cn.MiConexion.Close();
            }
            catch (Exception)
            {
                txtDatoBuscar.Clear();
                MessageBox.Show("Nombre no encontrado digite otro");
                txtDatoBuscar.Focus();
                cn.MiConexion.Close();

                txtID.Text = "";




            }
        }



        // buscar datos por ID
        private void AddID()
        {

            try
            {
                DataTable dt = new DataTable();
                cn.da = new System.Data.SqlClient.SqlDataAdapter(" Select * from Tbl_Cliente  where CId=" + Convert.ToInt16(txtDatoBuscar.Text.ToString()) + "", cn.MiConexion);
                cn.da.Fill(dt);
                                
                txtID.Text = dt.Rows[0][0].ToString();
                mkTCedula.Text = dt.Rows[0][1].ToString();
                txtNombre.Text = dt.Rows[0][2].ToString();
                txtApellido.Text = dt.Rows[0][3].ToString();
                txtDatoBuscar.ResetText();
                txtDatoBuscar2.Focus();

                cn.MiConexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ID no encotrado digite otro");
                txtDatoBuscar.Clear();
                txtDatoBuscar.Focus();
                cn.MiConexion.Close();
            }
        }
        // buscar por Id producto
        private void AddIDProducto()
        {

            try
            {
               
                DataTable dt = new DataTable();
                cn.da = new System.Data.SqlClient.SqlDataAdapter(" Select * from Tbl_Productos  where PId=" + Convert.ToInt16(txtDatoBuscar2.Text.ToString()) + "", cn.MiConexion);
                cn.da.Fill(dt);

               
                 txtPrecio.Text = dt.Rows[0][4].ToString();
                
               
                lblNProducto.Text = dt.Rows[0][1].ToString();
                txtDatoBuscar2.ResetText();
               

                cn.MiConexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ID no encotrado digite otro");
                txtDatoBuscar.Clear();
                txtDatoBuscar.Focus();
                cn.MiConexion.Close();
            }
        }

        
        private void cmbSeleccion2_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmbSeleccion2.Text == "ID")
            {
                this.lblSeleciónProductos.Text = "Digite el ID";
                this.txtDatoBuscar2.Visible = true;


                this.txtDatoBuscar2.Focus();


            }


            else if (cmbSeleccion2.Text == "Nombre de Producto")
            {
                this.lblSeleciónProductos.Text = "Digite el Nombre del Producto";
                this.txtDatoBuscar2.Visible = true;


                this.txtDatoBuscar2.Focus();

            }

            else if (cmbSeleccion2.Text == "")
            {
                MessageBox.Show("Escoja una Opcion ");
                this.cmbSeleccion2.Focus();
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mktFechaFactura.Text = DateTime.Now.ToShortDateString();
        }

        private void mktCedulaBuscar_Enter(object sender, EventArgs e)
        {

        }


        private void mktCedulaBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mktBuscarPorCedula.MaskCompleted)
            {
                Existe();

                if (mkTCedula.MaskCompleted && mktFechaFactura.Text != "" & txtNombre.Text != "" && txtApellido.Text != "")
                {
                    txtDatoBuscar2.Focus();

                }
            }
        }

        // es un metodo para que diga si la cedula existe

        private void Existe()
        {
               ConexionBD cn = new ConexionBD();
                cn.MiConexion.Open();
                cn.ComandoSql.CommandText = @"SELECT * FROM Tbl_Cliente WHERE CCedula ='" + mktBuscarPorCedula.Text + "'";
                cn.ComandoSql.Connection = cn.MiConexion;
                cn.leerDatos = cn.ComandoSql.ExecuteReader();
                

                if (cn.leerDatos.Read() == false)
                {

                    if ( MessageBox.Show("La Cedula no Existe en la base del Registro ", "Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1)==DialogResult.OK)

                     mktBuscarPorCedula.ResetText();
                   
                        mktBuscarPorCedula.Focus();
                        mktBuscarPorCedula.Text.Trim();
                        cn.MiConexion.Close();
                    
                

            }
        }


        private void mktBuscarPorCedula_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void mktBuscarPorCedula_Validated(object sender, EventArgs e)
        {
           
        }

        private void txtDatoBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDatoBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (cmbSeleccion.Text == "ID")
            {
                if (e.KeyCode == Keys.Enter)
                { AddID(); }

            }

            else if (cmbSeleccion.Text == "Nombre")
            {
                if (e.KeyCode == Keys.Enter)
                { AddNombre(); }

            }



        }

        private void mktBuscarPorCedula_KeyDown(object sender, KeyEventArgs e)
        {
            
            
              
                    if (e.KeyCode == Keys.Enter)
                    {
                        if (mktBuscarPorCedula.MaskCompleted)
                        {
                                            
                        AddCedula();
                        }
                        else
                        {
                            MessageBox.Show("Complete el campo");
                            mktBuscarPorCedula.Focus();
                            
                        }

                }                      
            
                                }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            prueba();
            //AddIDProducto();
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {

        }



        private void txtEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
           
                if (e.KeyCode == Keys.Enter)
                {
                    Cobar();
                    Guardar();
                }
            
            
        }

        private void txtCantida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                descuento();
                
            }
        }

        private void txtDatoBuscar2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                AddIDProducto();
                txtCantidad.Focus();
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mktBuscarPorCedula.MaskCompleted)
            {

                Existe();
                AddCedula();
            }
            else
            {
                MessageBox.Show("Complete el campo");
                mktBuscarPorCedula.Focus();


            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

       
       

        

    }
}



           

            

       
        

        
    

