
namespace IKYS
{
    partial class BolumUI
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
            this.gbxBolum = new System.Windows.Forms.GroupBox();
            this.lbluyarı = new System.Windows.Forms.Label();
            this.cbxSirketAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBolumListele = new System.Windows.Forms.Button();
            this.tbxBolumAdi = new System.Windows.Forms.TextBox();
            this.lblBolumAdi = new System.Windows.Forms.Label();
            this.btnBolumGuncelle = new System.Windows.Forms.Button();
            this.lblBolumSil = new System.Windows.Forms.Button();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.dgwBolum = new System.Windows.Forms.DataGridView();
            this.gbxBolum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBolum)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBolum
            // 
            this.gbxBolum.Controls.Add(this.lbluyarı);
            this.gbxBolum.Controls.Add(this.cbxSirketAdi);
            this.gbxBolum.Controls.Add(this.label1);
            this.gbxBolum.Controls.Add(this.lblBolumListele);
            this.gbxBolum.Controls.Add(this.tbxBolumAdi);
            this.gbxBolum.Controls.Add(this.lblBolumAdi);
            this.gbxBolum.Controls.Add(this.btnBolumGuncelle);
            this.gbxBolum.Controls.Add(this.lblBolumSil);
            this.gbxBolum.Controls.Add(this.btnBolumEkle);
            this.gbxBolum.Controls.Add(this.dgwBolum);
            this.gbxBolum.Location = new System.Drawing.Point(29, 89);
            this.gbxBolum.Name = "gbxBolum";
            this.gbxBolum.Size = new System.Drawing.Size(825, 346);
            this.gbxBolum.TabIndex = 1;
            this.gbxBolum.TabStop = false;
            this.gbxBolum.Text = "BÖLÜM YÖNETİMİ";
            // 
            // lbluyarı
            // 
            this.lbluyarı.AutoSize = true;
            this.lbluyarı.Location = new System.Drawing.Point(243, 313);
            this.lbluyarı.Name = "lbluyarı";
            this.lbluyarı.Size = new System.Drawing.Size(392, 20);
            this.lbluyarı.TabIndex = 9;
            this.lbluyarı.Text = "Güncelleme ve silme için lütfen tablodan seçim yapınız.";
            // 
            // cbxSirketAdi
            // 
            this.cbxSirketAdi.FormattingEnabled = true;
            this.cbxSirketAdi.Location = new System.Drawing.Point(439, 49);
            this.cbxSirketAdi.Name = "cbxSirketAdi";
            this.cbxSirketAdi.Size = new System.Drawing.Size(185, 28);
            this.cbxSirketAdi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şirket Adı";
            // 
            // lblBolumListele
            // 
            this.lblBolumListele.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblBolumListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBolumListele.Location = new System.Drawing.Point(648, 204);
            this.lblBolumListele.Name = "lblBolumListele";
            this.lblBolumListele.Size = new System.Drawing.Size(134, 48);
            this.lblBolumListele.TabIndex = 6;
            this.lblBolumListele.Text = "Bolum Listele";
            this.lblBolumListele.UseVisualStyleBackColor = false;
            this.lblBolumListele.Click += new System.EventHandler(this.lblBolumListele_Click);
            // 
            // tbxBolumAdi
            // 
            this.tbxBolumAdi.Location = new System.Drawing.Point(111, 49);
            this.tbxBolumAdi.Name = "tbxBolumAdi";
            this.tbxBolumAdi.Size = new System.Drawing.Size(239, 26);
            this.tbxBolumAdi.TabIndex = 4;
            // 
            // lblBolumAdi
            // 
            this.lblBolumAdi.AutoSize = true;
            this.lblBolumAdi.Location = new System.Drawing.Point(26, 55);
            this.lblBolumAdi.Name = "lblBolumAdi";
            this.lblBolumAdi.Size = new System.Drawing.Size(81, 20);
            this.lblBolumAdi.TabIndex = 5;
            this.lblBolumAdi.Text = "Bolüm Adı";
            // 
            // btnBolumGuncelle
            // 
            this.btnBolumGuncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBolumGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBolumGuncelle.Location = new System.Drawing.Point(648, 150);
            this.btnBolumGuncelle.Name = "btnBolumGuncelle";
            this.btnBolumGuncelle.Size = new System.Drawing.Size(134, 48);
            this.btnBolumGuncelle.TabIndex = 3;
            this.btnBolumGuncelle.Text = "Bölüm Güncelle";
            this.btnBolumGuncelle.UseVisualStyleBackColor = false;
            this.btnBolumGuncelle.Click += new System.EventHandler(this.btnBolumGuncelle_Click);
            // 
            // lblBolumSil
            // 
            this.lblBolumSil.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblBolumSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBolumSil.Location = new System.Drawing.Point(648, 258);
            this.lblBolumSil.Name = "lblBolumSil";
            this.lblBolumSil.Size = new System.Drawing.Size(134, 48);
            this.lblBolumSil.TabIndex = 2;
            this.lblBolumSil.Text = "Bolum Sil";
            this.lblBolumSil.UseVisualStyleBackColor = false;
            this.lblBolumSil.Click += new System.EventHandler(this.lblBolumSil_Click);
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBolumEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBolumEkle.Location = new System.Drawing.Point(648, 96);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(134, 48);
            this.btnBolumEkle.TabIndex = 1;
            this.btnBolumEkle.Text = "Bolum Ekle";
            this.btnBolumEkle.UseVisualStyleBackColor = false;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // dgwBolum
            // 
            this.dgwBolum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBolum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBolum.Location = new System.Drawing.Point(20, 96);
            this.dgwBolum.Name = "dgwBolum";
            this.dgwBolum.ReadOnly = true;
            this.dgwBolum.RowHeadersWidth = 62;
            this.dgwBolum.RowTemplate.Height = 28;
            this.dgwBolum.Size = new System.Drawing.Size(613, 210);
            this.dgwBolum.TabIndex = 0;
            this.dgwBolum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBolum_CellContentClick);
            // 
            // BolumUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(895, 436);
            this.Controls.Add(this.gbxBolum);
            this.Name = "BolumUI";
            this.Text = "BolumUI";
            this.Load += new System.EventHandler(this.BolumUI_Load);
            this.gbxBolum.ResumeLayout(false);
            this.gbxBolum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBolum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBolum;
        private System.Windows.Forms.Button lblBolumListele;
        private System.Windows.Forms.TextBox tbxBolumAdi;
        private System.Windows.Forms.Label lblBolumAdi;
        private System.Windows.Forms.Button btnBolumGuncelle;
        private System.Windows.Forms.Button lblBolumSil;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.DataGridView dgwBolum;
        private System.Windows.Forms.ComboBox cbxSirketAdi;
        private System.Windows.Forms.Label lbluyarı;
        private System.Windows.Forms.Label label1;
    }
}