
namespace IKYS
{
    partial class PersonelDokumanIslemleriUI
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
            this.gbxPersonelDokuman = new System.Windows.Forms.GroupBox();
            this.dgwPersonelDokuman = new System.Windows.Forms.DataGridView();
            this.llblDosyaAc = new System.Windows.Forms.LinkLabel();
            this.lblDosyaAc = new System.Windows.Forms.Label();
            this.btnSicilveKategoriAra = new System.Windows.Forms.Button();
            this.gbxDokumanAra = new System.Windows.Forms.GroupBox();
            this.btnkategoriara = new System.Windows.Forms.Button();
            this.btnSicilNoAra = new System.Windows.Forms.Button();
            this.lblKategoriAra = new System.Windows.Forms.Label();
            this.cbxPDKategoriAra = new System.Windows.Forms.ComboBox();
            this.cbxSicilNoAra = new System.Windows.Forms.ComboBox();
            this.lblSicilNoAra = new System.Windows.Forms.Label();
            this.btnTumunuListele = new System.Windows.Forms.Button();
            this.gbxKDSil = new System.Windows.Forms.GroupBox();
            this.lbldosyasecmesaji = new System.Windows.Forms.Label();
            this.tbxPersonelDosyaPath = new System.Windows.Forms.TextBox();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.btnDosyaSil = new System.Windows.Forms.Button();
            this.chbxOnay = new System.Windows.Forms.CheckBox();
            this.gbxKDEkle = new System.Windows.Forms.GroupBox();
            this.cbxPDKategori = new System.Windows.Forms.ComboBox();
            this.cbxSicilNo = new System.Windows.Forms.ComboBox();
            this.lblSicilNo = new System.Windows.Forms.Label();
            this.btnPDKaydet = new System.Windows.Forms.Button();
            this.lblDosyaAdi = new System.Windows.Forms.Label();
            this.lblKDKategori = new System.Windows.Forms.Label();
            this.btnPDSec = new System.Windows.Forms.Button();
            this.gbxPersonelDokuman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelDokuman)).BeginInit();
            this.gbxDokumanAra.SuspendLayout();
            this.gbxKDSil.SuspendLayout();
            this.gbxKDEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPersonelDokuman
            // 
            this.gbxPersonelDokuman.Controls.Add(this.dgwPersonelDokuman);
            this.gbxPersonelDokuman.Controls.Add(this.llblDosyaAc);
            this.gbxPersonelDokuman.Controls.Add(this.lblDosyaAc);
            this.gbxPersonelDokuman.Controls.Add(this.btnSicilveKategoriAra);
            this.gbxPersonelDokuman.Controls.Add(this.gbxDokumanAra);
            this.gbxPersonelDokuman.Controls.Add(this.btnTumunuListele);
            this.gbxPersonelDokuman.Controls.Add(this.gbxKDSil);
            this.gbxPersonelDokuman.Controls.Add(this.gbxKDEkle);
            this.gbxPersonelDokuman.Location = new System.Drawing.Point(9, 118);
            this.gbxPersonelDokuman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxPersonelDokuman.Name = "gbxPersonelDokuman";
            this.gbxPersonelDokuman.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxPersonelDokuman.Size = new System.Drawing.Size(1228, 789);
            this.gbxPersonelDokuman.TabIndex = 1;
            this.gbxPersonelDokuman.TabStop = false;
            this.gbxPersonelDokuman.Text = "PERSONEL DOKÜMAN İŞLEMLERİ";
            // 
            // dgwPersonelDokuman
            // 
            this.dgwPersonelDokuman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPersonelDokuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonelDokuman.Location = new System.Drawing.Point(27, 323);
            this.dgwPersonelDokuman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwPersonelDokuman.Name = "dgwPersonelDokuman";
            this.dgwPersonelDokuman.ReadOnly = true;
            this.dgwPersonelDokuman.RowHeadersWidth = 82;
            this.dgwPersonelDokuman.RowTemplate.Height = 33;
            this.dgwPersonelDokuman.Size = new System.Drawing.Size(1157, 322);
            this.dgwPersonelDokuman.TabIndex = 3;
            this.dgwPersonelDokuman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPersonelDokuman_CellContentClick);
            // 
            // llblDosyaAc
            // 
            this.llblDosyaAc.AutoSize = true;
            this.llblDosyaAc.Location = new System.Drawing.Point(137, 291);
            this.llblDosyaAc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblDosyaAc.Name = "llblDosyaAc";
            this.llblDosyaAc.Size = new System.Drawing.Size(222, 20);
            this.llblDosyaAc.TabIndex = 10;
            this.llblDosyaAc.TabStop = true;
            this.llblDosyaAc.Text = "Tablodan bir dokuman seçiniz.";
            this.llblDosyaAc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDosyaAc_LinkClicked);
            // 
            // lblDosyaAc
            // 
            this.lblDosyaAc.AutoSize = true;
            this.lblDosyaAc.Location = new System.Drawing.Point(41, 291);
            this.lblDosyaAc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDosyaAc.Name = "lblDosyaAc";
            this.lblDosyaAc.Size = new System.Drawing.Size(94, 20);
            this.lblDosyaAc.TabIndex = 9;
            this.lblDosyaAc.Text = "Dosya Yolu:";
            // 
            // btnSicilveKategoriAra
            // 
            this.btnSicilveKategoriAra.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSicilveKategoriAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSicilveKategoriAra.Location = new System.Drawing.Point(430, 194);
            this.btnSicilveKategoriAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSicilveKategoriAra.Name = "btnSicilveKategoriAra";
            this.btnSicilveKategoriAra.Size = new System.Drawing.Size(172, 62);
            this.btnSicilveKategoriAra.TabIndex = 8;
            this.btnSicilveKategoriAra.Text = "Sicil ve Kategori İle Ara";
            this.btnSicilveKategoriAra.UseVisualStyleBackColor = false;
            this.btnSicilveKategoriAra.Click += new System.EventHandler(this.btnSicilveKategoriAra_Click);
            // 
            // gbxDokumanAra
            // 
            this.gbxDokumanAra.Controls.Add(this.btnkategoriara);
            this.gbxDokumanAra.Controls.Add(this.btnSicilNoAra);
            this.gbxDokumanAra.Controls.Add(this.lblKategoriAra);
            this.gbxDokumanAra.Controls.Add(this.cbxPDKategoriAra);
            this.gbxDokumanAra.Controls.Add(this.cbxSicilNoAra);
            this.gbxDokumanAra.Controls.Add(this.lblSicilNoAra);
            this.gbxDokumanAra.Location = new System.Drawing.Point(347, 47);
            this.gbxDokumanAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxDokumanAra.Name = "gbxDokumanAra";
            this.gbxDokumanAra.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxDokumanAra.Size = new System.Drawing.Size(404, 228);
            this.gbxDokumanAra.TabIndex = 5;
            this.gbxDokumanAra.TabStop = false;
            this.gbxDokumanAra.Text = "Doküman Ara";
            // 
            // btnkategoriara
            // 
            this.btnkategoriara.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnkategoriara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkategoriara.Location = new System.Drawing.Point(260, 92);
            this.btnkategoriara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnkategoriara.Name = "btnkategoriara";
            this.btnkategoriara.Size = new System.Drawing.Size(132, 44);
            this.btnkategoriara.TabIndex = 7;
            this.btnkategoriara.Text = "Kategori İle Ara";
            this.btnkategoriara.UseVisualStyleBackColor = false;
            this.btnkategoriara.Click += new System.EventHandler(this.btnkategoriara_Click);
            // 
            // btnSicilNoAra
            // 
            this.btnSicilNoAra.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSicilNoAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSicilNoAra.Location = new System.Drawing.Point(260, 39);
            this.btnSicilNoAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSicilNoAra.Name = "btnSicilNoAra";
            this.btnSicilNoAra.Size = new System.Drawing.Size(132, 44);
            this.btnSicilNoAra.TabIndex = 6;
            this.btnSicilNoAra.Text = "Sicil İle ara";
            this.btnSicilNoAra.UseVisualStyleBackColor = false;
            this.btnSicilNoAra.Click += new System.EventHandler(this.btnSicilNoAra_Click);
            // 
            // lblKategoriAra
            // 
            this.lblKategoriAra.AutoSize = true;
            this.lblKategoriAra.Location = new System.Drawing.Point(16, 104);
            this.lblKategoriAra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategoriAra.Name = "lblKategoriAra";
            this.lblKategoriAra.Size = new System.Drawing.Size(68, 20);
            this.lblKategoriAra.TabIndex = 3;
            this.lblKategoriAra.Text = "Kategori";
            // 
            // cbxPDKategoriAra
            // 
            this.cbxPDKategoriAra.FormattingEnabled = true;
            this.cbxPDKategoriAra.Location = new System.Drawing.Point(84, 102);
            this.cbxPDKategoriAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxPDKategoriAra.Name = "cbxPDKategoriAra";
            this.cbxPDKategoriAra.Size = new System.Drawing.Size(173, 28);
            this.cbxPDKategoriAra.TabIndex = 2;
            // 
            // cbxSicilNoAra
            // 
            this.cbxSicilNoAra.FormattingEnabled = true;
            this.cbxSicilNoAra.Location = new System.Drawing.Point(84, 45);
            this.cbxSicilNoAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSicilNoAra.Name = "cbxSicilNoAra";
            this.cbxSicilNoAra.Size = new System.Drawing.Size(173, 28);
            this.cbxSicilNoAra.TabIndex = 0;
            // 
            // lblSicilNoAra
            // 
            this.lblSicilNoAra.AutoSize = true;
            this.lblSicilNoAra.Location = new System.Drawing.Point(16, 51);
            this.lblSicilNoAra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSicilNoAra.Name = "lblSicilNoAra";
            this.lblSicilNoAra.Size = new System.Drawing.Size(61, 20);
            this.lblSicilNoAra.TabIndex = 1;
            this.lblSicilNoAra.Text = "Sicil No";
            // 
            // btnTumunuListele
            // 
            this.btnTumunuListele.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTumunuListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTumunuListele.Location = new System.Drawing.Point(914, 231);
            this.btnTumunuListele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTumunuListele.Name = "btnTumunuListele";
            this.btnTumunuListele.Size = new System.Drawing.Size(271, 44);
            this.btnTumunuListele.TabIndex = 4;
            this.btnTumunuListele.Text = "Tüm Kayıtları Listele";
            this.btnTumunuListele.UseVisualStyleBackColor = false;
            this.btnTumunuListele.Click += new System.EventHandler(this.btnTumunuListele_Click);
            // 
            // gbxKDSil
            // 
            this.gbxKDSil.Controls.Add(this.lbldosyasecmesaji);
            this.gbxKDSil.Controls.Add(this.tbxPersonelDosyaPath);
            this.gbxKDSil.Controls.Add(this.lblDosyaYolu);
            this.gbxKDSil.Controls.Add(this.btnDosyaSil);
            this.gbxKDSil.Controls.Add(this.chbxOnay);
            this.gbxKDSil.Location = new System.Drawing.Point(770, 47);
            this.gbxKDSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxKDSil.Name = "gbxKDSil";
            this.gbxKDSil.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxKDSil.Size = new System.Drawing.Size(430, 161);
            this.gbxKDSil.TabIndex = 2;
            this.gbxKDSil.TabStop = false;
            this.gbxKDSil.Text = "Doküman Sil";
            // 
            // lbldosyasecmesaji
            // 
            this.lbldosyasecmesaji.AutoSize = true;
            this.lbldosyasecmesaji.Location = new System.Drawing.Point(160, 31);
            this.lbldosyasecmesaji.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldosyasecmesaji.Name = "lbldosyasecmesaji";
            this.lbldosyasecmesaji.Size = new System.Drawing.Size(257, 20);
            this.lbldosyasecmesaji.TabIndex = 4;
            this.lbldosyasecmesaji.Text = "Dosyayı aşağıdaki tablodan seçiniz.";
            // 
            // tbxPersonelDosyaPath
            // 
            this.tbxPersonelDosyaPath.Location = new System.Drawing.Point(107, 58);
            this.tbxPersonelDosyaPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxPersonelDosyaPath.Name = "tbxPersonelDosyaPath";
            this.tbxPersonelDosyaPath.ReadOnly = true;
            this.tbxPersonelDosyaPath.Size = new System.Drawing.Size(308, 26);
            this.tbxPersonelDosyaPath.TabIndex = 0;
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.Location = new System.Drawing.Point(10, 58);
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
            this.btnDosyaSil.Location = new System.Drawing.Point(254, 94);
            this.btnDosyaSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDosyaSil.Name = "btnDosyaSil";
            this.btnDosyaSil.Size = new System.Drawing.Size(160, 38);
            this.btnDosyaSil.TabIndex = 2;
            this.btnDosyaSil.Text = "Dosya Sil";
            this.btnDosyaSil.UseVisualStyleBackColor = false;
            this.btnDosyaSil.Click += new System.EventHandler(this.btnDosyaSil_Click);
            // 
            // chbxOnay
            // 
            this.chbxOnay.AutoSize = true;
            this.chbxOnay.Location = new System.Drawing.Point(111, 98);
            this.chbxOnay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbxOnay.Name = "chbxOnay";
            this.chbxOnay.Size = new System.Drawing.Size(137, 24);
            this.chbxOnay.TabIndex = 5;
            this.chbxOnay.Text = "Silmeyi Onayla";
            this.chbxOnay.UseVisualStyleBackColor = true;
            // 
            // gbxKDEkle
            // 
            this.gbxKDEkle.Controls.Add(this.cbxPDKategori);
            this.gbxKDEkle.Controls.Add(this.cbxSicilNo);
            this.gbxKDEkle.Controls.Add(this.lblSicilNo);
            this.gbxKDEkle.Controls.Add(this.btnPDKaydet);
            this.gbxKDEkle.Controls.Add(this.lblDosyaAdi);
            this.gbxKDEkle.Controls.Add(this.lblKDKategori);
            this.gbxKDEkle.Controls.Add(this.btnPDSec);
            this.gbxKDEkle.Location = new System.Drawing.Point(27, 47);
            this.gbxKDEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxKDEkle.Name = "gbxKDEkle";
            this.gbxKDEkle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxKDEkle.Size = new System.Drawing.Size(307, 228);
            this.gbxKDEkle.TabIndex = 0;
            this.gbxKDEkle.TabStop = false;
            this.gbxKDEkle.Text = "Doküman Ekle";
            // 
            // cbxPDKategori
            // 
            this.cbxPDKategori.FormattingEnabled = true;
            this.cbxPDKategori.Location = new System.Drawing.Point(86, 78);
            this.cbxPDKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxPDKategori.Name = "cbxPDKategori";
            this.cbxPDKategori.Size = new System.Drawing.Size(193, 28);
            this.cbxPDKategori.TabIndex = 1;
            // 
            // cbxSicilNo
            // 
            this.cbxSicilNo.FormattingEnabled = true;
            this.cbxSicilNo.Location = new System.Drawing.Point(86, 45);
            this.cbxSicilNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSicilNo.Name = "cbxSicilNo";
            this.cbxSicilNo.Size = new System.Drawing.Size(193, 28);
            this.cbxSicilNo.TabIndex = 6;
            // 
            // lblSicilNo
            // 
            this.lblSicilNo.AutoSize = true;
            this.lblSicilNo.Location = new System.Drawing.Point(24, 51);
            this.lblSicilNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSicilNo.Name = "lblSicilNo";
            this.lblSicilNo.Size = new System.Drawing.Size(61, 20);
            this.lblSicilNo.TabIndex = 7;
            this.lblSicilNo.Text = "Sicil No";
            // 
            // btnPDKaydet
            // 
            this.btnPDKaydet.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnPDKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDKaydet.Location = new System.Drawing.Point(156, 165);
            this.btnPDKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPDKaydet.Name = "btnPDKaydet";
            this.btnPDKaydet.Size = new System.Drawing.Size(134, 44);
            this.btnPDKaydet.TabIndex = 5;
            this.btnPDKaydet.Text = "Kaydet";
            this.btnPDKaydet.UseVisualStyleBackColor = false;
            this.btnPDKaydet.Click += new System.EventHandler(this.btnPDKaydet_Click);
            // 
            // lblDosyaAdi
            // 
            this.lblDosyaAdi.AutoSize = true;
            this.lblDosyaAdi.Location = new System.Drawing.Point(24, 124);
            this.lblDosyaAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDosyaAdi.Name = "lblDosyaAdi";
            this.lblDosyaAdi.Size = new System.Drawing.Size(77, 20);
            this.lblDosyaAdi.TabIndex = 4;
            this.lblDosyaAdi.Text = "DosyaAdı";
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
            // btnPDSec
            // 
            this.btnPDSec.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnPDSec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDSec.Location = new System.Drawing.Point(18, 165);
            this.btnPDSec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPDSec.Name = "btnPDSec";
            this.btnPDSec.Size = new System.Drawing.Size(134, 44);
            this.btnPDSec.TabIndex = 0;
            this.btnPDSec.Text = "Doküman Seç";
            this.btnPDSec.UseVisualStyleBackColor = false;
            this.btnPDSec.Click += new System.EventHandler(this.btnPDSec_Click);
            // 
            // PersonelDokumanIslemleriUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1250, 930);
            this.Controls.Add(this.gbxPersonelDokuman);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PersonelDokumanIslemleriUI";
            this.Text = "PersonelDokumanIslemleriUI";
            this.Load += new System.EventHandler(this.PersonelDokumanIslemleriUI_Load);
            this.gbxPersonelDokuman.ResumeLayout(false);
            this.gbxPersonelDokuman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelDokuman)).EndInit();
            this.gbxDokumanAra.ResumeLayout(false);
            this.gbxDokumanAra.PerformLayout();
            this.gbxKDSil.ResumeLayout(false);
            this.gbxKDSil.PerformLayout();
            this.gbxKDEkle.ResumeLayout(false);
            this.gbxKDEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPersonelDokuman;
        private System.Windows.Forms.Button btnTumunuListele;
        private System.Windows.Forms.DataGridView dgwPersonelDokuman;
        private System.Windows.Forms.GroupBox gbxKDSil;
        private System.Windows.Forms.Label lbldosyasecmesaji;
        private System.Windows.Forms.TextBox tbxPersonelDosyaPath;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.Button btnDosyaSil;
        private System.Windows.Forms.GroupBox gbxKDEkle;
        private System.Windows.Forms.ComboBox cbxSicilNo;
        private System.Windows.Forms.Label lblSicilNo;
        private System.Windows.Forms.Button btnPDKaydet;
        private System.Windows.Forms.Label lblDosyaAdi;
        private System.Windows.Forms.ComboBox cbxPDKategori;
        private System.Windows.Forms.Label lblKDKategori;
        private System.Windows.Forms.Button btnPDSec;
        private System.Windows.Forms.GroupBox gbxDokumanAra;
        private System.Windows.Forms.Label lblKategoriAra;
        private System.Windows.Forms.ComboBox cbxPDKategoriAra;
        private System.Windows.Forms.ComboBox cbxSicilNoAra;
        private System.Windows.Forms.Label lblSicilNoAra;
        private System.Windows.Forms.Button btnSicilNoAra;
        private System.Windows.Forms.Button btnkategoriara;
        private System.Windows.Forms.Button btnSicilveKategoriAra;
        private System.Windows.Forms.Label lblDosyaAc;
        private System.Windows.Forms.LinkLabel llblDosyaAc;
        private System.Windows.Forms.CheckBox chbxOnay;
    }
}