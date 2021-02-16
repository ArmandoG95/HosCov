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
    public partial class frmBarraDeCarga : Form
    {
        public frmBarraDeCarga()
        {
            InitializeComponent();
            pbrCargando.Value = 0;



        }
            



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbrCargando.Value < 100)
            {
                pbrCargando.Value++;
            }



        }

        private void pbrCargando_Click_1(object sender, EventArgs e)
        {
            if (pbrCargando.Value == 100)
            {
                frmInformaciónEnviada frmInformaciónEnviada = new frmInformaciónEnviada();
                frmInformaciónEnviada.Show();
            }
            this.Close();

        }

        private void frmBarraDeCarga_Load(object sender, EventArgs e)
        {
         
        }
    }
}
