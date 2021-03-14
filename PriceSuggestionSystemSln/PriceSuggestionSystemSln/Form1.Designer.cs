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
            this.tabPageUrunArama = new System.Windows.Forms.TabPage();
            this.tabPageAyarlar = new System.Windows.Forms.TabPage();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLokasyon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grdFullSearchIlan = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFullSearchIlan = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnIndexClear = new System.Windows.Forms.Button();
            this.btnIndexList = new System.Windows.Forms.Button();
            this.btnIndexCreate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageUrunEkle.SuspendLayout();
            this.tabPageUrunArama.SuspendLayout();
            this.tabPageAyarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFullSearchIlan)).BeginInit();
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
            this.tabPageUrunEkle.Controls.Add(this.textBox1);
            this.tabPageUrunEkle.Controls.Add(this.label7);
            this.tabPageUrunEkle.Controls.Add(this.btnTemizle);
            this.tabPageUrunEkle.Controls.Add(this.btnKaydet);
            this.tabPageUrunEkle.Controls.Add(this.txtUcret);
            this.tabPageUrunEkle.Controls.Add(this.label4);
            this.tabPageUrunEkle.Controls.Add(this.txtLokasyon);
            this.tabPageUrunEkle.Controls.Add(this.label3);
            this.tabPageUrunEkle.Controls.Add(this.txtFirma);
            this.tabPageUrunEkle.Controls.Add(this.label1);
            this.tabPageUrunEkle.Location = new System.Drawing.Point(4, 22);
            this.tabPageUrunEkle.Name = "tabPageUrunEkle";
            this.tabPageUrunEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunEkle.Size = new System.Drawing.Size(582, 217);
            this.tabPageUrunEkle.TabIndex = 0;
            this.tabPageUrunEkle.Text = "Ürün Ekle";
            this.tabPageUrunEkle.UseVisualStyleBackColor = true;
            // 
            // tabPageUrunArama
            // 
            this.tabPageUrunArama.Controls.Add(this.grdFullSearchIlan);
            this.tabPageUrunArama.Controls.Add(this.button1);
            this.tabPageUrunArama.Controls.Add(this.txtFullSearchIlan);
            this.tabPageUrunArama.Controls.Add(this.label24);
            this.tabPageUrunArama.Location = new System.Drawing.Point(4, 22);
            this.tabPageUrunArama.Name = "tabPageUrunArama";
            this.tabPageUrunArama.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunArama.Size = new System.Drawing.Size(730, 531);
            this.tabPageUrunArama.TabIndex = 1;
            this.tabPageUrunArama.Text = "Ürün Ara";
            this.tabPageUrunArama.UseVisualStyleBackColor = true;
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
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(178, 85);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(355, 20);
            this.txtUcret.TabIndex = 17;
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
            // txtLokasyon
            // 
            this.txtLokasyon.Location = new System.Drawing.Point(178, 57);
            this.txtLokasyon.Name = "txtLokasyon";
            this.txtLokasyon.Size = new System.Drawing.Size(355, 20);
            this.txtLokasyon.TabIndex = 14;
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
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(178, 31);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(355, 20);
            this.txtFirma.TabIndex = 13;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 20);
            this.textBox1.TabIndex = 26;
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
            // grdFullSearchIlan
            // 
            this.grdFullSearchIlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdFullSearchIlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFullSearchIlan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdFullSearchIlan.Location = new System.Drawing.Point(3, 123);
            this.grdFullSearchIlan.Name = "grdFullSearchIlan";
            this.grdFullSearchIlan.Size = new System.Drawing.Size(724, 405);
            this.grdFullSearchIlan.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Filtre";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtFullSearchIlan
            // 
            this.txtFullSearchIlan.Location = new System.Drawing.Point(127, 32);
            this.txtFullSearchIlan.Name = "txtFullSearchIlan";
            this.txtFullSearchIlan.Size = new System.Drawing.Size(355, 20);
            this.txtFullSearchIlan.TabIndex = 11;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 43);
            this.button2.TabIndex = 24;
            this.button2.Text = "Ayarları Sıfırla";
            this.button2.UseVisualStyleBackColor = true;
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
            this.tabPageAyarlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFullSearchIlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUrunEkle;
        private System.Windows.Forms.TabPage tabPageUrunArama;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLokasyon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageAyarlar;
        private System.Windows.Forms.DataGridView grdFullSearchIlan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFullSearchIlan;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIndexClear;
        private System.Windows.Forms.Button btnIndexList;
        private System.Windows.Forms.Button btnIndexCreate;
    }
}

