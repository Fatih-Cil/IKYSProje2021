
namespace IKYS
{
    partial class KurumsalDokumanIslemleriUI
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
            this.gbxKDIslemleri = new System.Windows.Forms.GroupBox();
            this.dgwKurumsalDokuman = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblDosyaAc = new System.Windows.Forms.Label();
            this.btnTumunuListele = new System.Windows.Forms.Button();
            this.gbxKDSil = new System.Windows.Forms.GroupBox();
            this.lbldosyasecmesaji = new System.Windows.Forms.Label();
            this.tbxDosyaPath = new System.Windows.Forms.TextBox();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.btnDosyaSil = new System.Windows.Forms.Button();
            this.chbxOnay = new System.Windows.Forms.CheckBox();
            this.gbxKDEkle = new System.Windows.Forms.GroupBox();
            this.cbxSirket = new System.Windows.Forms.ComboBox();
            this.lblSirket = new System.Windows.Forms.Label();
            this.btnKDKaydet = new System.Windows.Forms.Button();
            this.lblDosyaAdi = new System.Windows.Forms.Label();
            this.lblSecilenDosyaAdi = new System.Windows.Forms.Label();
            this.cbxKDKategori = new System.Windows.Forms.ComboBox();
            this.lblKDKategori = new System.Windows.Forms.Label();
            this.btnKDSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbxKDIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKurumsalDokuman)).BeginInit();
            this.gbxKDSil.SuspendLayout();
            this.gbxKDEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxKDIslemleri
            // 
            this.gbxKDIslemleri.Controls.Add(this.dgwKurumsalDokuman);
            this.gbxKDIslemleri.Controls.Add(this.linkLabel1);
            this.gbxKDIslemleri.Controls.Add(this.lblDosyaAc);
            this.gbxKDIslemleri.Controls.Add(this.btnTumunuListele);
            this.gbxKDIslemleri.Controls.Add(this.gbxKDSil);
            this.gbxKDIslemleri.Controls.Add(this.gbxKDEkle);
            this.gbxKDIslemleri.Location = new System.Drawing.Point(9, 92);
            this.gbxKDIslemleri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxKDIslemleri.Name = "gbxKDIslemleri";
            this.gbxKDIslemleri.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxKDIslemleri.Size = new System.Drawing.Size(1009, 657);
            this.gbxKDIslemleri.TabIndex = 0;
            this.gbxKDIslemleri.TabStop = false;
            this.gbxKDIslemleri.Text = "KURUMSAL DOKÜMAN İŞLEMLERİ";
            // 
            // dgwKurumsalDokuman
            // 
            this.dgwKurumsalDokuman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKurumsalDokuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKurumsalDokuman.Location = new System.Drawing.Point(27, 331);
            this.dgwKurumsalDokuman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwKurumsalDokuman.Name = "dgwKurumsalDokuman";
            this.dgwKurumsalDokuman.ReadOnly = true;
            this.dgwKurumsalDokuman.RowHeadersWidth = 82;
            this.dgwKurumsalDokuman.RowTemplate.Height = 33;
            this.dgwKurumsalDokuman.Size = new System.Drawing.Size(946, 283);
            this.dgwKurumsalDokuman.TabIndex = 3;
            this.dgwKurumsalDokuman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKurumsalDokuman_CellContentClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(110, 300);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(222, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Tablodan bir dokuman seçiniz.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblDosyaAc
            // 
            this.lblDosyaAc.AutoSize = true;
            this.lblDosyaAc.Location = new System.Drawing.Point(27, 300);
            this.lblDosyaAc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDosyaAc.Name = "lblDosyaAc";
            this.lblDosyaAc.Size = new System.Drawing.Size(81, 20);
            this.lblDosyaAc.TabIndex = 6;
            this.lblDosyaAc.Text = "Dosya Aç:";
            // 
            // btnTumunuListele
            // 
            this.btnTumunuListele.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTumunuListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTumunuListele.Location = new System.Drawing.Point(765, 236);
            this.btnTumunuListele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTumunuListele.Name = "btnTumunuListele";
            this.btnTumunuListele.Size = new System.Drawing.Size(185, 39);
            this.btnTumunuListele.TabIndex = 4;
            this.btnTumunuListele.Text = "Tüm Kayıtları Listele";
            this.btnTumunuListele.UseVisualStyleBackColor = false;
            this.btnTumunuListele.Click += new System.EventHandler(this.btnTumunuListele_Click);
            // 
            // gbxKDSil
            // 
            this.gbxKDSil.Controls.Add(this.lbldosyasecmesaji);
            this.gbxKDSil.Controls.Add(this.tbxDosyaPath);
            this.gbxKDSil.Controls.Add(this.lblDosyaYolu);
            this.gbxKDSil.Controls.Add(this.btnDosyaSil);
            this.gbxKDSil.Controls.Add(this.chbxOnay);
            this.gbxKDSil.Location = new System.Drawing.Point(441, 47);
            this.gbxKDSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxKDSil.Name = "gbxKDSil";
            this.gbxKDSil.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxKDSil.Size = new System.Drawing.Size(532, 175);
            this.gbxKDSil.TabIndex = 2;
            this.gbxKDSil.TabStop = false;
            this.gbxKDSil.Text = "Doküman Sil";
            // 
            // lbldosyasecmesaji
            // 
            this.lbldosyasecmesaji.AutoSize = true;
            this.lbldosyasecmesaji.Location = new System.Drawing.Point(243, 22);
            this.lbldosyasecmesaji.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldosyasecmesaji.Name = "lbldosyasecmesaji";
            this.lbldosyasecmesaji.Size = new System.Drawing.Size(257, 20);
            this.lbldosyasecmesaji.TabIndex = 4;
            this.lbldosyasecmesaji.Text = "Dosyayı aşağıdaki tablodan seçiniz.";
            // 
            // tbxDosyaPath
            // 
            this.tbxDosyaPath.Location = new System.Drawing.Point(110, 51);
            this.tbxDosyaPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxDosyaPath.Name = "tbxDosyaPath";
            this.tbxDosyaPath.ReadOnly = true;
            this.tbxDosyaPath.Size = new System.Drawing.Size(400, 26);
            this.tbxDosyaPath.TabIndex = 0;
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.Location = new System.Drawing.Point(14, 54);
            this.lblDosyaYolu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(90, 20);
            this.lblDosyaYolu.TabIndex = 3;
            this.lblDosyaYolu.Text = "Dosya Yolu";
            // 
            // btnDosyaSil
            // 
            this.btnDosyaSil.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDosyaSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDosyaSil.Location = new System.Drawing.Point(324, 85);
            this.btnDosyaSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDosyaSil.Name = "btnDosyaSil";
            this.btnDosyaSil.Size = new System.Drawing.Size(185, 38);
            this.btnDosyaSil.TabIndex = 2;
            this.btnDosyaSil.Text = "Dosya Sil";
            this.btnDosyaSil.UseVisualStyleBackColor = false;
            this.btnDosyaSil.Click += new System.EventHandler(this.btnDosyaSil_Click);
            // 
            // chbxOnay
            // 
            this.chbxOnay.AutoSize = true;
            this.chbxOnay.Location = new System.Drawing.Point(110, 85);
            this.chbxOnay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbxOnay.Name = "chbxOnay";
            this.chbxOnay.Size = new System.Drawing.Size(137, 24);
            this.chbxOnay.TabIndex = 5;
            this.chbxOnay.Text = "Silmeyi Onayla";
            this.chbxOnay.UseVisualStyleBackColor = true;
            // 
            // gbxKDEkle
            // 
            this.gbxKDEkle.Controls.Add(this.cbxSirket);
            this.gbxKDEkle.Controls.Add(this.lblSirket);
            this.gbxKDEkle.Controls.Add(this.btnKDKaydet);
            this.gbxKDEkle.Controls.Add(this.lblDosyaAdi);
            this.gbxKDEkle.Controls.Add(this.lblSecilenDosyaAdi);
            this.gbxKDEkle.Controls.Add(this.cbxKDKategori);
            this.gbxKDEkle.Controls.Add(this.lblKDKategori);
            this.gbxKDEkle.Controls.Add(this.btnKDSec);
            this.gbxKDEkle.Location = new System.Drawing.Point(27, 47);
            this.gbxKDEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxKDEkle.Name = "gbxKDEkle";
            this.gbxKDEkle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxKDEkle.Size = new System.Drawing.Size(320, 236);
            this.gbxKDEkle.TabIndex = 0;
            this.gbxKDEkle.TabStop = false;
            this.gbxKDEkle.Text = "Doküman Ekle";
            // 
            // cbxSirket
            // 
            this.cbxSirket.FormattingEnabled = true;
            this.cbxSirket.Location = new System.Drawing.Point(86, 45);
            this.cbxSirket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSirket.Name = "cbxSirket";
            this.cbxSirket.Size = new System.Drawing.Size(218, 28);
            this.cbxSirket.TabIndex = 6;
            // 
            // lblSirket
            // 
            this.lblSirket.AutoSize = true;
            this.lblSirket.Location = new System.Drawing.Point(24, 51);
            this.lblSirket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSirket.Name = "lblSirket";
            this.lblSirket.Size = new System.Drawing.Size(50, 20);
            this.lblSirket.TabIndex = 7;
            this.lblSirket.Text = "Şirket";
            // 
            // btnKDKaydet
            // 
            this.btnKDKaydet.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnKDKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKDKaydet.Location = new System.Drawing.Point(170, 184);
            this.btnKDKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKDKaydet.Name = "btnKDKaydet";
            this.btnKDKaydet.Size = new System.Drawing.Size(134, 44);
            this.btnKDKaydet.TabIndex = 5;
            this.btnKDKaydet.Text = "Kaydet";
            this.btnKDKaydet.UseVisualStyleBackColor = false;
            this.btnKDKaydet.Click += new System.EventHandler(this.btnKDKaydet_Click);
            // 
            // lblDosyaAdi
            // 
            this.lblDosyaAdi.AutoSize = true;
            this.lblDosyaAdi.Location = new System.Drawing.Point(16, 146);
            this.lblDosyaAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDosyaAdi.Name = "lblDosyaAdi";
            this.lblDosyaAdi.Size = new System.Drawing.Size(77, 20);
            this.lblDosyaAdi.TabIndex = 4;
            this.lblDosyaAdi.Text = "DosyaAdı";
            // 
            // lblSecilenDosyaAdi
            // 
            this.lblSecilenDosyaAdi.AutoSize = true;
            this.lblSecilenDosyaAdi.Location = new System.Drawing.Point(16, 118);
            this.lblSecilenDosyaAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecilenDosyaAdi.Name = "lblSecilenDosyaAdi";
            this.lblSecilenDosyaAdi.Size = new System.Drawing.Size(137, 20);
            this.lblSecilenDosyaAdi.TabIndex = 3;
            this.lblSecilenDosyaAdi.Text = "Seçilen Dosya Adı";
            // 
            // cbxKDKategori
            // 
            this.cbxKDKategori.FormattingEnabled = true;
            this.cbxKDKategori.Location = new System.Drawing.Point(86, 78);
            this.cbxKDKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxKDKategori.Name = "cbxKDKategori";
            this.cbxKDKategori.Size = new System.Drawing.Size(218, 28);
            this.cbxKDKategori.TabIndex = 1;
            // 
            // lblKDKategori
            // 
            this.lblKDKategori.AutoSize = true;
            this.lblKDKategori.Location = new System.Drawing.Point(16, 85);
            this.lblKDKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKDKategori.Name = "lblKDKategori";
            this.lblKDKategori.Size = new System.Drawing.Size(68, 20);
            this.lblKDKategori.TabIndex = 2;
            this.lblKDKategori.Text = "Kategori";
            // 
            // btnKDSec
            // 
            this.btnKDSec.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnKDSec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKDSec.Location = new System.Drawing.Point(20, 184);
            this.btnKDSec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKDSec.Name = "btnKDSec";
            this.btnKDSec.Size = new System.Drawing.Size(134, 44);
            this.btnKDSec.TabIndex = 0;
            this.btnKDSec.Text = "Doküman Seç";
            this.btnKDSec.UseVisualStyleBackColor = false;
            this.btnKDSec.Click += new System.EventHandler(this.btnKDEkle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // KurumsalDokumanIslemleriUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1088, 758);
            this.Controls.Add(this.gbxKDIslemleri);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KurumsalDokumanIslemleriUI";
            this.Text = "KurumsalDokumanIslemleriUI";
            this.Load += new System.EventHandler(this.KurumsalDokumanIslemleriUI_Load);
            this.gbxKDIslemleri.ResumeLayout(false);
            this.gbxKDIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKurumsalDokuman)).EndInit();
            this.gbxKDSil.ResumeLayout(false);
            this.gbxKDSil.PerformLayout();
            this.gbxKDEkle.ResumeLayout(false);
            this.gbxKDEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxKDIslemleri;
        private System.Windows.Forms.GroupBox gbxKDSil;
        private System.Windows.Forms.GroupBox gbxKDEkle;
        private System.Windows.Forms.Button btnKDSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbxKDKategori;
        private System.Windows.Forms.Label lblKDKategori;
        private System.Windows.Forms.Label lblSecilenDosyaAdi;
        private System.Windows.Forms.Label lblDosyaAdi;
        private System.Windows.Forms.Button btnKDKaydet;
        private System.Windows.Forms.ComboBox cbxSirket;
        private System.Windows.Forms.Label lblSirket;
        private System.Windows.Forms.DataGridView dgwKurumsalDokuman;
        private System.Windows.Forms.Button btnTumunuListele;
        private System.Windows.Forms.TextBox tbxDosyaPath;
        private System.Windows.Forms.Button btnDosyaSil;
        private System.Windows.Forms.Label lbldosyasecmesaji;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblDosyaAc;
        private System.Windows.Forms.CheckBox chbxOnay;
    }
}