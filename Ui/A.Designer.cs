namespace Ui
{
    partial class A
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
            this.Enable = new System.Windows.Forms.CheckBox();
            this.EnableFire = new System.Windows.Forms.CheckBox();
            this.EnableRandomPitchRecoilReductionFactor = new System.Windows.Forms.CheckBox();
            this.EnableRandomYawRecoilReductionFactor = new System.Windows.Forms.CheckBox();
            this.EnableTimeout = new System.Windows.Forms.CheckBox();
            this.IgnoreShotCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxRandomPitch = new System.Windows.Forms.TextBox();
            this.MaxRandomYaw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinRandomPitch = new System.Windows.Forms.TextBox();
            this.MinRandomYaw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TargetJumpingPlayers = new System.Windows.Forms.CheckBox();
            this.SmoothPercent = new System.Windows.Forms.TextBox();
            this.StaticPitch = new System.Windows.Forms.TextBox();
            this.StaticYaw = new System.Windows.Forms.TextBox();
            this.TargetBone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Timeout = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Save_Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enable
            // 
            this.Enable.AutoSize = true;
            this.Enable.Location = new System.Drawing.Point(12, 12);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(59, 17);
            this.Enable.TabIndex = 0;
            this.Enable.Text = "Enable";
            this.Enable.UseVisualStyleBackColor = true;
            this.Enable.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EnableFire
            // 
            this.EnableFire.AutoSize = true;
            this.EnableFire.Location = new System.Drawing.Point(12, 35);
            this.EnableFire.Name = "EnableFire";
            this.EnableFire.Size = new System.Drawing.Size(65, 17);
            this.EnableFire.TabIndex = 1;
            this.EnableFire.Text = "EnableF";
            this.EnableFire.UseVisualStyleBackColor = true;
            // 
            // EnableRandomPitchRecoilReductionFactor
            // 
            this.EnableRandomPitchRecoilReductionFactor.AutoSize = true;
            this.EnableRandomPitchRecoilReductionFactor.Location = new System.Drawing.Point(12, 58);
            this.EnableRandomPitchRecoilReductionFactor.Name = "EnableRandomPitchRecoilReductionFactor";
            this.EnableRandomPitchRecoilReductionFactor.Size = new System.Drawing.Size(67, 17);
            this.EnableRandomPitchRecoilReductionFactor.TabIndex = 2;
            this.EnableRandomPitchRecoilReductionFactor.Text = "EnableR";
            this.EnableRandomPitchRecoilReductionFactor.UseVisualStyleBackColor = true;
            // 
            // EnableRandomYawRecoilReductionFactor
            // 
            this.EnableRandomYawRecoilReductionFactor.AutoSize = true;
            this.EnableRandomYawRecoilReductionFactor.Location = new System.Drawing.Point(12, 81);
            this.EnableRandomYawRecoilReductionFactor.Name = "EnableRandomYawRecoilReductionFactor";
            this.EnableRandomYawRecoilReductionFactor.Size = new System.Drawing.Size(74, 17);
            this.EnableRandomYawRecoilReductionFactor.TabIndex = 3;
            this.EnableRandomYawRecoilReductionFactor.Text = "EnableRY";
            this.EnableRandomYawRecoilReductionFactor.UseVisualStyleBackColor = true;
            // 
            // EnableTimeout
            // 
            this.EnableTimeout.AutoSize = true;
            this.EnableTimeout.Location = new System.Drawing.Point(12, 104);
            this.EnableTimeout.Name = "EnableTimeout";
            this.EnableTimeout.Size = new System.Drawing.Size(66, 17);
            this.EnableTimeout.TabIndex = 4;
            this.EnableTimeout.Text = "EnableT";
            this.EnableTimeout.UseVisualStyleBackColor = true;
            // 
            // IgnoreShotCount
            // 
            this.IgnoreShotCount.Location = new System.Drawing.Point(53, 150);
            this.IgnoreShotCount.Name = "IgnoreShotCount";
            this.IgnoreShotCount.Size = new System.Drawing.Size(100, 20);
            this.IgnoreShotCount.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ignore";
            // 
            // MaxRandomPitch
            // 
            this.MaxRandomPitch.Location = new System.Drawing.Point(53, 176);
            this.MaxRandomPitch.Name = "MaxRandomPitch";
            this.MaxRandomPitch.Size = new System.Drawing.Size(100, 20);
            this.MaxRandomPitch.TabIndex = 7;
            // 
            // MaxRandomYaw
            // 
            this.MaxRandomYaw.Location = new System.Drawing.Point(53, 202);
            this.MaxRandomYaw.Name = "MaxRandomYaw";
            this.MaxRandomYaw.Size = new System.Drawing.Size(100, 20);
            this.MaxRandomYaw.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "MRP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "MRY";
            // 
            // MinRandomPitch
            // 
            this.MinRandomPitch.Location = new System.Drawing.Point(53, 228);
            this.MinRandomPitch.Name = "MinRandomPitch";
            this.MinRandomPitch.Size = new System.Drawing.Size(100, 20);
            this.MinRandomPitch.TabIndex = 11;
            // 
            // MinRandomYaw
            // 
            this.MinRandomYaw.Location = new System.Drawing.Point(53, 255);
            this.MinRandomYaw.Name = "MinRandomYaw";
            this.MinRandomYaw.Size = new System.Drawing.Size(100, 20);
            this.MinRandomYaw.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "MIRP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "MIRY";
            // 
            // TargetJumpingPlayers
            // 
            this.TargetJumpingPlayers.AutoSize = true;
            this.TargetJumpingPlayers.Location = new System.Drawing.Point(12, 127);
            this.TargetJumpingPlayers.Name = "TargetJumpingPlayers";
            this.TargetJumpingPlayers.Size = new System.Drawing.Size(64, 17);
            this.TargetJumpingPlayers.TabIndex = 15;
            this.TargetJumpingPlayers.Text = "EnableJ";
            this.TargetJumpingPlayers.UseVisualStyleBackColor = true;
            // 
            // SmoothPercent
            // 
            this.SmoothPercent.Location = new System.Drawing.Point(53, 281);
            this.SmoothPercent.Name = "SmoothPercent";
            this.SmoothPercent.Size = new System.Drawing.Size(100, 20);
            this.SmoothPercent.TabIndex = 16;
            // 
            // StaticPitch
            // 
            this.StaticPitch.Location = new System.Drawing.Point(53, 307);
            this.StaticPitch.Name = "StaticPitch";
            this.StaticPitch.Size = new System.Drawing.Size(100, 20);
            this.StaticPitch.TabIndex = 17;
            // 
            // StaticYaw
            // 
            this.StaticYaw.Location = new System.Drawing.Point(53, 333);
            this.StaticYaw.Name = "StaticYaw";
            this.StaticYaw.Size = new System.Drawing.Size(100, 20);
            this.StaticYaw.TabIndex = 18;
            // 
            // TargetBone
            // 
            this.TargetBone.Location = new System.Drawing.Point(53, 359);
            this.TargetBone.Name = "TargetBone";
            this.TargetBone.Size = new System.Drawing.Size(100, 20);
            this.TargetBone.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "SP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "StaticP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "StaticR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "TB";
            // 
            // Timeout
            // 
            this.Timeout.Location = new System.Drawing.Point(53, 385);
            this.Timeout.Name = "Timeout";
            this.Timeout.Size = new System.Drawing.Size(100, 20);
            this.Timeout.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Timeout";
            // 
            // Save_Settings
            // 
            this.Save_Settings.Location = new System.Drawing.Point(13, 411);
            this.Save_Settings.Name = "Save_Settings";
            this.Save_Settings.Size = new System.Drawing.Size(75, 23);
            this.Save_Settings.TabIndex = 26;
            this.Save_Settings.Text = "Save";
            this.Save_Settings.UseVisualStyleBackColor = true;
            this.Save_Settings.Click += new System.EventHandler(this.Save_Settings_Click);
            // 
            // A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 446);
            this.Controls.Add(this.Save_Settings);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Timeout);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TargetBone);
            this.Controls.Add(this.StaticYaw);
            this.Controls.Add(this.StaticPitch);
            this.Controls.Add(this.SmoothPercent);
            this.Controls.Add(this.TargetJumpingPlayers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MinRandomYaw);
            this.Controls.Add(this.MinRandomPitch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxRandomYaw);
            this.Controls.Add(this.MaxRandomPitch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IgnoreShotCount);
            this.Controls.Add(this.EnableTimeout);
            this.Controls.Add(this.EnableRandomYawRecoilReductionFactor);
            this.Controls.Add(this.EnableRandomPitchRecoilReductionFactor);
            this.Controls.Add(this.EnableFire);
            this.Controls.Add(this.Enable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "A";
            this.Text = "AimBot Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Enable;
        private System.Windows.Forms.CheckBox EnableFire;
        private System.Windows.Forms.CheckBox EnableRandomPitchRecoilReductionFactor;
        private System.Windows.Forms.CheckBox EnableRandomYawRecoilReductionFactor;
        private System.Windows.Forms.CheckBox EnableTimeout;
        private System.Windows.Forms.TextBox IgnoreShotCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaxRandomPitch;
        private System.Windows.Forms.TextBox MaxRandomYaw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MinRandomPitch;
        private System.Windows.Forms.TextBox MinRandomYaw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox TargetJumpingPlayers;
        private System.Windows.Forms.TextBox SmoothPercent;
        private System.Windows.Forms.TextBox StaticPitch;
        private System.Windows.Forms.TextBox StaticYaw;
        private System.Windows.Forms.TextBox TargetBone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Timeout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Save_Settings;
    }
}