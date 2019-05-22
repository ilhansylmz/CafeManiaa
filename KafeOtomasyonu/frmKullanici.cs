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
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        public SqlConnection con { get; internal set; }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            kulllaniciGetir();
        }

        private void kulllaniciGetir()//Kullanıcı çağırmak için fonksiyon yazıyoruz.
        {
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM users", con);//users tablasonu çağırıyoruz
            SqlDataAdapter da = new SqlDataAdapter(cmd);//Datagriedviewe bağlanmak için data adapter oluşturuyoruz 

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt; //Çağırılan verileri dataGridViewe ekliyoruz.
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE id =" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), con);//İdye göre kullanıcıyı siliyoruz.

                if (cmd.ExecuteNonQuery() > 0)
                    kulllaniciGetir();
            }
            else
            {
                MessageBox.Show("Seçili Kullanıcı Bulunamadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//Kullanıcı yok ise uyarı mesajı veriyoruz.
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtSifreTekrar.Text)//Şifre kontrolü
            {
                if (txtKadi.Text.Length > 0 && txtSifreTekrar.Text.Length > 0)//0 dan büyük uzunlukta olması gerekiyor.
                {
                    if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                        con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO users(kadi,sifre) VALUES('" + txtKadi.Text + "','" + txtSifre.Text + "')", con);//Kullanıcı ekleniyor.
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        kulllaniciGetir();//Kullanıcıyı data gridwieve getiriyoruz
                        txtKadi.Text = "";
                        txtSifre.Text = "";
                        txtSifreTekrar.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Şifreler Birbiriyle Uyuşmamaktadır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
