using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Drawing;


namespace FIVT
{
    public partial class Frm_EntradaDeCliente : Form
    {
        public Frm_EntradaDeCliente(string nombre)
        {
            InitializeComponent();
           this. NombreUsuario = nombre;
        }

        string NombreUsuario;

        /*  SqlConnection MiConexion = new SqlConnection("Data Source=GEIDISON;Initial Catalog=BDFacturacion;Integrated Security=True");
          SqlCommand ComandoSql = new SqlCommand();*/
        ConexionBD cBD = new ConexionBD();
        
              

        private void Frm_Cliente_Load(object sender, EventArgs e)
        {         
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
            txtID.Enabled = false;
            txtCalle.Multiline = true;
            //solo lectura
            //txtNombre.ReadOnly = true;

            txtNo_Casa.MaxLength = 4;
            CargarID();
            AutoCompletar();

        }


        // Codigo para Auto Completar

        private void AutoCompletar()
        {



            try
            {
                // auto completar

                //cargar los datos para el autocomplete del textbox
                this.txtApellido.AutoCompleteCustomSource = AutoCompleClass.Autocomplete();
                this.txtApellido.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.txtApellido.AutoCompleteSource = AutoCompleteSource.CustomSource;

                /*     // Cargo los datos que tendra el combobox
                     comboBox1.DataSource = AutoCompleClass.Datos();
                     comboBox1.DisplayMember = "pais";
                     comboBox1.ValueMember = "id";

                     // cargo la lista de items para el autocomplete dle combobox
                     comboBox1.AutoCompleteCustomSource = AutoCompleClass.Autocomplete();
                     comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                     comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                     */

            }

            catch (Exception)
            {
                MessageBox.Show("No se Cargo el Auto Completar");

            }




           
        
        
        }

