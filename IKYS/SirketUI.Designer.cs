
namespace IKYS
{
    partial class SirketUI
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
            this.gbxSirket = new System.Windows.Forms.GroupBox();
            this.tbxVergiAdi = new System.Windows.Forms.TextBox();
            this.lblVergiAdi = new System.Windows.Forms.Label();
            this.tbxVergiNo = new System.Windows.Forms.TextBox();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.lblVergiNo = new System.Windows.Forms.Label();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblSirketTel = new System.Windows.Forms.Label();
            this.lbluyarı = new System.Windows.Forms.Label();
            this.btnSirketListele = new System.Windows.Forms.Button();
            this.tbxUnvan = new System.Windows.Forms.TextBox();
            this.lblSirketUnvani = new System.Windows.Forms.Label();
            this.btsSirketGuncelle = new System.Windows.Forms.Button();
            this.dgwSirket = new System.Windows.Forms.DataGridView();
            this.gbxSirket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSirket)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSirket
            // 
            this.gbxSirket.Controls.Add(this.tbxVergiAdi);
            this.gbxSirket.Controls.Add(this.lblVergiAdi);
            this.gbxSirket.Controls.Add(this.tbxVergiNo);
            this.gbxSirket.Controls.Add(this.tbxTelefon);
            this.gbxSirket.Controls.Add(this.lblVergiNo);
            this.gbxSirket.Controls.Add(this.tbxAdres);
            this.gbxSirket.Controls.Add(this.lblAdres);
            this.gbxSirket.Controls.Add(this.lblSirketTel);
            this.gbxSirket.Controls.Add(this.lbluyarı);
            this.gbxSirket.Controls.Add(this.btnSirketListele);
            this.gbxSirket.Controls.Add(this.tbxUnvan);
            this.gbxSirket.Controls.Add(this.lblSirketUnvani);
            this.gbxSirket.Controls.Add(this.btsSirketGuncelle);
            this.gbxSirket.Controls.Add(this.dgwSirket);
            this.gbxSirket.Location = new System.Drawing.Point(38, 102);
            this.gbxSirket.Name = "gbxSirket";
            this.gbxSirket.Size = new System.Drawing.Size(939, 421);
            this.gbxSirket.TabIndex = 2;
            this.gbxSirket.TabStop = false;
            this.gbxSirket.Text = "ŞİRKET BİLGİLERİ";
            // 
            // tbxVergiAdi
            // 
            this.tbxVergiAdi.Location = new System.Drawing.Point(381, 86);
            this.tbxVergiAdi.Name = "tbxVergiAdi";
            this.tbxVergiAdi.Size = new System.Drawing.Size(138, 26);
            this.tbxVergiAdi.TabIndex = 16;
            // 
            // lblVergiAdi
            // 
            this.lblVergiAdi.AutoSize = true;
            this.lblVergiAdi.Location = new System.Drawing.Point(252, 89);
            this.lblVergiAdi.Name = "lblVergiAdi";
            this.lblVergiAdi.Size = new System.Drawing.Size(126, 20);
            this.lblVergiAdi.TabIndex = 17;
            this.lblVergiAdi.Text = "Vergi Dairesi Adı";
            // 
            // tbxVergiNo
            // 
            this.tbxVergiNo.Location = new System.Drawing.Point(381, 50);
            this.tbxVergiNo.MaxLength = 11;
            this.tbxVergiNo.Name = "tbxVergiNo";
            this.tbxVergiNo.Size = new System.Drawing.Size(138, 26);
            this.tbxVergiNo.TabIndex = 14;
            this.tbxVergiNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVergiNo_KeyPress);
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(100, 86);
            this.tbxTelefon.MaxLength = 11;
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(138, 26);
            this.tbxTelefon.TabIndex = 10;
            this.tbxTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTelefon_KeyPress);
            // 
            // lblVergiNo
            // 
            this.lblVergiNo.AutoSize = true;
            this.lblVergiNo.Location = new System.Drawing.Point(252, 56);
            this.lblVergiNo.Name = "lblVergiNo";
            this.lblVergiNo.Size = new System.Drawing.Size(123, 20);
            this.lblVergiNo.TabIndex = 15;
            this.lblVergiNo.Text = "Vergi Dairesi No";
            // 
            // tbxAdres
            // 
            this.tbxAdres.Location = new System.Drawing.Point(100, 124);
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(419, 26);
            this.tbxAdres.TabIndex = 12;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(26, 124);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(51, 20);
            this.lblAdres.TabIndex = 13;
            this.lblAdres.Text = "Adres";
            // 
            // lblSirketTel
            // 
            this.lblSirketTel.AutoSize = true;
            this.lblSirketTel.Location = new System.Drawing.Point(26, 94);
            this.lblSirketTel.Name = "lblSirketTel";
            this.lblSirketTel.Size = new System.Drawing.Size(62, 20);
            this.lblSirketTel.TabIndex = 11;
            this.lblSirketTel.Text = "Telefon";
            // 
            // lbluyarı
            // 
            this.lbluyarı.AutoSize = true;
            this.lbluyarı.Location = new System.Drawing.Point(591, 382);
            this.lbluyarı.Name = "lbluyarı";
            this.lbluyarı.Size = new System.Drawing.Size(332, 20);
            this.lbluyarı.TabIndex = 9;
            this.lbluyarı.Text = "Güncelleme için lütfen tablodan seçim yapınız.";
            // 
            // btnSirketListele
            // 
            this.btnSirketListele.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSirketListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSirketListele.Location = new System.Drawing.Point(748, 50);
            this.btnSirketListele.Name = "btnSirketListele";
            this.btnSirketListele.Size = new System.Drawing.Size(134, 100);
            this.btnSirketListele.TabIndex = 6;
            this.btnSirketListele.Text = "Şirket Listele";
            this.btnSirketListele.UseVisualStyleBackColor = false;
            this.btnSirketListele.Click += new System.EventHandler(this.lblBolumListele_Click);
            // 
            // tbxUnvan
            // 
            this.tbxUnvan.Location = new System.Drawing.Point(100, 50);
            this.tbxUnvan.Name = "tbxUnvan";
            this.tbxUnvan.Size = new System.Drawing.Size(138, 26);
            this.tbxUnvan.TabIndex = 4;
            // 
            // lblSirketUnvani
            // 
            this.lblSirketUnvani.AutoSize = true;
            this.lblSirketUnvani.Location = new System.Drawing.Point(26, 55);
            this.lblSirketUnvani.Name = "lblSirketUnvani";
            this.lblSirketUnvani.Size = new System.Drawing.Size(58, 20);
            this.lblSirketUnvani.TabIndex = 5;
            this.lblSirketUnvani.Text = "Unvanı";
            // 
            // btsSirketGuncelle
            // 
            this.btsSirketGuncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btsSirketGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btsSirketGuncelle.Location = new System.Drawing.Point(585, 49);
            this.btsSirketGuncelle.Name = "btsSirketGuncelle";
            this.btsSirketGuncelle.Size = new System.Drawing.Size(134, 100);
            this.btsSirketGuncelle.TabIndex = 3;
            this.btsSirketGuncelle.Text = "Şirket Güncelle";
            this.btsSirketGuncelle.UseVisualStyleBackColor = false;
            this.btsSirketGuncelle.Click += new System.EventHandler(this.btnBolumGuncelle_Click);
            // 
            // dgwSirket
            // 
            this.dgwSirket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSirket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSirket.Location = new System.Drawing.Point(16, 169);
            this.dgwSirket.Name = "dgwSirket";
            this.dgwSirket.ReadOnly = true;
            this.dgwSirket.RowHeadersWidth = 62;
            this.dgwSirket.RowTemplate.Height = 28;
            this.dgwSirket.Size = new System.Drawing.Size(903, 210);
            this.dgwSirket.TabIndex = 0;
            this.dgwSirket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSirket_CellContentClick);
            // 
            // SirketUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 603);
            this.Controls.Add(this.gbxSirket);
            this.Name = "SirketUI";
            this.Text = "SirketUI";
            this.Load += new System.EventHandler(this.SirketUI_Load);
            this.gbxSirket.ResumeLayout(false);
            this.gbxSirket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSirket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSirket;
        private System.Windows.Forms.Label lbluyarı;
        private System.Windows.Forms.Button btnSirketListele;
        private System.Windows.Forms.TextBox tbxUnvan;
        private System.Windows.Forms.Label lblSirketUnvani;
        private System.Windows.Forms.Button btsSirketGuncelle;
        private System.Windows.Forms.DataGridView dgwSirket;
        private System.Windows.Forms.TextBox tbxVergiAdi;
        private System.Windows.Forms.Label lblVergiAdi;
        private System.Windows.Forms.TextBox tbxVergiNo;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.Label lblVergiNo;
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblSirketTel;
    }
}