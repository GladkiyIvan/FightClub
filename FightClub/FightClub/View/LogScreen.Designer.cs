namespace FightClub
{
    partial class LogScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogScreen));
            this.lblcoach = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblcoach
            // 
            this.lblcoach.AutoSize = true;
            this.lblcoach.BackColor = System.Drawing.Color.SkyBlue;
            this.lblcoach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcoach.Location = new System.Drawing.Point(120, 9);
            this.lblcoach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcoach.Name = "lblcoach";
            this.lblcoach.Size = new System.Drawing.Size(235, 26);
            this.lblcoach.TabIndex = 3;
            this.lblcoach.Text = "Комментарии тренера";
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.SkyBlue;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.ForeColor = System.Drawing.SystemColors.MenuText;
            this.log.FormattingEnabled = true;
            this.log.HorizontalScrollbar = true;
            this.log.ItemHeight = 15;
            this.log.Location = new System.Drawing.Point(11, 187);
            this.log.Margin = new System.Windows.Forms.Padding(2);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(460, 124);
            this.log.TabIndex = 2;
            // 
            // LogScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 321);
            this.Controls.Add(this.lblcoach);
            this.Controls.Add(this.log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogScreen";
            this.Text = "Log";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogScreen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcoach;
        private System.Windows.Forms.ListBox log;
    }
}