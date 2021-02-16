using System;
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
    public partial class FrmMenuPaciente : Form
    {
        public FrmMenuPaciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            FrmExpediente frmExpediente = new FrmExpediente();
            frmExpediente.Show();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            frmPruebaCovid frmPruebaCovid = new frmPruebaCovid();
            frmPruebaCovid.Show();
            this.Close();
        }

        private void btnRegistroVacuna_Click(object sender, EventArgs e)
        {
            FrmRegVacuna FrmRegVacuna = new FrmRegVacuna();
            FrmRegVacuna.Show();
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmAgendarCita frmAgendarCita = new frmAgendarCita();
            frmAgendarCita.Show();
        }
    }
}
