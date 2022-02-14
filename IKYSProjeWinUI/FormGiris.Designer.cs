
namespace IKYSProjeWinUI
{
    partial class FormGiris
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
            this.gbxGiris = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.tbxTcNo = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.gbxGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGiris
            // 
            this.gbxGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxGiris.Controls.Add(this.btnCikis);
            this.gbxGiris.Controls.Add(this.btnGiris);
            this.gbxGiris.Controls.Add(this.tbxSifre);
            this.gbxGiris.Controls.Add(this.tbxTcNo);
            this.gbxGiris.Controls.Add(this.lblSifre);
            this.gbxGiris.Controls.Add(this.lblTcNo);
            this.gbxGiris.Location = new System.Drawing.Point(28, 48);
            this.gbxGiris.Name = "gbxGiris";
            this.gbxGiris.Size = new System.Drawing.Size(699, 316);
            this.gbxGiris.TabIndex = 0;
            this.gbxGiris.TabStop = false;
            this.gbxGiris.Text = "Kullanıcı Giriş";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiris.Location = new System.Drawing.Point(172, 216);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(161, 64);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // tbxSifre
            // 
            this.tbxSifre.Location = new System.Drawing.Point(240, 149);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(250, 31);
            this.tbxSifre.TabIndex = 1;
            this.tbxSifre.UseSystemPasswordChar = true;
            // 
            // tbxTcNo
            // 
            this.tbxTcNo.Location = new System.Drawing.Point(240, 80);
            this.tbxTcNo.Name = "tbxTcNo";
            this.tbxTcNo.Size = new System.Drawing.Size(250, 31);
            this.tbxTcNo.TabIndex = 0;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(157, 155);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(73, 25);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "ŞİFRE";
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(157, 86);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(77, 25);
            this.lblTcNo.TabIndex = 2;
            this.lblTcNo.Text = "TC NO";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.Location = new System.Drawing.Point(339, 216);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(161, 64);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 413);
            this.Controls.Add(this.gbxGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IKYS Giriş Ekranı";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.gbxGiris.ResumeLayout(false);
            this.gbxGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGiris;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.TextBox tbxTcNo;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.Button btnCikis;
    }
}

