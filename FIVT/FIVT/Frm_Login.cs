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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        public string a;
        ConexionBD cn = new ConexionBD();



        private void Frm_Login_Load(object sender, EventArgs e)
        {
            Enfocar();

           

        }

        private void Enfocar()
        {
            if (txtNombre.Text != "" && txtContraseña.Text != "" && cmbAcesso.Text!="")

            {
                btn_Aceptar.Focus();
            }
        
        }



        private void Completar() 
        {
            

             if (txtNombre.Text == "")
            {
                if ((MessageBox.Show("Entre Su Usuario", "ERROR  ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.OK))
                {
                    txtNombre.Focus();
                    return;
                }
            }

             if (txtContraseña.Text == "")
             {
                 if ((MessageBox.Show("Entre Su Contraseña", "ERROR  ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.OK))
                 {
                     txtContraseña.Focus();
                     return;
                 }
             }

            else if (cmbAcesso.Text == "")
            {
                if ((MessageBox.Show("ELija Su Nivel de Acceso", "ERROR  ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.OK))
                {
                    cmbAcesso.Focus();
                    return;
                }
            }
        
        }

      private void Iniciar()
        {
            try
            {//open try
                cn.MiConexion.Open();

                SqlCommand comandosql = new SqlCommand("Select *  From Tbl_Usuario Where Rtrim (UUsuario) ='" + txtNombre.Text + "'and Rtrim (UContraseña)='" + txtContraseña.Text + "'and Rtrim (UAcceso)='" + cmbAcesso.Text + "'   ", cn.MiConexion);
                SqlDataReader ejecuta = comandosql.ExecuteReader();

                if (ejecuta.Read() == true)
                {
                    if (cmbAcesso.Text == "Administrador")
                    {

                        //muestra un mejes de vienbenido 
                        MessageBox.Show("Bienvenido : " + (ejecuta[1].ToString()) + (ejecuta[2].ToString()), "Correcto !");
                        a = Convert.ToString((ejecuta[5].ToString()) + ejecuta[1].ToString() + ejecuta[2].ToString());
                       
                        this.Hide();


                        //abreme formulario 2
                        Frm_Menuprincipal MP = new Frm_Menuprincipal(a.Trim());

                        MP.Show();
                        this.Close();
                    }


                    else if (cmbAcesso.Text == "Usuario")
                    {

                        //muestra un mejes de vienbenido 
                        MessageBox.Show("Bienvenido : "+ (ejecuta[1].ToString()) + (ejecuta[2].ToString()), "Correcto !");
                        a = Convert.ToString(ejecuta[5].ToString()  +ejecuta[1].ToString() + ejecuta[2].ToString());
                        //esconde el mensaje
                        this.Hide();

                        //abreme formulario 2 y le pasa los datos a esa variable para que lo pueda usar en sigiente formulario
                        Frm_Menuprincipal MP = new Frm_Menuprincipal(a);

                        MP.Desabilitar();
                        MP.Show();
                        this.Close();

                    }

                }

                else
                {

                    MessageBox.Show("Acceso Denegado");
                    txtNombre.Clear();
                    txtContraseña.Clear();
                    txtNombre.Focus();

                    cn.MiConexion.Close();
                }


            }
        

            catch (Exception)
            {
                if (MessageBox.Show("La conexión con el servidor no se ha establecido correctamente, por eso  se ha producido un error durante el proceso de inicio de sesión. (provider: TCP Provider, error: 0 - El nombre de red especificado ya no está disponible.)Error de conexión consulte a su Administrador de Base de Datos o a un tecnico para que repare su selvidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.OK)

                    btn_Cancelar.Focus();

            }
        }
        
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Completar();
            if (txtNombre.Text != "" & txtContraseña.Text != "" & cmbAcesso.Text != "")
            {
                Iniciar();
            }
              
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir ", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            { 
            
            
               
                this.Hide();
                
                this.Close();
                this.Focus();
                this.Dispose();
               
                Environment.Exit(0);
            }

            else

                txtNombre.Clear();
            txtContraseña.Clear();
            txtNombre.Focus();
            

        
            
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                this.txtContraseña.Focus();


            
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmbAcesso.Focus();
        }

        private void cmbAcesso_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                this.btn_Aceptar.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
           


        }

        private void cmbAcesso_KeyPress(object sender, KeyPressEventArgs e)
        {

            

        }

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // no permitir cerrar el formulario con alt+f4
            e.Cancel = true;
        }

        

       

        
}
}



/*
 nombre = txtNombre.Text;


string strsql = "SELECT * FROM amigos WHERE nombre ='" + nombre + "'";            

            sqladapt = new System.Data.SqlClient.SqlDataAdapter(strsql, cnn);


            sqladapt.Fill(ds, "clientes");


            dt = ds.Tables["clientes"];

            if (dt.Rows.Count == 0)

                this.lblUsuario.Text = "No existe el usuario...";

            else

            {

                foreach (System.Data.DataRow fila in dt.Rows)

                {

                    this.lblUsuario.Text = "Bienvenido " + fila["nombre"].ToString();

                }

            }
 */