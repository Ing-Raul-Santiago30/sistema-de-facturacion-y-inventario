using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace FIVT
{
    class Cliente
    {

        private string cedula;
        private DateTime fecha;


        private string nombre;


        private string apellido;


        private string oficina;


        private string recidencia;


        private string cel;


        private string provincia, sector, calle, noCasa;

       
       

        // creo un metodo
        public Cliente()
        {

            cedula = string.Empty;
            nombre = string.Empty;
            apellido = string.Empty;
            oficina=string.Empty;
            recidencia = string.Empty;
            cel = string.Empty;
            provincia = string.Empty;
            sector = string.Empty;
            calle = string.Empty;        
        }

        // Encapsulamos los campos 

        public string Cedula 
        {
            get { return  this.cedula;}

            set { this.cedula=value;}
        }


        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Oficina
        {
            get { return oficina; }
            set { oficina = value; }
        }
        public string Recidencia
        {
            get { return recidencia; }
            set { recidencia = value; }
        }

        public string Cel
        {
            get { return cel; }
            set { cel = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public string Sector
        {
            get { return sector; }
            set { sector = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public string NoCasa
        {
            get { return noCasa; }
            set { noCasa = value; }
        }


                         
      
         

    }
}
