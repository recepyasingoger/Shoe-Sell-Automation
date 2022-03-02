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
    public partial class Kadın : Form
    {
        public static string ayakkabıismi = "";
        Baglanti bgl = new Baglanti();
        string kullanıcıadi = NikeGiris.kullanıcıadi;
        public Kadın()
        {
            InitializeComponent();
        }
        
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Erkek erkek = new Erkek();
            erkek.Show();
            this.Hide();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            Çocuk çocuk = new Çocuk();
            çocuk.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            NikeGiris nk = new NikeGiris();
            nk.Show();
            this.Hide();
        }
        int cpt = 1;
        private void Kadın_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(2);
            dataGridView1.Rows[0].Cells[0].Value = Image.FromFile(@"kshoe\1.png");
            dataGridView1.Rows[1].Cells[0].Value = Image.FromFile(@"kshoe\2.png");
            dataGridView1.Rows[2].Cells[0].Value = Image.FromFile(@"kshoe\3.png");




            dataGridView1.Rows[0].Cells[1].Value = "Nike Metcon  7";
            dataGridView1.Rows[1].Cells[1].Value = "Nike Air Force 1";
             dataGridView1.Rows[2].Cells[1].Value = "Nike Blazer 77 Cozi By You";
            shoe1.Visible = true;
            shoe2.Visible = true;
            shoe3.Visible = false;
            shoe4.Visible = false;
            shoe5.Visible = false;
            shoe6.Visible = false;
            label7.Text = "1.379,90";
            label6.Text = "Nike Metcon \n7";
            label8.Text = "Kadın Antrenman \nAyakkabısı";

            ayakismi.Text = label6.Text;
            fiyat.Text = label7.Text;
            açıklama.Text = label8.Text;
            ayakrenk.Text = "Pembe-Beyaz";
            KullanıcıAdı.Text = kullanıcıadi;
            dosya.Text = "kshoe\\1.png";
        }
        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            if (cpt < dataGridView1.Rows.Count)
            {
                cpt++;


                ana.Image = (Image)dataGridView1.Rows[cpt - 1].Cells[0].Value;

                çarpraz.Load(@"kshoe\" + cpt.ToString() + ".png");
                yan.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + ".png");
                ikili.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
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
                label7.Text = "1.379,90";
                label6.Text = "Nike Metcon \n7";
                label8.Text = "Kadın Antrenman \nAyakkabısı";
                ayakismi.Text = label6.Text;
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Pembe-Beyaz";
                dosya.Text = "kshoe\\1.png";


            }
            if (cpt == 2)
            {
                
                shoe3.Visible = true;
                shoe4.Visible = true;
                shoe5.Visible = false;
                shoe6.Visible = false;
                shoe1.Visible = false;
                shoe2.Visible = false;
                label7.Text = "1.569,90";
                label6.Text = "Nike Air Force 1 \nLow Unlocked";
                label8.Text = "Kadın Ayakkabısı";
                ayakismi.Text = label6.Text;
                ayakrenk.Text = "Turuncu-Krem";
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                dosya.Text = "kshoe\\2.png";
            }
            if (cpt == 3)
            {
                shoe1.Visible = false;
                shoe2.Visible = false;
                label6.Text = "Nike Blazer 77 \nCozi By You";
                shoe3.Visible = false;
                shoe4.Visible = false;
                shoe5.Visible = true;
                shoe6.Visible = true;
                label7.Text = "1.249.90";
                label8.Text = "Kişiye Özel Ayakkabı";
                ayakismi.Text = label6.Text;

                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Gri-Mor";
                dosya.Text = "kshoe\\3.png";

            }
        }
        

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt > 1)
            {
                cpt--;


                ana.Image = (Image)dataGridView1.Rows[cpt - 1].Cells[0].Value;

                çarpraz.Load(@"kshoe\" + cpt.ToString() + ".png");
                yan.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + ".png");
                ikili.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
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
                label7.Text = "1.379,90";
                label6.Text = "Nike Metcon \n7";
                label8.Text = "Kadın Antrenman \nAyakkabısı";
                ayakismi.Text = label6.Text;
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Pembe-Beyaz";
                dosya.Text = "kshoe\\1.png";



            }
            if (cpt == 2)
            {
                shoe1.Visible = false;
                shoe2.Visible = false;
                shoe3.Visible = true;
                shoe4.Visible = true;
                shoe5.Visible = false;
                shoe6.Visible = false;
                label7.Text = "1.569,90";
                label6.Text = "Nike Air Force 1 \nLow Unlocked";
                label8.Text = "Kadın Ayakkabısı";
                ayakismi.Text = label6.Text;
                ayakrenk.Text = "Turuncu-Krem";
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                dosya.Text = "kshoe\\2.png";
            }
            if (cpt == 3)
            {
                shoe1.Visible = false;
                shoe2.Visible = false;
                label6.Text = "Nike Blazer 77 \nCozi By You";
                shoe3.Visible = false;
                shoe4.Visible = false;
                shoe5.Visible = true;
                shoe6.Visible = true;
                label7.Text = "1.249.90";
                label8.Text = "Kişiye Özel Ayakkabı";
                ayakismi.Text = label6.Text;

                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Gri-Mor";
                dosya.Text = "kshoe\\3.png";
            }
        }

        private void ana_Click(object sender, EventArgs e)
        {

        }

        private void çarpraz_Click(object sender, EventArgs e)
        {
            ana.Image = çarpraz.Image;
        }

        private void yan_Click(object sender, EventArgs e)
        {
            ana.Image = yan.Image;
        }

        private void ikili_Click(object sender, EventArgs e)
        {
            ana.Image = ikili.Image;
        }

        

       

      

        private void shoe1_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "kshoe\\1.png";
            ayakrenk.Text = "Pembe-Beyaz";
            ana.Load(@"kshoe\" + cpt.ToString() + ".png");
            çarpraz.Load(@"kshoe\" + cpt.ToString() + ".png");
            yan.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + ".png");
            ikili.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
        }

        private void shoe2_Click(object sender, EventArgs e)
        {
            dosya.Text = "kshoe\\1g.png";
            ayakrenk.Text = "Gri-Mor";
            ana.Load(@"kshoe\" + cpt.ToString() + "g.png");
            çarpraz.Load(@"kshoe\" + cpt.ToString() + "g.png");
            yan.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + "g.png");
            ikili.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "g.png");
        }

        private void shoe3_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "kshoe\\2.png";
            ayakrenk.Text = "Turuncu-Krem";
            ana.Load(@"kshoe\" + cpt.ToString() + ".png");
            çarpraz.Load(@"kshoe\" + cpt.ToString() + ".png");
            yan.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + ".png");
            ikili.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
        }

        private void shoe4_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "kshoe\\2y.png";
            ayakrenk.Text = "Yeşil-Krem";
            ana.Load(@"kshoe\" + cpt.ToString() + "y.png");
            çarpraz.Load(@"kshoe\" + cpt.ToString() + "y.png");
            yan.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + "y.png");
            ikili.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "y.png");
        }

        private void shoe6_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "kshoe\\3s.png";
            ayakrenk.Text = "Krem-Pembe";
            ana.Load(@"kshoe\" + cpt.ToString() + "s.png");
            çarpraz.Load(@"kshoe\" + cpt.ToString() + "s.png");
            yan.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + "s.png");
            ikili.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "s.png");
        }

        private void shoe5_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "kshoe\\3.png";
            ayakrenk.Text = "Gri-Mor";
            ana.Load(@"kshoe\" + cpt.ToString() + ".png");
            çarpraz.Load(@"kshoe\" + cpt.ToString() + ".png");
            yan.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + ".png");
            ikili.Load(@"kshoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
        }

        private void N34_Click(object sender, EventArgs e)
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

        private void gunaControlBox1_Click(object sender, EventArgs e)
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
