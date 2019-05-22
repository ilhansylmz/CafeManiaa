using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace KafeOtomasyonu
{
   
    public partial class Raporlar : Form
    {
        SqlConnection com = new SqlConnection("Server=185.153.229.94;Database=KafeOtomasyonu;User Id=sem54;Password=sem54;");
        DataSet ds = new DataSet();
        DataTable tablo = new DataTable();
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            
    }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Remove();
            }
            com.Open();

            SqlCommand getir2 = new SqlCommand("select masaAdi,ucret,baslamaTarihi from adisyon where DATEDIFF(year,baslamaTarihi,GETDATE())<31", com);
            SqlDataReader yeni = getir2.ExecuteReader();

            while (yeni.Read())
            {
                string[] row = { yeni["masaAdi"].ToString(), yeni["ucret"].ToString(), yeni["baslamaTarihi"].ToString().Replace(",", ".") };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);

            }
            com.Close();
            double toplam = 0;
            double genel = 0;
            foreach (ListViewItem item in listView1.Items)
            {

                double fiyat = Convert.ToDouble(item.SubItems[1].Text);

                toplam += fiyat / 30;//Fiyat bilgisini alıyoruz
                genel += fiyat;



            }
            lblaylıkucret.Text = toplam + " TL";
            label5.Text = genel + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Remove();
            }
            
            com.Open();

            SqlCommand getir2 = new SqlCommand("select masaAdi,ucret,baslamaTarihi from adisyon where DATEDIFF(day,baslamaTarihi,GETDATE())<1", com);
            SqlDataReader yeni = getir2.ExecuteReader();

            while (yeni.Read())
            {
                string[] row = { yeni["masaAdi"].ToString(), yeni["ucret"].ToString(), yeni["baslamaTarihi"].ToString().Replace(",", ".") };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);

            }
            com.Close();
            double toplam = 0;

            foreach (ListViewItem item in listView1.Items)
            {

                double fiyat = Convert.ToDouble(item.SubItems[1].Text);

                toplam += fiyat /1 ;//Fiyat bilgisini alıyoruz




            }
            lblgunlukucret.Text = toplam + " TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Remove();
            }

            com.Open();

            SqlCommand getir2 = new SqlCommand("select masaAdi,ucret,baslamaTarihi from adisyon where DATEDIFF(year,baslamaTarihi,GETDATE())<366", com);
            SqlDataReader yeni = getir2.ExecuteReader();

            while (yeni.Read())
            {
                string[] row = { yeni["masaAdi"].ToString(), yeni["ucret"].ToString(), yeni["baslamaTarihi"].ToString().Replace(",", ".") };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);

            }
            com.Close();
            double toplam = 0;
            double genel = 0;
            foreach (ListViewItem item in listView1.Items)
            {

                double fiyat = Convert.ToDouble(item.SubItems[1].Text);

                toplam += fiyat / 365;//Fiyat bilgisini alıyoruz
                genel += fiyat;


            }
            lblyıllıkucret.Text = toplam + " TL";
            label7.Text = genel + "TL";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            double genel = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                int adet = Convert.ToInt16(item.SubItems[2].Text);
                double fiyat = Convert.ToDouble(item.SubItems[3].Text);

                toplam += adet * fiyat;//Fiyat bilgisini alıyoruz




            }
            lblaylıkucret.Text = toplam + " TL";


        }
        
    }
    }
