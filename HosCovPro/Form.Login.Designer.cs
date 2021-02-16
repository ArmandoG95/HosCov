namespace HosCovPro
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.bttPaciente = new System.Windows.Forms.Button();
            this.bttPersonalMD = new System.Windows.Forms.Button();
            this.bttCrearNuevoPerfil = new System.Windows.Forms.Button();
            this.lblIdentificate = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.bttExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bttPaciente
            // 
            this.bttPaciente.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPaciente.Location = new System.Drawing.Point(601, 325);
            this.bttPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.bttPaciente.Name = "bttPaciente";
            this.bttPaciente.Size = new System.Drawing.Size(157, 53);
            this.bttPaciente.TabIndex = 0;
            this.bttPaciente.Text = "Paciente";
            this.bttPaciente.UseVisualStyleBackColor = true;
            this.bttPaciente.Click += new System.EventHandler(this.bttPaciente_Click);
            // 
            // bttPersonalMD
            // 
            this.bttPersonalMD.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPersonalMD.Location = new System.Drawing.Point(298, 325);
            this.bttPersonalMD.Margin = new System.Windows.Forms.Padding(4);
            this.bttPersonalMD.Name = "bttPersonalMD";
            this.bttPersonalMD.Size = new System.Drawing.Size(157, 53);
            this.bttPersonalMD.TabIndex = 1;
            this.bttPersonalMD.Text = "Personal Médico";
            this.bttPersonalMD.UseVisualStyleBackColor = true;
            // 
            // bttCrearNuevoPerfil
            // 
            this.bttCrearNuevoPerfil.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCrearNuevoPerfil.Location = new System.Drawing.Point(447, 426);
            this.bttCrearNuevoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.bttCrearNuevoPerfil.Name = "bttCrearNuevoPerfil";
            this.bttCrearNuevoPerfil.Size = new System.Drawing.Size(157, 53);
            this.bttCrearNuevoPerfil.TabIndex = 2;
            this.bttCrearNuevoPerfil.Text = "Crear nuevo perfil";
            this.bttCrearNuevoPerfil.UseVisualStyleBackColor = true;
            // 
            // lblIdentificate
            // 
            this.lblIdentificate.AutoSize = true;
            this.lblIdentificate.Font = new System.Drawing.Font("Palatino Linotype", 25F);
            this.lblIdentificate.Location = new System.Drawing.Point(415, 169);
            this.lblIdentificate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificate.Name = "lblIdentificate";
            this.lblIdentificate.Size = new System.Drawing.Size(236, 56);
            this.lblIdentificate.TabIndex = 3;
            this.lblIdentificate.Text = "Identifícate";
            this.lblIdentificate.Click += new System.EventHandler(this.lblIdentificate_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(16, 17);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(260, 125);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 4;
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bttExit
            // 
            this.bttExit.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttExit.Location = new System.Drawing.Point(897, 557);
            this.bttExit.Margin = new System.Windows.Forms.Padding(4);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(157, 53);
            this.bttExit.TabIndex = 5;
            this.bttExit.Text = "Exit";
            this.bttExit.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.lblIdentificate);
            this.Controls.Add(this.bttCrearNuevoPerfil);
            this.Controls.Add(this.bttPersonalMD);
            this.Controls.Add(this.bttPaciente);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttPaciente;
        private System.Windows.Forms.Button bttPersonalMD;
        private System.Windows.Forms.Button bttCrearNuevoPerfil;
        private System.Windows.Forms.Label lblIdentificate;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button bttExit;
    }
}

