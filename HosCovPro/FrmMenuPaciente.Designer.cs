namespace HosCovPro
{
    partial class FrmMenuPaciente
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
            this.btnExpediente = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnRegistroVacuna = new System.Windows.Forms.Button();
            this.lblSolicitar = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::HosCovPro.Properties.Resources.WhatsApp_Image_2021_02_12_at_12_46_15_PM;
            this.pctLogo.Location = new System.Drawing.Point(16, 17);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(260, 125);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 7;
            this.pctLogo.TabStop = false;
            // 
            // btnExpediente
            // 
            this.btnExpediente.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpediente.Location = new System.Drawing.Point(440, 165);
            this.btnExpediente.Name = "btnExpediente";
            this.btnExpediente.Size = new System.Drawing.Size(215, 34);
            this.btnExpediente.TabIndex = 8;
            this.btnExpediente.Text = "Mi Expediente";
            this.btnExpediente.UseVisualStyleBackColor = true;
            this.btnExpediente.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(394, 114);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(309, 41);
            this.lblMenu.TabIndex = 9;
            this.lblMenu.Text = "¿Qué desea consultar?";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(440, 317);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(215, 34);
            this.btnConsulta.TabIndex = 11;
            this.btnConsulta.Text = "Consulta virtual/presencial";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnPrueba
            // 
            this.btnPrueba.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba.Location = new System.Drawing.Point(440, 357);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(215, 34);
            this.btnPrueba.TabIndex = 12;
            this.btnPrueba.Text = "Prueba Covid-19";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnRegistroVacuna
            // 
            this.btnRegistroVacuna.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroVacuna.Location = new System.Drawing.Point(440, 467);
            this.btnRegistroVacuna.Name = "btnRegistroVacuna";
            this.btnRegistroVacuna.Size = new System.Drawing.Size(215, 34);
            this.btnRegistroVacuna.TabIndex = 13;
            this.btnRegistroVacuna.Text = "Registro Vacuna Covid-19";
            this.btnRegistroVacuna.UseVisualStyleBackColor = true;
            this.btnRegistroVacuna.Click += new System.EventHandler(this.btnRegistroVacuna_Click);
            // 
            // lblSolicitar
            // 
            this.lblSolicitar.AutoSize = true;
            this.lblSolicitar.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitar.Location = new System.Drawing.Point(480, 257);
            this.lblSolicitar.Name = "lblSolicitar";
            this.lblSolicitar.Size = new System.Drawing.Size(133, 41);
            this.lblSolicitar.TabIndex = 14;
            this.lblSolicitar.Text = "Solicitar:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(480, 414);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(147, 41);
            this.lblRegistros.TabIndex = 15;
            this.lblRegistros.Text = "Registros:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(912, 578);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 35);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMenuPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.lblSolicitar);
            this.Controls.Add(this.btnRegistroVacuna);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnExpediente);
            this.Controls.Add(this.pctLogo);
            this.Name = "FrmMenuPaciente";
            this.Text = "FrmMenuPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnExpediente;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button btnRegistroVacuna;
        private System.Windows.Forms.Label lblSolicitar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnExit;
    }
}