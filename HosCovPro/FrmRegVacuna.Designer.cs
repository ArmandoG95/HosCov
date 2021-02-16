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
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFechaDeNacimiento = new System.Windows.Forms.TextBox();
            this.lblCurp = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.lstDatosDeContacto = new System.Windows.Forms.ListBox();
            this.grpDatosDeContacto = new System.Windows.Forms.GroupBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumTelefono = new System.Windows.Forms.Label();
            this.btnNumTelefono = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.grpDatosPersonales.SuspendLayout();
            this.grpDatosDeContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::HosCovPro.Properties.Resources.WhatsApp_Image_2021_02_12_at_12_46_15_PM;
            this.pctLogo.Location = new System.Drawing.Point(16, 17);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(260, 125);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(294, 17);
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
            this.grpDatosPersonales.Size = new System.Drawing.Size(419, 520);
            this.grpDatosPersonales.TabIndex = 3;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(448, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(388, 22);
            this.dateTimePicker1.TabIndex = 6;
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
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Location = new System.Drawing.Point(19, 140);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(118, 17);
            this.lblApMaterno.TabIndex = 6;
            this.lblApMaterno.Text = "Apellido Materno:";
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
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(22, 103);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(388, 22);
            this.txtApPaterno.TabIndex = 9;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(22, 160);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(388, 22);
            this.txtApMaterno.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(298, 63);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(98, 17);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de hoy:";
            // 
            // txtFechaDeNacimiento
            // 
            this.txtFechaDeNacimiento.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFechaDeNacimiento.Location = new System.Drawing.Point(22, 215);
            this.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento";
            this.txtFechaDeNacimiento.Size = new System.Drawing.Size(388, 22);
            this.txtFechaDeNacimiento.TabIndex = 12;
            this.txtFechaDeNacimiento.Text = "dd/mm/aaaa";
            this.txtFechaDeNacimiento.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
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
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(22, 271);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(388, 22);
            this.txtCurp.TabIndex = 12;
            // 
            // lstDatosDeContacto
            // 
            this.lstDatosDeContacto.AccessibleName = "Datos de contacto";
            this.lstDatosDeContacto.FormattingEnabled = true;
            this.lstDatosDeContacto.ItemHeight = 16;
            this.lstDatosDeContacto.Location = new System.Drawing.Point(568, 49);
            this.lstDatosDeContacto.Name = "lstDatosDeContacto";
            this.lstDatosDeContacto.Size = new System.Drawing.Size(247, 180);
            this.lstDatosDeContacto.TabIndex = 12;
            // 
            // grpDatosDeContacto
            // 
            this.grpDatosDeContacto.Controls.Add(this.btnNumTelefono);
            this.grpDatosDeContacto.Controls.Add(this.textBox1);
            this.grpDatosDeContacto.Controls.Add(this.lstDatosDeContacto);
            this.grpDatosDeContacto.Controls.Add(this.textBox2);
            this.grpDatosDeContacto.Controls.Add(this.txtNumTelefono);
            this.grpDatosDeContacto.Controls.Add(this.textBox3);
            this.grpDatosDeContacto.Controls.Add(this.lblNumTelefono);
            this.grpDatosDeContacto.Controls.Add(this.label1);
            this.grpDatosDeContacto.Controls.Add(this.label3);
            this.grpDatosDeContacto.Controls.Add(this.label2);
            this.grpDatosDeContacto.Location = new System.Drawing.Point(478, 179);
            this.grpDatosDeContacto.Name = "grpDatosDeContacto";
            this.grpDatosDeContacto.Size = new System.Drawing.Size(821, 484);
            this.grpDatosDeContacto.TabIndex = 13;
            this.grpDatosDeContacto.TabStop = false;
            this.grpDatosDeContacto.Text = "Datos de Contacto";
            this.grpDatosDeContacto.Enter += new System.EventHandler(this.grpDatosDeContacto_Enter);
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
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(6, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 22);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "dd/mm/aaaa";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(388, 22);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(388, 22);
            this.textBox3.TabIndex = 21;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Apellido Materno:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Apellido Paterno:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNumTelefono
            // 
            this.txtNumTelefono.Location = new System.Drawing.Point(6, 49);
            this.txtNumTelefono.Name = "txtNumTelefono";
            this.txtNumTelefono.Size = new System.Drawing.Size(388, 22);
            this.txtNumTelefono.TabIndex = 17;
            this.txtNumTelefono.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha de nacimiento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNumTelefono
            // 
            this.lblNumTelefono.AutoSize = true;
            this.lblNumTelefono.Location = new System.Drawing.Point(3, 29);
            this.lblNumTelefono.Name = "lblNumTelefono";
            this.lblNumTelefono.Size = new System.Drawing.Size(137, 17);
            this.lblNumTelefono.TabIndex = 16;
            this.lblNumTelefono.Text = "Numero de telefono:";
            this.lblNumTelefono.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnNumTelefono
            // 
            this.btnNumTelefono.Location = new System.Drawing.Point(319, 80);
            this.btnNumTelefono.Name = "btnNumTelefono";
            this.btnNumTelefono.Size = new System.Drawing.Size(75, 23);
            this.btnNumTelefono.TabIndex = 24;
            this.btnNumTelefono.Text = "Agregar";
            this.btnNumTelefono.UseVisualStyleBackColor = true;
            this.btnNumTelefono.Click += new System.EventHandler(this.btnNumTelefono_Click);
            // 
            // FrmRegVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1332, 891);
            this.Controls.Add(this.grpDatosDeContacto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.grpDatosPersonales);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FrmRegVacuna";
            this.Text = "FrmRegVacuna";
            this.Load += new System.EventHandler(this.FrmRegVacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpDatosDeContacto.ResumeLayout(false);
            this.grpDatosDeContacto.PerformLayout();
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
        private System.Windows.Forms.TextBox txtFechaDeNacimiento;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.ListBox lstDatosDeContacto;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.GroupBox grpDatosDeContacto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtNumTelefono;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblNumTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNumTelefono;
    }
}