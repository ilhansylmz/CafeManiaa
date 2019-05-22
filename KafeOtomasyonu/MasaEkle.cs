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

    public partial class MasaEkle : Form
    {

        int sil;
        int id;
        SqlConnection con = new System.Data.SqlClient.SqlConnection("Server=185.153.229.94;Database=KafeOtomasyonu;User Id=sem54;Password=sem54;");
        public MasaEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand masaekle = new SqlCommand("INSERT INTO masalar(masaAdi,durum,adisyonId)VALUES (@a,0,0)", con);
            masaekle.Parameters.AddWithValue("a", lblmasa.Text + txtmasano.Text);

            

            MessageBox.Show(masaekle.ExecuteNonQuery() + " Eklendi.");

            con.Close();

         ;
         
            
        }

        private void MasaEkle_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand masaekle = new SqlCommand("delete from masalar where masaAdi=@a", con);
            masaekle.Parameters.AddWithValue("a", lblmasa.Text + txtmasano.Text);
            MessageBox.Show(masaekle.ExecuteNonQuery() + " Silindi.");
            
            
            con.Close();
           
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand masaguncelle = new SqlCommand("update masalar set masaAdi=@b where masaAdi=@c ", con);
            masaguncelle.Parameters.AddWithValue("c", lblmasa.Text +txtguncellemasa.Text);
            masaguncelle.Parameters.AddWithValue("b", lblmasa.Text + txtyenimasa.Text);
          
            MessageBox.Show(masaguncelle.ExecuteNonQuery() + " Güncellendi.");
            con.Close();
        }
    }
}
