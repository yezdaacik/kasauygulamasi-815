using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasa_uygulaması_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            double tutar;
            tutar = Convert.ToDouble(txtTutar.Text);
            if (rb2.Checked == true || rb3.Checked == true)
            {
                tutar = tutar + (tutar * 0.05);
            }
            if (rb4.Checked == true || rb5.Checked == true)
            {
                tutar = tutar + (tutar * 0.10);
            }
            MessageBox.Show("Ödenecek Toplam Tutar:" + tutar.ToString() + "TL");
        }
    }
}
