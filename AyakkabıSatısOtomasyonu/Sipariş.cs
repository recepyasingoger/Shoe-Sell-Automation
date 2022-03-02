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
    
    public partial class Sipariş : Form
    {
        
        
        Baglanti bgl = new Baglanti();
        public static string tcno = "";
        string kullanıcıadi = NikeGiris.kullanıcıadi;
        public Sipariş()
        {
            InitializeComponent();
        }
        
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        string KartNoTemizle(string text)
        {
            text = text.Replace("-", "").Replace(" ", "").Replace("(", "").Replace(")", "").Replace("_", "");
            return text;
        }
        bool KartNoUzunlukKontrol(string kartno)
        {
            if (kartno.Length == 16)
                return true;
            else
                return false;
        }
        bool SayisalDegerKontrol(string deger)
        {
            foreach (char chr in deger)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        int SayiBasamaklariTopla(int sayi)
        {
            int toplam = 0;
            while (sayi > 0)
            {
                toplam += sayi % 10;
                sayi /= 10;
            }
            return toplam;
        }
        bool Kredi_Kart_Lunh_Algoritmasi(string kartno)
        {
            kartno = KartNoTemizle(kartno); // kart numarasını temizledik.

            if (KartNoUzunlukKontrol(kartno) == false) // uzunluğu kontrol ettik
                return false;
            else if (SayisalDegerKontrol(kartno) == false) // sayısal değerleri kontrol ettik
                return false;
            else
            {
                int ciftlerin_toplami = 0;
                int teklerin_toplami = 0;
                for (int i = 0; i < kartno.Length; i++)
                {
                    int eleman = Convert.ToInt32(kartno[i].ToString());
                    if (i % 2 == 0)
                        ciftlerin_toplami += SayiBasamaklariTopla(eleman * 2);
                    else
                        teklerin_toplami += eleman;
                }
                int sonuc = (teklerin_toplami + ciftlerin_toplami) % 10;
                if (sonuc == 0)
                    return true;
                else
                    return false;
            }
        }
        public void tablo()
        {
            DataTable tbl = new DataTable();

            
          
            
            KullanıcıAdı.Text = kullanıcıadi;
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();


            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Sepet where kullanıcıadı='" + KullanıcıAdı.Text + "'", baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            
            
            baglanti.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tcno = tc.Text;
            iletisim.SendToBack();
            Ödeme.Visible = true;
            Ödeme.BringToFront();
            label9.Visible = false;
            adet.Visible = false;
            

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
           Ödeme.Visible = false;
            iletisim.BringToFront();
            label9.Visible = true;
            adet.Visible = true;
            label5.Visible = false;
            guna2PictureBox4.Visible = false;
            guna2PictureBox1.Visible = true;
            guna2ImageButton6.Visible = true;
            fiyattoplam.Visible = true;
            basarısız.Visible = false;
            basarısıztext.Visible = false;
        }
        public void Hesapla()
        {
            double adet = Convert.ToDouble(this.adet.Value);
            double fiyat = Convert.ToDouble(this.fiyat.Text);
            double toplam = adet * fiyat;
            fiyattoplam.Text = Convert.ToString(toplam);


        }
        private void Sipariş_Load(object sender, EventArgs e)
        {

            Tarih.Text = DateTime.Now.ToLongDateString(); // sadece tarih
            basarısız.Visible = false;
            basarısıztext.Visible = false;
            iletisim.BringToFront();
            label9.Visible = true;
            adet.Visible = true;
            label5.Visible = false;
            guna2PictureBox4.Visible = false;
            guna2PictureBox1.Visible =true;
            
            Hesapla();
            guna2ImageButton6.Visible = true;
            fiyattoplam.Visible = true;
            tablo();
            int i = dataGridView1.Rows.Count;
            for (int j = 0; j < i; j++)
            {



                if (dataGridView1.Rows[j].Cells[0].Value != null)
                {
                    katext1.Text = dataGridView1.Rows[j].Cells["ayakkabıfoto"].Value.ToString();
                    ayakkabıismi.Text = dataGridView1.Rows[j].Cells["ayakkabıismi"].Value.ToString();
                    ayakkabınumara.Text = dataGridView1.Rows[j].Cells["ayakkabınumara"].Value.ToString();
                    fiyat.Text = dataGridView1.Rows[j].Cells["ayakkabıfiyat"].Value.ToString();
                    fiyattoplam.Text = dataGridView1.Rows[j].Cells["ayakkabıfiyat"].Value.ToString();
                    ayakkabırenk.Text = dataGridView1.Rows[j].Cells["ayakkabırenk"].Value.ToString();
                    guna2PictureBox1.Image = Image.FromFile(katext1.Text);

                }
            }

            
        }
     
    
       
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            tcno = tc.Text;
            

            if (tcno != "")
            {
                if (tcno.Length == 11)
                {
                    char[] rakamlar = tcno.ToCharArray();
                    int kural1 = 0, hane11 = rakamlar[10], hane10 = rakamlar[9];
                    //kural1: ilk 10 rakamın toplamının birler basamağı, 11. rakamı vermektedir.
                    for (int i = 0; i < 10; i++)
                    {
                        kural1 += Convert.ToInt32(rakamlar[i].ToString());
                    }
                    char[] birlerbasamagikural1 = kural1.ToString().ToCharArray();

                    int kural2tek = 0, kural2cift = 0;
                    //kural2:  1, 3, 5, 7 ve 9. rakamın toplamının 7 katı ile 2, 4, 6 ve 8. rakamın toplamının 9 katının toplamının birler basamağı 10. rakamı vermektedir.
                    for (int i = 0; i < 10; i += 2)
                    {
                        kural2tek += Convert.ToInt32(rakamlar[i].ToString());
                    }
                    for (int i = 1; i < 9; i += 2)
                    {
                        kural2cift += Convert.ToInt32(rakamlar[i].ToString());
                    }
                    char[] birlerbasamagikural2 = ((7 * kural2tek) + (9 * kural2cift)).ToString().ToCharArray();

                    int kural3 = 0;
                    //1, 3, 5, 7 ve 9. rakamın toplamının 8 katının birler basamağı 11. rakamı vermektedir.
                    for (int i = 0; i < 10; i += 2)
                    {
                        kural3 += Convert.ToInt32(rakamlar[i].ToString());
                    }
                    char[] birlerbasamagikural3 = (8 * kural3).ToString().ToCharArray();

                    if ((birlerbasamagikural1[birlerbasamagikural1.Length - 1] == hane11) && (birlerbasamagikural2[birlerbasamagikural2.Length - 1] == hane10) && (birlerbasamagikural3[birlerbasamagikural3.Length - 1] == hane11) && tcno != "00000000000")
                    {
                        if (kartadı.Text != "" || ay.Text!="" || yıl.Text != "" || cvv.Text != "")
                        {
                         
                            if (Kredi_Kart_Lunh_Algoritmasi(kartnumarası.Text) == true )
                            {


                                basarısız.Visible = false;
                                basarısıztext.Visible = false;
                                guna2PictureBox1.Visible = false;
                                label5.Visible = true;
                                guna2PictureBox4.Visible = true;
                                guna2ImageButton6.Visible = false;
                                fiyattoplam.Visible = false;

                                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                                baglanti.Open();
                                SqlCommand ekle = new SqlCommand("insert into Sipariş(kullanıcıadı,ayakkabıismi,ayakkabırenk,ayakkabınumara,fiyat,adet,ad,soyad,adres,sehir,tckimlik,telefon,eposta,kredikartıadı,kredikartınumara,kredikartıay,kredikartıyıl,kredikartıcvv,tarih) values('" + KullanıcıAdı.Text + "','" + ayakkabıismi.Text + "','" + ayakkabırenk.Text +  "','" + ayakkabınumara.Text + "','" + fiyattoplam.Text + "' ,'" + adet.Text + "' ,'" + adı.Text + "' ,'" + soyadı.Text + "' ,'" + adres.Text + "' ,'" + sehir.Text + "' ,'" + tc.Text + "' ,'" + telefonnumarası.Text + "' ,'" + eposta.Text + "' ,'" + kartadı.Text + "' ,'" + kartnumarası.Text + "' ,'" + ay.Text + "' ,'" + yıl.Text + "' ,'" + cvv.Text + "','" + Tarih.Text+"' )", baglanti);
                                

                                ekle.ExecuteNonQuery();
                               



                               


                                baglanti.Close();
                            }
                            else
                            {
                                guna2PictureBox1.Visible = false;
                                label5.Visible = false;
                                guna2PictureBox4.Visible = false;
                                kartnumarası.Clear();
                                basarısız.Visible = true;
                                basarısıztext.Visible = true;
                            }
                           


                        }

                    else
                        {
                            guna2PictureBox1.Visible = false;
                            label5.Visible = false;
                            guna2PictureBox4.Visible = false;
                            kartnumarası.Clear();
                            basarısız.Visible = true;
                            basarısıztext.Visible = true;
                            kartadı.Clear();
                            ay.Clear();
                            yıl.Clear();
                            cvv.Clear();
                        }
                    }

                    else
                    {

                        MessageBox.Show("TC Kimlik Numarası Geçerli Değildir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
                else
                {
                    MessageBox.Show(" TC Kimlik Numaranızı Eksik Girdiniz Lütfen Kontrol Ediniz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

                MessageBox.Show(" TC Kimlik Numarası Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            


            }

            private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Erkek erkek = new Erkek();
            erkek.Show();
            this.Hide();
        }

        private void telefonnumarası_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            NikeGiris nk = new NikeGiris();
            nk.Show();
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

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Favoriler fav = new Favoriler();
            fav.Show();
            this.Hide();
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ödeme_Click(object sender, EventArgs e)
        {

        }

        private void yıl_TextChanged(object sender, EventArgs e)
        {
            yılkart.Text = yıl.Text;
        }

        private void kartnumarası_KeyUp(object sender, KeyEventArgs e)
        {
            label3.Text = kartnumarası.Text;
        }

        private void kartadı_TextChanged(object sender, EventArgs e)
        {
            label4.Text = kartadı.Text;
        }

        private void yılkart_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cvv_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void cvv_TextChanged(object sender, EventArgs e)
        {
            cvvkart.Text = cvv.Text;
        }

        private void ay_TextChanged(object sender, EventArgs e)
        {
            aykart.Text = ay.Text;
        }

        private void ay_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
