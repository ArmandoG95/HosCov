namespace HosCovPro
{
    partial class frmBarraDeCarga
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
            this.components = new System.ComponentModel.Container();
            this.lblEnviando = new System.Windows.Forms.Label();
            this.pbrCargando = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblEnviando
            // 
            this.lblEnviando.AutoSize = true;
            this.lblEnviando.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviando.Location = new System.Drawing.Point(208, 66);
            this.lblEnviando.Name = "lblEnviando";
            this.lblEnviando.Size = new System.Drawing.Size(141, 36);
            this.lblEnviando.TabIndex = 0;
            this.lblEnviando.Text = "Enviando";
            // 
            // pbrCargando
            // 
            this.pbrCargando.Location = new System.Drawing.Point(12, 137);
            this.pbrCargando.Name = "pbrCargando";
            this.pbrCargando.Size = new System.Drawing.Size(548, 23);
            this.pbrCargando.TabIndex = 1;
            this.pbrCargando.Click += new System.EventHandler(this.pbrCargando_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBarraDeCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 261);
            this.Controls.Add(this.pbrCargando);
            this.Controls.Add(this.lblEnviando);
            this.Name = "frmBarraDeCarga";
            this.Text = "Cargando";
            this.Load += new System.EventHandler(this.frmBarraDeCarga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnviando;
        private System.Windows.Forms.ProgressBar pbrCargando;
        private System.Windows.Forms.Timer timer1;
    }
}