
namespace IKYSProjeWinUI
{
    partial class DepartmanIslemleri
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
            this.grbDepartmanIslemleri = new System.Windows.Forms.GroupBox();
            this.dgwDepartman = new System.Windows.Forms.DataGridView();
            this.grbDepartmanIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartman)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDepartmanIslemleri
            // 
            this.grbDepartmanIslemleri.Controls.Add(this.dgwDepartman);
            this.grbDepartmanIslemleri.Location = new System.Drawing.Point(10, 50);
            this.grbDepartmanIslemleri.Name = "grbDepartmanIslemleri";
            this.grbDepartmanIslemleri.Size = new System.Drawing.Size(732, 326);
            this.grbDepartmanIslemleri.TabIndex = 0;
            this.grbDepartmanIslemleri.TabStop = false;
            this.grbDepartmanIslemleri.Text = "Departman İşlemleri";
            // 
            // dgwDepartman
            // 
            this.dgwDepartman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDepartman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepartman.Location = new System.Drawing.Point(13, 120);
            this.dgwDepartman.Name = "dgwDepartman";
            this.dgwDepartman.ReadOnly = true;
            this.dgwDepartman.Size = new System.Drawing.Size(656, 164);
            this.dgwDepartman.TabIndex = 0;
            // 
            // DepartmanIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbDepartmanIslemleri);
            this.Name = "DepartmanIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman İşlemleri";
            this.Load += new System.EventHandler(this.DepartmanIslemleri_Load);
            this.grbDepartmanIslemleri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDepartmanIslemleri;
        private System.Windows.Forms.DataGridView dgwDepartman;
    }
}