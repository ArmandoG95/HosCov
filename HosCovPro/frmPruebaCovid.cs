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
    public partial class frmPruebaCovid : Form
    {
        public frmPruebaCovid()
        {
            InitializeComponent();
        }

        private void prgEnviado_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FrmMenuPaciente FrmMenuPaciente = new FrmMenuPaciente();
            FrmMenuPaciente.Show();
            this.Close();
        }
    }
}
