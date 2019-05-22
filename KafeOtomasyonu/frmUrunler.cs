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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }

        public SqlConnection con { get; internal set; }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            cmbKategori.SelectedIndex = 0;

            listeGetir();
        }

        private void listeGetir()//listview1 çağırma fonksiyonu oluşturduk.
        {
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM urunler", con);//Ürünleri çağırıyoruz.
            SqlDataReader dr = cmd.ExecuteReader();

            listView1.Items.Clear();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["urun"].ToString());
                item.SubItems.Add(dr["kategori"].ToString());
                item.SubItems.Add(dr["fiyat"].ToString());
                listView1.Items.Add(item);//Listview1'e ürünleri listeliyoruz.
            }
            dr.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text.Length > 0 && txtFiyat.Text.Length > 0)//Ürün adının uzunluğu ve fiyatın uzunluğu 0 dan büyük mü kontrolü yapıyoruz.
            {
                if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO urunler(urun,kategori,fiyat) VALUES('" + txtUrunAdi.Text + "','" + cmbKategori.SelectedItem + "'," + txtFiyat.Text.Replace(",", ".") + ")", con);//Ürünler tablosuna ürünü ekliyoruz.
                if (cmd.ExecuteNonQuery() > 0)
                {
                    listeGetir();//Listview1 listemele fonksiyonunu çağırıyoruz.
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM urunler WHERE id = " + listView1.SelectedItems[0].SubItems[0].Text, con);//Seçili ürünü IDsine göre siliyoruz.
                if (cmd.ExecuteNonQuery() > 0)
                    listeGetir();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
