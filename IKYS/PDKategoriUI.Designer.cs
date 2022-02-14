
namespace IKYS
{
    partial class PDKategoriUI
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
            this.gbxPDKategori = new System.Windows.Forms.GroupBox();
            this.lblKategoriListele = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.dgwPDKategori = new System.Windows.Forms.DataGridView();
            this.tbxKategoriAdi = new System.Windows.Forms.TextBox();
            this.lblPDKategoriAdi = new System.Windows.Forms.Label();
            this.gbxPDKategori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPDKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPDKategori
            // 
            this.gbxPDKategori.Controls.Add(this.lblKategoriListele);
            this.gbxPDKategori.Controls.Add(this.btnKategoriGuncelle);
            this.gbxPDKategori.Controls.Add(this.btnKategoriSil);
            this.gbxPDKategori.Controls.Add(this.btnKategoriEkle);
            this.gbxPDKategori.Controls.Add(this.dgwPDKategori);
            this.gbxPDKategori.Controls.Add(this.tbxKategoriAdi);
            this.gbxPDKategori.Controls.Add(this.lblPDKategoriAdi);
            this.gbxPDKategori.Location = new System.Drawing.Point(39, 113);
            this.gbxPDKategori.Name = "gbxPDKategori";
            this.gbxPDKategori.Size = new System.Drawing.Size(1079, 606);
            this.gbxPDKategori.TabIndex = 1;
            this.gbxPDKategori.TabStop = false;
            this.gbxPDKategori.Text = "PERSONEL DÖKÜMAN KATEGORİ";
            // 
            // lblKategoriListele
            // 
            this.lblKategoriListele.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblKategoriListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategoriListele.Location = new System.Drawing.Point(853, 330);
            this.lblKategoriListele.Margin = new System.Windows.Forms.Padding(4);
            this.lblKategoriListele.Name = "lblKategoriListele";
            this.lblKategoriListele.Size = new System.Drawing.Size(210, 60);
            this.lblKategoriListele.TabIndex = 10;
            this.lblKategoriListele.Text = "Kategori Listele";
            this.lblKategoriListele.UseVisualStyleBackColor = false;
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnKategoriGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(853, 262);
            this.btnKategoriGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(210, 60);
            this.btnKategoriGuncelle.TabIndex = 9;
            this.btnKategoriGuncelle.Text = "Kategori Guncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = false;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnKategoriSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKategoriSil.Location = new System.Drawing.Point(853, 398);
            this.btnKategoriSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(210, 60);
            this.btnKategoriSil.TabIndex = 8;
            this.btnKategoriSil.Text = "Kategori Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = false;
            this.btnKategoriSil.Click += new System.EventHandler(this.lblKategoriSil_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnKategoriEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKategoriEkle.Location = new System.Drawing.Point(853, 194);
            this.btnKategoriEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(210, 60);
            this.btnKategoriEkle.TabIndex = 7;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // dgwPDKategori
            // 
            this.dgwPDKategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPDKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPDKategori.Location = new System.Drawing.Point(39, 166);
            this.dgwPDKategori.Name = "dgwPDKategori";
            this.dgwPDKategori.RowHeadersWidth = 82;
            this.dgwPDKategori.RowTemplate.Height = 33;
            this.dgwPDKategori.Size = new System.Drawing.Size(797, 309);
            this.dgwPDKategori.TabIndex = 2;
            this.dgwPDKategori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPDKategori_CellContentClick);
            // 
            // tbxKategoriAdi
            // 
            this.tbxKategoriAdi.Location = new System.Drawing.Point(172, 95);
            this.tbxKategoriAdi.Name = "tbxKategoriAdi";
            this.tbxKategoriAdi.Size = new System.Drawing.Size(223, 31);
            this.tbxKategoriAdi.TabIndex = 1;
            // 
            // lblPDKategoriAdi
            // 
            this.lblPDKategoriAdi.AutoSize = true;
            this.lblPDKategoriAdi.Location = new System.Drawing.Point(34, 98);
            this.lblPDKategoriAdi.Name = "lblPDKategoriAdi";
            this.lblPDKategoriAdi.Size = new System.Drawing.Size(129, 25);
            this.lblPDKategoriAdi.TabIndex = 0;
            this.lblPDKategoriAdi.Text = "Kategori Adı";
            // 
            // PDKategoriUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1530, 973);
            this.Controls.Add(this.gbxPDKategori);
            this.DoubleBuffered = true;
            this.Name = "PDKategoriUI";
            this.Text = "PDKategoriUI";
            this.Load += new System.EventHandler(this.PDKategoriUI_Load);
            this.gbxPDKategori.ResumeLayout(false);
            this.gbxPDKategori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPDKategori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPDKategori;
        private System.Windows.Forms.Button lblKategoriListele;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.DataGridView dgwPDKategori;
        private System.Windows.Forms.TextBox tbxKategoriAdi;
        private System.Windows.Forms.Label lblPDKategoriAdi;
    }
}