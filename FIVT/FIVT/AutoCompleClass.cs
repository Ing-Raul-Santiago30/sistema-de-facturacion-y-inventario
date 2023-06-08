using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/////////// llamo las libreria que usare par este codigo
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;


namespace FIVT
{
  class AutoCompleClass :ConexionBD
    {
                
          //metodo para cargar los datos de la bd
            public static DataTable Datos()
            {
                ConexionBD cn = new ConexionBD();
                DataTable dt = new DataTable();

               // SqlConnection conexion = new SqlConnection(@" Data Source=GEIDISON;Initial Catalog=BDFacturacion;Integrated Security=True");
                cn.MiConexion.Open();
                string consulta = "SELECT * FROM Tbl_Cliente"; //consulta a la tabla paises
                SqlCommand comando = new SqlCommand(consulta,cn.MiConexion/* conexion*/);

                SqlDataAdapter adap = new SqlDataAdapter(comando);

                adap.Fill(dt);
                // DESPUES QUE LO DATOS AYA SIDO CARGADO SIERRO MI CONECION
                cn.MiConexion.Close();
                return dt;
               
            }

            //metodo para cargar la coleccion de datos para el autocomplete
            public static AutoCompleteStringCollection Autocomplete()
            {
                DataTable dt = Datos();

                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                //recorrer y cargar los items para el autocompletado
                foreach (DataRow row in dt.Rows)
                {    
                    // AQUI SELECIONO EL CAMPO QUE QUIERO TRAER DE LA TABLA
                    coleccion.Add(Convert.ToString(row["CApellidos"]));
                }

                return coleccion;
            }

      

            //metodo para cargar los datos de la bd
            public static DataTable Datos2()
            {
                ConexionBD cn = new ConexionBD();
                cn.dt = new DataTable();

                cn.MiConexion.Open();
              
                string consulta = "SELECT * FROM tblCliente"; //consulta a la tabla Clientes
                SqlCommand comando = new SqlCommand(consulta,cn.MiConexion);

                cn.da = new SqlDataAdapter(comando);

                cn.da.Fill(cn.dt);
                return cn.dt;
            }

            //metodo para cargar la coleccion de datos para el autocomplete
            public static AutoCompleteStringCollection Autocomplete2()
            {
                DataTable dt = Datos2();

                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                //recorrer y cargar los items para el autocompletado
                foreach (DataRow row in dt.Rows)
                {
                    coleccion.Add(Convert.ToString(row["CNombres"]));
                    
                }

                return coleccion;
            }
        


    }
}
