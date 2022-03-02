using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyakkabıSatısOtomasyonu
{
    public partial class Ayarlar : Form
    {
        Baglanti bgl = new Baglanti();
        string kullanıcıadi = NikeGiris.kullanıcıadi;
        public Ayarlar()
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

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            Çocuk çocuk = new Çocuk();
            çocuk.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Favoriler fav = new Favoriler();
            fav.Show();
            this.Hide();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Sipariş sipariş = new Sipariş();
            sipariş.Show();
            this.Hide();
        }
        public void tablo()
        {
            DataTable tbl = new DataTable();
            KullanıcıAdı.Text = kullanıcıadi;
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();


            SqlDataAdapter adtr = new SqlDataAdapter("Select * from KayıtMusteri where kullanıcıadı='" + KullanıcıAdı.Text + "'", baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;


            baglanti.Close();
        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            tablo();
            KullanıcıAdı.Text = kullanıcıadi;
            label3.Text = kullanıcıadi;
          
            adı.Text = dataGridView1.CurrentRow.Cells["adı"].Value.ToString();
            soyadı.Text = dataGridView1.CurrentRow.Cells["soyadı"].Value.ToString();
            guna2TextBox1.Text = dataGridView1.CurrentRow.Cells["kullanıcıadı"].Value.ToString();
            sifre.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();


        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();

            SqlCommand guncelle = new SqlCommand("UPDATE KayıtMusteri set kullanıcıadı='" + guna2TextBox1.Text + "',sifre='" + sifre.Text + "' where id ='" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            guncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            tablo();
            MessageBox.Show("Programın düzgün çalışabilmesi için Yeniden Başlatılıyor...");
            Application.Restart();

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            NikeGiris nk = new NikeGiris();
            nk.Show();
            this.Hide();
        }
    }
}
