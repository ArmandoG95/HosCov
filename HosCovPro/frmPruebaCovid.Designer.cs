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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
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
            this.lblTitulo.Location = new System.Drawing.Point(127, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(281, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Solicitud para prueba Covid";
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(536, 4);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(260, 125);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 5;
            this.pctLogo.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 25);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(12, 104);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(93, 25);
            this.lblApellidos.TabIndex = 7;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(121, 60);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(258, 29);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(121, 109);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(258, 29);
            this.txtApellidos.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(589, 143);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(199, 25);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha de Nacimiento";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(12, 159);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(57, 25);
            this.lblEdad.TabIndex = 14;
            this.lblEdad.Text = "Edad";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.Location = new System.Drawing.Point(95, 215);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(103, 25);
            this.rdbMasculino.TabIndex = 17;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemenino.Location = new System.Drawing.Point(204, 216);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(100, 25);
            this.rdbFemenino.TabIndex = 18;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(12, 215);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(77, 25);
            this.lblGenero.TabIndex = 16;
            this.lblGenero.Text = "Género";
            // 
            // lblEmbarazo
            // 
            this.lblEmbarazo.AutoSize = true;
            this.lblEmbarazo.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmbarazo.Location = new System.Drawing.Point(12, 255);
            this.lblEmbarazo.Name = "lblEmbarazo";
            this.lblEmbarazo.Size = new System.Drawing.Size(100, 25);
            this.lblEmbarazo.TabIndex = 19;
            this.lblEmbarazo.Text = "Embarazo";
            // 
            // chcSi
            // 
            this.chcSi.AutoSize = true;
            this.chcSi.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcSi.Location = new System.Drawing.Point(118, 257);
            this.chcSi.Name = "chcSi";
            this.chcSi.Size = new System.Drawing.Size(43, 25);
            this.chcSi.TabIndex = 20;
            this.chcSi.Text = "Si";
            this.chcSi.UseVisualStyleBackColor = true;
            // 
            // chcNo
            // 
            this.chcNo.AutoSize = true;
            this.chcNo.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcNo.Location = new System.Drawing.Point(182, 255);
            this.chcNo.Name = "chcNo";
            this.chcNo.Size = new System.Drawing.Size(56, 29);
            this.chcNo.TabIndex = 21;
            this.chcNo.Text = "No";
            this.chcNo.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(694, 407);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(94, 31);
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
            this.cmbEdad.Location = new System.Drawing.Point(121, 159);
            this.cmbEdad.Name = "cmbEdad";
            this.cmbEdad.Size = new System.Drawing.Size(89, 29);
            this.cmbEdad.TabIndex = 23;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(536, 173);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            // 
            // prgEnviado
            // 
            this.prgEnviado.Location = new System.Drawing.Point(536, 407);
            this.prgEnviado.Name = "prgEnviado";
            this.prgEnviado.Size = new System.Drawing.Size(139, 31);
            this.prgEnviado.TabIndex = 25;
            this.prgEnviado.Value = 12;
            this.prgEnviado.Click += new System.EventHandler(this.prgEnviado_Click);
            // 
            // lblEnfermedades
            // 
            this.lblEnfermedades.AutoSize = true;
            this.lblEnfermedades.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermedades.Location = new System.Drawing.Point(14, 302);
            this.lblEnfermedades.Name = "lblEnfermedades";
            this.lblEnfermedades.Size = new System.Drawing.Size(141, 25);
            this.lblEnfermedades.TabIndex = 26;
            this.lblEnfermedades.Text = "Enfermedades";
            // 
            // lstEnfermedades
            // 
            this.lstEnfermedades.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEnfermedades.FormattingEnabled = true;
            this.lstEnfermedades.ItemHeight = 21;
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
            this.lstEnfermedades.Location = new System.Drawing.Point(162, 302);
            this.lstEnfermedades.Name = "lstEnfermedades";
            this.lstEnfermedades.Size = new System.Drawing.Size(120, 67);
            this.lstEnfermedades.TabIndex = 27;
            // 
            // frmPruebaCovid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstEnfermedades);
            this.Controls.Add(this.lblEnfermedades);
            this.Controls.Add(this.prgEnviado);
            this.Controls.Add(this.monthCalendar1);
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ProgressBar prgEnviado;
        private System.Windows.Forms.Label lblEnfermedades;
        private System.Windows.Forms.ListBox lstEnfermedades;
    }
}