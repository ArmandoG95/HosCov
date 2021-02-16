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
    public partial class FrmRegVacuna : Form
    {
        public FrmRegVacuna()
        {
            InitializeComponent();
        }

        private void FrmRegVacuna_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaDeNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void grpDatosDeContacto_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNumTelefono_Click(object sender, EventArgs e)
        {
            if (txtNumCelular.Text != "")
            {
                lstDatosDeContacto.Items.Add(lblNumCelular.Text);
                lstDatosDeContacto.Items.Add(txtNumCelular.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCorreoElectronico.Text != "")
            {
                lstDatosDeContacto.Items.Add(lblCorreoElectronico.Text);
                lstDatosDeContacto.Items.Add(txtCorreoElectronico.Text);
            }

        }

        private void btnTelefonoFijo_Click(object sender, EventArgs e)
        {
            if (txtTelefonoFijo.Text != "")
            {
                lstDatosDeContacto.Items.Add(lblTelefonoFijo.Text);
                lstDatosDeContacto.Items.Add(txtTelefonoFijo.Text);
            }


        }

        private void lstDatosDeContacto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmaTuCorreoElectronico_Click(object sender, EventArgs e)
        {
            if (txtConfirmaTuCorreoElectronico.Text == txtCorreoElectronico.Text)
            {
                lstDatosDeContacto.Items.Add(lblConfirmaTuCorreoElectronico.AccessibleDescription);
                lstDatosDeContacto.Items.Add(txtConfirmaTuCorreoElectronico.Text);
            }


        }
    }
}
