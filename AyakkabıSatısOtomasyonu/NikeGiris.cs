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
    public partial class NikeGiris : Form
    {
        Baglanti bgl = new Baglanti();
        public NikeGiris()
        {
            InitializeComponent();
        }
        public static string kullanıcıadi= "";
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://agreementservice.svs.nike.com/rest/agreement?agreementType=privacyPolicy&country=TR&language=tr&mobileStatus=false&requestType=redirect&uxId=com.nike.commerce.nikedotcom.web");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://agreementservice.svs.nike.com/rest/agreement?agreementType=termsOfUse&country=TR&language=tr&mobileStatus=false&requestType=redirect&uxId=com.nike.commerce.nikedotcom.web");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guna2Panel2.SendToBack();
            guna2Panel3.Visible = true;
            guna2Panel3.BringToFront();
            guna2ImageButton1.Visible = true;
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            guna2Panel3.Visible = false;
            guna2ImageButton1.Visible = false;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (guna2TextBox3.Text == "" || guna2TextBox2.Text == "")
            {
                MessageBox.Show("Lütfen Bütün Bilgileri Doldurunuz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guna2TextBox3.Clear();
                guna2TextBox2.Clear();
                return;
                
            }


            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            string kadi = guna2TextBox3.Text;
            string parola = guna2TextBox2.Text;
            baglanti.Open();
            string sql = "select * from KayıtMusteri where kullanıcıadı = @kullaniciadi and sifre = @sifre";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.Add(new SqlParameter("@kullaniciadi", kadi));
            komut.Parameters.Add(new SqlParameter("@sifre", parola));

            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                kullanıcıadi = reader[3].ToString();
                Erkek ek = new Erkek();
                ek.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guna2TextBox3.Clear();
                guna2TextBox2.Clear();
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();

            SqlCommand ekle = new SqlCommand("insert into KayıtMusteri(adı,soyadı,kullanıcıadı,sifre,dogumtarihi) values('" + adı.Text + "','" + soyadı.Text + "','" + kullanıcıadı.Text + "','" + sifre.Text + "','" + dogumtarihi.Text + "')", baglanti);
            ekle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı");
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
