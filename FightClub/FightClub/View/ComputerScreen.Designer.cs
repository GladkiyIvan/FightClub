namespace FightClub
{
    partial class ComputerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerScreen));
            this.compHP = new System.Windows.Forms.ProgressBar();
            this.lblcomp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // compHP
            // 
            this.compHP.Location = new System.Drawing.Point(11, 316);
            this.compHP.Margin = new System.Windows.Forms.Padding(2);
            this.compHP.Name = "compHP";
            this.compHP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.compHP.RightToLeftLayout = true;
            this.compHP.Size = new System.Drawing.Size(500, 29);
            this.compHP.TabIndex = 13;
            this.compHP.Value = 100;
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.BackColor = System.Drawing.Color.SkyBlue;
            this.lblcomp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcomp.Location = new System.Drawing.Point(11, 9);
            this.lblcomp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(125, 26);
            this.lblcomp.TabIndex = 12;
            this.lblcomp.Text = "Компьютер";
            // 
            // ComputerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 356);
            this.Controls.Add(this.compHP);
            this.Controls.Add(this.lblcomp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ComputerScreen";
            this.Text = "ComputerScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComputerScreen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar compHP;
        private System.Windows.Forms.Label lblcomp;
    }
}