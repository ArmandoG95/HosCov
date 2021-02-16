namespace HosCovPro
{
    partial class FrmLoginPersonalMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginPersonalMedico));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.dttFecha = new System.Windows.Forms.DateTimePicker();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bttExit = new System.Windows.Forms.Button();
            this.bttLogIn = new System.Windows.Forms.Button();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.bttBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(12, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(175, 80);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // dttFecha
            // 
            this.dttFecha.Location = new System.Drawing.Point(588, 12);
            this.dttFecha.Name = "dttFecha";
            this.dttFecha.Size = new System.Drawing.Size(200, 20);
            this.dttFecha.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(218, 172);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 29);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(218, 218);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(370, 181);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(186, 20);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(370, 227);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // bttExit
            // 
            this.bttExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttExit.Location = new System.Drawing.Point(674, 384);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(89, 33);
            this.bttExit.TabIndex = 7;
            this.bttExit.Text = "Exit";
            this.bttExit.UseVisualStyleBackColor = true;
            // 
            // bttLogIn
            // 
            this.bttLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLogIn.Location = new System.Drawing.Point(370, 276);
            this.bttLogIn.Name = "bttLogIn";
            this.bttLogIn.Size = new System.Drawing.Size(139, 37);
            this.bttLogIn.TabIndex = 8;
            this.bttLogIn.Text = "Log In";
            this.bttLogIn.UseVisualStyleBackColor = true;
            this.bttLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPassword.Location = new System.Drawing.Point(383, 329);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(106, 16);
            this.lblResetPassword.TabIndex = 9;
            this.lblResetPassword.Text = "Reset password";
            // 
            // bttBack
            // 
            this.bttBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttBack.Location = new System.Drawing.Point(25, 384);
            this.bttBack.Name = "bttBack";
            this.bttBack.Size = new System.Drawing.Size(89, 33);
            this.bttBack.TabIndex = 10;
            this.bttBack.Text = "Back";
            this.bttBack.UseVisualStyleBackColor = true;
            // 
            // FrmLoginPersonalMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttBack);
            this.Controls.Add(this.lblResetPassword);
            this.Controls.Add(this.bttLogIn);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.dttFecha);
            this.Controls.Add(this.pctLogo);
            this.Name = "FrmLoginPersonalMedico";
            this.Text = "FrmLoginPersonalMedico";
            this.Load += new System.EventHandler(this.FrmLoginPersonalMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.DateTimePicker dttFecha;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Button bttLogIn;
        private System.Windows.Forms.Label lblResetPassword;
        private System.Windows.Forms.Button bttBack;
    }
}