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
    public partial class FrmReporteParametrizadoproducto : Form
    {
        public FrmReporteParametrizadoproducto()
        {
            InitializeComponent();
        }
        public string a;
        public void FrmReporteParametrizadoCliente_Load(object sender, EventArgs e)
        {
            this.enfocar();
        }

        public void enfocar()
        {
            if (cmbSeleccion.Text == "ID")
            {
                this.txtDatoBuscar.Clear();
                this.label7.Text = "Digite el ID";
                this.txtDatoBuscar.Visible = true;
                this.mktFechaBuscar.Visible = false;
                this.lblFormatoFecha.Visible = false;
                this.lblFormatoFecha.Enabled = false;
                this.txtDatoBuscar.Focus();


            }

            else if (cmbSeleccion.Text == "Fecha")
            {
                this.mktFechaBuscar.Clear();
                this.label7.Text = "Digite la Fecha ";
                this.mktFechaBuscar.Visible = true;
                this.txtDatoBuscar.Visible = false;
                this.lblFormatoFecha.Visible = true;
                this.lblFormatoFecha.Enabled = true; ;
                this.mktFechaBuscar.Focus();

            }
            else if (cmbSeleccion.Text == "Nombre de Productos")
            {
                this.txtDatoBuscar.Clear();
                this.label7.Text = "Digite el Nombre del Producto";
                this.txtDatoBuscar.Visible = true;
                this.mktFechaBuscar.Visible = false;
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


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.Validar();
        }

        // llamar formulario del reporte 
       

               
        
       private void Validar()
        {
            if (cmbSeleccion.Text == "ID" && txtDatoBuscar.Text == "")
            {
                MessageBox.Show("Digite el ID y luego Buscar ");
                txtDatoBuscar.Focus();

            }

            else if (cmbSeleccion.Text == "ID" && txtDatoBuscar.Text != "")
            {
                btnBuscar.Focus();
                a = Convert.ToString(txtDatoBuscar.Text);
                FrmReporteProductosID cp = new FrmReporteProductosID(a);
                cp.Show();
            }

            else if (cmbSeleccion.Text == "Fecha")
            {
                mktFechaBuscar.Focus();
                if (mktFechaBuscar.MaskCompleted)
                {
                    btnBuscar.Focus();
                   
                  a = Convert.ToString(mktFechaBuscar.Text);
                  
                    FrmReporteProductosFecha cp = new FrmReporteProductosFecha (a);
                    cp.Show();
                }
                else
                {
                    MessageBox.Show("Complete el Campo Fecha y luego Buscar ");
                    this.mktFechaBuscar.Focus();

                }

            }



            if (cmbSeleccion.Text == "Nombre de Productos" && txtDatoBuscar.Text == "")
            {
                MessageBox.Show("Digite el Nombre de Productos y luego Buscar ");
                txtDatoBuscar.Focus();


            }

            else if (cmbSeleccion.Text == "Nombre de Productos" && txtDatoBuscar.Text != "")
            {
                btnBuscar.Focus();
                a = Convert.ToString(txtDatoBuscar.Text);
                FrmReporteProductosNombre cp = new  FrmReporteProductosNombre (a);
                cp.Show();

            }
}
        private void cmbSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            enfocar();
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

    }
}
