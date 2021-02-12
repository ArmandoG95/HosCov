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
            this.bttPaciente = new System.Windows.Forms.Button();
            this.bttPersonalMD = new System.Windows.Forms.Button();
            this.bttCrearNuevoPerfil = new System.Windows.Forms.Button();
            this.lblIdentificate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttPaciente
            // 
            this.bttPaciente.Location = new System.Drawing.Point(292, 140);
            this.bttPaciente.Name = "bttPaciente";
            this.bttPaciente.Size = new System.Drawing.Size(134, 74);
            this.bttPaciente.TabIndex = 0;
            this.bttPaciente.Text = "Paciente";
            this.bttPaciente.UseVisualStyleBackColor = true;
            // 
            // bttPersonalMD
            // 
            this.bttPersonalMD.Location = new System.Drawing.Point(291, 219);
            this.bttPersonalMD.Name = "bttPersonalMD";
            this.bttPersonalMD.Size = new System.Drawing.Size(135, 74);
            this.bttPersonalMD.TabIndex = 1;
            this.bttPersonalMD.Text = "Personal MD";
            this.bttPersonalMD.UseVisualStyleBackColor = true;
            // 
            // bttCrearNuevoPerfil
            // 
            this.bttCrearNuevoPerfil.Location = new System.Drawing.Point(292, 299);
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
            this.lblIdentificate.Location = new System.Drawing.Point(204, 30);
            this.lblIdentificate.Name = "lblIdentificate";
            this.lblIdentificate.Size = new System.Drawing.Size(344, 73);
            this.lblIdentificate.TabIndex = 3;
            this.lblIdentificate.Text = "Identificate";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdentificate);
            this.Controls.Add(this.bttCrearNuevoPerfil);
            this.Controls.Add(this.bttPersonalMD);
            this.Controls.Add(this.bttPaciente);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttPaciente;
        private System.Windows.Forms.Button bttPersonalMD;
        private System.Windows.Forms.Button bttCrearNuevoPerfil;
        private System.Windows.Forms.Label lblIdentificate;
    }
}

