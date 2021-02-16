namespace HosCovPro
{
    partial class frmInformaciónEnviada
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
            this.lblInformaciónGuardada = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::HosCovPro.Properties.Resources.WhatsApp_Image_2021_02_12_at_12_46_15_PM;
            this.pctLogo.Location = new System.Drawing.Point(12, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(163, 72);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            // 
            // lblInformaciónGuardada
            // 
            this.lblInformaciónGuardada.AutoSize = true;
            this.lblInformaciónGuardada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformaciónGuardada.Location = new System.Drawing.Point(216, 12);
            this.lblInformaciónGuardada.Name = "lblInformaciónGuardada";
            this.lblInformaciónGuardada.Size = new System.Drawing.Size(270, 100);
            this.lblInformaciónGuardada.TabIndex = 2;
            this.lblInformaciónGuardada.Text = "La información ha sido \r\nguardada en nuestra base \r\nde datos, espere a que lo \r\nc" +
    "ontactemos.";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(439, 155);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmInformaciónEnviada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(560, 208);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblInformaciónGuardada);
            this.Controls.Add(this.pctLogo);
            this.Name = "frmInformaciónEnviada";
            this.Text = "frmInformaciónEnviada";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblInformaciónGuardada;
        private System.Windows.Forms.Button btnCerrar;
    }
}