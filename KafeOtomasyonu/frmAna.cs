using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KafeOtomasyonu
{
     

    public partial class frmAna : Form
    {
      
        public frmAna()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        List<string> adisyonlar = new List<string>();//Adisyon numarası için List oluşturuldu.

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//Çıkış Butonu.
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            masalariGetir();
           
           

        }

        private void masalariGetir()//Veritabanından masaları getirmek için fonksiyon yazıldı.
        {
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * from masalar", con);
            SqlDataReader dr = cmd.ExecuteReader();

            lvMasalar.Clear();
            adisyonlar.Clear();
            while (dr.Read())
            {
                lvMasalar.Items.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToByte(dr[2].ToString())); //Masaadı,MasaDurumu,Adisyon numarası lvlmasalar list viewini eklendi.
                adisyonlar.Add(dr[3].ToString());//Adisyon ID si masalar tablasundan alınmıştı ve adisyonar listine eklendi.
            }

            dr.Close();
        }

        private void masalarıYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            masalariGetir();//Masalar kısmını yenilemek için tekrar çağırdık.
        }

        private void lvMasalar_DoubleClick(object sender, EventArgs e)//Masaya tıklandığında 
        {
            frmAdisyon adisyon = new frmAdisyon(); //Sipariş kısmında nesne oluştur.
            adisyon.con = this.con;
            adisyon.masaId = Convert.ToInt32(lvMasalar.SelectedItems[0].Name);
            adisyon.Text = "Adisyon - Masa : " + lvMasalar.SelectedItems[0].Text;//Form adı alındı.

            SqlCommand cmd = new SqlCommand("SELECT adisyonId FROM masalar WHERE id = " + lvMasalar.SelectedItems[0].Name, con);// Seçili masanın adisyonId sini çağırır.
            SqlDataReader dr = cmd.ExecuteReader();

            int adisyonId = 0;
            while (dr.Read())
            {
                adisyonId = Convert.ToInt32(dr[0].ToString()); // Çağırılan adisyon id adisyon idye yazdırıldı.
            }
            dr.Close();

            if (adisyonId == 0)//Adisyon id 0 durumunda ise 
            {
                if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)//Bağlantı hatalı veya kapalıysa 
                    con.Open();//bağlantıyı aç

                SqlCommand cmdLog = new SqlCommand("INSERT INTO adisyon (masaAdi) VALUES ('" + lvMasalar.SelectedItems[0].Text + "');SELECT SCOPE_IDENTITY();", con);//Adisyon veritabanına masa adını ekledi.
                adisyonId = Convert.ToInt32(cmdLog.ExecuteScalar()); //Son İd değerini döndürür.
            }
            //else
            //{
            //    SqlCommand cmdMasaAdisyonUpdate = new SqlCommand("UPDATE masalar SET durum=1, adisyonId=" + adisyonId + " WHERE id = " + lvMasalar.SelectedItems[0].Name, con);
            //    cmdMasaAdisyonUpdate.ExecuteScalar();

            //    adisyon.adisyonId = adisyonId;
            //}


            adisyon.adisyonId = adisyonId;//adisyon sınıfındaki adisyon değişkenine adisyon değerini yolladık.

            SqlCommand cmdMasaAdisyonUpdate = new SqlCommand("UPDATE masalar SET durum=1, adisyonId=" + adisyonId + " WHERE id = " + lvMasalar.SelectedItems[0].Name, con);//Masalar veritabanına masa ismine göre adisyon numarası ekledik ve masayı açık hale getirdik.
            cmdMasaAdisyonUpdate.ExecuteScalar();

            adisyon.ShowDialog();

            masalariGetir();
        }

        private void frmAna_FormClosing(object sender, FormClosingEventArgs e)//Kullanıcı çıkış yaparsa
        {
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmdLog = new SqlCommand("INSERT INTO userLoginLog (kadi,durum) VALUES ('" + lblKullanici.Text + "',0)", con);//Kullanıcı logları sayfasında kullanıcı çıkış tarihi yazıcak ve durumu 0 olucak.
            cmdLog.ExecuteScalar();
        }

        private void urunAyarlariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblKullanici.Text == "admin" && label2.Text == "admin")
            {
                frmUrunler urunler = new frmUrunler();//Ürün ayarları sayfası açılır.
                urunler.con = this.con;
                urunler.ShowDialog();

            }
            else {
                MessageBox.Show("Bu işlemi sadece yöneticiler yapabilir.");
            }



    }

        private void kullaniciAyarlariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblKullanici.Text == "admin" && label2.Text == "admin")
            {
                frmKullanici kullanici = new frmKullanici();//Kullanıcı bilgileri düzenlenmesi yapar.
                kullanici.con = this.con;
                kullanici.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu işlemi sadece yöneticiler yapabilir.");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lblKullanici.Text == "admin" && label2.Text == "admin")
            {
                Raporlar rapor = new Raporlar();
                rapor.ShowDialog();
            }

            else
            {
                MessageBox.Show("Bu işlemi sadece yöneticiler yapabilir.");
            }
        }

        private void Masaekle_Click(object sender, EventArgs e)
        {
            if (lblKullanici.Text == "admin" && label2.Text == "admin")
            {
                MasaEkle ekle = new MasaEkle();
                ekle.Show();
            }
            else
            {
                MessageBox.Show("Bu işlemi sadece yöneticiler yapabilir.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
         
        }

        private void hesapDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin getir = new frmLogin();
            this.Close();
            this.Hide();
            getir.ShowDialog();
        }
    }
}
