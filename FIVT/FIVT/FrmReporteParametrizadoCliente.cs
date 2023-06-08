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
    public partial class FrmReporteParametrizadoCliente : Form
    {
        public FrmReporteParametrizadoCliente()
        {
            InitializeComponent();
        }
        string a;
        private void FrmReporteParametrizadoCliente_Load(object sender, EventArgs e)
        {
            this.enfocar();
        }

        private void enfocar() 
        {if (cmbSeleccion.Text == "ID")
            {
                this.txtDatoBuscar.Clear();
                this.label7.Text = "Digite el ID";
                this.txtDatoBuscar.Visible = true;
                this.mktCedulaBuscar.Visible = false;
                this.txtDatoBuscar.Focus();


            }

            else if (cmbSeleccion.Text == "Cedula")
            {
                this.mktCedulaBuscar.Clear();
                this.label7.Text = "Digite la Cedula ";
                this.mktCedulaBuscar.Visible = true;
                this.txtDatoBuscar.Visible = false;
                this.mktCedulaBuscar.Focus();

            }
            else if (cmbSeleccion.Text == "Nombre")
            {
                this.txtDatoBuscar.Clear();
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
                a = Convert.ToString(txtDatoBuscar.Text);
                FrmReporteClientesID cp = new FrmReporteClientesID (a);
                cp.Show();
               
            }

            else if (cmbSeleccion.Text == "Cedula")
            {
                mktCedulaBuscar.Focus();
                if (mktCedulaBuscar.MaskCompleted)
                {
                    btnBuscar.Focus();
                    a = Convert.ToString(mktCedulaBuscar.Text);
                  FrmReporteClientesCedula cp = new  FrmReporteClientesCedula (a);
                    cp.Show();
               
                    
                }
                else
                {
                    MessageBox.Show("Complete el Campo Cedula y luego Buscar ");
                    mktCedulaBuscar.Focus();
                    


                }

            }





            if (cmbSeleccion.Text == "Nombre" && txtDatoBuscar.Text == "")
            {
                MessageBox.Show("Digite el Nombre y luego Buscar ");
                txtDatoBuscar.Focus();
               

            }

            else if (cmbSeleccion.Text == "Nombre" && txtDatoBuscar.Text != "")
            {
                btnBuscar.Focus();
                a = Convert.ToString(txtDatoBuscar.Text);                              
           FrmReporteClientesNombre RCN = new  FrmReporteClientesNombre (a);
               RCN.Show();
               
            }











           

        }

        private void cmbSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.enfocar();
        }
    }

}
