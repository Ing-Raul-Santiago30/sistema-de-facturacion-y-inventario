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
    public partial class Frm_Menuprincipal : Form
    {
        public Frm_Menuprincipal(string nombre)
        {
            
            InitializeComponent();
            this.NombreUsuario =  nombre;
        }
        string NombreUsuario;
        private void Frm_Administrador_Load(object sender, EventArgs e)
        {
           cambiarContraseñaToolStripMenuItem.Visible = false;
            KeyPreview = true;
           
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;

            


           
        }






       

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EntradaDeCliente NC = new Frm_EntradaDeCliente(NombreUsuario);
            NC.ShowDialog(this);
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EntradaDeProducto NP = new Frm_EntradaDeProducto(NombreUsuario);
            NP.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente CC = new FrmConsultaCliente(NombreUsuario);
            CC.ShowDialog();
        }

        

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas Nf = new FrmVentas(NombreUsuario);
            Nf.ShowDialog();
        }

        private void CerrarAplicacion()
        {

            if (MessageBox.Show("Esta seguro que deseas Cerrar FIVT ", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {

                this.Hide();
                this.Close();
                this.Dispose();
                // este comando cierra toda la aplicacion osea todos o formulario
                Environment.Exit(0);

            }
        
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarAplicacion();
            
                      

        }

        private void cambioDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();         
                      
            Frm_Login login = new Frm_Login();
            login.Show();
            this.Close();

            
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void horaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            horaToolStripMenuItem.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            horaToolStripMenuItem.Text = DateTime.Now.ToLongTimeString();
            lblFechaActual.Text = DateTime.Now.ToLongDateString();

            lblUsuario.Text = Convert.ToString(NombreUsuario); 


           


        }

        private void label1_Click(object sender, EventArgs e)
        {

            lblFechaActual.Text = DateTime.Now.ToShortDateString();
             



        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario US = new FrmCrearUsuario(NombreUsuario);
            US.ShowDialog();

        }
          
       
            

           
            
            
         
        

       

        private void ensayoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoProductos mp = new FrmMantenimientoProductos(NombreUsuario);
            mp.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMantenimientoCliente MC = new FrmMantenimientoCliente(NombreUsuario);
            MC.ShowDialog();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMantenimientoProductos mp = new FrmMantenimientoProductos(NombreUsuario);
            mp.ShowDialog();
        }

        // este metodo  le desabilata estas opciones a los usuarios 
        public void Desabilitar()
        {
            mantenimientoToolStripMenuItem.Enabled = false;
            consultasToolStripMenuItem.Enabled = false;
            cambiarContraseñaToolStripMenuItem.Visible = false;
            registrarUsuariosToolStripMenuItem.Visible = false;
            reporteToolStripMenuItem.Enabled = false;
           
            
            



          

        }
      

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
           
           
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  FrmConsultaProducto cp = new FrmConsultaProducto(NombreUsuario);
          //  cp.ShowDialog();


        }

        private void Frm_Menuprincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
                CerrarAplicacion();
            


        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // System.Diagnostics.Process.Start(@"C:\Users\EULALIA\Downloads\INDICE.docx");

            System.Diagnostics.Process pr = new System.Diagnostics.Process(); 
try 
{
    pr.StartInfo.FileName = @"C:\Users\EULALIA\Downloads\INDICE.docx";
pr.Start(); 
} 
catch (NullReferenceException ex) 
{ 
MessageBox.Show(ex.Message, "Error no se encuentra el archivo"); 
}
       
            }

        private void Frm_Menuprincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // no permitir cerrar el formulario con alt+f4
            e.Cancel = true;

           
            
        }

        private void reporteDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteGeneralClientes reporte = new FrmReporteGeneralClientes();
            reporte.ShowDialog();

            /*1
            CrystalReport1 objRpt;
            objRpt = new CrystalReport1();


            String ConnStr = @"Data Source=GEIDISON;Initial Catalog=BDFacturacion;Integrated Security=True";

            // LA DE ARRIBA ES NUESTRA CADENA DE CONEXION DEL SERVIDOR

            SqlConnection myConnection = new SqlConnection(ConnStr); // TIENEN QUE UTILIZAR EN EL USING LA CLASE DE System.Data.SqlClient

            String Query = "SELECT * FROM tblCliente"; // ESTE ES NUESTRO QUERY

            SqlDataAdapter adapter = new SqlDataAdapter(Query, ConnStr);

           BDFacturacionDataSet  Ds =new BDFacturacionDataSet     (); // ESTE ES EL NOMBRE DE NUESTRO DATASET
            adapter.Fill(Ds, "Reportes"); // ESTE Reportes ES EL NOMBRE DE NUESTRA TABLA DE DATOS QUE ESTA DENTRO DE NUESTRO DATASET


            objRpt.SetDataSource(Ds); FrmReporte rpt = new FrmReporte (); // ES EL FORM DONDE ESTA NUESTRO CRYSTAL REPORT VIEWER
            rpt.crystalReportViewer1.ReportSource = objRpt; // ESTE ES NUESTRO REPORT VIEWER
            rpt.ShowDialog(); // AQUI LO MUESTRA
            
            */
            
        }

        private void Frm_Menuprincipal_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "0";
           timer2.Stop();
            timer2.Start();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // codigo para limitar tiempo ()

            timer2.Start();
            timer2.Interval = 1000;

            int t;
            t = Convert.ToInt32(label1.Text);
            t += 1;
            label1.Text = t.ToString();
            if (t >= 7)
            {
                label1.ForeColor = Color.Red;
            }
            else { label1.ForeColor = DefaultForeColor; }

          /*  if (t == 10)
            {

                MessageBox.Show("Tiempo de Espera Agotado");
               Application.Exit();
               this.Hide();
               this.Dispose();               
              Frm_Login l = new Frm_Login();
              l.Show();
               this.Close();
                

            }*/

        }

        private void reporteDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteGeneralProductos reporte = new FrmReporteGeneralProductos ();
            reporte.ShowDialog();
        }

        private void reporteParametricizdoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteParametrizadoproducto RPC = new FrmReporteParametrizadoproducto();
            RPC.ShowDialog();
        }

        private void reporteParametrizadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteParametrizadoCliente r = new FrmReporteParametrizadoCliente();
            r.ShowDialog();
        }

        private void reporteDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteGeneralVentas rgv = new FrmReporteGeneralVentas();
            rgv.ShowDialog();
        }

        

        /*     //creamos un nuevo metodo
        private void cargarlista()
        {
            ConexionBD cn =new ConexionBD ();
           
            cn.MiConexion.Open();
            cn.ComandoSql.CommandText = ("Select Nombre FROM tblUsuario  ");
            cn.DatosLeido = cn.ComandoSql.ExecuteReader();
            if (cn.DatosLeido.HasRows)
            {

                while (cn.DatosLeido.Read())
                {
                    
                   // listBox1.Items.Add(DatosLeido[0].ToString());
                   
                
                }
            
            
            }

            cn.MiConexion.Close();



        


        } */
    }
}
