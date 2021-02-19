namespace HosCovPro
{
    partial class frmAgendarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendarCita));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.mthSelecioneUnaFecha = new System.Windows.Forms.MonthCalendar();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblSintomas = new System.Windows.Forms.Label();
            this.chcSintomas = new System.Windows.Forms.CheckedListBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.prgEnviado = new System.Windows.Forms.ProgressBar();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(381, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(622, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agende Su cita en Línea o de manera presencial";
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(3, 11);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(207, 87);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 6;
            this.pctLogo.TabStop = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(644, 128);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(343, 35);
            this.txtApellidos.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(644, 68);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 35);
            this.txtNombre.TabIndex = 12;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(499, 122);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(114, 31);
            this.lblApellidos.TabIndex = 11;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(499, 68);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 31);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // mthSelecioneUnaFecha
            // 
            this.mthSelecioneUnaFecha.Location = new System.Drawing.Point(3, 164);
            this.mthSelecioneUnaFecha.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mthSelecioneUnaFecha.Name = "mthSelecioneUnaFecha";
            this.mthSelecioneUnaFecha.TabIndex = 25;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(36, 122);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(246, 31);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Seleccione una fecha";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(499, 191);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(235, 31);
            this.lblNum.TabIndex = 27;
            this.lblNum.Text = "Número de Teléfono";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(761, 191);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(225, 35);
            this.txtNum.TabIndex = 28;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(499, 254);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(117, 31);
            this.lblDireccion.TabIndex = 29;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(644, 254);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(343, 35);
            this.txtDireccion.TabIndex = 30;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(499, 319);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 31);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(644, 319);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 35);
            this.txtEmail.TabIndex = 32;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemenino.Location = new System.Drawing.Point(748, 378);
            this.rdbFemenino.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(123, 30);
            this.rdbFemenino.TabIndex = 35;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.Location = new System.Drawing.Point(603, 377);
            this.rdbMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(127, 30);
            this.rdbMasculino.TabIndex = 34;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(492, 377);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(93, 31);
            this.lblGenero.TabIndex = 33;
            this.lblGenero.Text = "Género";
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintomas.Location = new System.Drawing.Point(492, 422);
            this.lblSintomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(116, 31);
            this.lblSintomas.TabIndex = 36;
            this.lblSintomas.Text = "Síntomas";
            // 
            // chcSintomas
            // 
            this.chcSintomas.BackColor = System.Drawing.Color.LightBlue;
            this.chcSintomas.FormattingEnabled = true;
            this.chcSintomas.Items.AddRange(new object[] {
            "Fiebre",
            "Tos seca",
            "Cansancio",
            "Molestias y dolores",
            "Dolor de garganta",
            "Diarrea",
            "Conjuntivitis",
            "Dolor de cabeza",
            "Pérdida del sentido del olfato o del gusto",
            "Erupciones cutáneas o pérdida del color en los dedos de las manos o de los pies",
            "Dificultad para respirar o sensación de falta de aire",
            "Dolor o presión en el pecho",
            "Incapacidad para hablar o moverse"});
            this.chcSintomas.Location = new System.Drawing.Point(644, 422);
            this.chcSintomas.Margin = new System.Windows.Forms.Padding(4);
            this.chcSintomas.Name = "chcSintomas";
            this.chcSintomas.Size = new System.Drawing.Size(343, 106);
            this.chcSintomas.TabIndex = 37;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(16, 378);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(239, 31);
            this.lblHora.TabIndex = 38;
            this.lblHora.Text = "Seleccione una Hora";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "7:00",
            "7:50",
            "8:40",
            "9:30",
            "11:20",
            "12:10",
            "13:00",
            "15:00",
            "15:50",
            "16:40",
            "18:30",
            "19:20"});
            this.comboBox1.Location = new System.Drawing.Point(284, 382);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 24);
            this.comboBox1.TabIndex = 39;
            // 
            // prgEnviado
            // 
            this.prgEnviado.Location = new System.Drawing.Point(43, 478);
            this.prgEnviado.Margin = new System.Windows.Forms.Padding(4);
            this.prgEnviado.Name = "prgEnviado";
            this.prgEnviado.Size = new System.Drawing.Size(185, 38);
            this.prgEnviado.TabIndex = 41;
            this.prgEnviado.Value = 23;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(253, 478);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(125, 38);
            this.btnEnviar.TabIndex = 40;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // frmAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.prgEnviado);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.chcSintomas);
            this.Controls.Add(this.lblSintomas);
            this.Controls.Add(this.rdbFemenino);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.mthSelecioneUnaFecha);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAgendarCita";
            this.Text = "Agendar Cita";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MonthCalendar mthSelecioneUnaFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblSintomas;
        private System.Windows.Forms.CheckedListBox chcSintomas;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar prgEnviado;
        private System.Windows.Forms.Button btnEnviar;
    }
}