        // Este metodo me tre el ultimo ID y le aumenta 1 para darle el ID a un cliente
       //Aca Cargo el ID al iniciar el formulario Entrada Deportista
        private void  CargarID()
        {
            try
            {
                this.cBD.MiConexion.Open();
                //bool Resultado = false;
                this.cBD.sql = string.Format(@"SELECT * FROM Tbl_Cliente WHERE CId=(SELECT MAX ( CId)  from  Tbl_Cliente )", cBD.MiConexion);
                // hacemos compraciones con la variable sql y la conecion 
                this.cBD.ComandoSql = new SqlCommand(this.cBD.sql, this.cBD.MiConexion);
                SqlDataReader Reg = null;
                Reg = this.cBD.ComandoSql.ExecuteReader();
                if (Reg.Read())
                {
                    //Resultado = true;
                    int d;

                    d = Convert.ToInt32(Reg[0].ToString());
                    d = d + 1;
                    txtID.Text = Convert.ToString(d);

                }

                else
                {
                    this.Focus();
                    this.Focus();
                    this.txtID.Text = "1";
                }


                this.cBD.MiConexion.Close();
               // return Resultado;

            }

            catch (Exception)
            {
                MessageBox.Show("No se pudo Cargar el ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }      

       // Metodo Para La Selecion y Mostrar las Provincias // este codigo mostrara la provincia y sus sectores segun la seleccion 
       private void sectorXprovincia() 
        {
            
         
            if (cmbProvincia.Text =="Santo Domingo" )
            {
                string[] installs = new string[]{"12 DE HAINA","16 DE AGOSTO","2 DE ENERO","24 DE ABRIL","24 DE ABRIL","27 DE FEBRERO","30 DE MAYO",
                    "AESA","AGUA DULCE","ALAMEDA","Alma Rosa","ALMA ROSA II","ALPES I","ALTOS DE ARROYO HDO. I","ALTOS DE ARROYO HDO. III","ALTOS DE ARROYO HONDO II","ALTOS DE CANCINO","ALTOS DE CHAVON","ALTOS DE SABANA PERDIDA","ALTOS DEL OESTE","ALTOS DEL PARQUE","AMARILIS III","ANA VIRGINIA","ANTILLAS","ARBOLEDA (NACO)","ARISMAR","ARROYO MANZANO","ARROYO MANZANO","ATALA","ATLANTIDA",// todes de A
                    "BARRIO ANTILLANO","BARRIO ARENOSO","BARRIO BRISA DE CHARLES","BARRIO BUENOS AIRES","BARRIO CHAVON","BARRIO ENRIQUILLO","BARRIO GRAN PODER DE DIOS","BARRIO HNAS. MIRABAL","BARRIO HOLGUIN","BARRIO INVI","BARRIO JOHN F. KENNEDY","BARRIO JOSUE","BARRIO LA ESPERANZA","BARRIO LA FE","BARRIO LA PIÑA","BARRIO LA TORRE","BARRIO LA UNION","BARRIO LANDIA","BARRIO LAS MERCEDES","BARRIO LIBERTADOR","BARRIO NORTE","BARRIO NUEVO","BARRIO OBRERO","BARRIO PARAISO","BARRIO PARAISO","BARRIO PROGRESO","BATEY BIENVENIDO","BATEY LA BALSA","BATEY PALMAREJO","BATEY PIRAGUA","BAYONA","BELLA COLINA","BELLA VISTA","BELLA VISTA 2 ","BELLO CAMPO","BOROJOL","BRISA DEL EDEN","BUENA VENTURA II","BUENA VISTA","BUENAS NOCHES","BUENOS AIRES DEL",
                    "CABIRMA DEL ESTE I","CABIRMA DEL ESTE II","CACHIMAN","CALERO","CAMPECHITO II","CANCINO","CANCINO ADENTRO","CANCINO I","CANCINO II","CAPOTILLO","CARLOS ALVAREZ","CARMELITA","CARMEN AMELIA","CAROLINA","CASTELLANA","CENTRO DE LOS HEROES","Centro de los Héroes","CENTRO OLIMPICO","CERRO DE ARROYO HDO.","CERROS DE ARROYO HDO III","CERROS DE BUENA VISTA I","CERROS DE BUENA VISTA II","CERROS DE LA YUCA","CERROS DE PALMAREJO","CERROS DE SABANA PERDIDA","CERROS DEL OZAMA","CEUTA","CIUDAD AGRARIA","CIUDAD CODIANA","Ciudad Colonial","CIUDAD DE LOS TRABAJADORES","CIUDAD DEL ALMIRANTE I","CIUDAD DEL ALMIRANTE II","CIUDAD GANDERA","CIUDAD MODERNA","CIUDAD NUEVA","CIUDAD UNIVERSITARIA","COLINAS DE ARROYO HONDO","COLINAS DE CANAAN","COLINAS DEL ESTE","COLINAS DEL NORTE","COLINAS DEL OZAMA","COLINAS DEL SEMINARIO","COLONIA DE LOS DOCTORES","CONSTELACION","CORALES DEL SUR","COSTA AZUL","COSTA BRAVA","COSTA CARIBE","COSTA VERDE","Country Club","CRISTO REY","CRUZ GRANDE (villa mella y sabana perdida )","CUESTA BRAVA","CUESTA HERMOSA","CUESTA HERMOSA III","CUESTA HERMOSA III",
                    "DE VILLA MELLA","DOMINGO SAVIO","DOMINICANOS AUSENTES","DON BOSCO","DON HONORIO","DUARTE",
                    "EL ABANICO DE HERRERA","EL BRISAL","EL CACHON","EL CACHON DE LA RUBIA","EL CACIQUE","EL CAFÉ","EL CALICHE","EL CATORCE","EL CHUCHO","EL CONDADO","EL EDEN","EL EMBAJADOR","EL ENSANCHITO","EL FUNDO","EL MAJAGUAL","EL MAMEY","EL MANGUITO","EL MILLON","EL MILLONCITO","EL PALMAR","EL PEDREGAL","EL PINO","EL PORTAL","EL ROSAL","EL TAMARINDO","EL TAMARINDO","EL TORITO","EL VERGEL","ENCARNACION","ENGOME","ENRRIQUILLO","ENS. ALMA ROSA (lado este)","ENS. ALMA ROSA (lado oeste)","ENS. IVAN GUZMAN KLAN","ENS. KENNEDY","ENS. LA FE","ENS. PARAISO","ENSANCHE ALTAGRACIA","ENSANCHE CRISTAL","ENSANCHE ESPAILLAT","ENSANCHE INDEPENDENCIA","ENSANCHE LA PAZ","ENSANCHE LUGO","ENSANCHE LUPERON","ENSANCHE LUPERON","ENSANCHE OZAMA","ENSANCHE PARAISO","ENSANCHE QUISQUEYA","ESPERILLA","ESTELA MARINA ( Los Millones)","EUGENIO M. DE HOSTOS","EVARISTO MORALES",
                    "FARO A COLON","FELICIDAD","FRANCISCO DEL","FRANCONIA ","FUNDACION",
                    "GACELA","GALAXIA","GAZCUE","GAZCUE ( Plaza de la Cultura )","General Antonio Duvergé","GUACHUPITA","GUALEY","GUARICANOS",
                    "HAINAMOSA","HAMARAP","HARAS NACIONALES","HATO NUEVO","HERRERA","HODURAS","Honduras del Norte",
                    "INVI","INVI CEA","INVIMOSA","INVIVIENDA","ISABEL","ISABEL VILLAS","ISABELA","ISSFAPOL","IVETTE",
                    "JACAGUA","JARDINES DE ALMA ROSA","JARDINES DE GENOVENA","JARDINES DEL SUR","JUAN PABLO DUARTE","JULIETA MORALES",
                    "KATANGA","KM. 7","KM. 8",
                    "LA AGUSTINA","LA AGUSTINITA","LA ALDABA","LA ANTENA","LA BARQUITA","LA CARIDAD","LA CEIBA","LA CEMENTERA","LA CIENAGA","LA CIENAGA","LA COMPUERTA","LA CONCORDIA","LA CUARENTA","LA ESPERANZA","LA ESPERANZA","La Esperilla","LA FE","La Fé","LA FRANCIA","LA FUENTE","LA ISABELA","LA ISABELA","LA JAVILLA","LA JULIA","LA MESETA","LA MILAGROSA","LA MINA","LA PIÑITA","LA PLACETA","LA PRIMAVERA","LA PUYA","LA REDENCION","LA ROSA","LA VENTA","LA YUCA","LA ZURZA","LANNA GAUTIER","LAS ACACIAS","LAS AMERICAS","LAS CAOBAS","LAS CAOBITAS","LAS COLINAS","LAS CRORIAS","LAS ENFERMERAS","LAS FLORES","LAS FRUTAS","LAS PALMAS","LAS PALMERAS","LAS VILLAS","LEBRON","LIBERTAD","LOMAS DE ARROYO HONDO","LOPEZ DE VEGA","LOS 3 BRAZOS","LOS ALCARRIZOS","LOS ALCARRIZOS III","LOS AMERICANOS","LOS ANGELES","LOS ARRECIFES","LOS ARROYOS","Los Cacicazgos","LOS CACICAZGOS","LOS CAMINOS","LOS CASABES","LOS CONUCOS","LOS COORDINADORES","LOS FRAILES","LOS FRAILES II","LOS GIRASOLES","LOS GUANDULES","LOS GUAYABOS","Los Jardines","LOS JARDINES DEL NORTE","Los Jardines del Sur","LOS LIBERTADORES","LOS MAESTROS","Los Mameyes","Los Millones","LOS MILLONES","LOS MINA NORTE","LOS MINA SUR","LOS MINA VIEJO","LOS MOLINOS","LOS PALMARES","Los Paralejos","LOS PERALEJOS","LOS PINOS","LOS PRADITOS","LOS PRADOS","LOS PROCERES","LOS RESTAURADORES","LOS RIOS","LOS ROBLES","LOS ROSALES","Los Tres Brazos","LOS TRES OJOS","LOS TRINITARIOS","LOS TRINITARIOS II","LOTERIA","LOTES Y SERVICIOS","LOTIFICACION DEL ESTE","LOTIFICACION ENGOMBE","LOTIFICACION VISTA VERDE","LUCERNA","Luperón","LUZ CONSUELO","LUZ DIVINA",
                    "MANDINGA","MANGANAGUA","Manoguayabo","MANOGUAYABO","MANRESA","MANZANO","MAQUITERIA","MAR AZUL","MARAÑON","MARAÑON II","MARBELLA III","MARIA AUXILIADORA","MARIA ISABELA","MATA HAMBRE","MATA LOS INDIOS","MEJORAMIENTO SOCIAL","MENDOZA","MI HOGAR","MI SUEÑO","MIL FLORES","MIRADOR","MIRADOR ESTE","MIRADOR NORTE","MIRADOR SUR","MIRAFLORES","MIRAMAR","MODELO","MOLINUEVO",
                    "NACO","NARCISA","NORDESA III","NUEVA ISABELA","NUEVO AMANECER","Nuevo Arroyo Hondo","NUEVO HORIZONTE","NUEVO RENACER",
                    "OBRAS PUBLICAS",
                    "PALMA REAL","PALMAREJITO","PANTOJA","PARAISO","PARAISO DEL CARIBE","PARAISO ORIENTAL","PARQUE DEL ESTE I","PARQUE IND. NUEVA ISABELA","PARQUE ISABELA","PARQUE MIRADOR ESTE","PIANTINI","PIDOCA","PISTA DE MOTOCROS LA YUCA","PONCE","PRADERA HERMOSA","PRADOS DEL CACHON","PROGRESO","PROYECTO BNV","PROYECTO CIUDAD","PUEBLO NUEVO","PUERTO DE HAINA","PUERTO RICO",
                    "Quisqueya",
                    "RADIANTE","RALMA","RENACIMIENTO","REP. ALMA ROSA","REP. VILLA CARMEN","REP. VILLA MARIA","REPARTO AGUEDITA ( Gazcue)","REPARTO CARIBE","REPARTO MIGUELINA","REPARTO RUDIMA","REPARTO SAMARIA","RES. AMAPOLA","RES. CLARIMAR","RES. DEL ESTE","RES. DON OSCAR","RES. FERNANDEZ ORIENTAL","RES. IDALIA A I","RES. LOMISA","RES. MIRADOR DEL ESTE","RES. NOELIA","RES. ORIENTE","RES. PARQUE DEL ESTE","RES. SANTO DOMINGO","RES. SOL DE LUZ","RES. TERESA","RES. EL DORADO","RESD. ENRIQUILLO","RESIDENCIAL ALAMEDA","RESIDENCIAL CANAAN","RESIDENCIAL DON OSCAR","RESIDENCIAL JOSE CONTRERAS","RESIDENCIAL LA YUCA","RESIDENCIAL LOYOLA","RESIDENCIAL ROSMIL","RIVERA DEL HAINA","ROCAMAR","ROSA MARIA","ROSARIO SANCHEZ",
                    "SABANA CENTRO","SABANA PERDIDA","SABANETA","SALOME UREÑA","SAN ANTONIO","SAN BARTOLO","SAN CARLOS","SAN FRANCISCO","SAN GERONIMO","SAN JOSE","SAN JOSE DE MENDOZA","SAN LAZARO","SAN MARTIN DE PORRES","SAN MIGUEL","SAN MIGUEL","SAN MIGUEL","SAN PABLO II","SAN SOUCI","SANDRA","SANDRA I","SANTA CRUZ","SANTA ROSA","SARASOTA","SAVICA","SIMON BOLIVAR","SIMONICO","SOL NACIENTE","SURIEL",
                    "TRABAJADORES","Tropical","TROPICAL DEL ESTE","TROPICANA","TRUEVA",
                    "URB. AMANDA","URB. ANA T. BALAGUER","URB. BRISA DEL NORTE","URB. CHARLES DE GAULLE","URB. EL REMANSO","URB. EL ROSAL","URB. ITALIA","URB. LAS PALMAS","URB. LAS PRADERAS","URB. MAXIMO GOMEZ","URB. OLIMPO","URB. PRIMAVERA","URB. PUERTA DE HIERRO","URB. REAL","URB. SAN RAFAEL","URB. SANTA CRUZ","URB. SARAH GABRIELA","URBANIZACION FERNANDEZ","URBANIZACION LAS MERCEDES","URBANIZACION PALMA REAL",
                    "VALLE ENCANTADO","VALLE VERDE","VARIA","VECINOS UNIDOS","Viejo Arroyo Hondo","VIEJO ARROYO HONDO","VIETNAN","VILLA ADELA","VILLA AURA","VILLA BLANCA","VILLA CARMELA","VILLA CARMEN","VILLA CLAUDIA","VILLA CONSUELO","VILLA CONSUELO","VILLA DUARTE","VILLA ELENA","VILLA ELOISA","VILLA ESFUERZO","VILLA ESPERANZA","VILLA FARO","VILLA FRANCISCA","VILLA JUANA","VILLA MARIA","VILLA MELLA","VILLA NAZARET","VILLA NUEVA","VILLA OLIMPICA","VILLA PERAVIA","VILLA SAN FELIPE","VILLA SATELITE","VILLAS AGRICOLAS","VILLAS DEL CAFÉ","VILLAS NACO","VISTA BELLA","VISTA HERMOSA",
                    "YAQUITO","ZONA COLONIAL",
                    "ZONA FRANCA DE LOS ALCARRIZOS","ZONA FRANCA INDUSTRIAL DE HERRERA","ZONA INDUSTRIAL DE HERRERA","ZONA INDUSTRIAL DE HERRERA","ZONA INDUSTRIAL DE LA ISABELA","ZONA INDUSTRIAL DE VILLA MELLA","ZONA UNIVERSITARIA",
                "Otros"};
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                
		  cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");
                
                                
          }
            else if (cmbProvincia.Text == "Distrito Nacional")
            {
                string[] installs = new string[] { "24 de Abril", "27 de Febrero", "30 de Mayo", "Altos de Arroyo Hondo", "Arroyo Manzano", "Atala", "Bella Vista", "Buenos Aires (Distrito Nacional)", "Centro de los Héroes", "Centro Olímpico", "Cerros de Arroyo Hondo", "Ciudad Colonial", "Ciudad Nueva", "Ciudad Universitaria", "Cristo Rey", "Domingo Sabio", "El Cacique", "El Millón", "Ensanche Capotillo", "Ensanche Espaillat", "Ensanche La Fe", "Ensanche Luperón", "Ensanche Naco", "Ensanche Quisqueya", "Gazcue", "General Antonio Duverge", "Gualey", "Honduras del Norte", "Honduras del Oeste", "Jardín Botánico", "Jardín Zoológico", "Jardines del Sur", "Julieta Morales", "La Agustina", "La Esperilla", "La Hondonada", "La Isabela", "La Julia", "La Zurza", "Los Cacicazgos", "Los Jardines", "Los Peralejos", "Los Prados", "Los Restauradores", "Los Ríos", "María Auxiliadora", "Mata Hambre", "Mejoramiento Social", "Mirador Norte", "Mirador Sur", "Miraflores", "Miramar", "Nuestra Señora de la Paz", "Nuevo Arroyo Hondo", "Palma Real", "Paraíso", "Paseo de los Indios", "Piantini", "Puerto Isabela", "Renacimiento", "San Carlos", "San Diego", "San Geronimo", "San Juan Bosco", "Simón Bolívar", "Tropical de Metaldom", "Viejo Arroyo Hondo", "Villa Consuelo", "Villa Francisca", "Villa Juana", "Villas Agrícolasg" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");
            }


            else if (cmbProvincia.Text == "Azua")
            {
                string[] installs = new string[] { "Amiama Gómez (D.M.)", "Azua de Compostela, municipio cabecera","Barreras (D.M.)", "Barro Arriba (D.M.)", "Clavellina (D.M.)", "Doña Emma Balaguer Vda. Vallejo (D.M.)", "El Rosario (D.M.)", "Estebanía", "Ganadero (D.M.)", "Guayabal", "Hato Nuevo Cortés (D.M.)", "La Siembra (D.M.)", "Las Barías-La Estancia (D.M.)", "Las Charcas", "Las Lagunas (D.M.)", "Las Lomas (D.M.)", "Las Yayas de Viajama", "Los Fríos (D.M.)", "Los Jovillos (D.M.)", "Los Toros (D.M.)", "Monte Bonito (D.M.)", "Padre Las Casas", "Palmar de Ocoa (D.M.)", "Peralta", "Proyecto 2-C (D.M.)", "Proyecto 4 (D.M.)", "Pueblo Viejo", "Puerto Viejo (D.M.)", "Sabana Yegua", "Tábara Abajo (D.M.)", "Tábara Arriba", "Villarpando (D.M.)" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }

            else if (cmbProvincia.Text == "Bahoruco")
            {
                string[] installs = new string[] {"Cabeza de Toro","El Palmar","El Salado","Galván","Las Clavellinas","Los Ríos","Mena","Monserrat","Neiba, municipio cabecera","Santa Bárbara","Santana","Tamayo","Uvilla","Villa Jaragua" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }

            else if (cmbProvincia.Text == "Barahona")
            {
                string[] installs = new string[] {"Arroyo Dulce","Bahoruco","Cabral","Cachón","Canoa","El Cachón","El Peñón","Enriquillo","Fondo Negro","Fundación","Jaquimeyes","La Ciénaga","Las Salinas","Los Patos","Palo Alto","Paraíso","Pescadería","Polo","Quita Coraza","Santa Cruz de Barahona","Vicente Noble","Villa Central (Antiguo Batey Central)" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Dajabón")
            {
                string[] installs = new string[] {"Cañongo (D.M.)","Capotillo (D.M.)","Dajabón, municipio cabecera","El Pino","Loma de Cabrera","Manuel Bueno (D.M.)","Partido","Restauración","Santiago de la Cruz (D.M.)" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Duarte")
            {
                string[] installs = new string[] {"Agua Santa del Yuna (D.M.)","Aguacate (D.M.)","Arenoso","Barraquito (D.M.)","Castillo","Cenoví (D.M.)","Cristo Rey de Guaraguao (D.M.)","Eugenio María de Hostos","Jaya (D.M.)","La Peña (D.M.)","Las Coles (D.M.)","Las Guáranas","Las Táranas (D.M.)","Pimentel","Presidente Don Antonio Guzmán Fernández (D.M.)","Sabana Grande (D.M.)","San Francisco de Macorís, municipio cabecera de la provincia","Villa Riva" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "El Seibo")
            {
                string[] installs = new string[] {"El Cedro (D.M.)","La Gina (D.M.)","Miches","Pedro Sánchez (D.M.)","San Francisco-Vicentillo (D.M.)","Santa Cruz del Seibo, municipio cabecera de la provincia","Santa Lucía (D.M.)" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Elías Piña")
            {
                string[] installs = new string[] {"Bánica ","Comendador ","El Llano","Guanito (D.M.)","Guayabo (D.M.)","Hondo Valle","Juan Santiago ","Municipios y sus Distritos Municipales","Pedro Santana ","Rancho de la Guardia (D.M.)","Río Limpio (D.M.)","Sabana Cruz (D.M.)","Sabana Higüero (D.M.)","Sabana Larga (D.M.)" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Espaillat")
            {
                string[] installs = new string[] {"Canca la Reina","Cayetano Germosén","Comendador,Municipio cabecera","El Higüerito","Gaspar Hernández","Jamao Al Norte","Joba Arriba","José Contreras","Juan López","Las Lagunas","Moca","Monte de la Jagua","Ortega","San Víctor","Veragua","Villa Magante" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Hato Mayor")
            {
                string[] installs = new string[] {"El Valle","Elupina Cordero de Las Cañitas","Guayabo Dulce","Hato Mayor del Rey, municipio cabecera","Mata Palacio","Sabana de la Mar","Yerba Buena" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Hermanas Mirabal")
            {
                string[] installs = new string[] {"Salcedo, municipio cabecera","Tenares","Villa Tapia","Jamao Afuera","Blanco Arriba" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Independencia")
            {
                string[] installs = new string[] {"Batey 8 (D.M.)","Boca de Cachón (D.M.)","Cristóbal","Duvergé ","El Limón (D.M.)","Guayabal (D.M.)","Jimaní","La Colonia (D.M.)","La Descubierta","Mella","Postrer Río","Vengan a Ver (D.M.)" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "La Altagracia")
            {
                string[] installs = new string[] {"Bayahibe","Boca de Yuma","Las Lagunas de Nisibón","Otra Banda","Turístico Verón-Punta Cana" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "La Romana")
            {
                string[] installs = new string[] {"Altos De Chavon","Altos de Río Dulce","Bancola","Buena Vista Este","Buena vista Norte","Buena Vista Sur","Casa De Campo","Catanga","Chicago","El Matty bisono","Ensanche Benjamín","Ensanche La Hoz","La Aviación","Las Piedras","Los Colonos","Los Mulos","Melissa","Papagayo","Papagayo","Pica Piedra","Piedra Linda","Preconca","Preconca Nueva","Quisqueya (vieja y nueva)","Recidencial Las Orquideas","Reparto Torres","Residencial Costa Mar","Residencial Romana","Residencial Romana del Oeste","Rio Salado","Río Salado","San Carlos","Savica","Villa Alacran","Villa Caleta","Villa España","Villa Pereyra","villa real","Villa San Carlos","Villa Verde","Vista Catalina" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "La Vega")
            {
                string[] installs = new string[] { "Buena Vista (D.M.)","Concepción de La Vega","Constanza","El Ranchito (D.M.)","Jarabacoa","Jima Abajo","La Sabina (D.M.)","Manabao (D.M.)","Rincón (D.M.)","Río Verde Arriba (D.M.)","Tireo (D.M.)"};
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "María Trinidad Sánchez")
            {
                string[] installs = new string[] {"Arroyo al Medio (D.M.)","Arroyo Salado (D.M.)","Cabrera","El Factor","El Pozo (D.M.)","La Entrada (D.M.)","Las Gordas (D.M.)","Nagua","Río San Juan","San José de Matanzas (D.M.)" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Monseñor Nouel")
            {
                string[] installs = new string[] { "Arroyo Toro-Masipedro (D.M.)","Bonao","Jayaco (D.M.)","Juan Adrián (D.M.)","Juma Bejucal (D.M.)","La Salvia-Los Quemados (D.M.)","Maimón","Piedra Blanca","Sabana del Puerto (D.M.)","Villa Sonador (D.M.)"};
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Monte Plata")
            {
                string[] installs = new string[] { "Majagual","Anton Sánchez","Bayaguana","Boyá (D.M.)","Centro Penso","Chirino (D.M.)","Cojobal","Comatillo","Don Juan (D.M.)","Frias","Gonzalo (D.M.)","Hidalgo","Juan Sánchez","La China","La Guazuma","La Pista","Los Botados (D.M.)","Los Jobillo","Los Mapolo","Monte Plata, municipio cabecera","Peralvillo","Sabana de Payabo","Sabana Grande de Boyá","San Antonio","Trinidad","Yamasá","Yuvina"};
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Montecristi")
            {
                string[] installs = new string[] {"Castañuelas (Ramon A. Pimentel). (Moreno)","Guayubín: (ING.Samuel Toribio). (Samuel)","Las Matas de Santa Cruz (Jose Ramon Estevez)","Pepillo Salcedo (Yanco Cruz Benjaran). (Yanco)","San Fernando de Montecristi (Luis Mendez Capellan ). (Luisito)","Villa Vásquez (Domingo Rivas)" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Pedernales")
            {
                string[] installs = new string[] {"LOS CAYUCOS" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Peravia")
            {
                string[] installs = new string[] {"Baní","Cañafistol","Catalina","El Carretón","Las Barias","Matanzas","Nízao","Parque de Nizao","Paya","Pizarrete","Santana","villa findacion[Saba buey]","Villa Sombrero" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Puerto Plata")
            {
                string[] installs = new string[] {"Altamira","Belloso","Cabarete","Cerro de Navas","El Estrecho de Luperón","Estero Hondo","Gualete","Guananico","Imbert","La Isabela","La Jaiba","Los Hidalgos","Luperón","Maimón","Río Grande","Sabaneta de Yásica","San Felipe de Puerto Plata","Sosúa","Villa Isabela","Villa Montellano","Yásica Arriba" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Samaná")
            {
                string[] installs = new string[] {"Arroyo Barril","El Limón","Las Galeras","Las Terrenas","Sánchez","Santa Bárbara de Samaná" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "San Cristóbal")
            {
                string[] installs = new string[] {"Bajos de Haina","Cambita El Pueblecito (D.M.)","Cambita Garabito","El Carril (D.M.)","Hato Damas (D.M.)","La Cuchilla (D.M.)","Los Cacaos","Medina (D.M.)","Sabana Grande de Palenque","San Cristóbal","San Gregorio de Nigua","San José del Puerto (D.M.)","Villa Altagracia","Yaguate" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "San José de Ocoa")
            {
                string[] installs = new string[] {"El Pinar","La Ciénaga","Naranjal- Parra","Nizao-Las Auyamas","Rancho Arriba","Sabana Larga","San José de Ocoa" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "San Juan")
            {
                string[] installs = new string[] {"((Las Zanjas- El Batey)) (D.M.)","Arroyo Cano (D.M.)","Batista (D.M.)","Bohechío","CarreYegua (D.M.)","Derrumbadero (D.M.)","El Cercado","El Rosario (D.M.)","Guanito (D.M.)","Hato del Padre (D.M.)","Jínova (D.M.)","Jorjillo (D.M.)","Juan de Herrera","La Jagua (D.M.)","Las Charcas de María Nova (D.M.)","Las Maguanas-Hato Nuevo (D.M.)","Las Matas de Farfán","Matayaya (D.M.)","Pedro Corto (D.M.)","Sabana Alta (D.M.)","Sabaneta (D.M.)","San Juan de la Maguana ","Vallejuelo","Yaque (D.M.)" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "San Pedro de Macorís")
            {
                string[] installs = new string[] {"Consuelo","El Puerto","Gautier","Guayacanes","Quisqueya","Ramón Santana","San José de Los Llanos","San Pedro de Macorís" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            else if (cmbProvincia.Text == "Sánchez Ramírez")
            {
                string[] installs = new string[] {"Angelina","Caballero","Cevicos","Cevicos","Comedero Arriba","Cotuí","Fantino","Hernando Alonzo","La Bija","La Cueva","La Mata","No Tiene","Platanal","Quita Sueño","Zambrana" };
                cmbSector.Items.Clear();
                cmbSector.Text = "";
                cmbSector.Items.AddRange(installs);

                cmbSector.Focus();
                cmbSector.Items.Add("");

            }
            

        }      

        // codigp para salir del formulario
        private void Salir() 
        {
            if (MessageBox.Show("Deseas salir  ", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {

                this.Hide();
                this.Close();
                this.Dispose();


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Salir();

        }           

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
                this.mktCedula.Focus();

        }

        private void maskedTxtCedula_KeyDown(object sender, KeyEventArgs e)
        {          

            if (mktCedula.MaskCompleted)
            {
                if (e.KeyCode == Keys.Enter)
                 this.txtNombre.Focus(); 
                    
                else { this.errorProvider1.Clear(); }

                if (e.KeyCode == Keys.Down)
                    this.txtNombre.Focus();
                else { this.errorProvider1.Clear(); }
            }

            else 
            {   
                this.errorProvider1.SetError(this.mktCedula,"Complete el Campo ")      ;
           
            mktCedula.Focus();
            }
            
                  

        }      

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.txtApellido.Focus(); }

            else if (e.KeyCode==Keys.Down)
                this.txtApellido.Focus();
            
        }

        private void maskedTxtOficina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.mkdTxtResidencia.Focus(); }
            else if (e.KeyCode == Keys.Down)
                this.mkdTxtResidencia.Focus();
        }

        private void maskedTxtResidencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (mkdTxtResidencia.MaskCompleted)
            {
                if (e.KeyCode == Keys.Enter)
                this.mkdTxtCel.Focus(); 

                      else { this.errorProvider1.Clear(); }
                if (e.KeyCode == Keys.Down)
                    this.mkdTxtCel.Focus();

                  else { this.errorProvider1.Clear(); }
            }

            else 
            {   
                this.errorProvider1.SetError(this.mkdTxtResidencia,"Complete el Campo ")      ;
           
            this.mkdTxtResidencia.Focus();
            }


            if (mktCedula.MaskCompleted && txtFecha.Text != "" & txtNombre.Text != "" && txtApellido.Text != "" && mkdTxtOficina.Text != "" && mkdTxtResidencia.Text != "" && mkdTxtCel.Text != "" && cmbProvincia.Text != "" && cmbSector.Text != "" && txtCalle.Text != "" && txtNo_Casa.Text != "")
            {
                btnGuardar.Focus();

            }








        }

        private void maskedTxtCel_KeyDown(object sender, KeyEventArgs e)
        {
            if (mkdTxtCel.MaskCompleted)
            {
                if (e.KeyCode == Keys.Enter)
                this.cmbProvincia.Focus(); 

                    else { this.errorProvider1.Clear(); }

                 if (e.KeyCode == Keys.Down)
                    this.cmbProvincia.Focus();
                 else { this.errorProvider1.Clear(); }
            }

            else
            {
                this.errorProvider1.SetError(this.mkdTxtCel, "Complete el Campo ");

                this.mkdTxtCel.Focus();
            }



            if (mktCedula.MaskCompleted && txtFecha.Text != "" & txtNombre.Text != "" && txtApellido.Text != "" && mkdTxtOficina.Text != "" && mkdTxtResidencia.Text != "" && mkdTxtCel.Text != "" && cmbProvincia.Text != "" && cmbSector.Text != "" && txtCalle.Text != "" && txtNo_Casa.Text != "")
            {
                btnGuardar.Focus();

            }
        }

        private void cmbProvincia_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                this.sectorXprovincia();
                //this.cmbSector.Focus(); 
            }
           
        }

        private void txtSector_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            { this.txtCalle.Focus(); }
            else if (e.KeyCode == Keys.Down)
                this.txtCalle.Focus();
        }       

        private void txtnNo_Casa_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            { this.btnGuardar.Focus(); }
            else if (e.KeyCode == Keys.Down)
                this.btnGuardar.Focus();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            lblUsuario.Text = NombreUsuario;

        }

        private void Insertar()
        {
            Existe();
            if (txtID.Text != "" & mktCedula.MaskCompleted & txtFecha.Text != "" & txtNombre.Text != "" & txtApellido.Text != "" & mkdTxtOficina.Text!="" & mkdTxtResidencia.MaskCompleted & mkdTxtCel.MaskCompleted & cmbProvincia.Text != "" & cmbSector.Text != "" & txtCalle.Text != "" & txtNo_Casa.Text != "")
            {
                cBD.MiConexion.Open();
                            /* acsociamos comando sql con conexion */

                            cBD.ComandoSql.Connection = cBD.MiConexion;

                            cBD.ComandoSql.CommandText = "Insert into tbl_Cliente(CCedula,CFechaEntrada,CNombres,CApellidos,COficina,CResidencia,CCel,CProvincia,CSector,CCalle,CNoCasa) values (            '" + mktCedula.Text + "','" + txtFecha.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + mkdTxtOficina.Text + "','" + mkdTxtResidencia.Text + "','" + mkdTxtCel.Text + "','" + cmbProvincia.Text + "','" + cmbSector.Text + "','" + txtCalle.Text + "','" + txtNo_Casa.Text + "')";
                            cBD.ComandoSql.ExecuteNonQuery();                                                                                                                                        
                            cBD.ComandoSql.Clone();


                            MessageBox.Show("Cliente Registrado Exitosamente !", "Exelente !");
                            this.cBD.MiConexion.Close();
                            this.RestablecerLabel();
                            
                            
                            AutoCompletar();
                            Limpiar();
                            CargarID();
                            this.mktCedula.Focus();
            }
            else 
            {
                cBD.MiConexion.Close();

                if (MessageBox.Show("Complete los Campos Vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    this.Validar();
                }

                
            }
            

            if (this.mktCedula.MaskCompleted & this.txtFecha.Text != "" & this.txtNombre.Text != "" & txtApellido.Text != "" && mkdTxtOficina.Text != "" && mkdTxtResidencia.Text != "" && mkdTxtCel.Text != "" && cmbProvincia.Text != "" && cmbSector.Text != "" && txtCalle.Text != "" && txtNo_Casa.Text != "")
            {
               this.btnGuardar.Focus();

            }
        }

        private void Limpiar()
        {

            txtID.Text = "";
            mktCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            mkdTxtOficina.Text = "";
            mkdTxtResidencia.Text = "";
            mkdTxtCel.Text = "";
            cmbProvincia.Text = "";
            cmbSector.Text = "";
            txtCalle.Text = "";
            txtNo_Casa.Text = "";
                            
        }

         // Mi forma de Validar los Campos     
        private void Validar()
        {

            // Aqui puse el codigo de Abajo hacia arriba para que determine y se ubique en el  campo que esta mas cerca del principios
            if (this.txtNo_Casa.Text == "")
            {
                this.errorProvider1.SetError(this.txtNo_Casa, "Complete el Campo");
                this.lblNCasa.ForeColor = System.Drawing.Color.Red;
                
                this.txtNo_Casa.Focus();

            }


            if (this.txtCalle.Text == "")
            {
                this.errorProvider1.SetError(this.txtCalle, "Complete el Campo");
                this.lblCalle.ForeColor = Color.Red;

                this.txtCalle.Focus();

            }
            if (this.cmbSector.Text == "")
            {
                this.errorProvider1.SetError(this.cmbSector, "Complete el Campo");
                this.cmbSector.Focus();
                this.lblSector.ForeColor = Color.Red;

            }


            if (this.cmbProvincia.Text == "")
            {
                this.errorProvider1.SetError(this.cmbProvincia, "Complete el Campo");

                this.cmbProvincia.Focus();
                this.lblProvincia.ForeColor = Color.Red;
            }

            if (this.mkdTxtCel.MaskCompleted)
            {
                
            }
            else
            {

                this.errorProvider1.SetError(this.mkdTxtCel, "Complete el Campo");
                this.mkdTxtCel.Focus();
                this.lblMovil.ForeColor = Color.Red;

            }

            if (this.mkdTxtResidencia.MaskCompleted)
            {                

            }
            else
            {
                this.errorProvider1.SetError(this.mkdTxtResidencia, "Complete el Campo");
                this.mkdTxtResidencia.Focus();
                this.lblResidencia.ForeColor = Color.Red;
            }
            /*
            if (mkdTxtOficina.MaskCompleted)
            {
                btnRegistrar.Focus();

            }
            else
            {

                this.errorProvider1.SetError(this.mkdTxtOficina, "Complete el Campo");
                this.mkdTxtOficina.Focus();

            }
            */
            if (this.txtApellido.Text == "")
            {
                this.errorProvider1.SetError(this.txtApellido, "Complete el Campo");
                this.txtApellido.Focus();
                this.Lbl_Apellido.ForeColor = Color.Red;

            }

            if (this.txtNombre.Text == "")
            {
                this.errorProvider1.SetError(this.txtNombre, "Complete el Campo");
                this.txtNombre.Focus();
                this.lbl_Nombre.ForeColor = Color.Red;
                

            }


           if (this.mktCedula.MaskCompleted)
            {                          

            }
            else
            {
                this.errorProvider1.SetError(this.mktCedula, "Complete el Campo");

               this. mktCedula.Focus();
               this.lblCedula.ForeColor = Color.Red;
            }
            
        
        
        }
        // Metodo para restablecer el color de los Label 
        private void RestablecerLabel() 
        {
            this.lblID.ForeColor = DefaultForeColor;
            this.lblCedula.ForeColor = DefaultForeColor;
            this.lbl_Nombre.ForeColor = DefaultForeColor;
            this.Lbl_Apellido.ForeColor = DefaultForeColor;
            this.lblOficina.ForeColor = DefaultForeColor;
            this.lblResidencia.ForeColor = DefaultForeColor;
            this.lblMovil.ForeColor = DefaultForeColor;
            this.lblProvincia.ForeColor = DefaultForeColor;
            this.lblSector.ForeColor = DefaultForeColor;
            this.lblCalle.ForeColor = DefaultForeColor;
            this.lblNCasa.ForeColor = DefaultForeColor;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            Insertar();
           
            
            
         
               
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {  

              // para el uso de la tecla enter y espacios este codigo solo funciona si el campo esta vacio
              
            if  ( this.txtNombre.Text == "" )
            {
                // Desabilito los espacios cuando se  introdusca espacios los campos no lo hacepten  vacios
                // este meodo dure mucho para planterarlo pero lo logre son errores que hay que corregir para que los datos no tomen datos erroneos
               // no se como pero este codigo esta combinado con el de abajo y me da la opcion para que pueda digitar numeros y signos al principios

                if (char.IsControl(e.KeyChar))
                {

                    e.Handled = true;
                }

                else if (char.IsSymbol(e.KeyChar))
                {
                    e.Handled = true;
                }


                else if (!char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {

                    e.Handled = true;
                }
                          
                    
                // podemos enviar un mensaje de texto o utilizar el control error provider
                this.errorProvider1.SetError(this.txtNombre, "Este Campo es Obligatorio");
                txtNombre.Focus();
            }                            
            
            else
            {
                
                this.errorProvider1.Clear();
            }

            // valido que no hacepten numeros 
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider1.SetError(this.txtNombre, "Este Campo No Acepta Números ");
                this.txtNombre.Focus();
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                 e.Handled = true;
                this.errorProvider1.SetError(this.txtNombre, "Este Campo No Acepta Signos ");
                this.txtNombre.Focus();
            }

            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider1.SetError(this.txtNombre, "Este Campo No Acepta Signos ");
                this.txtNombre.Focus();
            }

                        
              
    }
        private void cmbProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) & this.cmbProvincia.Text == "")
            {
               errorProvider1.SetError(cmbProvincia, "Debe seleccionar una opcíon");
                cmbProvincia.Focus();
               
            }
            else
            {
                errorProvider1.Clear();
            }
                        
            
            if (char.IsLetter(e.KeyChar))
            {
                errorProvider1.SetError(cmbProvincia, "Debe seleccionar una opcíon");
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;


            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            
            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }


           
            
        }

        private void txtSector_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) & cmbSector.Text == "")
            {
                // podemos enviar un mensaje de texto o utilizar el control error provider
                this.errorProvider1.SetError(this.cmbSector, "Este Campo es Obligatorio");
                cmbSector.Focus();
            }

            else
            {
                this.errorProvider1.Clear();
            }





            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;


            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }


            

        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;


            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = true;
            }
        }
        private void cmbProvincia_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (!int.TryParse(cmbProvincia.Text, out result))
                cmbProvincia.Text = "";
        }

        private void txtNo_Casa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & this.txtNo_Casa.Text == "")
            {
                // podemos enviar un mensaje de texto o utilizar el control error provider
                this.errorProvider1.SetError(this.txtNo_Casa, "Digite un numero de Casa");
                txtNo_Casa.Focus();
            }

            else
            {
                this.errorProvider1.Clear();
            }




            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;


            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                this.errorProvider1.SetError(this.txtNo_Casa, "Este Campo Solo Acepta nuemero");
                txtNo_Casa.Focus();
                e.Handled = true;
            }



       
      





             




        }      

        private void mkdTxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Existe();


            if (mktCedula.MaskCompleted && txtFecha.Text != "" & txtNombre.Text != "" && txtApellido.Text != "" && mkdTxtOficina.Text != "" && mkdTxtResidencia.Text != "" && mkdTxtCel.Text != "" && cmbProvincia.Text != "" && cmbSector.Text != "" && txtCalle.Text != "" && txtNo_Casa.Text != "")
                {
                    btnGuardar.Focus();

                }
                        
            

            

        }

        // si existe en base de datos
       private void Existe() 
        {
            
            ConexionBD cn = new ConexionBD();
            cn.MiConexion.Open();
            cn.ComandoSql.CommandText = @"SELECT * FROM Tbl_Cliente WHERE CCedula =   '" + mktCedula.Text + "'";

            cn.ComandoSql.Connection = cn.MiConexion;

            cn.leerDatos = cn.ComandoSql.ExecuteReader();



            if (cn.leerDatos.Read() == true)
            {
                MessageBox.Show("La cedula ya exite  ", "Advertencia");
                this.mktCedula.Clear();
                this.mktCedula.Focus();
            }

        }

       private void txtID_KeyPress(object sender, KeyPressEventArgs e)
       {
           // este el codigo para que coja solo numero


           if (char.IsNumber(e.KeyChar))
           {
               e.Handled = false;
           }

           else if (char.IsControl(e.KeyChar))
           {
               e.Handled = false;


           }

           else if (char.IsSeparator(e.KeyChar))
           {
               e.Handled = false;
           }

           else
           {
               e.Handled = true;
           }



           //

           if ((int)e.KeyChar == (int)Keys.Enter)
           {
               // Validaciones 

               //   errorProvider1.SetError(txtID, "");

               int id = 0;

               if (!int.TryParse(txtID.Text, out id) && txtID.Text == "")
               {
                   errorProvider1.SetError(txtID, "No se haceptan campo vacios");
                   txtID.Focus();
                   return;

                   /* errorProvider1.SetError(txtID, "El ID debe ser un Valor numerico.");
                    return;*/



               }
           }
       }
       /*         if (!Existe(id))
                {
                    // con este codigo puedo decir que no hay ningun error
                    errorProvider1.Clear();
                    return;

                }

                else 
                {


                    errorProvider1.SetError(txtID, "El ID Ya existe  .");
                
                }

                Obtener(id);

            }
        }// fin de key press
        
    /*    // este metodo lo que hace es una consulta y lo manda a textbox
      private void Obtener(int id)
        {

            string sql = @"SELECT IdCliente,Nombres,Apellidos FROM tblCliente WHERE IdCliente =@IdCliente";

            using (SqlConnection conn = new SqlConnection(@" Data Source=GEIDISON;Initial Catalog=BDFacturacion;Integrated Security=True"))


            {
                SqlCommand comandosql = new SqlCommand(sql, conn);

                comandosql.Parameters.AddWithValue("IdCliente", id);

                conn.Open();

                SqlDataReader LecturaBD = comandosql.ExecuteReader();
                if (LecturaBD.Read())
                
                {

                    txtNombre.Text = Convert.ToString(LecturaBD["Nombres"]);
                    txtApellido.Text = Convert.ToString(LecturaBD["Apellidos"]);

                }

                

            }
       

        }// fin del metodo OBtener

        */
  /*      // este metodo se encar de decir si existe en Base de dato
        private bool Existe(int id)

        { 
                   string sql = @"SELECT COUNT(*) FROM tblCliente WHERE CId =@CId";

           using (SqlConnection conn = new SqlConnection(@" Data Source=GEIDISON;Initial Catalog=BDFacturacion;Integrated Security=True"))

           {

               SqlCommand comandosql = new SqlCommand(sql, conn);

               comandosql.Parameters.AddWithValue("IdCliente", id);

               conn.Open();

               int count = Convert.ToInt32(comandosql.ExecuteScalar());

               if (count == 0)
               { return false; }
               else
               { return true; }
        
           }

        }           

      */

        private void Frm_EntradaDeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Existe();
                Insertar();
            }
            else if (e.KeyCode == Keys.F3)

                Salir();

                           
        }

        private void cmbSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCalle.Focus();
            errorProvider1.Clear();
        }                   

        private void mkdTxtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
                    
            
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;


            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                
                e.Handled = true;
            }
         


        }                  
    
        private void cmbSector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & this.cmbSector.Text == "")
            {
                errorProvider1.SetError(this.cmbSector, "Debe seleccionar una opcíon");
                this.cmbSector.Focus();

            }
            else
            {

                errorProvider1.Clear();
            }


            if (char.IsLetter(e.KeyChar))
            {
                errorProvider1.SetError(this.cmbSector, "Debe seleccionar una opcíon");
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;


            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;

            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ( this.txtCalle.Text == "" )
            {
                // podemos enviar un mensaje de texto o utilizar el control error provider
                this.errorProvider1.SetError(this.txtCalle, "Este Campo es Obligatorio");
                this.txtCalle.Focus();
            }

            else
            {
                this.errorProvider1.Clear();
            }
            // Desabilito los espacios cuando se  introdusca espacios los campos no lo hacepten  vacios
            // este meodo dure mucho para planterarlo pero lo logre son errores que hay que corregir para que los datos no tomen datos erroneos

            if (this.txtCalle.Text == "")
            {

               if (char.IsControl(e.KeyChar) )
                {

                    e.Handled = true;
                }
               else if (char.IsSymbol(e.KeyChar))
               {
                   e.Handled = true;
               }
                else if (!char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {

                    e.Handled = true;
                }
            }
           }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // para el uso de la tecla enter y espacios este codigo solo funciona si el campo esta vacio

            if (this.txtApellido.Text == "")
            {
                // Desabilito los espacios cuando se  introdusca espacios los campos no lo hacepten  vacios
                // este meodo dure mucho para planterarlo pero lo logre son errores que hay que corregir para que los datos no tomen datos erroneos
                // no se como pero este codigo esta combinado con el de abajo y me da la opcion para que pueda digitar numeros y signos al principios

                if (char.IsControl(e.KeyChar))
                {

                    e.Handled = true;

                }
                else if (!char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {

                    e.Handled = true;
                }


                // podemos enviar un mensaje de texto o utilizar el control error provider
                this.errorProvider1.SetError(this.txtApellido, "Este Campo es Obligatorio");
                txtApellido.Focus();
            }

            else
            {

                this.errorProvider1.Clear();
            }

            // valido que no hacepten numeros 
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider1.SetError(this.txtApellido, "Este Campo No Acepta Números ");
                this.txtApellido.Focus();
            }

            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider1.SetError(this.txtApellido, "Este Campo No Acepta Signos ");
                this.txtApellido.Focus();
            }


            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider1.SetError(this.txtApellido, "Este Campo No Acepta Signos ");
                this.txtApellido.Focus();
            }

         
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtApellido.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                { this.mkdTxtOficina.Focus(); }
                else if (e.KeyCode == Keys.Down)
                    this.mkdTxtOficina.Focus();
            }

            else
            {
                this.errorProvider1.SetError(this.txtApellido, "Este Campo es Obligatorio");

                this.txtApellido.Focus();
            }
        }

        private void cmbProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            this.sectorXprovincia();
        }

        private void txtCalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter & this.txtCalle.Text!="")
            {
                this.txtNo_Casa.Focus();
            
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // desactivo las teclas de escribir palabras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            // desactivo las teclas Numericas del teclado
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            // desactivo las teclas de signos del teclado
            else if (char.IsPunctuation(e.KeyChar))
            {

               e.Handled = true;
            }
            // desactivo las teclas espacios
            else if (char.IsSeparator(e.KeyChar))
            {
            e.Handled=true;
            }
            // desactivo las teclas enter
            else if (char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
            }

            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled= true;
            }

            
        }

       

              

        
       

       
             
        }



    
    
    
      
        }
    

        



      
    
    
    




    

