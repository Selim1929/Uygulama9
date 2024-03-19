namespace Uygulama9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSatırSayısı = new System.Windows.Forms.TextBox();
            this.txtSütünSayısı = new System.Windows.Forms.TextBox();
            this.txtRastgeleMin = new System.Windows.Forms.TextBox();
            this.txtRastgeleMax = new System.Windows.Forms.TextBox();
            this.btnDiziOlustur = new System.Windows.Forms.Button();
            this.btnDiziGöster = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dizi satır sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dizi sütün sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rastgele en dusuk sayı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rastgele en yuksek sayı";
            // 
            // txtSatırSayısı
            // 
            this.txtSatırSayısı.Location = new System.Drawing.Point(144, 54);
            this.txtSatırSayısı.Name = "txtSatırSayısı";
            this.txtSatırSayısı.Size = new System.Drawing.Size(100, 20);
            this.txtSatırSayısı.TabIndex = 4;
            // 
            // txtSütünSayısı
            // 
            this.txtSütünSayısı.Location = new System.Drawing.Point(152, 95);
            this.txtSütünSayısı.Name = "txtSütünSayısı";
            this.txtSütünSayısı.Size = new System.Drawing.Size(100, 20);
            this.txtSütünSayısı.TabIndex = 5;
            // 
            // txtRastgeleMin
            // 
            this.txtRastgeleMin.Location = new System.Drawing.Point(198, 140);
            this.txtRastgeleMin.Name = "txtRastgeleMin";
            this.txtRastgeleMin.Size = new System.Drawing.Size(100, 20);
            this.txtRastgeleMin.TabIndex = 6;
            // 
            // txtRastgeleMax
            // 
            this.txtRastgeleMax.Location = new System.Drawing.Point(217, 184);
            this.txtRastgeleMax.Name = "txtRastgeleMax";
            this.txtRastgeleMax.Size = new System.Drawing.Size(100, 20);
            this.txtRastgeleMax.TabIndex = 7;
            // 
            // btnDiziOlustur
            // 
            this.btnDiziOlustur.Location = new System.Drawing.Point(144, 258);
            this.btnDiziOlustur.Name = "btnDiziOlustur";
            this.btnDiziOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnDiziOlustur.TabIndex = 8;
            this.btnDiziOlustur.Text = "Dizi Olustur";
            this.btnDiziOlustur.UseVisualStyleBackColor = true;
            this.btnDiziOlustur.Click += new System.EventHandler(this.btnDiziOlustur_Click);
            // 
            // btnDiziGöster
            // 
            this.btnDiziGöster.Location = new System.Drawing.Point(523, 136);
            this.btnDiziGöster.Name = "btnDiziGöster";
            this.btnDiziGöster.Size = new System.Drawing.Size(75, 23);
            this.btnDiziGöster.TabIndex = 9;
            this.btnDiziGöster.Text = "Dizi Göster";
            this.btnDiziGöster.UseVisualStyleBackColor = true;
            this.btnDiziGöster.Click += new System.EventHandler(this.btnDiziGöster_Click);
            // 
            // btnListele
            // 
            this.btnListele.FormattingEnabled = true;
            this.btnListele.Location = new System.Drawing.Point(523, 199);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(120, 186);
            this.btnListele.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnDiziGöster);
            this.Controls.Add(this.btnDiziOlustur);
            this.Controls.Add(this.txtRastgeleMax);
            this.Controls.Add(this.txtRastgeleMin);
            this.Controls.Add(this.txtSütünSayısı);
            this.Controls.Add(this.txtSatırSayısı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSatırSayısı;
        private System.Windows.Forms.TextBox txtSütünSayısı;
        private System.Windows.Forms.TextBox txtRastgeleMin;
        private System.Windows.Forms.TextBox txtRastgeleMax;
        private System.Windows.Forms.Button btnDiziOlustur;
        private System.Windows.Forms.Button btnDiziGöster;
        private System.Windows.Forms.ListBox btnListele;
    }
}

