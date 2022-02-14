
namespace IKYS
{
    partial class RollerUI
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
            this.gbxRoller = new System.Windows.Forms.GroupBox();
            this.lblRolMesajı = new System.Windows.Forms.Label();
            this.dgwRoller = new System.Windows.Forms.DataGridView();
            this.gbxRoller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRoller)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxRoller
            // 
            this.gbxRoller.Controls.Add(this.lblRolMesajı);
            this.gbxRoller.Controls.Add(this.dgwRoller);
            this.gbxRoller.Location = new System.Drawing.Point(24, 93);
            this.gbxRoller.Name = "gbxRoller";
            this.gbxRoller.Size = new System.Drawing.Size(706, 272);
            this.gbxRoller.TabIndex = 1;
            this.gbxRoller.TabStop = false;
            this.gbxRoller.Text = "ROLLER";
            // 
            // lblRolMesajı
            // 
            this.lblRolMesajı.AutoSize = true;
            this.lblRolMesajı.Location = new System.Drawing.Point(228, 243);
            this.lblRolMesajı.Name = "lblRolMesajı";
            this.lblRolMesajı.Size = new System.Drawing.Size(465, 20);
            this.lblRolMesajı.TabIndex = 1;
            this.lblRolMesajı.Text = "Bu alanda herhangi bir ekleme çıkarma yada değişiklik yapılamaz.";
            // 
            // dgwRoller
            // 
            this.dgwRoller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRoller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRoller.Location = new System.Drawing.Point(17, 82);
            this.dgwRoller.Name = "dgwRoller";
            this.dgwRoller.ReadOnly = true;
            this.dgwRoller.RowHeadersWidth = 62;
            this.dgwRoller.RowTemplate.Height = 28;
            this.dgwRoller.Size = new System.Drawing.Size(670, 158);
            this.dgwRoller.TabIndex = 0;
            // 
            // RollerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxRoller);
            this.Name = "RollerUI";
            this.Text = "RollerUI";
            this.Load += new System.EventHandler(this.RollerUI_Load);
            this.gbxRoller.ResumeLayout(false);
            this.gbxRoller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRoller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxRoller;
        private System.Windows.Forms.DataGridView dgwRoller;
        private System.Windows.Forms.Label lblRolMesajı;
    }
}