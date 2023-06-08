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
    public partial class FrmCrearUsuario : Form
    {
        public FrmCrearUsuario(string nombre)
        {
            InitializeComponent();
            this.NombreUsuario = nombre;
        }

        string NombreUsuario;

        private void frmUsuariocs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDFacturacionDataSet.tblUsuario' Puede moverla o quitarla según sea necesario.
            lblUsuario.Text = NombreUsuario;

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tblUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsuarioBindingSource.EndEdit();
           

        }
    }
}
