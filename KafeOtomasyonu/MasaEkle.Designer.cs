namespace KafeOtomasyonu
{
    partial class MasaEkle
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnmasil = new System.Windows.Forms.Button();
            this.lblmasa = new System.Windows.Forms.Label();
            this.txtmasano = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtguncellemasa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtyenimasa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "MasaEkle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmasil
            // 
            this.btnmasil.Location = new System.Drawing.Point(179, 16);
            this.btnmasil.Name = "btnmasil";
            this.btnmasil.Size = new System.Drawing.Size(75, 23);
            this.btnmasil.TabIndex = 0;
            this.btnmasil.Text = "MasaSil";
            this.btnmasil.UseVisualStyleBackColor = true;
            this.btnmasil.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblmasa
            // 
            this.lblmasa.AutoSize = true;
            this.lblmasa.Location = new System.Drawing.Point(92, 19);
            this.lblmasa.Name = "lblmasa";
            this.lblmasa.Size = new System.Drawing.Size(42, 13);
            this.lblmasa.TabIndex = 1;
            this.lblmasa.Text = "Masa - ";
            // 
            // txtmasano
            // 
            this.txtmasano.Location = new System.Drawing.Point(129, 16);
            this.txtmasano.Name = "txtmasano";
            this.txtmasano.Size = new System.Drawing.Size(33, 20);
            this.txtmasano.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masa - ";
            // 
            // txtguncellemasa
            // 
            this.txtguncellemasa.Location = new System.Drawing.Point(130, 63);
            this.txtguncellemasa.Name = "txtguncellemasa";
            this.txtguncellemasa.Size = new System.Drawing.Size(33, 20);
            this.txtguncellemasa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masa - ";
            // 
            // txtyenimasa
            // 
            this.txtyenimasa.Location = new System.Drawing.Point(129, 94);
            this.txtyenimasa.Name = "txtyenimasa";
            this.txtyenimasa.Size = new System.Drawing.Size(33, 20);
            this.txtyenimasa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni";
            // 
            // MasaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 160);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtyenimasa);
            this.Controls.Add(this.txtguncellemasa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtmasano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmasa);
            this.Controls.Add(this.btnmasil);
            this.Controls.Add(this.button1);
            this.Name = "MasaEkle";
            this.Text = "MasaEkle";
            this.Load += new System.EventHandler(this.MasaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnmasil;
        private System.Windows.Forms.Label lblmasa;
        private System.Windows.Forms.TextBox txtmasano;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtguncellemasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtyenimasa;
        private System.Windows.Forms.Label label3;
    }
}