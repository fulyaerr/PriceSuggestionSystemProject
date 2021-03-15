namespace PriceSuggestionSystemSln
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUrunEkle = new System.Windows.Forms.TabPage();
            this.txtMarketAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageUrunArama = new System.Windows.Forms.TabPage();
            this.grdFullSearchUrun = new System.Windows.Forms.DataGridView();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.txtFullSearchUrun = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPageAyarlar = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIndexClear = new System.Windows.Forms.Button();
            this.btnIndexList = new System.Windows.Forms.Button();
            this.btnIndexCreate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageUrunEkle.SuspendLayout();
            this.tabPageUrunArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFullSearchUrun)).BeginInit();
            this.tabPageAyarlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUrunEkle);
            this.tabControl1.Controls.Add(this.tabPageUrunArama);
            this.tabControl1.Controls.Add(this.tabPageAyarlar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUrunEkle
            // 
            this.tabPageUrunEkle.Controls.Add(this.txtMarketAdi);
            this.tabPageUrunEkle.Controls.Add(this.label7);
            this.tabPageUrunEkle.Controls.Add(this.btnTemizle);
            this.tabPageUrunEkle.Controls.Add(this.btnKaydet);
            this.tabPageUrunEkle.Controls.Add(this.txtUrunFiyat);
            this.tabPageUrunEkle.Controls.Add(this.label4);
            this.tabPageUrunEkle.Controls.Add(this.txtUrunMarka);
            this.tabPageUrunEkle.Controls.Add(this.label3);
            this.tabPageUrunEkle.Controls.Add(this.txtUrunAdi);
            this.tabPageUrunEkle.Controls.Add(this.label1);
            this.tabPageUrunEkle.Location = new System.Drawing.Point(4, 22);
            this.tabPageUrunEkle.Name = "tabPageUrunEkle";
            this.tabPageUrunEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunEkle.Size = new System.Drawing.Size(730, 531);
            this.tabPageUrunEkle.TabIndex = 0;
            this.tabPageUrunEkle.Text = "Ürün Ekle";
            this.tabPageUrunEkle.UseVisualStyleBackColor = true;
            // 
            // txtMarketAdi
            // 
            this.txtMarketAdi.Location = new System.Drawing.Point(178, 114);
            this.txtMarketAdi.Name = "txtMarketAdi";
            this.txtMarketAdi.Size = new System.Drawing.Size(355, 20);
            this.txtMarketAdi.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Market Adı";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(377, 155);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 45);
            this.btnTemizle.TabIndex = 23;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(458, 155);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 45);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(178, 85);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(355, 20);
            this.txtUrunFiyat.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ürün Fiyatı";
            // 
            // txtUrunMarka
            // 
            this.txtUrunMarka.Location = new System.Drawing.Point(178, 57);
            this.txtUrunMarka.Name = "txtUrunMarka";
            this.txtUrunMarka.Size = new System.Drawing.Size(355, 20);
            this.txtUrunMarka.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ürün Markası";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(178, 31);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(355, 20);
            this.txtUrunAdi.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ürün Adı";
            // 
            // tabPageUrunArama
            // 
            this.tabPageUrunArama.Controls.Add(this.grdFullSearchUrun);
            this.tabPageUrunArama.Controls.Add(this.btnFiltre);
            this.tabPageUrunArama.Controls.Add(this.txtFullSearchUrun);
            this.tabPageUrunArama.Controls.Add(this.label24);
            this.tabPageUrunArama.Location = new System.Drawing.Point(4, 22);
            this.tabPageUrunArama.Name = "tabPageUrunArama";
            this.tabPageUrunArama.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunArama.Size = new System.Drawing.Size(730, 531);
            this.tabPageUrunArama.TabIndex = 1;
            this.tabPageUrunArama.Text = "Ürün Ara";
            this.tabPageUrunArama.UseVisualStyleBackColor = true;
            // 
            // grdFullSearchUrun
            // 
            this.grdFullSearchUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdFullSearchUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFullSearchUrun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdFullSearchUrun.Location = new System.Drawing.Point(3, 123);
            this.grdFullSearchUrun.Name = "grdFullSearchUrun";
            this.grdFullSearchUrun.Size = new System.Drawing.Size(724, 405);
            this.grdFullSearchUrun.TabIndex = 13;
            // 
            // btnFiltre
            // 
            this.btnFiltre.Location = new System.Drawing.Point(407, 58);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(75, 45);
            this.btnFiltre.TabIndex = 12;
            this.btnFiltre.Text = "Filtre";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // txtFullSearchUrun
            // 
            this.txtFullSearchUrun.Location = new System.Drawing.Point(127, 32);
            this.txtFullSearchUrun.Name = "txtFullSearchUrun";
            this.txtFullSearchUrun.Size = new System.Drawing.Size(355, 20);
            this.txtFullSearchUrun.TabIndex = 11;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(33, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "Anahtar Kelime";
            // 
            // tabPageAyarlar
            // 
            this.tabPageAyarlar.Controls.Add(this.button2);
            this.tabPageAyarlar.Controls.Add(this.btnIndexClear);
            this.tabPageAyarlar.Controls.Add(this.btnIndexList);
            this.tabPageAyarlar.Controls.Add(this.btnIndexCreate);
            this.tabPageAyarlar.Location = new System.Drawing.Point(4, 22);
            this.tabPageAyarlar.Name = "tabPageAyarlar";
            this.tabPageAyarlar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAyarlar.Size = new System.Drawing.Size(730, 531);
            this.tabPageAyarlar.TabIndex = 2;
            this.tabPageAyarlar.Text = "Ayarlar";
            this.tabPageAyarlar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 43);
            this.button2.TabIndex = 24;
            this.button2.Text = "Ayarları Sıfırla";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnIndexClear
            // 
            this.btnIndexClear.Location = new System.Drawing.Point(130, 22);
            this.btnIndexClear.Name = "btnIndexClear";
            this.btnIndexClear.Size = new System.Drawing.Size(98, 43);
            this.btnIndexClear.TabIndex = 23;
            this.btnIndexClear.Text = "İndeksleri Oluştur";
            this.btnIndexClear.UseVisualStyleBackColor = true;
            // 
            // btnIndexList
            // 
            this.btnIndexList.Location = new System.Drawing.Point(234, 22);
            this.btnIndexList.Name = "btnIndexList";
            this.btnIndexList.Size = new System.Drawing.Size(98, 43);
            this.btnIndexList.TabIndex = 22;
            this.btnIndexList.Text = "Dataları İçeri Aktar";
            this.btnIndexList.UseVisualStyleBackColor = true;
            // 
            // btnIndexCreate
            // 
            this.btnIndexCreate.Location = new System.Drawing.Point(338, 22);
            this.btnIndexCreate.Name = "btnIndexCreate";
            this.btnIndexCreate.Size = new System.Drawing.Size(118, 43);
            this.btnIndexCreate.TabIndex = 21;
            this.btnIndexCreate.Text = "Dataları Dışarı Aktar";
            this.btnIndexCreate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 557);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiyat Öneri Sistemi";
            this.tabControl1.ResumeLayout(false);
            this.tabPageUrunEkle.ResumeLayout(false);
            this.tabPageUrunEkle.PerformLayout();
            this.tabPageUrunArama.ResumeLayout(false);
            this.tabPageUrunArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFullSearchUrun)).EndInit();
            this.tabPageAyarlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUrunEkle;
        private System.Windows.Forms.TabPage tabPageUrunArama;
        private System.Windows.Forms.TextBox txtMarketAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageAyarlar;
        private System.Windows.Forms.DataGridView grdFullSearchUrun;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.TextBox txtFullSearchUrun;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIndexClear;
        private System.Windows.Forms.Button btnIndexList;
        private System.Windows.Forms.Button btnIndexCreate;
    }
}

