namespace HosCovPro
{
    partial class FrmRegVacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegVacuna));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.lblCurp = new System.Windows.Forms.Label();
            this.txtFechaDeNacimiento = new System.Windows.Forms.TextBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lstDatosDeContacto = new System.Windows.Forms.ListBox();
            this.grpDatosDeContacto = new System.Windows.Forms.GroupBox();
            this.btnConfirmaTuCorreoElectronico = new System.Windows.Forms.Button();
            this.btnTelefonoFijo = new System.Windows.Forms.Button();
            this.btnCorreoElectronico = new System.Windows.Forms.Button();
            this.btnNumTelefono = new System.Windows.Forms.Button();
            this.txtConfirmaTuCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtTelefonoFijo = new System.Windows.Forms.TextBox();
            this.lblConfirmaTuCorreoElectronico = new System.Windows.Forms.Label();
            this.txtNumCelular = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblNumCelular = new System.Windows.Forms.Label();
            this.lblTelefonoFijo = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.grpCondiciones = new System.Windows.Forms.GroupBox();
            this.txtEspecifiqueCuales = new System.Windows.Forms.TextBox();
            this.lblEspecifiqueCuales = new System.Windows.Forms.Label();
            this.chcSi = new System.Windows.Forms.CheckBox();
            this.chcNo = new System.Windows.Forms.CheckBox();
            this.lblCondiciones = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grpDatosPersonales.SuspendLayout();
            this.grpDatosDeContacto.SuspendLayout();
            this.grpCondiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(313, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(984, 38);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Bienvenido al registro para la vacuna de covid del hospital HosCov";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.comboBox1);
            this.grpDatosPersonales.Controls.Add(this.lblNacionalidad);
            this.grpDatosPersonales.Controls.Add(this.txtCurp);
            this.grpDatosPersonales.Controls.Add(this.lblCurp);
            this.grpDatosPersonales.Controls.Add(this.txtFechaDeNacimiento);
            this.grpDatosPersonales.Controls.Add(this.txtApMaterno);
            this.grpDatosPersonales.Controls.Add(this.txtApPaterno);
            this.grpDatosPersonales.Controls.Add(this.lblApMaterno);
            this.grpDatosPersonales.Controls.Add(this.rdbMasculino);
            this.grpDatosPersonales.Controls.Add(this.lblApPaterno);
            this.grpDatosPersonales.Controls.Add(this.rdbFemenino);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblFechaDeNacimiento);
            this.grpDatosPersonales.Controls.Add(this.lblSexo);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(16, 179);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(419, 463);
            this.grpDatosPersonales.TabIndex = 3;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Coahuila de Zaragoza",
            "Colima",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacán de Ocampo",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz de Ignacio de la Llave",
            "Yucatán",
            "Zacatecas"});
            this.comboBox1.Location = new System.Drawing.Point(22, 330);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(388, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(19, 310);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(56, 17);
            this.lblNacionalidad.TabIndex = 14;
            this.lblNacionalidad.Text = "Estado:";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(22, 271);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(388, 22);
            this.txtCurp.TabIndex = 12;
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Location = new System.Drawing.Point(19, 251);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(42, 17);
            this.lblCurp.TabIndex = 13;
            this.lblCurp.Text = "Curp:";
            // 
            // txtFechaDeNacimiento
            // 
            this.txtFechaDeNacimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFechaDeNacimiento.Location = new System.Drawing.Point(22, 215);
            this.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento";
            this.txtFechaDeNacimiento.Size = new System.Drawing.Size(388, 22);
            this.txtFechaDeNacimiento.TabIndex = 12;
            this.txtFechaDeNacimiento.Text = "dd/mm/aaaa";
            this.txtFechaDeNacimiento.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(22, 160);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(388, 22);
            this.txtApMaterno.TabIndex = 10;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(22, 103);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(388, 22);
            this.txtApPaterno.TabIndex = 9;
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Location = new System.Drawing.Point(19, 140);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(118, 17);
            this.lblApMaterno.TabIndex = 6;
            this.lblApMaterno.Text = "Apellido Materno:";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(25, 401);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(92, 21);
            this.rdbMasculino.TabIndex = 8;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Location = new System.Drawing.Point(19, 83);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(116, 17);
            this.lblApPaterno.TabIndex = 7;
            this.lblApPaterno.Text = "Apellido Paterno:";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(25, 428);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(91, 21);
            this.rdbFemenino.TabIndex = 7;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(388, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(19, 195);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(139, 17);
            this.lblFechaDeNacimiento.TabIndex = 4;
            this.lblFechaDeNacimiento.Text = "Fecha de nacimiento";
            this.lblFechaDeNacimiento.Click += new System.EventHandler(this.lblFechaDeNacimiento_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(22, 381);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 17);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1451, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(1336, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(98, 17);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de hoy:";
            // 
            // lstDatosDeContacto
            // 
            this.lstDatosDeContacto.AccessibleName = "Datos de contacto";
            this.lstDatosDeContacto.FormattingEnabled = true;
            this.lstDatosDeContacto.ItemHeight = 16;
            this.lstDatosDeContacto.Location = new System.Drawing.Point(453, 49);
            this.lstDatosDeContacto.Name = "lstDatosDeContacto";
            this.lstDatosDeContacto.Size = new System.Drawing.Size(247, 180);
            this.lstDatosDeContacto.TabIndex = 12;
            this.lstDatosDeContacto.SelectedIndexChanged += new System.EventHandler(this.lstDatosDeContacto_SelectedIndexChanged);
            // 
            // grpDatosDeContacto
            // 
            this.grpDatosDeContacto.Controls.Add(this.btnConfirmaTuCorreoElectronico);
            this.grpDatosDeContacto.Controls.Add(this.btnTelefonoFijo);
            this.grpDatosDeContacto.Controls.Add(this.btnCorreoElectronico);
            this.grpDatosDeContacto.Controls.Add(this.btnNumTelefono);
            this.grpDatosDeContacto.Controls.Add(this.txtConfirmaTuCorreoElectronico);
            this.grpDatosDeContacto.Controls.Add(this.lstDatosDeContacto);
            this.grpDatosDeContacto.Controls.Add(this.txtTelefonoFijo);
            this.grpDatosDeContacto.Controls.Add(this.lblConfirmaTuCorreoElectronico);
            this.grpDatosDeContacto.Controls.Add(this.txtNumCelular);
            this.grpDatosDeContacto.Controls.Add(this.txtCorreoElectronico);
            this.grpDatosDeContacto.Controls.Add(this.lblNumCelular);
            this.grpDatosDeContacto.Controls.Add(this.lblTelefonoFijo);
            this.grpDatosDeContacto.Controls.Add(this.lblCorreoElectronico);
            this.grpDatosDeContacto.Location = new System.Drawing.Point(478, 179);
            this.grpDatosDeContacto.Name = "grpDatosDeContacto";
            this.grpDatosDeContacto.Size = new System.Drawing.Size(717, 463);
            this.grpDatosDeContacto.TabIndex = 13;
            this.grpDatosDeContacto.TabStop = false;
            this.grpDatosDeContacto.Text = "Datos de Contacto";
            this.grpDatosDeContacto.Enter += new System.EventHandler(this.grpDatosDeContacto_Enter);
            // 
            // btnConfirmaTuCorreoElectronico
            // 
            this.btnConfirmaTuCorreoElectronico.Location = new System.Drawing.Point(322, 360);
            this.btnConfirmaTuCorreoElectronico.Name = "btnConfirmaTuCorreoElectronico";
            this.btnConfirmaTuCorreoElectronico.Size = new System.Drawing.Size(75, 29);
            this.btnConfirmaTuCorreoElectronico.TabIndex = 27;
            this.btnConfirmaTuCorreoElectronico.Text = "Agregar";
            this.btnConfirmaTuCorreoElectronico.UseVisualStyleBackColor = true;
            this.btnConfirmaTuCorreoElectronico.Click += new System.EventHandler(this.btnConfirmaTuCorreoElectronico_Click);
            // 
            // btnTelefonoFijo
            // 
            this.btnTelefonoFijo.Location = new System.Drawing.Point(319, 168);
            this.btnTelefonoFijo.Name = "btnTelefonoFijo";
            this.btnTelefonoFijo.Size = new System.Drawing.Size(75, 29);
            this.btnTelefonoFijo.TabIndex = 26;
            this.btnTelefonoFijo.Text = "Agregar";
            this.btnTelefonoFijo.UseVisualStyleBackColor = true;
            this.btnTelefonoFijo.Click += new System.EventHandler(this.btnTelefonoFijo_Click);
            // 
            // btnCorreoElectronico
            // 
            this.btnCorreoElectronico.Location = new System.Drawing.Point(319, 260);
            this.btnCorreoElectronico.Name = "btnCorreoElectronico";
            this.btnCorreoElectronico.Size = new System.Drawing.Size(75, 29);
            this.btnCorreoElectronico.TabIndex = 25;
            this.btnCorreoElectronico.Text = "Agregar";
            this.btnCorreoElectronico.UseVisualStyleBackColor = true;
            this.btnCorreoElectronico.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNumTelefono
            // 
            this.btnNumTelefono.Location = new System.Drawing.Point(319, 77);
            this.btnNumTelefono.Name = "btnNumTelefono";
            this.btnNumTelefono.Size = new System.Drawing.Size(75, 29);
            this.btnNumTelefono.TabIndex = 24;
            this.btnNumTelefono.Text = "Agregar";
            this.btnNumTelefono.UseVisualStyleBackColor = true;
            this.btnNumTelefono.Click += new System.EventHandler(this.btnNumTelefono_Click);
            // 
            // txtConfirmaTuCorreoElectronico
            // 
            this.txtConfirmaTuCorreoElectronico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConfirmaTuCorreoElectronico.Location = new System.Drawing.Point(9, 332);
            this.txtConfirmaTuCorreoElectronico.Name = "txtConfirmaTuCorreoElectronico";
            this.txtConfirmaTuCorreoElectronico.Size = new System.Drawing.Size(388, 22);
            this.txtConfirmaTuCorreoElectronico.TabIndex = 23;
            this.txtConfirmaTuCorreoElectronico.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // txtTelefonoFijo
            // 
            this.txtTelefonoFijo.Location = new System.Drawing.Point(9, 140);
            this.txtTelefonoFijo.Name = "txtTelefonoFijo";
            this.txtTelefonoFijo.Size = new System.Drawing.Size(388, 22);
            this.txtTelefonoFijo.TabIndex = 22;
            this.txtTelefonoFijo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblConfirmaTuCorreoElectronico
            // 
            this.lblConfirmaTuCorreoElectronico.AccessibleDescription = "Confirmación de correo electronico:";
            this.lblConfirmaTuCorreoElectronico.AutoSize = true;
            this.lblConfirmaTuCorreoElectronico.Location = new System.Drawing.Point(6, 310);
            this.lblConfirmaTuCorreoElectronico.Name = "lblConfirmaTuCorreoElectronico";
            this.lblConfirmaTuCorreoElectronico.Size = new System.Drawing.Size(202, 17);
            this.lblConfirmaTuCorreoElectronico.TabIndex = 18;
            this.lblConfirmaTuCorreoElectronico.Text = "Confirma tu correo electronico:";
            this.lblConfirmaTuCorreoElectronico.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNumCelular
            // 
            this.txtNumCelular.Location = new System.Drawing.Point(6, 49);
            this.txtNumCelular.Name = "txtNumCelular";
            this.txtNumCelular.Size = new System.Drawing.Size(388, 22);
            this.txtNumCelular.TabIndex = 17;
            this.txtNumCelular.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(9, 232);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(388, 22);
            this.txtCorreoElectronico.TabIndex = 21;
            this.txtCorreoElectronico.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblNumCelular
            // 
            this.lblNumCelular.AutoSize = true;
            this.lblNumCelular.Location = new System.Drawing.Point(3, 29);
            this.lblNumCelular.Name = "lblNumCelular";
            this.lblNumCelular.Size = new System.Drawing.Size(128, 17);
            this.lblNumCelular.TabIndex = 16;
            this.lblNumCelular.Text = "Numero de celular:";
            this.lblNumCelular.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTelefonoFijo
            // 
            this.lblTelefonoFijo.AutoSize = true;
            this.lblTelefonoFijo.Location = new System.Drawing.Point(3, 120);
            this.lblTelefonoFijo.Name = "lblTelefonoFijo";
            this.lblTelefonoFijo.Size = new System.Drawing.Size(98, 17);
            this.lblTelefonoFijo.TabIndex = 19;
            this.lblTelefonoFijo.Text = "Telefono Fijo: ";
            this.lblTelefonoFijo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(6, 212);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(132, 17);
            this.lblCorreoElectronico.TabIndex = 20;
            this.lblCorreoElectronico.Text = "Correo electronico: ";
            this.lblCorreoElectronico.Click += new System.EventHandler(this.label2_Click);
            // 
            // grpCondiciones
            // 
            this.grpCondiciones.Controls.Add(this.txtEspecifiqueCuales);
            this.grpCondiciones.Controls.Add(this.lblEspecifiqueCuales);
            this.grpCondiciones.Controls.Add(this.chcSi);
            this.grpCondiciones.Controls.Add(this.chcNo);
            this.grpCondiciones.Controls.Add(this.lblCondiciones);
            this.grpCondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCondiciones.Location = new System.Drawing.Point(1230, 179);
            this.grpCondiciones.Name = "grpCondiciones";
            this.grpCondiciones.Size = new System.Drawing.Size(540, 463);
            this.grpCondiciones.TabIndex = 28;
            this.grpCondiciones.TabStop = false;
            this.grpCondiciones.Text = "¿Usted presenta alguna de las siguientes condiciones?";
            // 
            // txtEspecifiqueCuales
            // 
            this.txtEspecifiqueCuales.Location = new System.Drawing.Point(19, 306);
            this.txtEspecifiqueCuales.Name = "txtEspecifiqueCuales";
            this.txtEspecifiqueCuales.Size = new System.Drawing.Size(515, 27);
            this.txtEspecifiqueCuales.TabIndex = 28;
            // 
            // lblEspecifiqueCuales
            // 
            this.lblEspecifiqueCuales.AutoSize = true;
            this.lblEspecifiqueCuales.Location = new System.Drawing.Point(20, 283);
            this.lblEspecifiqueCuales.Name = "lblEspecifiqueCuales";
            this.lblEspecifiqueCuales.Size = new System.Drawing.Size(160, 20);
            this.lblEspecifiqueCuales.TabIndex = 28;
            this.lblEspecifiqueCuales.Text = "Especifique cuales: ";
            // 
            // chcSi
            // 
            this.chcSi.AutoSize = true;
            this.chcSi.Location = new System.Drawing.Point(53, 241);
            this.chcSi.Name = "chcSi";
            this.chcSi.Size = new System.Drawing.Size(46, 24);
            this.chcSi.TabIndex = 30;
            this.chcSi.Text = "SI";
            this.chcSi.UseVisualStyleBackColor = true;
            this.chcSi.CheckedChanged += new System.EventHandler(this.chkSi_CheckedChanged);
            // 
            // chcNo
            // 
            this.chcNo.AutoSize = true;
            this.chcNo.Location = new System.Drawing.Point(158, 241);
            this.chcNo.Name = "chcNo";
            this.chcNo.Size = new System.Drawing.Size(56, 24);
            this.chcNo.TabIndex = 29;
            this.chcNo.Text = "NO";
            this.chcNo.UseVisualStyleBackColor = true;
            this.chcNo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblCondiciones
            // 
            this.lblCondiciones.AutoSize = true;
            this.lblCondiciones.Location = new System.Drawing.Point(19, 46);
            this.lblCondiciones.Name = "lblCondiciones";
            this.lblCondiciones.Size = new System.Drawing.Size(388, 160);
            this.lblCondiciones.TabIndex = 28;
            this.lblCondiciones.Text = resources.GetString("lblCondiciones.Text");
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(1643, 679);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(141, 64);
            this.btnEnviar.TabIndex = 16;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::HosCovPro.Properties.Resources.WhatsApp_Image_2021_02_12_at_12_46_15_PM;
            this.pctLogo.Location = new System.Drawing.Point(16, 17);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(291, 135);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(41, 679);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(141, 64);
            this.btnRegresar.TabIndex = 29;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmRegVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1837, 870);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.grpCondiciones);
            this.Controls.Add(this.grpDatosDeContacto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.grpDatosPersonales);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FrmRegVacuna";
            this.Text = "Registro Vacuna COVID.";
            this.Load += new System.EventHandler(this.FrmRegVacuna_Load);
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpDatosDeContacto.ResumeLayout(false);
            this.grpDatosDeContacto.PerformLayout();
            this.grpCondiciones.ResumeLayout(false);
            this.grpCondiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.ListBox lstDatosDeContacto;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.GroupBox grpDatosDeContacto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtConfirmaTuCorreoElectronico;
        private System.Windows.Forms.TextBox txtTelefonoFijo;
        private System.Windows.Forms.TextBox txtNumCelular;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblTelefonoFijo;
        private System.Windows.Forms.Label lblConfirmaTuCorreoElectronico;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Button btnNumTelefono;
        private System.Windows.Forms.Button btnCorreoElectronico;
        private System.Windows.Forms.Button btnTelefonoFijo;
        private System.Windows.Forms.Label lblNumCelular;
        private System.Windows.Forms.Button btnConfirmaTuCorreoElectronico;
        private System.Windows.Forms.TextBox txtFechaDeNacimiento;
        private System.Windows.Forms.GroupBox grpCondiciones;
        private System.Windows.Forms.CheckBox chcSi;
        private System.Windows.Forms.CheckBox chcNo;
        private System.Windows.Forms.Label lblCondiciones;
        private System.Windows.Forms.TextBox txtEspecifiqueCuales;
        private System.Windows.Forms.Label lblEspecifiqueCuales;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnRegresar;
    }
}