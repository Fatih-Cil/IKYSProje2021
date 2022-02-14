
namespace IKYSProjeWinUI
{
    partial class RolTanimlari
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
            this.gbxRolTanimlari = new System.Windows.Forms.GroupBox();
            this.dgwRolTanimlari = new System.Windows.Forms.DataGridView();
            this.gbxRolTanimlari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRolTanimlari)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxRolTanimlari
            // 
            this.gbxRolTanimlari.Controls.Add(this.dgwRolTanimlari);
            this.gbxRolTanimlari.Location = new System.Drawing.Point(40, 192);
            this.gbxRolTanimlari.Margin = new System.Windows.Forms.Padding(6);
            this.gbxRolTanimlari.Name = "gbxRolTanimlari";
            this.gbxRolTanimlari.Padding = new System.Windows.Forms.Padding(6);
            this.gbxRolTanimlari.Size = new System.Drawing.Size(1116, 512);
            this.gbxRolTanimlari.TabIndex = 0;
            this.gbxRolTanimlari.TabStop = false;
            this.gbxRolTanimlari.Text = "Rol Tanımları";
            // 
            // dgwRolTanimlari
            // 
            this.dgwRolTanimlari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRolTanimlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRolTanimlari.Location = new System.Drawing.Point(22, 188);
            this.dgwRolTanimlari.Margin = new System.Windows.Forms.Padding(6);
            this.dgwRolTanimlari.Name = "dgwRolTanimlari";
            this.dgwRolTanimlari.ReadOnly = true;
            this.dgwRolTanimlari.RowHeadersWidth = 82;
            this.dgwRolTanimlari.Size = new System.Drawing.Size(1070, 285);
            this.dgwRolTanimlari.TabIndex = 0;
            // 
            // RolTanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.gbxRolTanimlari);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RolTanimlari";
            this.Text = "RolTanimlari";
            this.Load += new System.EventHandler(this.RolTanimlari_Load);
            this.gbxRolTanimlari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRolTanimlari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRolTanimlari;
        private System.Windows.Forms.DataGridView dgwRolTanimlari;
    }
}