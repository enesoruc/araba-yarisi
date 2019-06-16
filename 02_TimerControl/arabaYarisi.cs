using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_TimerControl
{
    public partial class arabaYarisi : Form
    {
        public arabaYarisi()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int kimKazandı = 0;
        int bakiye = 0;
        int yatırılan = 0;
        int bahisNo = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
           timer1.Enabled = true;
        }
        public void onePing()
        {
            SystemSounds.Beep.Play();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbBirinciAraba.Top = pbBirinciAraba.Top- rnd.Next(1, 10);//araba hızı random alınır
            pbİkinciAraba.Top = pbİkinciAraba.Top- rnd.Next(1, 10);
            pbUcuncuAraba.Top = pbUcuncuAraba.Top- rnd.Next(1, 10);

            int bitis = label5.Top;
            if (pbBirinciAraba.Top<=bitis)//hangi araba kazandıysa o gösterilir
            {
                onePing();
                timer1.Enabled = false;
                MessageBox.Show("1 kazandı");
                kimKazandı = 1;
            }
            else if (pbİkinciAraba.Top<=bitis)
            {
                onePing();
                timer1.Enabled = false;
                MessageBox.Show("2 kazandı");
                kimKazandı = 2;
            }
            else if (pbUcuncuAraba.Top <= bitis)
            {
                onePing();
                timer1.Enabled = false;
                MessageBox.Show("3 kazandı");
                kimKazandı = 3;
            }

            KimKazanmis(kimKazandı, bahisNo);//oynanan arabayla kazanan araba eşitse bakiye güncellenir
        }

        private void btnReset_Click(object sender, EventArgs e)//yeniden oyna butonu basıldığı zaman değerler default değere çevrilir
        {
            pbBirinciAraba.Top = 410;
            pbİkinciAraba.Top = 410;
            pbUcuncuAraba.Top = 410;
            kimKazandı = 0;
        }

        private void btnbahis_Click(object sender, EventArgs e)//bahis formu açılır
        {
            bahis bhs = new bahis();
            bhs.Owner = this;
            bhs.ShowDialog();
        }
        public void SetLabel(string text)
        {
             lblBahis.Text = text;
             bahisNo = int.Parse(text);
        }
        public void MiktarAl(string miktar)//kullanıcının girdiği miktar textboxta gösterilir
        {
            textBox1.Text = miktar;
        }
        
        private void arabaYarisi_Load(object sender, EventArgs e)//bakiye 1000 olarak default gelir
        {
            bakiye = 1000;
            txtBakiye.Text = bakiye.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)///kullanıcının yatırdığı para değişkene atılır
        {
            yatırılan = int.Parse(textBox1.Text);
            
        }
        private void KimKazanmis(int kimKazandi,int bahisNo)//oynanan arabayla kazanan araba eşitse bakiye güncellenir
        {
            if (kimKazandı == 1)
            {
                if (kimKazandı == bahisNo)
                {
                    MessageBox.Show("1 kazandı iyisin");
                    bakiye += yatırılan;
                    txtBakiye.Clear();
                    txtBakiye.Text = bakiye.ToString();
                }
                else
                {
                    bakiye -= yatırılan;
                    txtBakiye.Clear();
                    txtBakiye.Text = bakiye.ToString();
                }
            }

            else if (kimKazandı == 2)
            {
                if (kimKazandı == bahisNo)
                {
                    MessageBox.Show("2 kazandı iyisin");
                    bakiye += yatırılan;
                    txtBakiye.Clear();
                    txtBakiye.Text = bakiye.ToString();
                }
                else
                {
                    bakiye -= yatırılan;
                    txtBakiye.Clear();
                    txtBakiye.Text = bakiye.ToString();
                }
            }
            else if (kimKazandı == 3)
            {
                if (kimKazandı == bahisNo)
                {
                    MessageBox.Show("3 kazandı iyisin");
                    bakiye += yatırılan;
                    txtBakiye.Clear();
                    txtBakiye.Text = bakiye.ToString();
                }
                else
                {
                    bakiye -= yatırılan;
                    txtBakiye.Clear();
                    txtBakiye.Text = bakiye.ToString();
                }
            }


        }
    }
}
