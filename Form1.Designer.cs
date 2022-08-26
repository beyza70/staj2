namespace ip
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
            this.components = new System.ComponentModel.Container();
            this.textBox_adi = new System.Windows.Forms.TextBox();
            this.textBox_giris = new System.Windows.Forms.TextBox();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_giris = new System.Windows.Forms.Label();
            this.lbl_bilg_adi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_mac = new System.Windows.Forms.TextBox();
            this.lbl_mac = new System.Windows.Forms.Label();
            this.lbl_islemci = new System.Windows.Forms.Label();
            this.lbl_ram = new System.Windows.Forms.Label();
            this.textBox_islemci = new System.Windows.Forms.TextBox();
            this.textBox_ram = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_adi
            // 
            this.textBox_adi.Location = new System.Drawing.Point(133, 37);
            this.textBox_adi.Name = "textBox_adi";
            this.textBox_adi.Size = new System.Drawing.Size(577, 22);
            this.textBox_adi.TabIndex = 0;
            // 
            // textBox_giris
            // 
            this.textBox_giris.Location = new System.Drawing.Point(133, 102);
            this.textBox_giris.Name = "textBox_giris";
            this.textBox_giris.Size = new System.Drawing.Size(577, 22);
            this.textBox_giris.TabIndex = 1;
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(133, 68);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(577, 22);
            this.textBox_ip.TabIndex = 2;
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(23, 74);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(64, 16);
            this.lbl_ip.TabIndex = 3;
            this.lbl_ip.Text = "IP Adresi:";
            // 
            // lbl_giris
            // 
            this.lbl_giris.AutoSize = true;
            this.lbl_giris.Location = new System.Drawing.Point(23, 108);
            this.lbl_giris.Name = "lbl_giris";
            this.lbl_giris.Size = new System.Drawing.Size(71, 16);
            this.lbl_giris.TabIndex = 4;
            this.lbl_giris.Text = "Giriş Saati:";
            // 
            // lbl_bilg_adi
            // 
            this.lbl_bilg_adi.AutoSize = true;
            this.lbl_bilg_adi.Location = new System.Drawing.Point(23, 43);
            this.lbl_bilg_adi.Name = "lbl_bilg_adi";
            this.lbl_bilg_adi.Size = new System.Drawing.Size(93, 16);
            this.lbl_bilg_adi.TabIndex = 7;
            this.lbl_bilg_adi.Text = "Bilgisayar Adı:";
            // 
            // textBox_mac
            // 
            this.textBox_mac.Location = new System.Drawing.Point(133, 135);
            this.textBox_mac.Name = "textBox_mac";
            this.textBox_mac.Size = new System.Drawing.Size(577, 22);
            this.textBox_mac.TabIndex = 8;
            // 
            // lbl_mac
            // 
            this.lbl_mac.AutoSize = true;
            this.lbl_mac.Location = new System.Drawing.Point(23, 141);
            this.lbl_mac.Name = "lbl_mac";
            this.lbl_mac.Size = new System.Drawing.Size(78, 16);
            this.lbl_mac.TabIndex = 9;
            this.lbl_mac.Text = "Mac Adresi:";
            // 
            // lbl_islemci
            // 
            this.lbl_islemci.AutoSize = true;
            this.lbl_islemci.Location = new System.Drawing.Point(23, 176);
            this.lbl_islemci.Name = "lbl_islemci";
            this.lbl_islemci.Size = new System.Drawing.Size(49, 16);
            this.lbl_islemci.TabIndex = 10;
            this.lbl_islemci.Text = "İşlemci";
            // 
            // lbl_ram
            // 
            this.lbl_ram.AutoSize = true;
            this.lbl_ram.Location = new System.Drawing.Point(23, 208);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(36, 16);
            this.lbl_ram.TabIndex = 11;
            this.lbl_ram.Text = "Ram";
            // 
            // textBox_islemci
            // 
            this.textBox_islemci.Location = new System.Drawing.Point(133, 170);
            this.textBox_islemci.Name = "textBox_islemci";
            this.textBox_islemci.Size = new System.Drawing.Size(577, 22);
            this.textBox_islemci.TabIndex = 12;
            // 
            // textBox_ram
            // 
            this.textBox_ram.Location = new System.Drawing.Point(133, 204);
            this.textBox_ram.Name = "textBox_ram";
            this.textBox_ram.Size = new System.Drawing.Size(577, 22);
            this.textBox_ram.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_ram);
            this.Controls.Add(this.textBox_islemci);
            this.Controls.Add(this.lbl_ram);
            this.Controls.Add(this.lbl_islemci);
            this.Controls.Add(this.lbl_mac);
            this.Controls.Add(this.textBox_mac);
            this.Controls.Add(this.lbl_bilg_adi);
            this.Controls.Add(this.lbl_giris);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.textBox_giris);
            this.Controls.Add(this.textBox_adi);
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_adi;
        private System.Windows.Forms.TextBox textBox_giris;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label lbl_giris;
        private System.Windows.Forms.Label lbl_bilg_adi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_mac;
        private System.Windows.Forms.Label lbl_mac;
        private System.Windows.Forms.Label lbl_islemci;
        private System.Windows.Forms.Label lbl_ram;
        private System.Windows.Forms.TextBox textBox_islemci;
        private System.Windows.Forms.TextBox textBox_ram;
    }
}

