namespace FIVT
{
    partial class Frm_EntradaDeCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.mktCedula = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.mkdTxtCel = new System.Windows.Forms.MaskedTextBox();
            this.lblMovil = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.mkdTxtOficina = new System.Windows.Forms.MaskedTextBox();
            this.lblOficina = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.mkdTxtResidencia = new System.Windows.Forms.MaskedTextBox();
            this.lblResidencia = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.txtNo_Casa = new System.Windows.Forms.TextBox();
            this.lblNCasa = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUsuario = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(15, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(699, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtID);
            this.groupBox10.Controls.Add(this.lblID);
            this.groupBox10.Location = new System.Drawing.Point(14, 24);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Size = new System.Drawing.Size(186, 50);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(31, 21);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(112, 24);
            this.txtID.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtID, "ID del Cliente");
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(68, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 18);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "*ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtApellido);
            this.groupBox4.Controls.Add(this.txtNombre);
            this.groupBox4.Controls.Add(this.Lbl_Apellido);
            this.groupBox4.Controls.Add(this.lbl_Nombre);
            this.groupBox4.Location = new System.Drawing.Point(14, 78);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(598, 52);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(296, 21);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(208, 24);
            this.txtApellido.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtApellido, "Campo para los  Apellidos del Cliente");
            this.txtApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApellido_KeyDown);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(29, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 24);
            this.txtNombre.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtNombre, "Campo para los  Nombres del Cliente");
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // Lbl_Apellido
            // 
            this.Lbl_Apellido.AutoSize = true;
            this.Lbl_Apellido.Location = new System.Drawing.Point(365, -2);
            this.Lbl_Apellido.Name = "Lbl_Apellido";
            this.Lbl_Apellido.Size = new System.Drawing.Size(73, 18);
            this.Lbl_Apellido.TabIndex = 1;
            this.Lbl_Apellido.Text = "*Apellidos";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(89, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(76, 18);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "*Nombres";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCedula);
            this.groupBox2.Controls.Add(this.mktCedula);
            this.groupBox2.Location = new System.Drawing.Point(233, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(188, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(61, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(64, 18);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = " *Cedula";
            // 
            // mktCedula
            // 
            this.mktCedula.Location = new System.Drawing.Point(32, 20);
            this.mktCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mktCedula.Mask = "000-0000000-0";
            this.mktCedula.Name = "mktCedula";
            this.mktCedula.Size = new System.Drawing.Size(133, 24);
            this.mktCedula.TabIndex = 1;
            this.toolTip1.SetToolTip(this.mktCedula, "Componente para Introducir Cedula");
            this.mktCedula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTxtCedula_KeyDown);
            this.mktCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mkdTxtCedula_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFecha);
            this.groupBox3.Controls.Add(this.lblFecha);
            this.groupBox3.Location = new System.Drawing.Point(468, 24);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(186, 50);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(32, 20);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(112, 24);
            this.txtFecha.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtFecha, "Fecha Actual del Sistema");
            this.txtFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFecha_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(58, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 18);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = " *Fecha";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Location = new System.Drawing.Point(15, 171);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(699, 71);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.mkdTxtCel);
            this.groupBox8.Controls.Add(this.lblMovil);
            this.groupBox8.Location = new System.Drawing.Point(447, 15);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(174, 53);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            // 
            // mkdTxtCel
            // 
            this.mkdTxtCel.Location = new System.Drawing.Point(26, 21);
            this.mkdTxtCel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkdTxtCel.Mask = "000-000-0000";
            this.mkdTxtCel.Name = "mkdTxtCel";
            this.mkdTxtCel.Size = new System.Drawing.Size(112, 24);
            this.mkdTxtCel.TabIndex = 7;
            this.toolTip1.SetToolTip(this.mkdTxtCel, "Campo para telefonos Movil del Cliente");
            this.mkdTxtCel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTxtCel_KeyDown);
            this.mkdTxtCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mkdTxtCel_KeyPress);
            // 
            // lblMovil
            // 
            this.lblMovil.AutoSize = true;
            this.lblMovil.Location = new System.Drawing.Point(50, 0);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(60, 18);
            this.lblMovil.TabIndex = 2;
            this.lblMovil.Text = "*Celular";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.mkdTxtOficina);
            this.groupBox6.Controls.Add(this.lblOficina);
            this.groupBox6.Location = new System.Drawing.Point(20, 15);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(174, 53);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            // 
            // mkdTxtOficina
            // 
            this.mkdTxtOficina.Location = new System.Drawing.Point(23, 20);
            this.mkdTxtOficina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkdTxtOficina.Mask = "000-000-0000";
            this.mkdTxtOficina.Name = "mkdTxtOficina";
            this.mkdTxtOficina.Size = new System.Drawing.Size(112, 24);
            this.mkdTxtOficina.TabIndex = 5;
            this.toolTip1.SetToolTip(this.mkdTxtOficina, "Campo Para Telefono Oficina o trabajo del Cliente");
            this.mkdTxtOficina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTxtOficina_KeyDown);
            // 
            // lblOficina
            // 
            this.lblOficina.AutoSize = true;
            this.lblOficina.Location = new System.Drawing.Point(44, 0);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(54, 18);
            this.lblOficina.TabIndex = 1;
            this.lblOficina.Text = "Oficina";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.mkdTxtResidencia);
            this.groupBox7.Controls.Add(this.lblResidencia);
            this.groupBox7.Location = new System.Drawing.Point(233, 15);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(174, 53);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // mkdTxtResidencia
            // 
            this.mkdTxtResidencia.Location = new System.Drawing.Point(32, 21);
            this.mkdTxtResidencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mkdTxtResidencia.Mask = "000-000-0000";
            this.mkdTxtResidencia.Name = "mkdTxtResidencia";
            this.mkdTxtResidencia.Size = new System.Drawing.Size(112, 24);
            this.mkdTxtResidencia.TabIndex = 6;
            this.toolTip1.SetToolTip(this.mkdTxtResidencia, "Campo para telefonos Residenciales ");
            this.mkdTxtResidencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTxtResidencia_KeyDown);
            // 
            // lblResidencia
            // 
            this.lblResidencia.AutoSize = true;
            this.lblResidencia.Location = new System.Drawing.Point(51, 0);
            this.lblResidencia.Name = "lblResidencia";
            this.lblResidencia.Size = new System.Drawing.Size(87, 18);
            this.lblResidencia.TabIndex = 0;
            this.lblResidencia.Text = "*Residencia";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.txtCalle);
            this.groupBox15.Controls.Add(this.lblCalle);
            this.groupBox15.Location = new System.Drawing.Point(20, 70);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox15.Size = new System.Drawing.Size(281, 98);
            this.groupBox15.TabIndex = 12;
            this.groupBox15.TabStop = false;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(23, 24);
            this.txtCalle.MaxLength = 50;
            this.txtCalle.Multiline = true;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(221, 67);
            this.txtCalle.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtCalle, "Campo para detallar mejor la calle o localizacionn del cliente \r\n");
            this.txtCalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCalle_KeyDown);
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(70, 3);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(110, 18);
            this.lblCalle.TabIndex = 0;
            this.lblCalle.Text = "*Calle / Avenida";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.txtNo_Casa);
            this.groupBox16.Controls.Add(this.lblNCasa);
            this.groupBox16.Location = new System.Drawing.Point(321, 77);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox16.Size = new System.Drawing.Size(100, 47);
            this.groupBox16.TabIndex = 13;
            this.groupBox16.TabStop = false;
            // 
            // txtNo_Casa
            // 
            this.txtNo_Casa.Location = new System.Drawing.Point(8, 15);
            this.txtNo_Casa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNo_Casa.MaxLength = 4;
            this.txtNo_Casa.Name = "txtNo_Casa";
            this.txtNo_Casa.Size = new System.Drawing.Size(72, 24);
            this.txtNo_Casa.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtNo_Casa, "Campo para el Número de la  Casa del Cliente");
            this.txtNo_Casa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnNo_Casa_KeyDown);
            this.txtNo_Casa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNo_Casa_KeyPress);
            // 
            // lblNCasa
            // 
            this.lblNCasa.AutoSize = true;
            this.lblNCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCasa.Location = new System.Drawing.Point(5, -4);
            this.lblNCasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNCasa.Name = "lblNCasa";
            this.lblNCasa.Size = new System.Drawing.Size(69, 18);
            this.lblNCasa.TabIndex = 0;
            this.lblNCasa.Text = "*Nº Casa";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.cmbSector);
            this.groupBox17.Controls.Add(this.lblSector);
            this.groupBox17.Location = new System.Drawing.Point(321, 16);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox17.Size = new System.Drawing.Size(364, 53);
            this.groupBox17.TabIndex = 11;
            this.groupBox17.TabStop = false;
            // 
            // cmbSector
            // 
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(7, 20);
            this.cmbSector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(340, 26);
            this.cmbSector.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cmbSector, "Campo Sector Contienes todo los Sectores de la provincia selecionada\r\n\r\n ");
            this.cmbSector.SelectedIndexChanged += new System.EventHandler(this.cmbSector_SelectedIndexChanged);
            this.cmbSector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSector_KeyPress);
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector.Location = new System.Drawing.Point(149, 0);
            this.lblSector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(58, 18);
            this.lblSector.TabIndex = 0;
            this.lblSector.Text = "*Sector";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.cmbProvincia);
            this.groupBox18.Controls.Add(this.lblProvincia);
            this.groupBox18.Location = new System.Drawing.Point(19, 16);
            this.groupBox18.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox18.Size = new System.Drawing.Size(279, 53);
            this.groupBox18.TabIndex = 10;
            this.groupBox18.TabStop = false;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "Santo Domingo",
            "Distrito Nacional",
            "Santiago",
            "San Cristóbal",
            "La Vega",
            "Puerto Plata",
            "San Pedro de Macorís",
            "Duarte",
            "San Juan",
            "Espaillat",
            "La Romana",
            "Azua",
            "La Altagracia",
            "Monte Plata",
            "Barahona",
            "Peravia",
            "Monseñor Nouel",
            "Valverde",
            "Sánchez Ramírez",
            "María Trinidad Sánchez",
            "Montecristi",
            "Hermanas Mirabal",
            "Samaná",
            "Bahoruco",
            "El Seibo",
            "Hato Mayor",
            "Elías Piña",
            "San José de Ocoa",
            "Dajabón",
            "Santiago Rodríguez",
            "Independencia",
            "Pedernales"});
            this.cmbProvincia.Location = new System.Drawing.Point(24, 20);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProvincia.MaxLength = 22;
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(223, 26);
            this.cmbProvincia.TabIndex = 8;
            this.toolTip1.SetToolTip(this.cmbProvincia, "Campo  Provincias Contienes todas las provincia\r\n");
            this.cmbProvincia.SelectedValueChanged += new System.EventHandler(this.cmbProvincia_SelectedValueChanged);
            this.cmbProvincia.TextChanged += new System.EventHandler(this.cmbProvincia_TextChanged);
            this.cmbProvincia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProvincia_KeyDown);
            this.cmbProvincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProvincia_KeyPress);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(85, 0);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(75, 18);
            this.lblProvincia.TabIndex = 0;
            this.lblProvincia.Text = "*Provincia";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox18);
            this.groupBox9.Controls.Add(this.groupBox17);
            this.groupBox9.Controls.Add(this.groupBox16);
            this.groupBox9.Controls.Add(this.groupBox15);
            this.groupBox9.Location = new System.Drawing.Point(15, 248);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(699, 177);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnGuardar);
            this.groupBox11.Controls.Add(this.btnSalir);
            this.groupBox11.Location = new System.Drawing.Point(100, 433);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox11.Size = new System.Drawing.Size(475, 54);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(66, 16);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 32);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "&Guardar";
            this.toolTip1.SetToolTip(this.btnGuardar, "Botón para Guardar Datos del Cliente");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(298, 12);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 36);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalir, "Botón para Salir del Formulario");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 564);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(138, 18);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Nombre de Usuario";
            this.toolTip1.SetToolTip(this.lblUsuario, "Nombre del Usuario según su categoria");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Los campos con * son olbligatorios.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Entrada de Clientes";
            // 
            // Frm_EntradaDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "Frm_EntradaDeCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Cliente";
            this.Load += new System.EventHandler(this.Frm_Cliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_EntradaDeCliente_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.MaskedTextBox mktCedula;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Lbl_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblOficina;
        private System.Windows.Forms.Label lblMovil;
        private System.Windows.Forms.Label lblResidencia;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.MaskedTextBox mkdTxtOficina;
        private System.Windows.Forms.MaskedTextBox mkdTxtResidencia;
        private System.Windows.Forms.MaskedTextBox mkdTxtCel;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox txtNo_Casa;
        private System.Windows.Forms.Label lblNCasa;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}