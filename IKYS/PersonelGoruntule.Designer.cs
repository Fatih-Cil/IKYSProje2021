
namespace IKYS
{
    partial class PersonelGoruntule
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
            this.gbxPersonelAra = new System.Windows.Forms.GroupBox();
            this.dgwPersonelListe = new System.Windows.Forms.DataGridView();
            this.chbxPasif = new System.Windows.Forms.CheckBox();
            this.btnSicilNo = new System.Windows.Forms.Button();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.lblPersonelAdi = new System.Windows.Forms.Label();
            this.tbxSicilNo = new System.Windows.Forms.TextBox();
            this.lblSicilNo = new System.Windows.Forms.Label();
            this.btnTumunuListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxPersonelAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListe)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPersonelAra
            // 
            this.gbxPersonelAra.Controls.Add(this.label1);
            this.gbxPersonelAra.Controls.Add(this.btnTumunuListele);
            this.gbxPersonelAra.Controls.Add(this.dgwPersonelListe);
            this.gbxPersonelAra.Controls.Add(this.chbxPasif);
            this.gbxPersonelAra.Controls.Add(this.btnSicilNo);
            this.gbxPersonelAra.Controls.Add(this.tbxAd);
            this.gbxPersonelAra.Controls.Add(this.lblPersonelAdi);
            this.gbxPersonelAra.Controls.Add(this.tbxSicilNo);
            this.gbxPersonelAra.Controls.Add(this.lblSicilNo);
            this.gbxPersonelAra.Location = new System.Drawing.Point(32, 85);
            this.gbxPersonelAra.Name = "gbxPersonelAra";
            this.gbxPersonelAra.Size = new System.Drawing.Size(1167, 575);
            this.gbxPersonelAra.TabIndex = 0;
            this.gbxPersonelAra.TabStop = false;
            this.gbxPersonelAra.Text = "PERSONEL GÖRÜNTÜLE";
            // 
            // dgwPersonelListe
            // 
            this.dgwPersonelListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonelListe.Location = new System.Drawing.Point(28, 132);
            this.dgwPersonelListe.Name = "dgwPersonelListe";
            this.dgwPersonelListe.RowHeadersWidth = 62;
            this.dgwPersonelListe.RowTemplate.Height = 28;
            this.dgwPersonelListe.Size = new System.Drawing.Size(1124, 386);
            this.dgwPersonelListe.TabIndex = 6;
            // 
            // chbxPasif
            // 
            this.chbxPasif.AutoSize = true;
            this.chbxPasif.Location = new System.Drawing.Point(96, 91);
            this.chbxPasif.Name = "chbxPasif";
            this.chbxPasif.Size = new System.Drawing.Size(130, 24);
            this.chbxPasif.TabIndex = 8;
            this.chbxPasif.Text = "Pasif Dahil Et";
            this.chbxPasif.UseVisualStyleBackColor = true;
            // 
            // btnSicilNo
            // 
            this.btnSicilNo.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSicilNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSicilNo.Location = new System.Drawing.Point(232, 56);
            this.btnSicilNo.Name = "btnSicilNo";
            this.btnSicilNo.Size = new System.Drawing.Size(152, 59);
            this.btnSicilNo.TabIndex = 7;
            this.btnSicilNo.Text = "Sicil No İle Ara";
            this.btnSicilNo.UseVisualStyleBackColor = false;
            this.btnSicilNo.Click += new System.EventHandler(this.btnSicilNo_Click);
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(1000, 81);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(152, 26);
            this.tbxAd.TabIndex = 5;
            this.tbxAd.TextChanged += new System.EventHandler(this.tbxAd_TextChanged);
            // 
            // lblPersonelAdi
            // 
            this.lblPersonelAdi.AutoSize = true;
            this.lblPersonelAdi.Location = new System.Drawing.Point(965, 84);
            this.lblPersonelAdi.Name = "lblPersonelAdi";
            this.lblPersonelAdi.Size = new System.Drawing.Size(29, 20);
            this.lblPersonelAdi.TabIndex = 4;
            this.lblPersonelAdi.Text = "Ad";
            // 
            // tbxSicilNo
            // 
            this.tbxSicilNo.Location = new System.Drawing.Point(96, 59);
            this.tbxSicilNo.Name = "tbxSicilNo";
            this.tbxSicilNo.Size = new System.Drawing.Size(130, 26);
            this.tbxSicilNo.TabIndex = 1;
            this.tbxSicilNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSicilNo_KeyPress);
            // 
            // lblSicilNo
            // 
            this.lblSicilNo.AutoSize = true;
            this.lblSicilNo.Location = new System.Drawing.Point(29, 65);
            this.lblSicilNo.Name = "lblSicilNo";
            this.lblSicilNo.Size = new System.Drawing.Size(61, 20);
            this.lblSicilNo.TabIndex = 0;
            this.lblSicilNo.Text = "Sicil No";
            // 
            // btnTumunuListele
            // 
            this.btnTumunuListele.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTumunuListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTumunuListele.Location = new System.Drawing.Point(1000, 524);
            this.btnTumunuListele.Name = "btnTumunuListele";
            this.btnTumunuListele.Size = new System.Drawing.Size(152, 45);
            this.btnTumunuListele.TabIndex = 9;
            this.btnTumunuListele.Text = "Tümünü Listele";
            this.btnTumunuListele.UseVisualStyleBackColor = false;
            this.btnTumunuListele.Click += new System.EventHandler(this.btnTumunuListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1063, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hızlı Arama";
            // 
            // PersonelGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1243, 709);
            this.Controls.Add(this.gbxPersonelAra);
            this.Name = "PersonelGoruntule";
            this.Text = "Personel Goruntule";
            this.Load += new System.EventHandler(this.PersonelGoruntule_Load);
            this.gbxPersonelAra.ResumeLayout(false);
            this.gbxPersonelAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxPersonelAra;
        private System.Windows.Forms.DataGridView dgwPersonelListe;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label lblPersonelAdi;
        private System.Windows.Forms.TextBox tbxSicilNo;
        private System.Windows.Forms.Label lblSicilNo;
        private System.Windows.Forms.Button btnSicilNo;
        private System.Windows.Forms.CheckBox chbxPasif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTumunuListele;
    }
}