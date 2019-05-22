namespace KafeOtomasyonu
{
    partial class frmAdisyon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdisyon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAraSicak = new System.Windows.Forms.Button();
            this.btnMakarnalar = new System.Windows.Forms.Button();
            this.btnCorbalar = new System.Windows.Forms.Button();
            this.btnFastFood = new System.Windows.Forms.Button();
            this.btnSalatalar = new System.Windows.Forms.Button();
            this.btnTatlilar = new System.Windows.Forms.Button();
            this.btnIcecekler = new System.Windows.Forms.Button();
            this.btnAnaYemek = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAraSicak);
            this.groupBox1.Controls.Add(this.btnMakarnalar);
            this.groupBox1.Controls.Add(this.btnCorbalar);
            this.groupBox1.Controls.Add(this.btnFastFood);
            this.groupBox1.Controls.Add(this.btnSalatalar);
            this.groupBox1.Controls.Add(this.btnTatlilar);
            this.groupBox1.Controls.Add(this.btnIcecekler);
            this.groupBox1.Controls.Add(this.btnAnaYemek);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü";
            // 
            // btnAraSicak
            // 
            this.btnAraSicak.Location = new System.Drawing.Point(143, 187);
            this.btnAraSicak.Name = "btnAraSicak";
            this.btnAraSicak.Size = new System.Drawing.Size(125, 50);
            this.btnAraSicak.TabIndex = 7;
            this.btnAraSicak.Tag = "Ara Sıcak";
            this.btnAraSicak.Text = "Ara Sıcak";
            this.btnAraSicak.UseVisualStyleBackColor = true;
            this.btnAraSicak.Click += new System.EventHandler(this.btnYemekTurleri_Click);
            // 
            // btnMakarnalar
            // 
            this.btnMakarnalar.Location = new System.Drawing.Point(12, 187);
            this.btnMakarnalar.Name = "btnMakarnalar";
            this.btnMakarnalar.Size = new System.Drawing.Size(125, 50);
            this.btnMakarnalar.TabIndex = 6;
            this.btnMakarnalar.Tag = "Makarna";
            this.btnMakarnalar.Text = "Makarna";
            this.btnMakarnalar.UseVisualStyleBackColor = true;
            this.btnMakarnalar.Click += new System.EventHandler(this.btnYemekTurleri_Click);
            // 
            // btnCorbalar
            // 
            this.btnCorbalar.Location = new System.Drawing.Point(143, 131);
            this.btnCorbalar.Name = "btnCorbalar";
            this.btnCorbalar.Size = new System.Drawing.Size(125, 50);
            this.btnCorbalar.TabIndex = 5;
            this.btnCorbalar.Tag = "Çorba";
            this.btnCorbalar.Text = "Çorbalar";
            this.btnCorbalar.UseVisualStyleBackColor = true;
            this.btnCorbalar.Click += new System.EventHandler(this.btnYemekTurleri_Click);
            // 
            // btnFastFood
            // 
            this.btnFastFood.Location = new System.Drawing.Point(12, 131);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(125, 50);
            this.btnFastFood.TabIndex = 4;
            this.btnFastFood.Tag = "Fast Food";
            this.btnFastFood.Text = "Fast Food";
            this.btnFastFood.UseVisualStyleBackColor = true;
            this.btnFastFood.Click += new System.EventHandler(this.btnYemekTurleri_Click);
            // 
            // btnSalatalar
            // 
            this.btnSalatalar.Location = new System.Drawing.Point(143, 75);
            this.btnSalatalar.Name = "btnSalatalar";
            this.btnSalatalar.Size = new System.Drawing.Size(125, 50);
            this.btnSalatalar.TabIndex = 3;
            this.btnSalatalar.Tag = "Salata";
            this.btnSalatalar.Text = "Salatalar";
            this.btnSalatalar.UseVisualStyleBackColor = true;
            this.btnSalatalar.Click += new System.EventHandler(this.btnYemekTurleri_Click);
            // 
            // btnTatlilar
            // 
            this.btnTatlilar.Location = new System.Drawing.Point(12, 75);
            this.btnTatlilar.Name = "btnTatlilar";
            this.btnTatlilar.Size = new System.Drawing.Size(125, 50);
            this.btnTatlilar.TabIndex = 2;
            this.btnTatlilar.Tag = "Tatlı";
            this.btnTatlilar.Text = "Tatlılar";
            this.btnTatlilar.UseVisualStyleBackColor = true;
            this.btnTatlilar.Click += new System.EventHandler(this.btnYemekTurleri_Click);
            // 
            // btnIcecekler
            // 
            this.btnIcecekler.Location = new System.Drawing.Point(143, 19);
            this.btnIcecekler.Name = "btnIcecekler";
            this.btnIcecekler.Size = new System.Drawing.Size(125, 50);
            this.btnIcecekler.TabIndex = 1;
            this.btnIcecekler.Tag = "İçecek";
            this.btnIcecekler.Text = "İçecekler";
            this.btnIcecekler.UseVisualStyleBackColor = true;
            this.btnIcecekler.Click += new System.EventHandler(this.btnYemekTurleri_Click);
            // 
            // btnAnaYemek
            // 
            this.btnAnaYemek.Location = new System.Drawing.Point(12, 19);
            this.btnAnaYemek.Name = "btnAnaYemek";
            this.btnAnaYemek.Size = new System.Drawing.Size(125, 50);
            this.btnAnaYemek.TabIndex = 0;
            this.btnAnaYemek.Tag = "Ana Yemek";
            this.btnAnaYemek.Text = "Ana Yemek";
            this.btnAnaYemek.UseVisualStyleBackColor = true;
            this.btnAnaYemek.Click += new System.EventHandler(this.btnYemekTurleri_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 501);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adisyon";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(3, 16);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(277, 231);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün Adı";
            this.columnHeader4.Width = 161;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adet";
            this.columnHeader5.Width = 43;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fiyat";
            this.columnHeader6.Width = 69;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFiyat);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtAdet);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.btnOdeme);
            this.groupBox4.Controls.Add(this.btnSiparis);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.btnIptal);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(566, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 501);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adisyon İşlemleri";
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.SystemColors.Control;
            this.txtFiyat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiyat.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.ForeColor = System.Drawing.Color.Red;
            this.txtFiyat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtFiyat.Location = new System.Drawing.Point(57, 387);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.ReadOnly = true;
            this.txtFiyat.Size = new System.Drawing.Size(65, 33);
            this.txtFiyat.TabIndex = 5;
            this.txtFiyat.Text = "0 TL";
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplam Tutar";
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(16, 23);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(162, 46);
            this.txtAdet.TabIndex = 11;
            this.txtAdet.Text = "1";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(128, 187);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 8;
            this.button9.Tag = "";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btn_Sayilar_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(128, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 5;
            this.button6.Tag = "";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn_Sayilar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 2;
            this.button3.Tag = "";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Sayilar_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.Location = new System.Drawing.Point(16, 439);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(162, 50);
            this.btnOdeme.TabIndex = 14;
            this.btnOdeme.Tag = "";
            this.btnOdeme.Text = "Ödeme";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Location = new System.Drawing.Point(100, 299);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(78, 50);
            this.btnSiparis.TabIndex = 12;
            this.btnSiparis.Tag = "";
            this.btnSiparis.Text = "Sipariş";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(128, 243);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 50);
            this.button11.TabIndex = 9;
            this.button11.Tag = "";
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btn_Sayilar_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(72, 187);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 7;
            this.button8.Tag = "";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btn_Sayilar_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(16, 299);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(78, 50);
            this.btnIptal.TabIndex = 13;
            this.btnIptal.Tag = "";
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(72, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 4;
            this.button5.Tag = "";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_Sayilar_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(16, 243);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(106, 50);
            this.button10.TabIndex = 10;
            this.button10.Tag = "";
            this.button10.Text = "C";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btn_Sayilar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.Tag = "";
            this.button1.Text = "2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Sayilar_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 187);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 6;
            this.button7.Tag = "";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_Sayilar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 3;
            this.button4.Tag = "";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_Sayilar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 0;
            this.button2.Tag = "";
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Sayilar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(283, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 501);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menü";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(277, 482);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 191;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            this.columnHeader3.Width = 82;
            // 
            // frmAdisyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 501);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmAdisyon";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adisyon";
            this.Load += new System.EventHandler(this.frmAdisyon_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAraSicak;
        private System.Windows.Forms.Button btnMakarnalar;
        private System.Windows.Forms.Button btnCorbalar;
        private System.Windows.Forms.Button btnFastFood;
        private System.Windows.Forms.Button btnSalatalar;
        private System.Windows.Forms.Button btnTatlilar;
        private System.Windows.Forms.Button btnIcecekler;
        private System.Windows.Forms.Button btnAnaYemek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}