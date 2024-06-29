namespace MarmarayBilet
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(214, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "İLK DURAĞI SEÇİNİZ;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "SON DURAĞI SEÇİNİZ;";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Halkalı İstasyonu",
            "Mustafa Kemal İstasyonu",
            "Küçükçekmece İstasyonu",
            "Florya İstasyonu",
            "Florya Akvaryum İstasyonu",
            "Yeşilköy İstasyonu",
            "Yeşilyurt İstasyonu",
            "Ataköy İstasyonu",
            "Bakırköy İstasyonu",
            "Yenimahalle İstasyonu",
            "Zeytinburnu İstasyonu",
            "Kazlıçeşme İstasyonu",
            "Yenikapı İstasyonu",
            "Sirkeci İstasyonu",
            "Üsküdar İstasyonu",
            "Ayrılık Çeşmesi İstasyonu",
            "Söğütlüçeşme İstasyonu",
            "Feneryolu İstasyonu",
            "Göztepe İstasyonu",
            "Erenköy İstasyonu",
            "Suadiye İstasyonu",
            "Bostancı İstasyonu",
            "Küçükyalı İstasyonu",
            "İdealtepe İstasyonu",
            "Süreyya Plajı İstasyonu",
            "Maltepe İstasyonu",
            "Cevizli İstasyonu",
            "Atalar İstasyonu",
            "Başak İstasyonu",
            "Kartal İstasyonu",
            "Yunus İstasyonu",
            "Pendik İstasyonu",
            "Kaynarca İstasyonu",
            "Tersane İstasyonu",
            "Güzelyalı İstasyonu",
            "Aydıntepe İstasyonu",
            "İçmeler İstasyonu",
            "Tuzla İstasyonu",
            "Çayırova İstasyonu",
            "Fatih İstasyonu",
            "Osmangazi İstasyonu",
            "Darıca İstasyonu",
            "Gebze İstasyonu"});
            this.comboBox1.Location = new System.Drawing.Point(258, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Halkalı İstasyonu",
            "Mustafa Kemal İstasyonu",
            "Küçükçekmece İstasyonu",
            "Florya İstasyonu",
            "Florya Akvaryum İstasyonu",
            "Yeşilköy İstasyonu",
            "Yeşilyurt İstasyonu",
            "Ataköy İstasyonu",
            "Bakırköy İstasyonu",
            "Yenimahalle İstasyonu",
            "Zeytinburnu İstasyonu",
            "Kazlıçeşme İstasyonu",
            "Yenikapı İstasyonu",
            "Sirkeci İstasyonu",
            "Üsküdar İstasyonu",
            "Ayrılık Çeşmesi İstasyonu",
            "Söğütlüçeşme İstasyonu",
            "Feneryolu İstasyonu",
            "Göztepe İstasyonu",
            "Erenköy İstasyonu",
            "Suadiye İstasyonu",
            "Bostancı İstasyonu",
            "Küçükyalı İstasyonu",
            "İdealtepe İstasyonu",
            "Süreyya Plajı İstasyonu",
            "Maltepe İstasyonu",
            "Cevizli İstasyonu",
            "Atalar İstasyonu",
            "Başak İstasyonu",
            "Kartal İstasyonu",
            "Yunus İstasyonu",
            "Pendik İstasyonu",
            "Kaynarca İstasyonu",
            "Tersane İstasyonu",
            "Güzelyalı İstasyonu",
            "Aydıntepe İstasyonu",
            "İçmeler İstasyonu",
            "Tuzla İstasyonu",
            "Çayırova İstasyonu",
            "Fatih İstasyonu",
            "Osmangazi İstasyonu",
            "Darıca İstasyonu",
            "Gebze İstasyonu"});
            this.comboBox2.Location = new System.Drawing.Point(258, 188);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "DURUMUNUZU  SEÇİNİZ;";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(240, 261);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TAM";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(309, 263);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ÖĞRENCİ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(57, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "MARMARAY BİLET ÜCRETİ HESAPLAMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "ÖDEYECEĞİNİZ TUTAR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(263, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.Location = new System.Drawing.Point(424, 263);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(171, 22);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "YAŞLI/ÖĞRETMEN";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(497, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(335, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 449);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}

