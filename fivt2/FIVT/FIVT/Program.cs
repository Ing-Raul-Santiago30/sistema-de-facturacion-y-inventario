using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FIVT
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Splash());
           // Application.Run(new FrmConsultaProducto());
         // Application.Run( new  Frm_Login ());

           // Application.Run( new FrmMantenimientoCliente());
           // Application.Run(new FrmCrearUsuario());
            //Application.Run(new Prueba());
        }
    }
}
