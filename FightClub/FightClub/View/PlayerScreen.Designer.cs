namespace FightClub
{
    partial class PlayerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerScreen));
            this.btnAtackHead = new System.Windows.Forms.Button();
            this.btnAtackBody = new System.Windows.Forms.Button();
            this.btnAtackLegs = new System.Windows.Forms.Button();
            this.btnDefLegs = new System.Windows.Forms.Button();
            this.btnDefBody = new System.Windows.Forms.Button();
            this.btnDefHead = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.userHP = new System.Windows.Forms.ProgressBar();
            this.lblatack = new System.Windows.Forms.Label();
            this.lbldef = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAtackHead
            // 
            this.btnAtackHead.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAtackHead.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAtackHead.FlatAppearance.BorderSize = 0;
            this.btnAtackHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtackHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAtackHead.Location = new System.Drawing.Point(118, 172);
            this.btnAtackHead.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtackHead.Name = "btnAtackHead";
            this.btnAtackHead.Size = new System.Drawing.Size(139, 46);
            this.btnAtackHead.TabIndex = 2;
            this.btnAtackHead.Text = "Голова";
            this.btnAtackHead.UseVisualStyleBackColor = false;
            this.btnAtackHead.Click += new System.EventHandler(this.btnAtackHead_Click);
            // 
            // btnAtackBody
            // 
            this.btnAtackBody.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAtackBody.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAtackBody.FlatAppearance.BorderSize = 0;
            this.btnAtackBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtackBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAtackBody.Location = new System.Drawing.Point(118, 222);
            this.btnAtackBody.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtackBody.Name = "btnAtackBody";
            this.btnAtackBody.Size = new System.Drawing.Size(139, 46);
            this.btnAtackBody.TabIndex = 3;
            this.btnAtackBody.Text = "Корпус";
            this.btnAtackBody.UseVisualStyleBackColor = false;
            this.btnAtackBody.Click += new System.EventHandler(this.btnAtackBody_Click);
            // 
            // btnAtackLegs
            // 
            this.btnAtackLegs.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAtackLegs.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAtackLegs.FlatAppearance.BorderSize = 0;
            this.btnAtackLegs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtackLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAtackLegs.Location = new System.Drawing.Point(118, 272);
            this.btnAtackLegs.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtackLegs.Name = "btnAtackLegs";
            this.btnAtackLegs.Size = new System.Drawing.Size(139, 46);
            this.btnAtackLegs.TabIndex = 4;
            this.btnAtackLegs.Text = "Ноги";
            this.btnAtackLegs.UseVisualStyleBackColor = false;
            this.btnAtackLegs.Click += new System.EventHandler(this.btnAtackLegs_Click);
            // 
            // btnDefLegs
            // 
            this.btnDefLegs.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDefLegs.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDefLegs.FlatAppearance.BorderSize = 0;
            this.btnDefLegs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefLegs.Location = new System.Drawing.Point(302, 272);
            this.btnDefLegs.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefLegs.Name = "btnDefLegs";
            this.btnDefLegs.Size = new System.Drawing.Size(139, 46);
            this.btnDefLegs.TabIndex = 7;
            this.btnDefLegs.Text = "Ноги";
            this.btnDefLegs.UseVisualStyleBackColor = false;
            this.btnDefLegs.Click += new System.EventHandler(this.btnDefLegs_Click);
            // 
            // btnDefBody
            // 
            this.btnDefBody.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDefBody.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDefBody.FlatAppearance.BorderSize = 0;
            this.btnDefBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefBody.Location = new System.Drawing.Point(302, 222);
            this.btnDefBody.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefBody.Name = "btnDefBody";
            this.btnDefBody.Size = new System.Drawing.Size(139, 46);
            this.btnDefBody.TabIndex = 6;
            this.btnDefBody.Text = "Корпус";
            this.btnDefBody.UseVisualStyleBackColor = false;
            this.btnDefBody.Click += new System.EventHandler(this.btnDefBody_Click);
            // 
            // btnDefHead
            // 
            this.btnDefHead.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDefHead.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDefHead.FlatAppearance.BorderSize = 0;
            this.btnDefHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefHead.Location = new System.Drawing.Point(302, 172);
            this.btnDefHead.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefHead.Name = "btnDefHead";
            this.btnDefHead.Size = new System.Drawing.Size(139, 46);
            this.btnDefHead.TabIndex = 5;
            this.btnDefHead.Text = "Голова";
            this.btnDefHead.UseVisualStyleBackColor = false;
            this.btnDefHead.Click += new System.EventHandler(this.btnDefHead_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.SkyBlue;
            this.lblusername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblusername.Location = new System.Drawing.Point(11, 9);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(70, 26);
            this.lblusername.TabIndex = 8;
            this.lblusername.Text = "Игрок";
            // 
            // userHP
            // 
            this.userHP.Location = new System.Drawing.Point(11, 322);
            this.userHP.Margin = new System.Windows.Forms.Padding(2);
            this.userHP.Name = "userHP";
            this.userHP.Size = new System.Drawing.Size(534, 29);
            this.userHP.TabIndex = 10;
            this.userHP.Value = 100;
            // 
            // lblatack
            // 
            this.lblatack.AutoSize = true;
            this.lblatack.BackColor = System.Drawing.Color.SkyBlue;
            this.lblatack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblatack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblatack.Location = new System.Drawing.Point(152, 135);
            this.lblatack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblatack.Name = "lblatack";
            this.lblatack.Size = new System.Drawing.Size(69, 26);
            this.lblatack.TabIndex = 14;
            this.lblatack.Text = "Атака";
            // 
            // lbldef
            // 
            this.lbldef.AutoSize = true;
            this.lbldef.BackColor = System.Drawing.Color.SkyBlue;
            this.lbldef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldef.Location = new System.Drawing.Point(328, 135);
            this.lbldef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldef.Name = "lbldef";
            this.lbldef.Size = new System.Drawing.Size(85, 26);
            this.lbldef.TabIndex = 15;
            this.lbldef.Text = "Защита";
            // 
            // PlayerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 356);
            this.Controls.Add(this.lbldef);
            this.Controls.Add(this.lblatack);
            this.Controls.Add(this.userHP);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnDefLegs);
            this.Controls.Add(this.btnDefBody);
            this.Controls.Add(this.btnDefHead);
            this.Controls.Add(this.btnAtackLegs);
            this.Controls.Add(this.btnAtackBody);
            this.Controls.Add(this.btnAtackHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayerScreen";
            this.Text = "Fight Club";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtackHead;
        private System.Windows.Forms.Button btnAtackBody;
        private System.Windows.Forms.Button btnAtackLegs;
        private System.Windows.Forms.Button btnDefLegs;
        private System.Windows.Forms.Button btnDefBody;
        private System.Windows.Forms.Button btnDefHead;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.ProgressBar userHP;
        private System.Windows.Forms.Label lblatack;
        private System.Windows.Forms.Label lbldef;
    }
}

