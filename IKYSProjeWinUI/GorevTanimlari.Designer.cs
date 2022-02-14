
namespace IKYSProjeWinUI
{
    partial class GorevTanimlari
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
            this.gbxGorevTanimlari = new System.Windows.Forms.GroupBox();
            this.dgwGorevTanimlari = new System.Windows.Forms.DataGridView();
            this.gbxGorevTanimlari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGorevTanimlari)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxGorevTanimlari
            // 
            this.gbxGorevTanimlari.Controls.Add(this.dgwGorevTanimlari);
            this.gbxGorevTanimlari.Location = new System.Drawing.Point(20, 96);
            this.gbxGorevTanimlari.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxGorevTanimlari.Name = "gbxGorevTanimlari";
            this.gbxGorevTanimlari.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxGorevTanimlari.Size = new System.Drawing.Size(1404, 715);
            this.gbxGorevTanimlari.TabIndex = 0;
            this.gbxGorevTanimlari.TabStop = false;
            this.gbxGorevTanimlari.Text = "Görev Tanımları";
            // 
            // dgwGorevTanimlari
            // 
            this.dgwGorevTanimlari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGorevTanimlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGorevTanimlari.Location = new System.Drawing.Point(12, 315);
            this.dgwGorevTanimlari.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgwGorevTanimlari.Name = "dgwGorevTanimlari";
            this.dgwGorevTanimlari.ReadOnly = true;
            this.dgwGorevTanimlari.RowHeadersWidth = 82;
            this.dgwGorevTanimlari.Size = new System.Drawing.Size(1282, 388);
            this.dgwGorevTanimlari.TabIndex = 0;
            // 
            // GorevTanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.gbxGorevTanimlari);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "GorevTanimlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Tanımları";
            this.Load += new System.EventHandler(this.GorevTanimlari_Load);
            this.gbxGorevTanimlari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGorevTanimlari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGorevTanimlari;
        private System.Windows.Forms.DataGridView dgwGorevTanimlari;
    }
}