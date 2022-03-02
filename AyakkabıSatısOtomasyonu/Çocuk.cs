using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyakkabıSatısOtomasyonu
{
    public partial class Çocuk : Form
    {
        public static string ayakkabıismi = "";
        Baglanti bgl = new Baglanti();
        string kullanıcıadi = NikeGiris.kullanıcıadi;
        public Çocuk()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Erkek erkek = new Erkek();
            erkek.Show();
            this.Hide();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            Kadın kadın = new Kadın();
            kadın.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            NikeGiris nk = new NikeGiris();
            nk.Show();
            this.Hide();
        }

        int cpt = 1;
        private void Çocuk_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(2);
            dataGridView1.Rows[0].Cells[0].Value = Image.FromFile(@"kcocuk\1.png");
            dataGridView1.Rows[1].Cells[0].Value = Image.FromFile(@"kcocuk\2.png");
            dataGridView1.Rows[2].Cells[0].Value = Image.FromFile(@"kcocuk\3.png");




            dataGridView1.Rows[0].Cells[1].Value = "Air Jordan 11 CMFT Low";
            dataGridView1.Rows[1].Cells[1].Value = "Nike Air Max Plus";
            dataGridView1.Rows[2].Cells[1].Value = "Nike Crater Impact";
            shoe1.Visible = true;
            shoe2.Visible = true;
            shoe3.Visible = false;
            shoe4.Visible = false;
            shoe5.Visible = false;
            shoe6.Visible = false;
            label7.Text = "999,90";
            label6.Text = "Air Jordan 11 \nCMFT Low";
            label8.Text = "Genç Çocuk \nAyakkabısı";
            ayakismi.Text = label6.Text;
            fiyat.Text = label7.Text;
            açıklama.Text = label8.Text;
            ayakrenk.Text = "Siyah-Beyaz";
            KullanıcıAdı.Text = kullanıcıadi;
            dosya.Text = "kcocuk\\1.png";

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            if (cpt < dataGridView1.Rows.Count)
            {
                cpt++;


                ana.Image = (Image)dataGridView1.Rows[cpt - 1].Cells[0].Value;

                çarpraz.Load(@"kcocuk\" + cpt.ToString() + ".png");
                yan.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + ".png");
                ikili.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                ana.Image = çarpraz.Image;
            }
            if (cpt == 1)
            {
                shoe1.Visible = true;
                shoe2.Visible = true;
                shoe3.Visible = false;
                shoe4.Visible = false;
                shoe5.Visible = false;
                shoe6.Visible = false;
                
                label7.Text = "999,90";
                label6.Text = "Air Jordan 11 \nCMFT Low";
                label8.Text = "Genç Çocuk \nAyakkabısı";
                ayakismi.Text = label6.Text;
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Siyah-Beyaz";
                dosya.Text = "kcocuk\\1.png";

            }
            if (cpt == 2)
            {

                shoe3.Visible = true;
                shoe4.Visible = true;
                shoe5.Visible = false;
                shoe6.Visible = false;
                shoe1.Visible = false;
                shoe2.Visible = false;
                label7.Text = "1.049,90";
                label6.Text = "Nike Air \nMax Plus ";
                label8.Text = "Küçük Çocuk \nAyakkabısı";
                ayakismi.Text = label6.Text;
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Siyah";
                dosya.Text = "kcocuk\\2.png";
            }
            if (cpt == 3)
            {
                shoe1.Visible = false;
                shoe2.Visible = false;
                
                shoe3.Visible = false;
                shoe4.Visible = false;
                shoe5.Visible = true;
                shoe6.Visible = true;
                label6.Text = "Nike Crater \nImpact";
                label7.Text = "669,90";
                label8.Text = "Küçük Çocuk \nAyakkabısı";
                ayakismi.Text = label6.Text;
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Krem-Gri";
                dosya.Text = "kcocuk\\3.png";
            }
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt > 1)
            {
                cpt--;


                ana.Image = (Image)dataGridView1.Rows[cpt - 1].Cells[0].Value;

                çarpraz.Load(@"kcocuk\" + cpt.ToString() + ".png");
                yan.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + ".png");
                ikili.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                ana.Image = çarpraz.Image;
            }
            if (cpt == 1)
            {
                shoe1.Visible = true;
                shoe2.Visible = true;
                shoe3.Visible = false;
                shoe4.Visible = false;
                shoe5.Visible = false;
                shoe6.Visible = false;

                label7.Text = "999,90";
                label6.Text = "Air Jordan 11 \nCMFT Low";
                label8.Text = "Genç Çocuk \nAyakkabısı";
                ayakismi.Text = label6.Text;
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Siyah-Beyaz";
                dosya.Text = "kcocuk\\1.png";



            }
            if (cpt == 2)
            {
                shoe1.Visible = false;
                shoe2.Visible = false;
                shoe3.Visible = true;
                shoe4.Visible = true;
                shoe5.Visible = false;
                shoe6.Visible = false;

                label7.Text = "1.049,90";
                label6.Text = "Nike Air \nMax Plus ";
                label8.Text = "Küçük Çocuk \nAyakkabısı";
                ayakismi.Text = label6.Text;
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Siyah";
                dosya.Text = "kcocuk\\2.png";
            }
            if (cpt == 3)
            {
                shoe1.Visible = false;
                shoe2.Visible = false;
                shoe3.Visible = false;
                shoe4.Visible = false;
                shoe5.Visible = true;
                shoe6.Visible = true;
                label6.Text = "Nike Crater \nImpact";
                label7.Text = "669,90";
                label8.Text = "Küçük Çocuk \nAyakkabısı";
                ayakismi.Text = label6.Text;
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Krem-Gri";
                dosya.Text = "kcocuk\\3.png";
            }
        }

        
      

        private void shoe1_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "kcocuk\\1.png";
            ayakrenk.Text = "Siyah-Beyaz";
            ana.Load(@"kcocuk\" + cpt.ToString() + ".png");
            çarpraz.Load(@"kcocuk\" + cpt.ToString() + ".png");
            yan.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + ".png");
            ikili.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
        }

        private void shoe2_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "kcocuk\\1g.png";
            ayakrenk.Text = "Gri-Beyaz";
            ana.Load(@"kcocuk\" + cpt.ToString() + "g.png");
            çarpraz.Load(@"kcocuk\" + cpt.ToString() + "g.png");
            yan.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + "g.png");
            ikili.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "g.png");
        }

        private void shoe3_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "kcocuk\\2.png";
            ayakrenk.Text = "Siyah";
            ana.Load(@"kcocuk\" + cpt.ToString() + ".png");
            çarpraz.Load(@"kcocuk\" + cpt.ToString() + ".png");
            yan.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + ".png");
            ikili.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
        }

        private void shoe4_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "kcocuk\\2p.png";
            ayakrenk.Text = "Pembe-Beyaz";
            ana.Load(@"kcocuk\" + cpt.ToString() + "p.png");
            çarpraz.Load(@"kcocuk\" + cpt.ToString() + "p.png");
            yan.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + "p.png");
            ikili.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "p.png");
        }

        private void shoe5_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "kcocuk\\3.png";
            ayakrenk.Text = "Krem-Gri";
            ana.Load(@"kcocuk\" + cpt.ToString() + ".png");
            çarpraz.Load(@"kcocuk\" + cpt.ToString() + ".png");
            yan.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + ".png");
            ikili.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
        }

        private void shoe6_Click(object sender, EventArgs e)
        {
            dosya.Text = "kcocuk\\3p.png";
            ayakrenk.Text = "Pembe-Gri";
            ana.Load(@"kcocuk\" + cpt.ToString() + "p.png");
            çarpraz.Load(@"kcocuk\" + cpt.ToString() + "p.png");
            yan.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + "p.png");
            ikili.Load(@"kcocuk\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "p.png");
        }

        private void çarpraz_Click(object sender, EventArgs e)
        {
            ana.Image = çarpraz.Image;
        }

        private void ikili_Click(object sender, EventArgs e)
        {
            ana.Image = ikili.Image;
        }

        private void yan_Click(object sender, EventArgs e)
        {
            ana.Image = yan.Image;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Sipariş sipariş = new Sipariş();
            sipariş.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Favoriler fav = new Favoriler();
            fav.Show();
            this.Hide();
        }

        private void N36_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientCircleButton rb = (Guna.UI2.WinForms.Guna2GradientCircleButton)sender;

            ayaknumara.Text = rb.Text;
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            ayakkabıismi = label6.Text;
            if (ayaknumara.Text != "")

            {
             
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Sepet(kullanıcıadı,ayakkabıismi,ayakkabırenk,ayakkabıaçıklama,ayakkabınumara,ayakkabıfiyat,ayakkabıfoto) values('" + KullanıcıAdı.Text + "','" + ayakismi.Text + "','" + ayakrenk.Text + "','" + açıklama.Text + "','" + ayaknumara.Text + "','" + fiyat.Text + "' ,'" + dosya.Text + "' )", baglanti);
                // SqlCommand komut = new SqlCommand("insert into Sepet(ayakkabıfoto) values(@images)", baglanti);
                //komut.Parameters.AddWithValue("@images", ana.ImageLocation);

                ekle.ExecuteNonQuery();
                //komut.ExecuteNonQuery();



                // SqlCommand sqlCommand = new SqlCommand("INSERT INTO Sepet (ayakkabıfoto) VALUES (@Image)", baglanti);


                baglanti.Close();

                MessageBox.Show(ayakkabıismi + " " + " \nİsimli Ayakkabı Sepete \nBaşarıyla Eklenmiştir.");
            }
            else
            {
                MessageBox.Show("Ayakkabı Numarası  Seçmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            ayakkabıismi = label6.Text;
            if (ayaknumara.Text != "")

            {
       
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Favoriler(kullanıcıadı,ayakkabıismi,ayakkabırenk,ayakkabıaçıklama,ayakkabınumara,ayakkabıfiyat,ayakkabıfoto) values('" + KullanıcıAdı.Text + "','" + ayakismi.Text + "','" + ayakrenk.Text + "','" + açıklama.Text + "','" + ayaknumara.Text + "','" + fiyat.Text + "' ,'" + dosya.Text + "' )", baglanti);
                // SqlCommand komut = new SqlCommand("insert into Sepet(ayakkabıfoto) values(@images)", baglanti);
                //komut.Parameters.AddWithValue("@images", ana.ImageLocation);

                ekle.ExecuteNonQuery();
                //komut.ExecuteNonQuery();



                // SqlCommand sqlCommand = new SqlCommand("INSERT INTO Sepet (ayakkabıfoto) VALUES (@Image)", baglanti);


                baglanti.Close();

                MessageBox.Show(ayakkabıismi + " " + " \nİsimli Ayakkabı Favorilere \nBaşarıyla Eklenmiştir.");
            }
            else
            {

                MessageBox.Show("Ayakkabı Numarası  Seçmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {

        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            Ayarlar ayar = new Ayarlar();
            ayar.Show();
            this.Hide();
        }
    }
}
