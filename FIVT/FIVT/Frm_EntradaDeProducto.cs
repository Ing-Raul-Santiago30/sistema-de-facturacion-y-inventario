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
    public partial class Frm_EntradaDeProducto : Form
    {
        public Frm_EntradaDeProducto(string nombre)
        {
            InitializeComponent();
            this.NombreUsuario = nombre;
        }
        string NombreUsuario;
        ConexionBD cBD = new ConexionBD();


        private void Frm_EntradaDeProducto_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            txtIDProducto.ReadOnly = true;
            this.txtIDProducto.Enabled = false;
            CargarID();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

       

        private void Insertar()
        {

            if (txtNombreProducto.Text != "" & txtDescripcion.Text != "" & txtCantidad.Text != "" & txtPrecioUnitario.Text != "" && mktFecha.MaskCompleted)
            {
                
                cBD.MiConexion.Open();
                /* acsociamos comando sql con conexion */

                cBD.ComandoSql.Connection = cBD.MiConexion;

                cBD.ComandoSql.CommandText = "Insert into Tbl_Productos(PNombres,PDescripción,PCantidadPorUnidad,PPrecioUnidad,PFechaEntrada) values ('" + txtNombreProducto.Text + "','" + txtDescripcion.Text + "','" + txtCantidad.Text + "','" + txtPrecioUnitario.Text + "','" + mktFecha.Text + "')";

                cBD.ComandoSql.ExecuteNonQuery();
                cBD.ComandoSql.Clone();
                MessageBox.Show("Producto Registrado Exitosamente !", "Exelente !");
                this.cBD.MiConexion.Close();
                txtIDProducto.Text = "";
                txtNombreProducto.Text = "";
                txtDescripcion.Text = "";
                txtCantidad.Text = "";
                txtPrecioUnitario.Text = "";

                txtNombreProducto.Focus();
                CargarID();

                
            }
            else if (MessageBox.Show("Has dejado Campos Vacios Continuar ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                cBD.MiConexion.Close();

                if (txtNombreProducto.Text == "")
                {

                    txtNombreProducto.Focus();
                }

                else if (txtDescripcion.Text == "")
                {
                    txtDescripcion.Focus();

                }


                else if (txtCantidad.Text == "")
                {
                    txtCantidad.Focus();

                }


                else if (txtPrecioUnitario.Text == "")
                {
                    txtPrecioUnitario.Focus();

                }

                
            }
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Insertar();


        }

        private void txtIDProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNombreProducto.Focus();
            
            }

        }

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtCantidad.Focus();
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                txtPrecioUnitario.Focus();
            }
        }

        private void txtPrecioUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistrar.Focus();
            
            }
        }

        private void Salir()
    {
        if (MessageBox.Show("Deseas salir  ", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
        {

            this.Hide();
            this.Close();
            this.Dispose();


        }
    
    }
        private void button2_Click(object sender, EventArgs e)
        {
            Salir();

        }

        private void txtIDProducto_TextChanged(object sender, EventArgs e)
        {
            txtIDProducto.Visible = true;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & this.txtCantidad.Text == "")
            {
                // podemos enviar un mensaje de texto o utilizar el control error provider
                this.errorProvider1.SetError(this.txtCantidad, "Digite una Cantidad");
                txtCantidad.Focus();
            }

            else
            {
                this.errorProvider1.Clear();
            }


            
            
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;


            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = true;
            }

        
        }

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {


          if (!char.IsNumber(e.KeyChar) & txtPrecioUnitario.Text == "")
            {
                // podemos enviar un mensaje de texto o utilizar el control error provider
                this.errorProvider1.SetError(this.txtPrecioUnitario, "Digite el Precio de venta ");
                txtPrecioUnitario.Focus();
            }

            else
            {
                this.errorProvider1.Clear();
            }
            



            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;


            }
         
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            
            }
            else
            {
                e.Handled = true;
            }


            


        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) & txtNombreProducto.Text == "")
            {
                // podemos enviar un mensaje de texto o utilizar el control error provider
                this.errorProvider1.SetError(this.txtNombreProducto, "Este Campo es Obligatorio");
                txtNombreProducto.Focus();
            }

            else
            {
                this.errorProvider1.Clear();
            }




            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;


            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }



           

        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && txtDescripcion.Text == "")
            {
                // podemos enviar un mensaje de texto o utilizar el control error provider
                this.errorProvider1.SetError(this.txtDescripcion, "Ponga una Decripción del Producto");
                txtDescripcion.Focus();
            }

            else
            {
                this.errorProvider1.Clear();
            }





            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;


            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }


        }

        private void txtIDProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;


            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mktFecha.Text = DateTime.Now.ToShortDateString();
            mktFecha.ReadOnly = true;
            mktFecha.Text.TrimEnd();
            mktFecha.Text.Trim();

            lblUsuario.Text = NombreUsuario;

        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
             {
                 e.Handled = true;
             }

           else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
          else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;


            }
           
           else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = true;
            }








        }

        private void Frm_EntradaDeProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Insertar();
            }
            else if (e.KeyCode == Keys.F3)
            {

                Salir();
            }
        }

     
        // Este metodo me tre el ultimo ID y le aumenta 1 para darle el ID a un cliente
        //Aca Cargo el ID al iniciar el formulario Entrada Deportista
        private void CargarID()
        {
            try
            {
                this.cBD.MiConexion.Open();
               // bool Resultado = false;
                this.cBD.sql = string.Format(@"SELECT * FROM Tbl_Productos WHERE PId=(SELECT MAX ( PId)  from  Tbl_Productos )", cBD.MiConexion);
                // hacemos compraciones con la variable sql y la conecion 
                this.cBD.ComandoSql = new SqlCommand(this.cBD.sql, this.cBD.MiConexion);
                 SqlDataReader Reg = null;
                Reg = this.cBD.ComandoSql.ExecuteReader();
                if (Reg.Read())
                {
                    //Resultado = true;
                    int d;

                    d = Convert.ToInt32(Reg[0].ToString());
                    d = d + 1;

                    txtIDProducto.Text = Convert.ToString(d);

                }

                else
                {
                    this.Focus();
                    this.Focus();
                    this.txtIDProducto.Text = "1";
                }


                this.cBD.MiConexion.Close();
                // return Resultado;

            }

            catch (Exception)
            {
                MessageBox.Show("No se pudo Cargar el ID ¨Hay un Error con el Servidor de Datos¨", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

      

       
       

    }
}
