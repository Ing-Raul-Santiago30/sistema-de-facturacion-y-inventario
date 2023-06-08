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
    public partial class Frm_Splash : Form
    {
        public Frm_Splash()
        {
            InitializeComponent();

        }

        int i;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            i = i + 1;
            lbl_Conteo.Text = i.ToString() + "% ";

            progressBar1.Value=i ;

            if (i == 100)

            {
                timer1.Stop();
                this.Hide();
                Frm_Login login = new Frm_Login();
                login.Show();
                this.Close();

            }
                



        }

        private void Frm_Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            // no permitir cerrar el formulario con alt+f4
            e.Cancel = true;
        }
    }
}
