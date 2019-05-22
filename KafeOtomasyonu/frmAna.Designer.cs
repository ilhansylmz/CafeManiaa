namespace KafeOtomasyonu
{
    partial class frmAna
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masalarıYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunAyarlariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciAyarlariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Masaekle = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvMasalar = new System.Windows.Forms.ListView();
            this.imageMasalar = new System.Windows.Forms.ImageList(this.components);
            this.hesapDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masalarıYenileToolStripMenuItem,
            this.urunAyarlariToolStripMenuItem,
            this.kullaniciAyarlariToolStripMenuItem,
            this.toolStripMenuItem1,
            this.Masaekle,
            this.hesapDeğiştirToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masalarıYenileToolStripMenuItem
            // 
            this.masalarıYenileToolStripMenuItem.Name = "masalarıYenileToolStripMenuItem";
            this.masalarıYenileToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.masalarıYenileToolStripMenuItem.Text = "Masaları Yenile";
            this.masalarıYenileToolStripMenuItem.Click += new System.EventHandler(this.masalarıYenileToolStripMenuItem_Click);
            // 
            // urunAyarlariToolStripMenuItem
            // 
            this.urunAyarlariToolStripMenuItem.Name = "urunAyarlariToolStripMenuItem";
            this.urunAyarlariToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.urunAyarlariToolStripMenuItem.Text = "Ürün Ayarları";
            this.urunAyarlariToolStripMenuItem.Click += new System.EventHandler(this.urunAyarlariToolStripMenuItem_Click);
            // 
            // kullaniciAyarlariToolStripMenuItem
            // 
            this.kullaniciAyarlariToolStripMenuItem.Name = "kullaniciAyarlariToolStripMenuItem";
            this.kullaniciAyarlariToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.kullaniciAyarlariToolStripMenuItem.Text = "Kullanıcı Ayarları";
            this.kullaniciAyarlariToolStripMenuItem.Click += new System.EventHandler(this.kullaniciAyarlariToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem1.Text = "Raporlar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Masaekle
            // 
            this.Masaekle.Name = "Masaekle";
            this.Masaekle.Size = new System.Drawing.Size(71, 20);
            this.Masaekle.Text = "Masa Ekle";
            this.Masaekle.Click += new System.EventHandler(this.Masaekle_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblKullanici);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 24);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "...";
            this.label2.Visible = false;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(63, 6);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(16, 13);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı :";
            // 
            // lvMasalar
            // 
            this.lvMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMasalar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvMasalar.LargeImageList = this.imageMasalar;
            this.lvMasalar.Location = new System.Drawing.Point(0, 24);
            this.lvMasalar.MultiSelect = false;
            this.lvMasalar.Name = "lvMasalar";
            this.lvMasalar.Size = new System.Drawing.Size(770, 462);
            this.lvMasalar.TabIndex = 2;
            this.lvMasalar.UseCompatibleStateImageBehavior = false;
            this.lvMasalar.DoubleClick += new System.EventHandler(this.lvMasalar_DoubleClick);
            // 
            // imageMasalar
            // 
            this.imageMasalar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageMasalar.ImageStream")));
            this.imageMasalar.TransparentColor = System.Drawing.Color.Transparent;
            this.imageMasalar.Images.SetKeyName(0, "bosMasa.png");
            this.imageMasalar.Images.SetKeyName(1, "doluMasa.png");
            // 
            // hesapDeğiştirToolStripMenuItem
            // 
            this.hesapDeğiştirToolStripMenuItem.Name = "hesapDeğiştirToolStripMenuItem";
            this.hesapDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.hesapDeğiştirToolStripMenuItem.Text = "Hesap Değiştir";
            this.hesapDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.hesapDeğiştirToolStripMenuItem_Click);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 510);
            this.Controls.Add(this.lvMasalar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CafeMania Cafe Otomasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAna_FormClosing);
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem urunAyarlariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciAyarlariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvMasalar;
        public System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageMasalar;
        private System.Windows.Forms.ToolStripMenuItem masalarıYenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem Masaekle;
        private System.Windows.Forms.ToolStripMenuItem hesapDeğiştirToolStripMenuItem;
    }
}

