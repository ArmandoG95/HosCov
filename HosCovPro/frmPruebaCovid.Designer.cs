namespace HosCovPro
{
    partial class frmPruebaCovid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPruebaCovid));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEmbarazo = new System.Windows.Forms.Label();
            this.chcSi = new System.Windows.Forms.CheckBox();
            this.chcNo = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cmbEdad = new System.Windows.Forms.ComboBox();
            this.mntFechaDeNacimiento = new System.Windows.Forms.MonthCalendar();
            this.prgEnviado = new System.Windows.Forms.ProgressBar();
            this.lblEnfermedades = new System.Windows.Forms.Label();
            this.lstEnfermedades = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(169, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(361, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Solicitud para prueba Covid";
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(715, 5);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(347, 154);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 5;
            this.pctLogo.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 74);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 31);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(16, 128);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(114, 31);
            this.lblApellidos.TabIndex = 7;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(161, 74);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 35);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(161, 134);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(343, 35);
            this.txtApellidos.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(785, 176);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(245, 31);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha de Nacimiento";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(16, 196);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(70, 31);
            this.lblEdad.TabIndex = 14;
            this.lblEdad.Text = "Edad";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.Location = new System.Drawing.Point(127, 265);
            this.rdbMasculino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(127, 30);
            this.rdbMasculino.TabIndex = 17;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemenino.Location = new System.Drawing.Point(272, 266);
            this.rdbFemenino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(123, 30);
            this.rdbFemenino.TabIndex = 18;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(16, 265);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(93, 31);
            this.lblGenero.TabIndex = 16;
            this.lblGenero.Text = "Género";
            // 
            // lblEmbarazo
            // 
            this.lblEmbarazo.AutoSize = true;
            this.lblEmbarazo.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmbarazo.Location = new System.Drawing.Point(16, 314);
            this.lblEmbarazo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmbarazo.Name = "lblEmbarazo";
            this.lblEmbarazo.Size = new System.Drawing.Size(123, 31);
            this.lblEmbarazo.TabIndex = 19;
            this.lblEmbarazo.Text = "Embarazo";
            // 
            // chcSi
            // 
            this.chcSi.AutoSize = true;
            this.chcSi.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcSi.Location = new System.Drawing.Point(157, 316);
            this.chcSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chcSi.Name = "chcSi";
            this.chcSi.Size = new System.Drawing.Size(52, 30);
            this.chcSi.TabIndex = 20;
            this.chcSi.Text = "Si";
            this.chcSi.UseVisualStyleBackColor = true;
            // 
            // chcNo
            // 
            this.chcNo.AutoSize = true;
            this.chcNo.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcNo.Location = new System.Drawing.Point(243, 314);
            this.chcNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chcNo.Name = "chcNo";
            this.chcNo.Size = new System.Drawing.Size(67, 35);
            this.chcNo.TabIndex = 21;
            this.chcNo.Text = "No";
            this.chcNo.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(925, 501);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(125, 38);
            this.btnEnviar.TabIndex = 22;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cmbEdad
            // 
            this.cmbEdad.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdad.FormattingEnabled = true;
            this.cmbEdad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cmbEdad.Location = new System.Drawing.Point(161, 196);
            this.cmbEdad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEdad.Name = "cmbEdad";
            this.cmbEdad.Size = new System.Drawing.Size(117, 34);
            this.cmbEdad.TabIndex = 23;
            // 
            // mntFechaDeNacimiento
            // 
            this.mntFechaDeNacimiento.Location = new System.Drawing.Point(715, 213);
            this.mntFechaDeNacimiento.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mntFechaDeNacimiento.Name = "mntFechaDeNacimiento";
            this.mntFechaDeNacimiento.TabIndex = 24;
            // 
            // prgEnviado
            // 
            this.prgEnviado.Location = new System.Drawing.Point(715, 501);
            this.prgEnviado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prgEnviado.Name = "prgEnviado";
            this.prgEnviado.Size = new System.Drawing.Size(185, 38);
            this.prgEnviado.TabIndex = 25;
            this.prgEnviado.Value = 12;
            this.prgEnviado.Click += new System.EventHandler(this.prgEnviado_Click);
            // 
            // lblEnfermedades
            // 
            this.lblEnfermedades.AutoSize = true;
            this.lblEnfermedades.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermedades.Location = new System.Drawing.Point(19, 372);
            this.lblEnfermedades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnfermedades.Name = "lblEnfermedades";
            this.lblEnfermedades.Size = new System.Drawing.Size(173, 31);
            this.lblEnfermedades.TabIndex = 26;
            this.lblEnfermedades.Text = "Enfermedades";
            // 
            // lstEnfermedades
            // 
            this.lstEnfermedades.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEnfermedades.FormattingEnabled = true;
            this.lstEnfermedades.ItemHeight = 26;
            this.lstEnfermedades.Items.AddRange(new object[] {
            "Diabetes",
            "Hipertensión",
            "Asma",
            "SIDA",
            "Alzheimer",
            "Cáncer",
            "Lupus",
            "Poliomelitis",
            "Ébola"});
            this.lstEnfermedades.Location = new System.Drawing.Point(216, 372);
            this.lstEnfermedades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEnfermedades.Name = "lstEnfermedades";
            this.lstEnfermedades.Size = new System.Drawing.Size(159, 82);
            this.lstEnfermedades.TabIndex = 27;
            // 
            // frmPruebaCovid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lstEnfermedades);
            this.Controls.Add(this.lblEnfermedades);
            this.Controls.Add(this.prgEnviado);
            this.Controls.Add(this.mntFechaDeNacimiento);
            this.Controls.Add(this.cmbEdad);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.chcNo);
            this.Controls.Add(this.chcSi);
            this.Controls.Add(this.lblEmbarazo);
            this.Controls.Add(this.rdbFemenino);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPruebaCovid";
            this.Text = "Solicitud Prueba Covid";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEmbarazo;
        private System.Windows.Forms.CheckBox chcSi;
        private System.Windows.Forms.CheckBox chcNo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cmbEdad;
        private System.Windows.Forms.MonthCalendar mntFechaDeNacimiento;
        private System.Windows.Forms.ProgressBar prgEnviado;
        private System.Windows.Forms.Label lblEnfermedades;
        private System.Windows.Forms.ListBox lstEnfermedades;
    }
}