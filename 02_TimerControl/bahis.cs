using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_TimerControl
{
    public partial class bahis : Form
    {
        public bahis()
        {
            InitializeComponent();
        }
        arabaYarisi arabaYaris;
        private void bahis_Load(object sender, EventArgs e)
        {
            arabaYaris = (arabaYarisi)this.Owner;
        }

        private void btnBahis_Click(object sender, EventArgs e)
        {
           if ((string.IsNullOrWhiteSpace(txtBahis.Text))||(string.IsNullOrWhiteSpace(txtMiktar.Text)))
            {
                MessageBox.Show("Lütfen bir değer giriniz");
                NullItems();
            }
            else
            {
                ArabaSec();
                MiktarGir();
                this.Close();
            }
        }
        private void NullItems()
        {
            txtBahis.Text = string.Empty;
            txtMiktar.Text = string.Empty;
            txtBahis.Focus();
        }
        private void ArabaSec()
        {
            try
            {
                int sayi = int.Parse(txtBahis.Text);
                if (sayi < 1 || sayi > 3)
                {
                    MessageBox.Show("Lütfen 1-2-3 arabalardan birini seçiniz");
                    NullItems();
                }
                else
                {
                    arabaYaris.SetLabel(txtBahis.Text);
                 }
            }
            catch
            {
                MessageBox.Show("Geçerli bir değer giriniz");
                NullItems();
            }
        }
        private void MiktarGir()
        {
            try
            {
                int miktar = int.Parse(txtMiktar.Text);
                if (miktar < 1 || miktar >= 1000)
                {
                    MessageBox.Show("Lütfen 1-1000 Tl arası bir miktar giriniz");
                    NullItems();
                }
                else
                {
                    arabaYaris.MiktarAl(txtMiktar.Text);
                }
            }
            catch
            {
                MessageBox.Show("Geçerli bir değer giriniz");
                NullItems();
            }
        }
        
    }
}
