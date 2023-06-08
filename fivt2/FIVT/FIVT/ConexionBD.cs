using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FIVT
{
    class ConexionBD
    {

        public string CadenaConexion;
        // esta variable lo voy ha usar para hacer referencia al consultar 
        public string sql;

        public  SqlConnection MiConexion;

        public SqlCommand ComandoSql;

        public DataSet ds;

       public SqlDataAdapter da;

        public SqlDataReader leerDatos ;

        public DataTable dt;
        public SqlCommandBuilder cmb;
      
        


        
        

        public   ConexionBD()
        {

            this.CadenaConexion = (@"Data Source=RAUL;Initial Catalog=BDFACTURACION;Integrated Security=True");
            this.MiConexion = new SqlConnection(CadenaConexion);
            this.ComandoSql = new SqlCommand();
            this.da = new SqlDataAdapter();
            this.ds = new DataSet();
            this.dt = new DataTable();
            //this.cmb = new SqlCommandBuilder(da);                              
        }


        // Metodo Consultaar

        public void Consultar(string sql, string tabla)

        {

            ds.Tables.Clear();
            da = new SqlDataAdapter (sql, MiConexion);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);

                   
        }


        // Metodo eliminar 

        public bool Eliminar(string tabla, string condicion)
        {
            MiConexion.Open();

            string sql = "Delete From " + tabla + " Where " + condicion;
            ComandoSql = new SqlCommand(sql, MiConexion);
            int i = ComandoSql.ExecuteNonQuery();
            MiConexion.Close();
            if (i > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }

            

            }

        // metodo Actualizar 

            public bool Actualizar (string tabla ,string campos ,string condicion)

            {
            MiConexion.Open();
            string sql = " Udapte * From " + tabla + " Set " + campos + " Where " + condicion;
            ComandoSql =new SqlCommand (sql,MiConexion);
            int i=ComandoSql.ExecuteNonQuery();

             if (i > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }

            }

                                   
            


    

        

        // Otro metodo que nos  e haces 

            public DataTable Consultar2(string tabla)
            {
                string sql = "Select * From " + tabla;
                   da =new SqlDataAdapter (sql ,MiConexion); 
                      DataSet dst = new DataSet();
                      da.Fill(dst, tabla);
                        DataTable dt =new DataTable ();
                        dt = dst.Tables[tabla];
                        return dt;  
            }



        // Metodo Insertar 

        public bool Insertar(string sql )
            {
                MiConexion.Open();
          
                ComandoSql = new SqlCommand(sql, MiConexion);
                int i = ComandoSql.ExecuteNonQuery();
                MiConexion.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        
        }








    }

}
        




























        
        
        


    

