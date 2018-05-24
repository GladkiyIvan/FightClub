namespace FightClub
{
    partial class WinLose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinLose));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblcoachcomment = new System.Windows.Forms.Label();
            this.lblwinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(491, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 75);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.Location = new System.Drawing.Point(121, 407);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(185, 75);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblcoachcomment
            // 
            this.lblcoachcomment.AutoSize = true;
            this.lblcoachcomment.BackColor = System.Drawing.Color.SkyBlue;
            this.lblcoachcomment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcoachcomment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcoachcomment.Location = new System.Drawing.Point(162, 284);
            this.lblcoachcomment.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblcoachcomment.Name = "lblcoachcomment";
            this.lblcoachcomment.Size = new System.Drawing.Size(300, 31);
            this.lblcoachcomment.TabIndex = 7;
            this.lblcoachcomment.Text = "Комментарии тренера";
            this.lblcoachcomment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblwinner
            // 
            this.lblwinner.AutoSize = true;
            this.lblwinner.BackColor = System.Drawing.Color.SkyBlue;
            this.lblwinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblwinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblwinner.Location = new System.Drawing.Point(306, 210);
            this.lblwinner.Name = "lblwinner";
            this.lblwinner.Size = new System.Drawing.Size(167, 31);
            this.lblwinner.TabIndex = 8;
            this.lblwinner.Text = "Победитель";
            // 
            // WinLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.lblwinner);
            this.Controls.Add(this.lblcoachcomment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WinLose";
            this.Text = "WinLose";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WinLose_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblcoachcomment;
        private System.Windows.Forms.Label lblwinner;
    }
}