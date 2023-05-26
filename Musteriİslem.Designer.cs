namespace BankaOtomasyonu
{
    partial class Musteriİslem
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHesapH = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSifre = new System.Windows.Forms.Button();
            this.btnHavale = new System.Windows.Forms.Button();
            this.btnBakiyeGoruntule = new System.Windows.Forms.Button();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Crimson;
            this.lblAdSoyad.Location = new System.Drawing.Point(158, 25);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(18, 25);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(38, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hesap No:";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblHesapNo.ForeColor = System.Drawing.Color.Crimson;
            this.lblHesapNo.Location = new System.Drawing.Point(158, 76);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(18, 25);
            this.lblHesapNo.TabIndex = 4;
            this.lblHesapNo.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHesapH);
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.btnSifre);
            this.groupBox1.Controls.Add(this.btnHavale);
            this.groupBox1.Controls.Add(this.btnBakiyeGoruntule);
            this.groupBox1.Controls.Add(this.btnParaYatir);
            this.groupBox1.Controls.Add(this.btnParaCek);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(150, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 518);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // btnHesapH
            // 
            this.btnHesapH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnHesapH.Location = new System.Drawing.Point(188, 361);
            this.btnHesapH.Name = "btnHesapH";
            this.btnHesapH.Size = new System.Drawing.Size(205, 49);
            this.btnHesapH.TabIndex = 6;
            this.btnHesapH.Text = "Hesap Hareketleri";
            this.btnHesapH.UseVisualStyleBackColor = true;
            this.btnHesapH.Click += new System.EventHandler(this.btnHesapH_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCikis.ForeColor = System.Drawing.Color.Crimson;
            this.btnCikis.Location = new System.Drawing.Point(188, 433);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(205, 48);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSifre
            // 
            this.btnSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSifre.Location = new System.Drawing.Point(188, 291);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(205, 49);
            this.btnSifre.TabIndex = 4;
            this.btnSifre.Text = "Şifre Değiştir";
            this.btnSifre.UseVisualStyleBackColor = true;
            // 
            // btnHavale
            // 
            this.btnHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnHavale.Location = new System.Drawing.Point(188, 226);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(205, 49);
            this.btnHavale.TabIndex = 3;
            this.btnHavale.Text = "Havale / EFT";
            this.btnHavale.UseVisualStyleBackColor = true;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // btnBakiyeGoruntule
            // 
            this.btnBakiyeGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBakiyeGoruntule.Location = new System.Drawing.Point(188, 162);
            this.btnBakiyeGoruntule.Name = "btnBakiyeGoruntule";
            this.btnBakiyeGoruntule.Size = new System.Drawing.Size(205, 49);
            this.btnBakiyeGoruntule.TabIndex = 2;
            this.btnBakiyeGoruntule.Text = "Bakiye Görüntüle";
            this.btnBakiyeGoruntule.UseVisualStyleBackColor = true;
            this.btnBakiyeGoruntule.Click += new System.EventHandler(this.btnBakiyeGoruntule_Click);
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnParaYatir.Location = new System.Drawing.Point(188, 97);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(205, 49);
            this.btnParaYatir.TabIndex = 1;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // btnParaCek
            // 
            this.btnParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnParaCek.Location = new System.Drawing.Point(188, 21);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(205, 49);
            this.btnParaCek.TabIndex = 0;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // Musteriİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Musteriİslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri İşlemleri";
            this.Load += new System.EventHandler(this.Musteriİslem_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHesapH;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSifre;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.Button btnBakiyeGoruntule;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Button btnParaCek;
    }
}