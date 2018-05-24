namespace FightClub
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.log = new System.Windows.Forms.ListBox();
            this.lblcoach = new System.Windows.Forms.Label();
            this.btnAtackHead = new System.Windows.Forms.Button();
            this.btnAtackBody = new System.Windows.Forms.Button();
            this.btnAtackLegs = new System.Windows.Forms.Button();
            this.btnDefLegs = new System.Windows.Forms.Button();
            this.btnDefBody = new System.Windows.Forms.Button();
            this.btnDefHead = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblcomp = new System.Windows.Forms.Label();
            this.userHP = new System.Windows.Forms.ProgressBar();
            this.compHP = new System.Windows.Forms.ProgressBar();
            this.lblround = new System.Windows.Forms.Label();
            this.lblcountRound = new System.Windows.Forms.Label();
            this.lblatack = new System.Windows.Forms.Label();
            this.lbldef = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.SkyBlue;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.ForeColor = System.Drawing.SystemColors.MenuText;
            this.log.FormattingEnabled = true;
            this.log.HorizontalScrollbar = true;
            this.log.ItemHeight = 18;
            this.log.Location = new System.Drawing.Point(274, 303);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(439, 292);
            this.log.TabIndex = 0;
            // 
            // lblcoach
            // 
            this.lblcoach.AutoSize = true;
            this.lblcoach.BackColor = System.Drawing.Color.SkyBlue;
            this.lblcoach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcoach.Location = new System.Drawing.Point(337, 258);
            this.lblcoach.Name = "lblcoach";
            this.lblcoach.Size = new System.Drawing.Size(300, 31);
            this.lblcoach.TabIndex = 1;
            this.lblcoach.Text = "Комментарии тренера";
            // 
            // btnAtackHead
            // 
            this.btnAtackHead.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAtackHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAtackHead.Location = new System.Drawing.Point(72, 238);
            this.btnAtackHead.Name = "btnAtackHead";
            this.btnAtackHead.Size = new System.Drawing.Size(185, 75);
            this.btnAtackHead.TabIndex = 2;
            this.btnAtackHead.Text = "Head";
            this.btnAtackHead.UseVisualStyleBackColor = false;
            this.btnAtackHead.Click += new System.EventHandler(this.btnAtackHead_Click);
            // 
            // btnAtackBody
            // 
            this.btnAtackBody.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAtackBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAtackBody.Location = new System.Drawing.Point(72, 352);
            this.btnAtackBody.Name = "btnAtackBody";
            this.btnAtackBody.Size = new System.Drawing.Size(185, 75);
            this.btnAtackBody.TabIndex = 3;
            this.btnAtackBody.Text = "Body";
            this.btnAtackBody.UseVisualStyleBackColor = false;
            this.btnAtackBody.Click += new System.EventHandler(this.btnAtackBody_Click);
            // 
            // btnAtackLegs
            // 
            this.btnAtackLegs.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAtackLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAtackLegs.Location = new System.Drawing.Point(72, 468);
            this.btnAtackLegs.Name = "btnAtackLegs";
            this.btnAtackLegs.Size = new System.Drawing.Size(185, 75);
            this.btnAtackLegs.TabIndex = 4;
            this.btnAtackLegs.Text = "Legs";
            this.btnAtackLegs.UseVisualStyleBackColor = false;
            this.btnAtackLegs.Click += new System.EventHandler(this.btnAtackLegs_Click);
            // 
            // btnDefLegs
            // 
            this.btnDefLegs.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDefLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefLegs.Location = new System.Drawing.Point(730, 468);
            this.btnDefLegs.Name = "btnDefLegs";
            this.btnDefLegs.Size = new System.Drawing.Size(185, 75);
            this.btnDefLegs.TabIndex = 7;
            this.btnDefLegs.Text = "Legs";
            this.btnDefLegs.UseVisualStyleBackColor = false;
            this.btnDefLegs.Click += new System.EventHandler(this.btnDefLegs_Click);
            // 
            // btnDefBody
            // 
            this.btnDefBody.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDefBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefBody.Location = new System.Drawing.Point(730, 352);
            this.btnDefBody.Name = "btnDefBody";
            this.btnDefBody.Size = new System.Drawing.Size(185, 75);
            this.btnDefBody.TabIndex = 6;
            this.btnDefBody.Text = "Body";
            this.btnDefBody.UseVisualStyleBackColor = false;
            this.btnDefBody.Click += new System.EventHandler(this.btnDefBody_Click);
            // 
            // btnDefHead
            // 
            this.btnDefHead.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDefHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefHead.Location = new System.Drawing.Point(730, 238);
            this.btnDefHead.Name = "btnDefHead";
            this.btnDefHead.Size = new System.Drawing.Size(185, 75);
            this.btnDefHead.TabIndex = 5;
            this.btnDefHead.Text = "Head";
            this.btnDefHead.UseVisualStyleBackColor = false;
            this.btnDefHead.Click += new System.EventHandler(this.btnDefHead_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.SkyBlue;
            this.lblusername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblusername.Location = new System.Drawing.Point(12, 9);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(89, 31);
            this.lblusername.TabIndex = 8;
            this.lblusername.Text = "Игрок";
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.BackColor = System.Drawing.Color.SkyBlue;
            this.lblcomp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcomp.Location = new System.Drawing.Point(803, 9);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(158, 31);
            this.lblcomp.TabIndex = 9;
            this.lblcomp.Text = "Компьютер";
            // 
            // userHP
            // 
            this.userHP.Location = new System.Drawing.Point(12, 52);
            this.userHP.Name = "userHP";
            this.userHP.Size = new System.Drawing.Size(388, 36);
            this.userHP.TabIndex = 10;
            this.userHP.Value = 100;
            // 
            // compHP
            // 
            this.compHP.Location = new System.Drawing.Point(585, 52);
            this.compHP.Name = "compHP";
            this.compHP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.compHP.RightToLeftLayout = true;
            this.compHP.Size = new System.Drawing.Size(385, 36);
            this.compHP.TabIndex = 11;
            this.compHP.Value = 100;
            // 
            // lblround
            // 
            this.lblround.AutoSize = true;
            this.lblround.BackColor = System.Drawing.Color.SkyBlue;
            this.lblround.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblround.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblround.Location = new System.Drawing.Point(449, 9);
            this.lblround.Name = "lblround";
            this.lblround.Size = new System.Drawing.Size(89, 31);
            this.lblround.TabIndex = 12;
            this.lblround.Text = "Раунд";
            // 
            // lblcountRound
            // 
            this.lblcountRound.AutoSize = true;
            this.lblcountRound.BackColor = System.Drawing.Color.SkyBlue;
            this.lblcountRound.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcountRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcountRound.Location = new System.Drawing.Point(470, 52);
            this.lblcountRound.Name = "lblcountRound";
            this.lblcountRound.Size = new System.Drawing.Size(49, 53);
            this.lblcountRound.TabIndex = 13;
            this.lblcountRound.Text = "1";
            // 
            // lblatack
            // 
            this.lblatack.AutoSize = true;
            this.lblatack.BackColor = System.Drawing.Color.SkyBlue;
            this.lblatack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblatack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblatack.Location = new System.Drawing.Point(117, 173);
            this.lblatack.Name = "lblatack";
            this.lblatack.Size = new System.Drawing.Size(85, 31);
            this.lblatack.TabIndex = 14;
            this.lblatack.Text = "Атака";
            // 
            // lbldef
            // 
            this.lbldef.AutoSize = true;
            this.lbldef.BackColor = System.Drawing.Color.SkyBlue;
            this.lbldef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldef.Location = new System.Drawing.Point(765, 173);
            this.lbldef.Name = "lbldef";
            this.lbldef.Size = new System.Drawing.Size(109, 31);
            this.lbldef.TabIndex = 15;
            this.lbldef.Text = "Защита";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 643);
            this.Controls.Add(this.lbldef);
            this.Controls.Add(this.lblatack);
            this.Controls.Add(this.lblcountRound);
            this.Controls.Add(this.lblround);
            this.Controls.Add(this.compHP);
            this.Controls.Add(this.userHP);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnDefLegs);
            this.Controls.Add(this.btnDefBody);
            this.Controls.Add(this.btnDefHead);
            this.Controls.Add(this.btnAtackLegs);
            this.Controls.Add(this.btnAtackBody);
            this.Controls.Add(this.btnAtackHead);
            this.Controls.Add(this.lblcoach);
            this.Controls.Add(this.log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Fight Club";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.Label lblcoach;
        private System.Windows.Forms.Button btnAtackHead;
        private System.Windows.Forms.Button btnAtackBody;
        private System.Windows.Forms.Button btnAtackLegs;
        private System.Windows.Forms.Button btnDefLegs;
        private System.Windows.Forms.Button btnDefBody;
        private System.Windows.Forms.Button btnDefHead;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.ProgressBar userHP;
        private System.Windows.Forms.ProgressBar compHP;
        private System.Windows.Forms.Label lblround;
        private System.Windows.Forms.Label lblcountRound;
        private System.Windows.Forms.Label lblatack;
        private System.Windows.Forms.Label lbldef;
    }
}

