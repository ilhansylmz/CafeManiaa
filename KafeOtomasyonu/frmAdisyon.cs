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
    public partial class frmAdisyon : Form
    {
        public frmAdisyon()
        {
            InitializeComponent();
        }

        public int adisyonId;
        public int masaId;
        public SqlConnection con;

        private void frmAdisyon_Load(object sender, EventArgs e)
        {
            adisyonAyrinti();
        }

        private void adisyonAyrinti()//Adisyon ayrıntıları için fonksiyon oluşturuyoruz.
        {
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM adisyonAyrinti WHERE adisyonId = " + adisyonId, con);//Adisyon ID ye göre adisyon ayrıntı tablosunu çağırıyoruz.
            SqlDataReader dr = cmd.ExecuteReader();

            listView2.Items.Clear();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["urun"].ToString());
                item.SubItems.Add(dr["adet"].ToString());
                item.SubItems.Add(dr["fiyat"].ToString());
                listView2.Items.Add(item);//Gelen bilgileri listwiev2'ye ekliyoruz.
            }
            dr.Close();

            double toplam = 0;
            double genel = 0;
            foreach (ListViewItem item in listView2.Items)
            {
                int adet = Convert.ToInt16(item.SubItems[2].Text);
                double fiyat = Convert.ToDouble(item.SubItems[3].Text);

                toplam += adet * fiyat;//Fiyat bilgisini alıyoruz

                

              
            }
            txtFiyat.Text = toplam + " TL";
         
             
            
        }
       
      

        private void btnYemekTurleri_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string kategori = btn.Tag.ToString();//Değişken buton tag değerini atıyoruz.

            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM urunler WHERE kategori ='" + kategori + "'", con);//Kategoriye göre ürünler çağırılıyor.
            SqlDataReader dr = cmd.ExecuteReader();

            listView1.Items.Clear();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["urun"].ToString());
                item.SubItems.Add(dr["fiyat"].ToString());
                listView1.Items.Add(item);//List wiev1 e ürün adı ve ürün fiyatını yazdırıyoruz.
            }
            dr.Close();
        }

        private void btn_Sayilar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "C")
                txtAdet.Text = "1";
            else
            {
                txtAdet.Text = btn.Text;
            }
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                        con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO adisyonAyrinti(adisyonId,urun,fiyat,adet) VALUES(" + adisyonId + ",'" + listView1.SelectedItems[0].SubItems[0].Text + "'," + listView1.SelectedItems[0].SubItems[1].Text.Replace(",", ".") + "," + txtAdet.Text + ")", con);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        txtAdet.Text = "1";
                        adisyonAyrinti();//Adisyon ayrıltıları eklendikten sonra listview 2 değerlerini getiriyor.Bu Fonksiyonu yukarda yazmıştık.
                    }
                }
                else
                {
                    MessageBox.Show("Seçili Ürün Bulunamadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//Ürün seçili değil ise hata mesajı veriyoruz.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM adisyonAyrinti WHERE id = " + listView2.SelectedItems[0].SubItems[0].Text, con);//btn iptale basılırsa listwiev2 deki seçili elemanı silsin.
                if (cmd.ExecuteNonQuery() > 0)
                    adisyonAyrinti();
            }
            else
            {
                MessageBox.Show("Seçili Ürün Bulunamadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            adisyonAyrinti();

            DialogResult result = MessageBox.Show("Ödeme Tutarı : " + txtFiyat.Text + "\nAdisyonu Kapatmak İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE adisyon SET bitisTarihi='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', ucret=" + txtFiyat.Text.Replace(",", ".").Replace("TL", "").Replace(" ", "") + " WHERE id=" + adisyonId, con);//Ödeme butonuna basılırsa adisyon logları tutuluyor.

                if (cmd.ExecuteNonQuery() > 0)
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE masalar SET durum=0, adisyonId=0 WHERE id=" + masaId, con);//masa durumu id'ye göre güncelleniyor.

                    if (cmd2.ExecuteNonQuery() > 0)
                        this.Close();
                }
            }
        }
    }
}
