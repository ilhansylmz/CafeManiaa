namespace KafeOtomasyonu
{
    partial class Raporlar
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
            this.btnAylıkRapor = new System.Windows.Forms.Button();
            this.btnGunlukRapor = new System.Windows.Forms.Button();
            this.btnYıllıkRapor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblgunlukucret = new System.Windows.Forms.Label();
            this.lblaylıkucret = new System.Windows.Forms.Label();
            this.lblyıllıkucret = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblaylık = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblyıllık = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAylıkRapor
            // 
            this.btnAylıkRapor.Location = new System.Drawing.Point(625, 34);
            this.btnAylıkRapor.Name = "btnAylıkRapor";
            this.btnAylıkRapor.Size = new System.Drawing.Size(75, 23);
            this.btnAylıkRapor.TabIndex = 1;
            this.btnAylıkRapor.Text = "AylıkRapor";
            this.btnAylıkRapor.UseVisualStyleBackColor = true;
            this.btnAylıkRapor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGunlukRapor
            // 
            this.btnGunlukRapor.Location = new System.Drawing.Point(542, 34);
            this.btnGunlukRapor.Name = "btnGunlukRapor";
            this.btnGunlukRapor.Size = new System.Drawing.Size(75, 23);
            this.btnGunlukRapor.TabIndex = 0;
            this.btnGunlukRapor.Text = "Günlük Rapor";
            this.btnGunlukRapor.UseVisualStyleBackColor = true;
            this.btnGunlukRapor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnYıllıkRapor
            // 
            this.btnYıllıkRapor.Location = new System.Drawing.Point(703, 34);
            this.btnYıllıkRapor.Name = "btnYıllıkRapor";
            this.btnYıllıkRapor.Size = new System.Drawing.Size(75, 23);
            this.btnYıllıkRapor.TabIndex = 2;
            this.btnYıllıkRapor.Text = "YıllıkRapor";
            this.btnYıllıkRapor.UseVisualStyleBackColor = true;
            this.btnYıllıkRapor.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aylık Ortlama Gelir :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yıllık Ortalama Gelir :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "GünlükÜcretToplamı :";
            // 
            // lblgunlukucret
            // 
            this.lblgunlukucret.AutoSize = true;
            this.lblgunlukucret.Location = new System.Drawing.Point(655, 80);
            this.lblgunlukucret.Name = "lblgunlukucret";
            this.lblgunlukucret.Size = new System.Drawing.Size(13, 13);
            this.lblgunlukucret.TabIndex = 5;
            this.lblgunlukucret.Text = "0";
            // 
            // lblaylıkucret
            // 
            this.lblaylıkucret.AutoSize = true;
            this.lblaylıkucret.Location = new System.Drawing.Point(655, 154);
            this.lblaylıkucret.Name = "lblaylıkucret";
            this.lblaylıkucret.Size = new System.Drawing.Size(13, 13);
            this.lblaylıkucret.TabIndex = 5;
            this.lblaylıkucret.Text = "0";
            // 
            // lblyıllıkucret
            // 
            this.lblyıllıkucret.AutoSize = true;
            this.lblyıllıkucret.Location = new System.Drawing.Point(655, 178);
            this.lblyıllıkucret.Name = "lblyıllıkucret";
            this.lblyıllıkucret.Size = new System.Drawing.Size(13, 13);
            this.lblyıllıkucret.TabIndex = 5;
            this.lblyıllıkucret.Text = "0";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(542, 231);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 6;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(32, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(476, 313);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Masa";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ücret";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            // 
            // lblaylık
            // 
            this.lblaylık.AutoSize = true;
            this.lblaylık.Location = new System.Drawing.Point(539, 105);
            this.lblaylık.Name = "lblaylık";
            this.lblaylık.Size = new System.Drawing.Size(98, 13);
            this.lblaylık.TabIndex = 5;
            this.lblaylık.Text = "AylıkÜcretToplamı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "0";
            // 
            // lblyıllık
            // 
            this.lblyıllık.AutoSize = true;
            this.lblyıllık.Location = new System.Drawing.Point(539, 128);
            this.lblyıllık.Name = "lblyıllık";
            this.lblyıllık.Size = new System.Drawing.Size(97, 13);
            this.lblyıllık.TabIndex = 5;
            this.lblyıllık.Text = "YıllıkÜcretToplamı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(655, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "0";
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.lblyıllıkucret);
            this.Controls.Add(this.lblaylıkucret);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblgunlukucret);
            this.Controls.Add(this.lblyıllık);
            this.Controls.Add(this.lblaylık);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGunlukRapor);
            this.Controls.Add(this.btnYıllıkRapor);
            this.Controls.Add(this.btnAylıkRapor);
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAylıkRapor;
        private System.Windows.Forms.Button btnGunlukRapor;
        private System.Windows.Forms.Button btnYıllıkRapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblgunlukucret;
        private System.Windows.Forms.Label lblaylıkucret;
        private System.Windows.Forms.Label lblyıllıkucret;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblaylık;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblyıllık;
        private System.Windows.Forms.Label label7;
    }
}