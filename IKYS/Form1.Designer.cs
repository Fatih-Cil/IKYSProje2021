
namespace IKYS
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.tbxTcNo = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.gbxGiris = new System.Windows.Forms.GroupBox();
            this.gbxGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.Location = new System.Drawing.Point(254, 173);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(121, 51);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiris.Location = new System.Drawing.Point(129, 173);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(121, 51);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // tbxSifre
            // 
            this.tbxSifre.Location = new System.Drawing.Point(180, 119);
            this.tbxSifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSifre.MaxLength = 20;
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(188, 26);
            this.tbxSifre.TabIndex = 1;
            this.tbxSifre.UseSystemPasswordChar = true;
            // 
            // tbxTcNo
            // 
            this.tbxTcNo.Location = new System.Drawing.Point(180, 64);
            this.tbxTcNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxTcNo.MaxLength = 11;
            this.tbxTcNo.Name = "tbxTcNo";
            this.tbxTcNo.Size = new System.Drawing.Size(188, 26);
            this.tbxTcNo.TabIndex = 0;
            this.tbxTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTcNo_KeyPress);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(118, 124);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 20);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "ŞİFRE";
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(118, 69);
            this.lblTcNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(56, 20);
            this.lblTcNo.TabIndex = 2;
            this.lblTcNo.Text = "TC NO";
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
            this.gbxGiris.Location = new System.Drawing.Point(40, 40);
            this.gbxGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxGiris.Name = "gbxGiris";
            this.gbxGiris.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxGiris.Size = new System.Drawing.Size(524, 253);
            this.gbxGiris.TabIndex = 1;
            this.gbxGiris.TabStop = false;
            this.gbxGiris.Text = "KULLANICI GİRİŞ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 369);
            this.Controls.Add(this.gbxGiris);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IKYS GİRİŞ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxGiris.ResumeLayout(false);
            this.gbxGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.TextBox tbxTcNo;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.GroupBox gbxGiris;
    }
}

