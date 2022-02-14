
namespace IKYS
{
    partial class LogYonetimUI
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
            this.gbxLogYonetim = new System.Windows.Forms.GroupBox();
            this.gbxTopluArama = new System.Windows.Forms.GroupBox();
            this.btnTarihTopluListele = new System.Windows.Forms.Button();
            this.dtpTopluTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTopluTarih = new System.Windows.Forms.Label();
            this.gbxSicilNoAra = new System.Windows.Forms.GroupBox();
            this.cbxSicilNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSicilNoModul = new System.Windows.Forms.ComboBox();
            this.lblSicilNo = new System.Windows.Forms.Label();
            this.btnSicilNoAra = new System.Windows.Forms.Button();
            this.dtpSicilNoTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblSicilNoTarih = new System.Windows.Forms.Label();
            this.gbxArama = new System.Windows.Forms.GroupBox();
            this.lblSinirliTarih = new System.Windows.Forms.Label();
            this.btnCokluSecim = new System.Windows.Forms.Button();
            this.lblEylem = new System.Windows.Forms.Label();
            this.dtpSinirliSecimTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbxEylem = new System.Windows.Forms.ComboBox();
            this.lblModul = new System.Windows.Forms.Label();
            this.cbxModul = new System.Windows.Forms.ComboBox();
            this.btnTumunuListele = new System.Windows.Forms.Button();
            this.dgwLogYonetim = new System.Windows.Forms.DataGridView();
            this.gbxLogYonetim.SuspendLayout();
            this.gbxTopluArama.SuspendLayout();
            this.gbxSicilNoAra.SuspendLayout();
            this.gbxArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLogYonetim)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxLogYonetim
            // 
            this.gbxLogYonetim.Controls.Add(this.gbxTopluArama);
            this.gbxLogYonetim.Controls.Add(this.gbxSicilNoAra);
            this.gbxLogYonetim.Controls.Add(this.gbxArama);
            this.gbxLogYonetim.Controls.Add(this.btnTumunuListele);
            this.gbxLogYonetim.Controls.Add(this.dgwLogYonetim);
            this.gbxLogYonetim.Location = new System.Drawing.Point(22, 88);
            this.gbxLogYonetim.Name = "gbxLogYonetim";
            this.gbxLogYonetim.Size = new System.Drawing.Size(1125, 722);
            this.gbxLogYonetim.TabIndex = 0;
            this.gbxLogYonetim.TabStop = false;
            this.gbxLogYonetim.Text = "LOG YÖNETİMİ";
            // 
            // gbxTopluArama
            // 
            this.gbxTopluArama.Controls.Add(this.btnTarihTopluListele);
            this.gbxTopluArama.Controls.Add(this.dtpTopluTarih);
            this.gbxTopluArama.Controls.Add(this.lblTopluTarih);
            this.gbxTopluArama.Location = new System.Drawing.Point(767, 44);
            this.gbxTopluArama.Name = "gbxTopluArama";
            this.gbxTopluArama.Size = new System.Drawing.Size(346, 179);
            this.gbxTopluArama.TabIndex = 15;
            this.gbxTopluArama.TabStop = false;
            this.gbxTopluArama.Text = "Tarihe Göre Toplu Listeleme";
            // 
            // btnTarihTopluListele
            // 
            this.btnTarihTopluListele.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTarihTopluListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTarihTopluListele.Location = new System.Drawing.Point(138, 96);
            this.btnTarihTopluListele.Name = "btnTarihTopluListele";
            this.btnTarihTopluListele.Size = new System.Drawing.Size(190, 43);
            this.btnTarihTopluListele.TabIndex = 16;
            this.btnTarihTopluListele.Text = "Tarihe Göre Listele";
            this.btnTarihTopluListele.UseVisualStyleBackColor = false;
            this.btnTarihTopluListele.Click += new System.EventHandler(this.btnTarihTopluListele_Click);
            // 
            // dtpTopluTarih
            // 
            this.dtpTopluTarih.Location = new System.Drawing.Point(102, 59);
            this.dtpTopluTarih.Name = "dtpTopluTarih";
            this.dtpTopluTarih.Size = new System.Drawing.Size(226, 26);
            this.dtpTopluTarih.TabIndex = 14;
            // 
            // lblTopluTarih
            // 
            this.lblTopluTarih.AutoSize = true;
            this.lblTopluTarih.Location = new System.Drawing.Point(52, 65);
            this.lblTopluTarih.Name = "lblTopluTarih";
            this.lblTopluTarih.Size = new System.Drawing.Size(44, 20);
            this.lblTopluTarih.TabIndex = 15;
            this.lblTopluTarih.Text = "Tarih";
            // 
            // gbxSicilNoAra
            // 
            this.gbxSicilNoAra.Controls.Add(this.cbxSicilNo);
            this.gbxSicilNoAra.Controls.Add(this.label1);
            this.gbxSicilNoAra.Controls.Add(this.cbxSicilNoModul);
            this.gbxSicilNoAra.Controls.Add(this.lblSicilNo);
            this.gbxSicilNoAra.Controls.Add(this.btnSicilNoAra);
            this.gbxSicilNoAra.Controls.Add(this.dtpSicilNoTarihi);
            this.gbxSicilNoAra.Controls.Add(this.lblSicilNoTarih);
            this.gbxSicilNoAra.Location = new System.Drawing.Point(383, 44);
            this.gbxSicilNoAra.Name = "gbxSicilNoAra";
            this.gbxSicilNoAra.Size = new System.Drawing.Size(358, 259);
            this.gbxSicilNoAra.TabIndex = 14;
            this.gbxSicilNoAra.TabStop = false;
            this.gbxSicilNoAra.Text = "Sicil No İle Ara";
            // 
            // cbxSicilNo
            // 
            this.cbxSicilNo.FormattingEnabled = true;
            this.cbxSicilNo.Location = new System.Drawing.Point(102, 157);
            this.cbxSicilNo.Name = "cbxSicilNo";
            this.cbxSicilNo.Size = new System.Drawing.Size(221, 28);
            this.cbxSicilNo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Modul";
            // 
            // cbxSicilNoModul
            // 
            this.cbxSicilNoModul.FormattingEnabled = true;
            this.cbxSicilNoModul.Items.AddRange(new object[] {
            "ŞİRKET YÖNETİMİ",
            "BÖLÜM YÖNETİMİ",
            "GÖREV YÖNETİMİ",
            "PERSONEL YÖNETİMİ",
            "KD KATEGORİ YÖNETİMİ",
            "PD KATEGORİ YÖNETİMİ",
            "KURUMSAL DOKÜMAN İŞLEMLERİ",
            "PERSONEL DOKÜMAN İŞLEMLERİ",
            "BORDRO YÖNETİMİ"});
            this.cbxSicilNoModul.Location = new System.Drawing.Point(97, 104);
            this.cbxSicilNoModul.Name = "cbxSicilNoModul";
            this.cbxSicilNoModul.Size = new System.Drawing.Size(226, 28);
            this.cbxSicilNoModul.TabIndex = 14;
            // 
            // lblSicilNo
            // 
            this.lblSicilNo.AutoSize = true;
            this.lblSicilNo.Location = new System.Drawing.Point(30, 157);
            this.lblSicilNo.Name = "lblSicilNo";
            this.lblSicilNo.Size = new System.Drawing.Size(61, 20);
            this.lblSicilNo.TabIndex = 9;
            this.lblSicilNo.Text = "Sicil No";
            // 
            // btnSicilNoAra
            // 
            this.btnSicilNoAra.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSicilNoAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSicilNoAra.Location = new System.Drawing.Point(212, 195);
            this.btnSicilNoAra.Name = "btnSicilNoAra";
            this.btnSicilNoAra.Size = new System.Drawing.Size(111, 43);
            this.btnSicilNoAra.TabIndex = 10;
            this.btnSicilNoAra.Text = "Ara";
            this.btnSicilNoAra.UseVisualStyleBackColor = false;
            this.btnSicilNoAra.Click += new System.EventHandler(this.btnSicilNoAra_Click);
            // 
            // dtpSicilNoTarihi
            // 
            this.dtpSicilNoTarihi.Location = new System.Drawing.Point(97, 60);
            this.dtpSicilNoTarihi.Name = "dtpSicilNoTarihi";
            this.dtpSicilNoTarihi.Size = new System.Drawing.Size(226, 26);
            this.dtpSicilNoTarihi.TabIndex = 11;
            // 
            // lblSicilNoTarih
            // 
            this.lblSicilNoTarih.AutoSize = true;
            this.lblSicilNoTarih.Location = new System.Drawing.Point(49, 65);
            this.lblSicilNoTarih.Name = "lblSicilNoTarih";
            this.lblSicilNoTarih.Size = new System.Drawing.Size(44, 20);
            this.lblSicilNoTarih.TabIndex = 13;
            this.lblSicilNoTarih.Text = "Tarih";
            // 
            // gbxArama
            // 
            this.gbxArama.Controls.Add(this.lblSinirliTarih);
            this.gbxArama.Controls.Add(this.btnCokluSecim);
            this.gbxArama.Controls.Add(this.lblEylem);
            this.gbxArama.Controls.Add(this.dtpSinirliSecimTarihi);
            this.gbxArama.Controls.Add(this.cbxEylem);
            this.gbxArama.Controls.Add(this.lblModul);
            this.gbxArama.Controls.Add(this.cbxModul);
            this.gbxArama.Location = new System.Drawing.Point(30, 44);
            this.gbxArama.Name = "gbxArama";
            this.gbxArama.Size = new System.Drawing.Size(313, 259);
            this.gbxArama.TabIndex = 7;
            this.gbxArama.TabStop = false;
            this.gbxArama.Text = "Sınırlı Listeleme";
            // 
            // lblSinirliTarih
            // 
            this.lblSinirliTarih.AutoSize = true;
            this.lblSinirliTarih.Location = new System.Drawing.Point(19, 65);
            this.lblSinirliTarih.Name = "lblSinirliTarih";
            this.lblSinirliTarih.Size = new System.Drawing.Size(44, 20);
            this.lblSinirliTarih.TabIndex = 14;
            this.lblSinirliTarih.Text = "Tarih";
            // 
            // btnCokluSecim
            // 
            this.btnCokluSecim.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCokluSecim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCokluSecim.Location = new System.Drawing.Point(181, 195);
            this.btnCokluSecim.Name = "btnCokluSecim";
            this.btnCokluSecim.Size = new System.Drawing.Size(114, 43);
            this.btnCokluSecim.TabIndex = 11;
            this.btnCokluSecim.Text = "Sınırlı Listele";
            this.btnCokluSecim.UseVisualStyleBackColor = false;
            this.btnCokluSecim.Click += new System.EventHandler(this.btnCokluSecim_Click);
            // 
            // lblEylem
            // 
            this.lblEylem.AutoSize = true;
            this.lblEylem.Location = new System.Drawing.Point(11, 112);
            this.lblEylem.Name = "lblEylem";
            this.lblEylem.Size = new System.Drawing.Size(52, 20);
            this.lblEylem.TabIndex = 2;
            this.lblEylem.Text = "Eylem";
            // 
            // dtpSinirliSecimTarihi
            // 
            this.dtpSinirliSecimTarihi.Location = new System.Drawing.Point(69, 60);
            this.dtpSinirliSecimTarihi.Name = "dtpSinirliSecimTarihi";
            this.dtpSinirliSecimTarihi.Size = new System.Drawing.Size(226, 26);
            this.dtpSinirliSecimTarihi.TabIndex = 12;
            // 
            // cbxEylem
            // 
            this.cbxEylem.FormattingEnabled = true;
            this.cbxEylem.Items.AddRange(new object[] {
            "EKLEME",
            "SİLME",
            "GÜNCELLEME"});
            this.cbxEylem.Location = new System.Drawing.Point(69, 104);
            this.cbxEylem.Name = "cbxEylem";
            this.cbxEylem.Size = new System.Drawing.Size(226, 28);
            this.cbxEylem.TabIndex = 1;
            this.cbxEylem.SelectedIndexChanged += new System.EventHandler(this.cbxEylem_SelectedIndexChanged);
            // 
            // lblModul
            // 
            this.lblModul.AutoSize = true;
            this.lblModul.Location = new System.Drawing.Point(11, 159);
            this.lblModul.Name = "lblModul";
            this.lblModul.Size = new System.Drawing.Size(52, 20);
            this.lblModul.TabIndex = 5;
            this.lblModul.Text = "Modul";
            // 
            // cbxModul
            // 
            this.cbxModul.FormattingEnabled = true;
            this.cbxModul.Items.AddRange(new object[] {
            "ŞİRKET YÖNETİMİ",
            "BÖLÜM YÖNETİMİ",
            "GÖREV YÖNETİMİ",
            "PERSONEL YÖNETİMİ",
            "KD KATEGORİ YÖNETİMİ",
            "PD KATEGORİ YÖNETİMİ",
            "KURUMSAL DOKÜMAN İŞLEMLERİ",
            "PERSONEL DOKÜMAN İŞLEMLERİ",
            "BORDRO YÖNETİMİ"});
            this.cbxModul.Location = new System.Drawing.Point(69, 151);
            this.cbxModul.Name = "cbxModul";
            this.cbxModul.Size = new System.Drawing.Size(226, 28);
            this.cbxModul.TabIndex = 4;
            this.cbxModul.SelectedIndexChanged += new System.EventHandler(this.cbxModul_SelectedIndexChanged);
            // 
            // btnTumunuListele
            // 
            this.btnTumunuListele.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTumunuListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTumunuListele.Location = new System.Drawing.Point(905, 239);
            this.btnTumunuListele.Name = "btnTumunuListele";
            this.btnTumunuListele.Size = new System.Drawing.Size(190, 43);
            this.btnTumunuListele.TabIndex = 6;
            this.btnTumunuListele.Text = "Tüm Kayıtları Listele";
            this.btnTumunuListele.UseVisualStyleBackColor = false;
            this.btnTumunuListele.Click += new System.EventHandler(this.btnTumunuListele_Click);
            // 
            // dgwLogYonetim
            // 
            this.dgwLogYonetim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLogYonetim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLogYonetim.Location = new System.Drawing.Point(30, 322);
            this.dgwLogYonetim.Name = "dgwLogYonetim";
            this.dgwLogYonetim.RowHeadersWidth = 62;
            this.dgwLogYonetim.RowTemplate.Height = 28;
            this.dgwLogYonetim.Size = new System.Drawing.Size(1083, 329);
            this.dgwLogYonetim.TabIndex = 0;
            // 
            // LogYonetimUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1174, 1108);
            this.Controls.Add(this.gbxLogYonetim);
            this.Name = "LogYonetimUI";
            this.Text = "LogYonetimUI";
            this.Load += new System.EventHandler(this.LogYonetimUI_Load);
            this.gbxLogYonetim.ResumeLayout(false);
            this.gbxTopluArama.ResumeLayout(false);
            this.gbxTopluArama.PerformLayout();
            this.gbxSicilNoAra.ResumeLayout(false);
            this.gbxSicilNoAra.PerformLayout();
            this.gbxArama.ResumeLayout(false);
            this.gbxArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLogYonetim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogYonetim;
        private System.Windows.Forms.DataGridView dgwLogYonetim;
        private System.Windows.Forms.ComboBox cbxEylem;
        private System.Windows.Forms.Label lblEylem;
        private System.Windows.Forms.Label lblModul;
        private System.Windows.Forms.ComboBox cbxModul;
        private System.Windows.Forms.GroupBox gbxArama;
        private System.Windows.Forms.Button btnTumunuListele;
        private System.Windows.Forms.Button btnSicilNoAra;
        private System.Windows.Forms.Label lblSicilNo;
        private System.Windows.Forms.Button btnCokluSecim;
        private System.Windows.Forms.DateTimePicker dtpSicilNoTarihi;
        private System.Windows.Forms.Label lblSicilNoTarih;
        private System.Windows.Forms.DateTimePicker dtpSinirliSecimTarihi;
        private System.Windows.Forms.Label lblSinirliTarih;
        private System.Windows.Forms.GroupBox gbxSicilNoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSicilNoModul;
        private System.Windows.Forms.GroupBox gbxTopluArama;
        private System.Windows.Forms.Button btnTarihTopluListele;
        private System.Windows.Forms.DateTimePicker dtpTopluTarih;
        private System.Windows.Forms.Label lblTopluTarih;
        private System.Windows.Forms.ComboBox cbxSicilNo;
    }
}