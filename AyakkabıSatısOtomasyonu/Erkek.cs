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
using Guna.UI.WinForms;

namespace AyakkabıSatısOtomasyonu
{
    public partial class Erkek : Form
    {
        Baglanti bgl = new Baglanti();
        string kullanıcıadi = NikeGiris.kullanıcıadi;
        public static string ayakkabıismi = "";
        public Erkek()
        {
            InitializeComponent();
        }

      

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            Hide();
            NikeGiris nk = new NikeGiris();
            
            
            

        }
        int cpt = 1;
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(2);
            dataGridView1.Rows[0].Cells[0].Value = Image.FromFile(@"shoe\1.png");
            dataGridView1.Rows[1].Cells[0].Value = Image.FromFile(@"shoe\2.png");
            dataGridView1.Rows[2].Cells[0].Value = Image.FromFile(@"shoe\3.png");




            dataGridView1.Rows[0].Cells[1].Value = "Nike Air Zoom Pegasus 38";
            dataGridView1.Rows[1].Cells[1].Value = "PG 5";
            dataGridView1.Rows[2].Cells[1].Value = "Nike Zoom Freak 3 By You";
            shoe1.Visible = true;
            shoe2.Visible = true;
            shoe3.Visible = false;
            shoe4.Visible = false;
            label6.Text = "Nike Air Zoom \nPegasus 38";
            label7.Text = "1.249,90";
            label8.Text = "Hava Şartlarına Dayanaklı \nKişiye Özel Erkek Koşu \nAyakkabısı";
            ayakismi.Text = label6.Text;
            fiyat.Text = label7.Text;
            açıklama.Text = label8.Text;
            ayakrenk.Text = "Mavi-Beyaz";
            dosya.Text = "shoe\\1.png";


