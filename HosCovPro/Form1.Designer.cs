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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttPaciente
            // 
            this.bttPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPaciente.Location = new System.Drawing.Point(182, 219);
            this.bttPaciente.Name = "bttPaciente";
            this.bttPaciente.Size = new System.Drawing.Size(134, 74);
            this.bttPaciente.TabIndex = 0;
            this.bttPaciente.Text = "Paciente";
            this.bttPaciente.UseVisualStyleBackColor = true;
            // 
            // bttPersonalMD
            // 
            this.bttPersonalMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPersonalMD.Location = new System.Drawing.Point(437, 219);
            this.bttPersonalMD.Name = "bttPersonalMD";
            this.bttPersonalMD.Size = new System.Drawing.Size(135, 74);
            this.bttPersonalMD.TabIndex = 1;
            this.bttPersonalMD.Text = "Personal MD";
            this.bttPersonalMD.UseVisualStyleBackColor = true;
            // 
            // bttCrearNuevoPerfil
            // 
            this.bttCrearNuevoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCrearNuevoPerfil.Location = new System.Drawing.Point(312, 310);
            this.bttCrearNuevoPerfil.Name = "bttCrearNuevoPerfil";
            this.bttCrearNuevoPerfil.Size = new System.Drawing.Size(135, 75);
            this.bttCrearNuevoPerfil.TabIndex = 2;
            this.bttCrearNuevoPerfil.Text = "Crear nuevo perfil";
            this.bttCrearNuevoPerfil.UseVisualStyleBackColor = true;
            // 
            // lblIdentificate
            // 
            this.lblIdentificate.AutoSize = true;
            this.lblIdentificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificate.Location = new System.Drawing.Point(212, 30);
            this.lblIdentificate.Name = "lblIdentificate";
            this.lblIdentificate.Size = new System.Drawing.Size(344, 73);
            this.lblIdentificate.TabIndex = 3;
            this.lblIdentificate.Text = "Identifícate";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bttExit
            // 
            this.bttExit.Location = new System.Drawing.Point(647, 395);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(101, 32);
            this.bttExit.TabIndex = 5;
            this.bttExit.Text = "Exit";
            this.bttExit.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIdentificate);
            this.Controls.Add(this.bttCrearNuevoPerfil);
            this.Controls.Add(this.bttPersonalMD);
            this.Controls.Add(this.bttPaciente);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttPaciente;
        private System.Windows.Forms.Button bttPersonalMD;
        private System.Windows.Forms.Button bttCrearNuevoPerfil;
        private System.Windows.Forms.Label lblIdentificate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttExit;
    }
}

