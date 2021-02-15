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
    public partial class Form2 : Form
    {

        public Form2()
        {

            InitializeComponent();

        }
        public Form1 fr1;
        private void tbTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public static int kNo;
        public void Form2_Load(object sender, EventArgs e)
        {


        }

        private void tbAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }


   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbAdSoyad.TextLength == 0)
            {
                MessageBox.Show("İsim Boş Geçilemez", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tbTCNo.TextLength < 11)
                {
                    MessageBox.Show("TC Kimlik Numarası Hatalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rbErkek.Checked || rbKadin.Checked)
                    {
                        Form1.adSoyad[kNo] = tbAdSoyad.Text;
                        Form1.tcNo[kNo] = tbTCNo.Text;
                        string c = "";
                        if (rbErkek.Checked)
                        {
                            c = "Erkek";
                        }
                        else if (rbKadin.Checked)
                        {
                            c = "Kadın";
                        }
                        Form1.cinsiyet[kNo] = c;
                        foreach (Control kontrol in fr1.panel1.Controls)
                        {
                            if (kontrol is Button && kontrol.Name == kNo.ToString())
                            {
                                kontrol.BackgroundImage = Image.FromFile(@"..\..\images\doluKoltuk.png");
                            }
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Cinsiyet Seçimi Yapınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form1.adSoyad[kNo] = "";
            Form1.tcNo[kNo] = "";
            Form1.cinsiyet[kNo] = "";
            foreach (Control kontrol in fr1.panel1.Controls)
            {
                if (kontrol is Button && kontrol.Name == kNo.ToString())
                {
                    kontrol.BackgroundImage = Image.FromFile(@"..\..\images\bosKoltuk.png");
                }
            }

            this.Hide();
        }

        private void tbTCNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