             KullanıcıAdı.Text= kullanıcıadi ;
           

        }

        private void gunaPictureBox2_Click_1(object sender, EventArgs e)
        {
            ana.Image = çarpraz.Image;
         
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            ana.Image = ikili.Image;
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            ana.Image = yan.Image;
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            if(cpt<dataGridView1.Rows.Count)
            {
                cpt++;
           
                
            ana.Image = (Image)dataGridView1.Rows[cpt - 1].Cells[0].Value;

            çarpraz.Load(@"shoe\" + cpt.ToString() + ".png");
            yan.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + ".png");
            ikili.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
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
                label7.Text = "1.249,90";
                label6.Text = "Nike Air Zoom \nPegasus 38";
                label8.Text = "Hava Şartlarına Dayanaklı \nKişiye Özel Erkek Koşu \nAyakkabısı";
                ayakismi.Text = label6.Text;
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Mavi-Beyaz";
                dosya.Text = "shoe\\1.png";

            }
            if (cpt == 2)
            {
                label6.Text = "PG 5 Basketbol \nAyakkabısı";
                shoe3.Visible = true;
                shoe2.Visible = false;
                shoe4.Visible = true;
                shoe1.Visible = false;
                shoe5.Visible = false;
                shoe6.Visible = false;
                label7.Text = "1.500";
                label8.Text = "Basketbol Ayakkabısı";
                ayakismi.Text = label6.Text;
                ayakrenk.Text = "Gri-Beyaz";
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                dosya.Text = "shoe\\2.png";
            }
            if (cpt == 3)
            {
                shoe1.Visible = false;
                shoe2.Visible = false;
                label6.Text = "Nike Zoom \nFreak 3 By You";
                shoe3.Visible = false;
                shoe4.Visible = false;
                shoe5.Visible = true;
                shoe6.Visible = true;
                label7.Text = "1.589.90";
                label8.Text = "Basketbol Ayakkabısı";
                ayakismi.Text = label6.Text;
              
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Siyah-Yeşil";
                dosya.Text = "shoe\\3.png";
            }
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt > 1)
            {
                cpt--;


                ana.Image = (Image)dataGridView1.Rows[cpt - 1].Cells[0].Value;

                çarpraz.Load(@"shoe\" + cpt.ToString() + ".png");
                yan.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + ".png");
                ikili.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                ana.Image =çarpraz.Image;
            }
            if (cpt == 1)
            {
                shoe1.Visible = true;
                shoe2.Visible = true;
                shoe3.Visible = false;
                shoe4.Visible = false;
                shoe5.Visible = false;
                shoe6.Visible = false;
                label6.Text = "Nike Air Zoom \nPegasus 38";
                label7.Text = "1.249,90";
                label8.Text = "Hava Şartlarına Dayanaklı \nKişiye Özel Erkek Koşu \nAyakkabısı";
                ayakismi.Text = label6.Text;
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Mavi-Beyaz";
                dosya.Text = "shoe\\1.png";


            }
            if (cpt==2)
            {
                shoe1.Visible = false;
                shoe2.Visible = false;
                label6.Text = "PG 5 Basketbol \nAyakkabısı";
                shoe3.Visible = true;
                shoe4.Visible = true;
                shoe5.Visible = false;
                shoe6.Visible = false;
                label7.Text = "1.500";
                label8.Text = "Basketbol Ayakkabısı";
                ayakismi.Text = label6.Text;
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Gri-Beyaz";
                dosya.Text = "shoe\\2.png";
            }
            if (cpt == 3)
            {
                shoe1.Visible = false;
                shoe2.Visible = false;
                label6.Text = "Nike Zoom \nFreak 3 By You";
                shoe3.Visible = false;
                shoe4.Visible = false;
                shoe5.Visible = true;
                shoe6.Visible = true;
                label7.Text = "1.589.90";
                label8.Text = "Basketbol Ayakkabısı";
                ayakismi.Text = label6.Text;
                fiyat.Text = label7.Text;
                açıklama.Text = label8.Text;
                ayakrenk.Text = "Siyah-Yeşil";
                dosya.Text = "shoe\\3.png";
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            NikeGiris nk = new NikeGiris();
            nk.Show();
            this.Hide();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            Kadın kdn = new Kadın();
            kdn.Show();
            this.Hide();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            Çocuk çocuk = new Çocuk();
            çocuk.Show();
            this.Hide();
        }
        private void shoe1_Click(object sender, EventArgs e)
        {
            dosya.Text = "shoe\\1.png";
            ayakrenk.Text = "Mavi-Beyaz";
            ana.Load(@"shoe\" + cpt.ToString() + ".png");
            çarpraz.Load(@"shoe\" + cpt.ToString() + ".png");
            yan.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + ".png");
            ikili.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
        }

        private void shoe2_Click(object sender, EventArgs e)
        {
            dosya.Text = "shoe\\1s.png";
            ayakrenk.Text = "Turuncu-Krem";
            ana.Load(@"shoe\" + cpt.ToString() + "s.png");
            çarpraz.Load(@"shoe\" + cpt.ToString() + "s.png");
            yan.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + "s.png");
            ikili.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "s.png");
        }

        private void shoe3_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "shoe\\2.png";
            ayakrenk.Text = "Gri-Beyaz";
            ana.Load(@"shoe\" + cpt.ToString() + ".png");
            çarpraz.Load(@"shoe\" + cpt.ToString() + ".png");
            yan.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + ".png");
            ikili.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
        }

        private void shoe4_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "shoe\\2s.png";
            ayakrenk.Text = "Sarı-Beyaz";
            ana.Load(@"shoe\" + cpt.ToString() + "s.png");
            çarpraz.Load(@"shoe\" + cpt.ToString() + "s.png");
            yan.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + "s.png");
            ikili.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "s.png");
        }

        private void shoe5_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "shoe\\3.png";
            ayakrenk.Text = "Siyah-Yeşil";
            ana.Load(@"shoe\" + cpt.ToString() + ".png");
            çarpraz.Load(@"shoe\" + cpt.ToString() + ".png");
            yan.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + ".png");
            ikili.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
        }

        private void shoe6_Click_1(object sender, EventArgs e)
        {
            dosya.Text = "shoe\\3y.png";
            ayakrenk.Text = "Yeşil-Krem";
            ana.Load(@"shoe\" + cpt.ToString() + "y.png");
            çarpraz.Load(@"shoe\" + cpt.ToString() + "y.png");
            yan.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + "y.png");
            ikili.Load(@"shoe\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "y.png");
        }

        

        private void N36_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientCircleButton rb = (Guna.UI2.WinForms.Guna2GradientCircleButton)sender;

            ayaknumara.Text = rb.Text;
        }
        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            ayakkabıismi = label6.Text;
            DataSet daset = new DataSet();
            


            if (ayaknumara.Text!="")

            {
                //TRUNCATE TABLE tablo adı
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                
                SqlCommand ekle = new SqlCommand("insert into Sepet(kullanıcıadı,ayakkabıismi,ayakkabırenk,ayakkabıaçıklama,ayakkabınumara,ayakkabıfiyat,ayakkabıfoto) values('" + KullanıcıAdı.Text + "','" + ayakismi.Text + "','" + ayakrenk.Text + "','" + açıklama.Text + "','" + ayaknumara.Text + "','" + fiyat.Text + "' ,'" + dosya.Text + "' )", baglanti);
                // SqlCommand komut = new SqlCommand("insert into Sepet(ayakkabıfoto) values(@images)", baglanti);
                //komut.Parameters.AddWithValue("@images", ana.ImageLocation);

                ekle.ExecuteNonQuery();
                //komut.ExecuteNonQuery();

                

                // SqlCommand sqlCommand = new SqlCommand("INSERT INTO Sepet (ayakkabıfoto) VALUES (@Image)", baglanti);


                baglanti.Close();
             
                MessageBox.Show(ayakkabıismi +" "+" \nİsimli Ayakkabı Sepete \nBaşarıyla Eklenmiştir.");
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

        private void gunaImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           

           
           
            
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
