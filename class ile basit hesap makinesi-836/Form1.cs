using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_ile_basit_hesap_makinesi_836
{
    public partial class Form1 : Form
    {
        Hesapmk hesap = new Hesapmk();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            hesap.sayi1 = Convert.ToInt32(txtS1.Text);
            hesap.sayi2= Convert.ToInt32(txtS2.Text);

            if (rbT.Checked)
            {
                lblSonuc.Text = "Sonuç: " + hesap.topla();
            }

            else if (rbCi.Checked)
            {
                lblSonuc.Text = "Sonuç: " + hesap.cikar();
            }

            else if (rbC.Checked)
            {
                lblSonuc.Text = "Sonuç: " + hesap.carp();
            }

            else
            {
                lblSonuc.Text="Sonuç: "+hesap.bol();
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            txtS1.Clear();
            txtS2.Clear();
            if (rbT.Checked)
            {
                lbSonuclar.Items.Add("Toplam= "+hesap.topla());
            }

            else if (rbCi.Checked)
            {
                lbSonuclar.Items.Add("Çıkarma= "+hesap.cikar());
            }

            else if (rbC.Checked)
            {
                lbSonuclar.Items.Add("Çarpma= "+hesap.carp());
            }

            else
            {
                lbSonuclar.Items.Add("Bölme= "+hesap.bol());
            }
        }
    }
}
