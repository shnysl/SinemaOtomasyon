using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class Form1 : Form
    {
        public static string[] adSoyad = new string[61];
        public static string[] tcNo = new string[61];
        public static string[] cinsiyet = new string[61];
        public int kNo;
        public static Button btn;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 61; j++)
            {
                Form1.adSoyad[j] = "";
                Form1.tcNo[j] = "";
                Form1.cinsiyet[j] = "";
            }
            for (int i = 1; i <= 60; i++)
            {
                Button btn = new Button();
                btn.Name = i.ToString(); ;
                btn.Text = $"{i}";
                btn.Font = new Font(btn.Font.FontFamily, 16, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.TopCenter;
                btn.Top = 60;
                btn.Width = 50;
                btn.Height = 50;
                btn.BackgroundImage = Image.FromFile(@"..\..\images\bosKoltuk.png");
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += Btn_Click;
                btn.Tag = i;
                if (i <= 8)
                {
                    // btn.Left = 200;
                    btn.Location = new Point(150 + (btn.Width) * i, (btn.Top));
                    panel1.Controls.Add(btn);
                }
                else if (i > 8 && i < 21)
                {
                    //btn.Left = 200;
                    btn.Location = new Point(50 + (btn.Width) * (i - 8), (btn.Top) + 50);
                    panel1.Controls.Add(btn);
                }
                else if (i >= 21 && i < 29)
                {
                    //btn.Left = 200;
                    btn.Location = new Point(150 + (btn.Width) * (i - 20), (btn.Top) + 100);
                    panel1.Controls.Add(btn);
                }
                else if (i >= 29 && i < 41)
                {
                    //btn.Left = 200;
                    btn.Location = new Point(50 + (btn.Width) * (i - 28), (btn.Top) + 150);
                    panel1.Controls.Add(btn);
                }
                else if (i >= 41 && i < 49)
                {
                    //btn.Left = 200;
                    btn.Location = new Point(150 + (btn.Width) * (i - 40), (btn.Top) + 200);
                    panel1.Controls.Add(btn);
                }
                else if (i >= 49 && i < 61)
                {
                    //btn.Left = 200;
                    btn.Location = new Point(50 + (btn.Width) * (i - 48), (btn.Top) + 250);
                    panel1.Controls.Add(btn);
                }

            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            kNo = Convert.ToInt32((((Button)sender).Text));
            Form2.kNo = kNo;
            fr2.fr1 = this;
            fr2.tbAdSoyad.Text = Form1.adSoyad[kNo].ToString();
            fr2.tbTCNo.Text = Form1.tcNo[kNo].ToString();
            if (cinsiyet[kNo] == "Erkek")
            {
                fr2.rbErkek.Checked = true;
            }
            else if (cinsiyet[kNo] == "Kadın")
            {
                fr2.rbKadin.Checked = true;
            }
            fr2.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i<60; i++)
            {
                if (adSoyad[i] != "")
                {
                    sayac++;
                }
            }
            MessageBox.Show(sayac.ToString(), "TOPLAM KİŞİ SAYISI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int eSayisi = 0;
            int kSayisi = 0;
            for (int i = 0; i < 60; i++)
            {
                if (cinsiyet[i] == "Erkek")
                {
                    eSayisi++;
                }
                else if (cinsiyet[i] == "Kadın")
                {
                    kSayisi++;
                }
            }
            MessageBox.Show($"Kadın Saysı = {kSayisi} \nErkek Sayısı = {eSayisi}", "TOPLAM KİŞİ SAYISI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
