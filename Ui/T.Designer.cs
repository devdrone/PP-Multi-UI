namespace Ui
{
    partial class T
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
            this.TEnable = new System.Windows.Forms.CheckBox();
            this.EnableTimeout = new System.Windows.Forms.CheckBox();
            this.EnableRecoilLimit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YawRecoilLimit = new System.Windows.Forms.TextBox();
            this.PitchRecoilLimit = new System.Windows.Forms.TextBox();
            this.Lable2 = new System.Windows.Forms.Label();
            this.FirstShotDelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FollowUpDelay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Timeout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEnable
            // 
            this.TEnable.AutoSize = true;
            this.TEnable.Location = new System.Drawing.Point(12, 12);
            this.TEnable.Name = "TEnable";
            this.TEnable.Size = new System.Drawing.Size(59, 17);
            this.TEnable.TabIndex = 0;
            this.TEnable.Text = "Enable";
            this.TEnable.UseVisualStyleBackColor = true;
            // 
            // EnableTimeout
            // 
            this.EnableTimeout.AutoSize = true;
            this.EnableTimeout.Location = new System.Drawing.Point(12, 35);
            this.EnableTimeout.Name = "EnableTimeout";
            this.EnableTimeout.Size = new System.Drawing.Size(97, 17);
            this.EnableTimeout.TabIndex = 1;
            this.EnableTimeout.Text = "EnableTimeout";
            this.EnableTimeout.UseVisualStyleBackColor = true;
            // 
            // EnableRecoilLimit
            // 
            this.EnableRecoilLimit.AutoSize = true;
            this.EnableRecoilLimit.Location = new System.Drawing.Point(12, 58);
            this.EnableRecoilLimit.Name = "EnableRecoilLimit";
            this.EnableRecoilLimit.Size = new System.Drawing.Size(110, 17);
            this.EnableRecoilLimit.TabIndex = 2;
            this.EnableRecoilLimit.Text = "EnableRecoilLimit";
            this.EnableRecoilLimit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "YawRecoilLimit";
            // 
            // YawRecoilLimit
            // 
            this.YawRecoilLimit.Location = new System.Drawing.Point(94, 81);
            this.YawRecoilLimit.Name = "YawRecoilLimit";
            this.YawRecoilLimit.Size = new System.Drawing.Size(100, 20);
            this.YawRecoilLimit.TabIndex = 4;
            // 
            // PitchRecoilLimit
            // 
            this.PitchRecoilLimit.Location = new System.Drawing.Point(94, 107);
            this.PitchRecoilLimit.Name = "PitchRecoilLimit";
            this.PitchRecoilLimit.Size = new System.Drawing.Size(100, 20);
            this.PitchRecoilLimit.TabIndex = 6;
            // 
            // Lable2
            // 
            this.Lable2.AutoSize = true;
            this.Lable2.Location = new System.Drawing.Point(9, 110);
            this.Lable2.Name = "Lable2";
            this.Lable2.Size = new System.Drawing.Size(82, 13);
            this.Lable2.TabIndex = 5;
            this.Lable2.Text = "PitchRecoilLimit";
            // 
            // FirstShotDelay
            // 
            this.FirstShotDelay.Location = new System.Drawing.Point(94, 133);
            this.FirstShotDelay.Name = "FirstShotDelay";
            this.FirstShotDelay.Size = new System.Drawing.Size(100, 20);
            this.FirstShotDelay.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "FirstShotDelay";
            // 
            // FollowUpDelay
            // 
            this.FollowUpDelay.Location = new System.Drawing.Point(94, 159);
            this.FollowUpDelay.Name = "FollowUpDelay";
            this.FollowUpDelay.Size = new System.Drawing.Size(100, 20);
            this.FollowUpDelay.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "FollowUpDelay";
            // 
            // Timeout
            // 
            this.Timeout.Location = new System.Drawing.Point(94, 185);
            this.Timeout.Name = "Timeout";
            this.Timeout.Size = new System.Drawing.Size(100, 20);
            this.Timeout.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Timeout";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Timeout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FollowUpDelay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstShotDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PitchRecoilLimit);
            this.Controls.Add(this.Lable2);
            this.Controls.Add(this.YawRecoilLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnableRecoilLimit);
            this.Controls.Add(this.EnableTimeout);
            this.Controls.Add(this.TEnable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "T";
            this.Text = "TriggetBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TEnable;
        private System.Windows.Forms.CheckBox EnableTimeout;
        private System.Windows.Forms.CheckBox EnableRecoilLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YawRecoilLimit;
        private System.Windows.Forms.TextBox PitchRecoilLimit;
        private System.Windows.Forms.Label Lable2;
        private System.Windows.Forms.TextBox FirstShotDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FollowUpDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Timeout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}