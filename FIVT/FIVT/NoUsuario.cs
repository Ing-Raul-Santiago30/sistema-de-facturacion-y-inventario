using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Configuration.Assemblies;
using System.Windows.Forms;

namespace FIVT
{
    public static class NoUsuario 
    {


        // Creamos un metodos
        /* abajo Creamos un método de tipo DataTable llamado Buscar 
         * que recibirá un parámetro que sera el dato a buscar en la bd.*/

        public static DataTable Buscar(string nombre)
        {

            DataTable dt = new DataTable();
            SqlConnection miconexion = new SqlConnection(@" Data Source=RAUL;Initial Catalog=BDFacturacion;Integrated Security=True");//cadena conexion

            /* Linea 9 Creamos una consulta para obtener los datos de la tabla en este caso apellido y edad */
            string Consulta = "Select id,apellido,edad FROM PERSONA WHERE nombre =@nombre";//Consultas

            SqlCommand comando = new SqlCommand(Consulta, miconexion);

            comando.Parameters.AddWithValue("@nombre", nombre);
            /* Linea 12 Enviamos el parámetro en base al cual 
             * obtendremos los datos de la tabla. */
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(dt);

            return dt;


        }


    }
}
