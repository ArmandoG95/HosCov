﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HosCovPro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblIdentificate_Click(object sender, EventArgs e)
        {

        }

        private void bttPaciente_Click(object sender, EventArgs e)
        {
            FrmLoginPacientes frmLoginPacientes = new FrmLoginPacientes();
            frmLoginPacientes.Show();
        }

        private void bttPersonalMD_Click(object sender, EventArgs e)
        {
            FrmLoginPersonalMedico FrmLoginPersonalMedico = new FrmLoginPersonalMedico();
            FrmLoginPersonalMedico.Show();

        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
