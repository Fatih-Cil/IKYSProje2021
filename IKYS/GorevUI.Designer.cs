
namespace IKYS
{
    partial class GorevUI
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
            this.gbxGorev = new System.Windows.Forms.GroupBox();
            this.lblGorevListele = new System.Windows.Forms.Button();
            this.tbxGorevAdi = new System.Windows.Forms.TextBox();
            this.lblGorevAdi = new System.Windows.Forms.Label();
            this.btnGorevGuncelle = new System.Windows.Forms.Button();
            this.lblGorevSil = new System.Windows.Forms.Button();
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.dgwGorev = new System.Windows.Forms.DataGridView();
            this.gbxGorev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGorev)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxGorev
            // 
            this.gbxGorev.Controls.Add(this.lblGorevListele);
            this.gbxGorev.Controls.Add(this.tbxGorevAdi);
            this.gbxGorev.Controls.Add(this.lblGorevAdi);
            this.gbxGorev.Controls.Add(this.btnGorevGuncelle);
            this.gbxGorev.Controls.Add(this.lblGorevSil);
            this.gbxGorev.Controls.Add(this.btnGorevEkle);
            this.gbxGorev.Controls.Add(this.dgwGorev);
            this.gbxGorev.Location = new System.Drawing.Point(39, 109);
            this.gbxGorev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxGorev.Name = "gbxGorev";
            this.gbxGorev.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxGorev.Size = new System.Drawing.Size(1080, 420);
            this.gbxGorev.TabIndex = 0;
            this.gbxGorev.TabStop = false;
            this.gbxGorev.Text = "GÖREVLER";
            // 
            // lblGorevListele
            // 
            this.lblGorevListele.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblGorevListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGorevListele.Location = new System.Drawing.Point(864, 255);
            this.lblGorevListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblGorevListele.Name = "lblGorevListele";
            this.lblGorevListele.Size = new System.Drawing.Size(179, 60);
            this.lblGorevListele.TabIndex = 6;
            this.lblGorevListele.Text = "GorevListele";
            this.lblGorevListele.UseVisualStyleBackColor = false;
            this.lblGorevListele.Click += new System.EventHandler(this.lblGorevListele_Click);
            // 
            // tbxGorevAdi
            // 
            this.tbxGorevAdi.Location = new System.Drawing.Point(148, 61);
            this.tbxGorevAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxGorevAdi.Name = "tbxGorevAdi";
            this.tbxGorevAdi.Size = new System.Drawing.Size(271, 31);
            this.tbxGorevAdi.TabIndex = 4;
            // 
            // lblGorevAdi
            // 
            this.lblGorevAdi.AutoSize = true;
            this.lblGorevAdi.Location = new System.Drawing.Point(35, 69);
            this.lblGorevAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGorevAdi.Name = "lblGorevAdi";
            this.lblGorevAdi.Size = new System.Drawing.Size(107, 25);
            this.lblGorevAdi.TabIndex = 5;
            this.lblGorevAdi.Text = "Görev Adı";
            // 
            // btnGorevGuncelle
            // 
            this.btnGorevGuncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGorevGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGorevGuncelle.Location = new System.Drawing.Point(864, 188);
            this.btnGorevGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGorevGuncelle.Name = "btnGorevGuncelle";
            this.btnGorevGuncelle.Size = new System.Drawing.Size(179, 60);
            this.btnGorevGuncelle.TabIndex = 3;
            this.btnGorevGuncelle.Text = "Görev Guncelle";
            this.btnGorevGuncelle.UseVisualStyleBackColor = false;
            this.btnGorevGuncelle.Click += new System.EventHandler(this.btnGorevGuncelle_Click);
            // 
            // lblGorevSil
            // 
            this.lblGorevSil.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblGorevSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGorevSil.Location = new System.Drawing.Point(864, 322);
            this.lblGorevSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblGorevSil.Name = "lblGorevSil";
            this.lblGorevSil.Size = new System.Drawing.Size(179, 60);
            this.lblGorevSil.TabIndex = 2;
            this.lblGorevSil.Text = "Görev Sil";
            this.lblGorevSil.UseVisualStyleBackColor = false;
            this.lblGorevSil.Click += new System.EventHandler(this.lblGorevSil_Click);
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGorevEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGorevEkle.Location = new System.Drawing.Point(864, 120);
            this.btnGorevEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(179, 60);
            this.btnGorevEkle.TabIndex = 1;
            this.btnGorevEkle.Text = "Görev Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = false;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // dgwGorev
            // 
            this.dgwGorev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGorev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGorev.Location = new System.Drawing.Point(27, 120);
            this.dgwGorev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgwGorev.Name = "dgwGorev";
            this.dgwGorev.ReadOnly = true;
            this.dgwGorev.RowHeadersWidth = 62;
            this.dgwGorev.RowTemplate.Height = 28;
            this.dgwGorev.Size = new System.Drawing.Size(817, 262);
            this.dgwGorev.TabIndex = 0;
            this.dgwGorev.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGorev_CellContentClick);
            // 
            // GorevUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1205, 619);
            this.Controls.Add(this.gbxGorev);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GorevUI";
            this.Text = "GorevUI";
            this.Load += new System.EventHandler(this.GorevUI_Load);
            this.gbxGorev.ResumeLayout(false);
            this.gbxGorev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGorev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGorev;
        private System.Windows.Forms.DataGridView dgwGorev;
        private System.Windows.Forms.Button lblGorevListele;
        private System.Windows.Forms.TextBox tbxGorevAdi;
        private System.Windows.Forms.Label lblGorevAdi;
        private System.Windows.Forms.Button btnGorevGuncelle;
        private System.Windows.Forms.Button lblGorevSil;
        private System.Windows.Forms.Button btnGorevEkle;
    }
}