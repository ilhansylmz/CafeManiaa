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
    public partial class frmLogin : Form
    {
      
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=185.153.229.94;Database=KafeOtomasyonu;User Id=sem54;Password=sem54;"); //sql bağlantısı
        //SqlConnection con = new SqlConnection("Server=.\\SQLEXPRESS;Database=KafeOtomasyonu;Trusted_Connection=True;");

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close(); // Çıkış butonu
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed) //Veritabanı bağlantı kontroloü
                con.Open();
            #region Kullanıcı Giriş Kontrol

            SqlCommand cmd = new SqlCommand("SELECT id FROM users WHERE kadi = '" + txtKadi.Text + "' AND sifre = '" + txtSifre.Text + "'", con);//Kullanıcının giriş bilgilerini kontrol ediyorç
            SqlDataReader dr = cmd.ExecuteReader(); 
            #endregion
            #region Kullanıcı Log Ekleme kontrolü

            if (dr.HasRows) // satır kontrolü
            {
                dr.Close();
                SqlCommand cmdLog = new SqlCommand("INSERT INTO userLoginLog (kadi,durum) VALUES ('" + txtKadi.Text + "',1)", con);//Veritabanına kullanıcı logu tutuyor.
                cmdLog.ExecuteScalar();//Tek sonuc yazılacağından execute scaler kullanıldı.
                this.Hide();//Bu formu gizle.
              
                frmAna ana = new frmAna();
                ana.con = this.con;
                ana.lblKullanici.Text = txtKadi.Text;
                ana.label2.Text = txtSifre.Text;
                ana.ShowDialog();
                this.Close();

            }
            else // Kulanncı bilgileri yanlış ise hata mesajı gönder.
            {
                txtKadi.Clear();
                txtSifre.Clear();
                MessageBox.Show("Kullanıcı Bilgileri Hatalı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtKadi.Focus();
            }

            dr.Close(); 
            #endregion
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
//#if DEBUG
//            txtKadi.Text = "a";
//            txtSifre.Text = "a";
//            btnLogin_Click(null, null);
//#endif
        }
    }
}
