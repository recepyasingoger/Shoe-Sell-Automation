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
    public partial class Favoriler : Form
    {
        public static string ayakkabıismi = "";
        Baglanti bgl = new Baglanti();
        string kullanıcıadi = NikeGiris.kullanıcıadi;
        public Favoriler()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Erkek erkek = new Erkek();
            erkek.Show();
            this.Hide();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Sipariş sipariş = new Sipariş();
            sipariş.Show();
            this.Hide();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            Çocuk çocuk = new Çocuk();
            çocuk.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            Kadın kdn = new Kadın();
            kdn.Show();
            this.Hide();
        }

        

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
           
        }

        public void tablo()
        {
            DataTable tbl = new DataTable();
            KullanıcıAdı.Text = kullanıcıadi;
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();


            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Favoriler where kullanıcıadı='" + KullanıcıAdı.Text + "'", baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;


            baglanti.Close();
        }
        private void Favoriler_Load(object sender, EventArgs e)
        {
         
            tablo();
            //if (dataGridView1.Rows[0] == null)
            //{
            //    ana2.Image = null;
            //    katext2.Text = "";
            //    ana3.Image = null;
            //    katext3.Text = "";
            //    ana.Image = null;
            //    katext1.Text = "";
            //}
            //else
            //{

            //}
           

            int i = dataGridView1.Rows.Count;
            for (int j = 0; j < i; j++)
            {
                


                if (dataGridView1.Rows[j].Cells[0].Value != null)
                {
                    katext1.Text = dataGridView1.Rows[j].Cells["ayakkabıfoto"].Value.ToString();
                    ayakismi.Text = dataGridView1.Rows[j].Cells["ayakkabıismi"].Value.ToString();
                    açıklama.Text = dataGridView1.Rows[j].Cells["ayakkabıaçıklama"].Value.ToString();
                    ayaknumara.Text = dataGridView1.Rows[j].Cells["ayakkabınumara"].Value.ToString();
                    fiyat.Text = dataGridView1.Rows[j].Cells["ayakkabıfiyat"].Value.ToString();
                    renk.Text = dataGridView1.Rows[j].Cells["ayakkabırenk"].Value.ToString();
                    ana.Image = Image.FromFile(katext1.Text);
                   
                }
            }
          





        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ayaknumara_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            tablo();
            ayakkabıismi = ayakismi.Text;
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from Favoriler where kullanıcıadı='" + KullanıcıAdı.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show(ayakkabıismi + " " + " \nİsimli Ayakkabı Favorilerden Başarıyla Silinmiştir.");
                baglanti.Close();
                
                ayakismi.Text = null;
                ana.Visible = false;
                ayakismi.Visible = false;
                ayaknumara.Visible = false;
                renk.Visible = false;
                fiyat.Visible = false;
                açıklama.Visible = false;
                label2.Visible = false;
                guna2ImageButton6.Visible = false;

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message); ;
            }
            dataGridView1.Refresh();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            NikeGiris nk = new NikeGiris();
            nk.Show();
            this.Hide();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            tablo();
            ayakkabıismi = ayakismi.Text;
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            if (ayakismi.Visible==false)
            {
                MessageBox.Show("Favoriler Ekranında Ayakkabı Yoktur.");

                
            }
            else
            {
                SqlCommand ekle = new SqlCommand("insert into Sepet(kullanıcıadı,ayakkabıismi,ayakkabırenk,ayakkabıaçıklama,ayakkabınumara,ayakkabıfiyat,ayakkabıfoto) values('" + KullanıcıAdı.Text + "','" + ayakismi.Text + "','" + renk.Text + "','" + açıklama.Text + "','" + ayaknumara.Text + "','" + fiyat.Text + "' ,'" + katext1.Text + "' )", baglanti);
                // SqlCommand komut = new SqlCommand("insert into Sepet(ayakkabıfoto) values(@images)", baglanti);
                //komut.Parameters.AddWithValue("@images", ana.ImageLocation);

                ekle.ExecuteNonQuery();
                //komut.ExecuteNonQuery();



                // SqlCommand sqlCommand = new SqlCommand("INSERT INTO Sepet (ayakkabıfoto) VALUES (@Image)", baglanti);


                baglanti.Close();
                MessageBox.Show(ayakkabıismi + " " + " \nİsimli Ayakkabı Sepete \nBaşarıyla Eklenmiştir.");
            }
            }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton4_Click_1(object sender, EventArgs e)
        {
            Ayarlar ayar = new Ayarlar();
            ayar.Show();
            this.Hide();
        }
    }
    }

