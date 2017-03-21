namespace RobotArm.Forms
{
    partial class SendAngles
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
            this.sendClawButton = new System.Windows.Forms.Button();
            this.sendPanButton = new System.Windows.Forms.Button();
            this.sendTiltButton = new System.Windows.Forms.Button();
            this.sendElbowButton = new System.Windows.Forms.Button();
            this.sendHandButton = new System.Windows.Forms.Button();
            this.clawMinusButton = new System.Windows.Forms.Button();
            this.clawPlusButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.clawTextBox = new System.Windows.Forms.TextBox();
            this.shoulderPanMinusButton = new System.Windows.Forms.Button();
            this.shoulderPanPlusButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.shoulderPanTextBox = new System.Windows.Forms.TextBox();
            this.shoulderTiltMinusButton = new System.Windows.Forms.Button();
            this.elbowMinusButon = new System.Windows.Forms.Button();
            this.handMinusButton = new System.Windows.Forms.Button();
            this.shoulderTiltPlusButton = new System.Windows.Forms.Button();
            this.elbowPlusButton = new System.Windows.Forms.Button();
            this.handPlusButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shoulderTiltTextBox = new System.Windows.Forms.TextBox();
            this.elbowTextBox = new System.Windows.Forms.TextBox();
            this.handTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendClawButton
            // 
            this.sendClawButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sendClawButton.Location = new System.Drawing.Point(280, 148);
            this.sendClawButton.Name = "sendClawButton";
            this.sendClawButton.Size = new System.Drawing.Size(75, 23);
            this.sendClawButton.TabIndex = 101;
            this.sendClawButton.Text = "Send";
            this.sendClawButton.UseVisualStyleBackColor = true;
            this.sendClawButton.Click += new System.EventHandler(this.sendClawButton_Click);
            // 
            // sendPanButton
            // 
            this.sendPanButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sendPanButton.Location = new System.Drawing.Point(280, 113);
            this.sendPanButton.Name = "sendPanButton";
            this.sendPanButton.Size = new System.Drawing.Size(75, 23);
            this.sendPanButton.TabIndex = 100;
            this.sendPanButton.Text = "Send";
            this.sendPanButton.UseVisualStyleBackColor = true;
            this.sendPanButton.Click += new System.EventHandler(this.sendPanButton_Click);
            // 
            // sendTiltButton
            // 
            this.sendTiltButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sendTiltButton.Location = new System.Drawing.Point(280, 78);
            this.sendTiltButton.Name = "sendTiltButton";
            this.sendTiltButton.Size = new System.Drawing.Size(75, 23);
            this.sendTiltButton.TabIndex = 99;
            this.sendTiltButton.Text = "Send";
            this.sendTiltButton.UseVisualStyleBackColor = true;
            this.sendTiltButton.Click += new System.EventHandler(this.sendTiltButton_Click);
            // 
            // sendElbowButton
            // 
            this.sendElbowButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sendElbowButton.Location = new System.Drawing.Point(280, 46);
            this.sendElbowButton.Name = "sendElbowButton";
            this.sendElbowButton.Size = new System.Drawing.Size(75, 23);
            this.sendElbowButton.TabIndex = 98;
            this.sendElbowButton.Text = "Send";
            this.sendElbowButton.UseVisualStyleBackColor = true;
            this.sendElbowButton.Click += new System.EventHandler(this.sendElbowButton_Click);
            // 
            // sendHandButton
            // 
            this.sendHandButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sendHandButton.Location = new System.Drawing.Point(280, 9);
            this.sendHandButton.Name = "sendHandButton";
            this.sendHandButton.Size = new System.Drawing.Size(75, 23);
            this.sendHandButton.TabIndex = 97;
            this.sendHandButton.Text = "Send";
            this.sendHandButton.UseVisualStyleBackColor = true;
            this.sendHandButton.Click += new System.EventHandler(this.sendHandButton_Click);
            // 
            // clawMinusButton
            // 
            this.clawMinusButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clawMinusButton.Location = new System.Drawing.Point(246, 148);
            this.clawMinusButton.Name = "clawMinusButton";
            this.clawMinusButton.Size = new System.Drawing.Size(25, 23);
            this.clawMinusButton.TabIndex = 96;
            this.clawMinusButton.Text = "-";
            this.clawMinusButton.UseVisualStyleBackColor = true;
            this.clawMinusButton.Click += new System.EventHandler(this.clawMinusButton_Click);
            // 
            // clawPlusButton
            // 
            this.clawPlusButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clawPlusButton.Location = new System.Drawing.Point(203, 148);
            this.clawPlusButton.Name = "clawPlusButton";
            this.clawPlusButton.Size = new System.Drawing.Size(25, 23);
            this.clawPlusButton.TabIndex = 95;
            this.clawPlusButton.Text = "+";
            this.clawPlusButton.UseVisualStyleBackColor = true;
            this.clawPlusButton.Click += new System.EventHandler(this.clawPlusButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(10, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "claw";
            // 
            // clawTextBox
            // 
            this.clawTextBox.Location = new System.Drawing.Point(87, 148);
            this.clawTextBox.Name = "clawTextBox";
            this.clawTextBox.Size = new System.Drawing.Size(100, 20);
            this.clawTextBox.TabIndex = 93;
            this.clawTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clawTextBox_KeyDown);
            // 
            // shoulderPanMinusButton
            // 
            this.shoulderPanMinusButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.shoulderPanMinusButton.Location = new System.Drawing.Point(246, 113);
            this.shoulderPanMinusButton.Name = "shoulderPanMinusButton";
            this.shoulderPanMinusButton.Size = new System.Drawing.Size(25, 23);
            this.shoulderPanMinusButton.TabIndex = 92;
            this.shoulderPanMinusButton.Text = "-";
            this.shoulderPanMinusButton.UseVisualStyleBackColor = true;
            this.shoulderPanMinusButton.Click += new System.EventHandler(this.shoulderPanMinusButton_Click);
            // 
            // shoulderPanPlusButton
            // 
            this.shoulderPanPlusButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.shoulderPanPlusButton.Location = new System.Drawing.Point(203, 113);
            this.shoulderPanPlusButton.Name = "shoulderPanPlusButton";
            this.shoulderPanPlusButton.Size = new System.Drawing.Size(25, 23);
            this.shoulderPanPlusButton.TabIndex = 91;
            this.shoulderPanPlusButton.Text = "+";
            this.shoulderPanPlusButton.UseVisualStyleBackColor = true;
            this.shoulderPanPlusButton.Click += new System.EventHandler(this.shoulderPanPlusButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(10, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "shoulderPan";
            // 
            // shoulderPanTextBox
            // 
            this.shoulderPanTextBox.Location = new System.Drawing.Point(87, 115);
            this.shoulderPanTextBox.Name = "shoulderPanTextBox";
            this.shoulderPanTextBox.Size = new System.Drawing.Size(100, 20);
            this.shoulderPanTextBox.TabIndex = 89;
            this.shoulderPanTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shoulderPanTextBox_KeyDown);
            // 
            // shoulderTiltMinusButton
            // 
            this.shoulderTiltMinusButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.shoulderTiltMinusButton.Location = new System.Drawing.Point(246, 78);
            this.shoulderTiltMinusButton.Name = "shoulderTiltMinusButton";
            this.shoulderTiltMinusButton.Size = new System.Drawing.Size(25, 23);
            this.shoulderTiltMinusButton.TabIndex = 88;
            this.shoulderTiltMinusButton.Text = "-";
            this.shoulderTiltMinusButton.UseVisualStyleBackColor = true;
            this.shoulderTiltMinusButton.Click += new System.EventHandler(this.shoulderTiltMinusButton_Click);
            // 
            // elbowMinusButon
            // 
            this.elbowMinusButon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.elbowMinusButon.Location = new System.Drawing.Point(246, 46);
            this.elbowMinusButon.Name = "elbowMinusButon";
            this.elbowMinusButon.Size = new System.Drawing.Size(25, 23);
            this.elbowMinusButon.TabIndex = 87;
            this.elbowMinusButon.Text = "-";
            this.elbowMinusButon.UseVisualStyleBackColor = true;
            this.elbowMinusButon.Click += new System.EventHandler(this.elbowMinusButon_Click);
            // 
            // handMinusButton
            // 
            this.handMinusButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.handMinusButton.Location = new System.Drawing.Point(246, 9);
            this.handMinusButton.Name = "handMinusButton";
            this.handMinusButton.Size = new System.Drawing.Size(25, 23);
            this.handMinusButton.TabIndex = 86;
            this.handMinusButton.Text = "-";
            this.handMinusButton.UseVisualStyleBackColor = true;
            this.handMinusButton.Click += new System.EventHandler(this.handMinusButton_Click);
            // 
            // shoulderTiltPlusButton
            // 
            this.shoulderTiltPlusButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.shoulderTiltPlusButton.Location = new System.Drawing.Point(203, 78);
            this.shoulderTiltPlusButton.Name = "shoulderTiltPlusButton";
            this.shoulderTiltPlusButton.Size = new System.Drawing.Size(25, 23);
            this.shoulderTiltPlusButton.TabIndex = 85;
            this.shoulderTiltPlusButton.Text = "+";
            this.shoulderTiltPlusButton.UseVisualStyleBackColor = true;
            this.shoulderTiltPlusButton.Click += new System.EventHandler(this.shoulderTiltPlusButton_Click);
            // 
            // elbowPlusButton
            // 
            this.elbowPlusButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.elbowPlusButton.Location = new System.Drawing.Point(203, 46);
            this.elbowPlusButton.Name = "elbowPlusButton";
            this.elbowPlusButton.Size = new System.Drawing.Size(25, 23);
            this.elbowPlusButton.TabIndex = 84;
            this.elbowPlusButton.Text = "+";
            this.elbowPlusButton.UseVisualStyleBackColor = true;
            this.elbowPlusButton.Click += new System.EventHandler(this.elbowPlusButton_Click);
            // 
            // handPlusButton
            // 
            this.handPlusButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.handPlusButton.Location = new System.Drawing.Point(203, 9);
            this.handPlusButton.Name = "handPlusButton";
            this.handPlusButton.Size = new System.Drawing.Size(25, 23);
            this.handPlusButton.TabIndex = 83;
            this.handPlusButton.Text = "+";
            this.handPlusButton.UseVisualStyleBackColor = true;
            this.handPlusButton.Click += new System.EventHandler(this.handPlusButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(10, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "elbow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "sholderTilt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "hand";
            // 
            // shoulderTiltTextBox
            // 
            this.shoulderTiltTextBox.Location = new System.Drawing.Point(87, 78);
            this.shoulderTiltTextBox.Name = "shoulderTiltTextBox";
            this.shoulderTiltTextBox.Size = new System.Drawing.Size(100, 20);
            this.shoulderTiltTextBox.TabIndex = 79;
            this.shoulderTiltTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shoulderTiltTextBox_KeyDown);
            // 
            // elbowTextBox
            // 
            this.elbowTextBox.Location = new System.Drawing.Point(87, 46);
            this.elbowTextBox.Name = "elbowTextBox";
            this.elbowTextBox.Size = new System.Drawing.Size(100, 20);
            this.elbowTextBox.TabIndex = 78;
            this.elbowTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.elbowTextBox_KeyDown);
            // 
            // handTextBox
            // 
            this.handTextBox.Location = new System.Drawing.Point(87, 12);
            this.handTextBox.Name = "handTextBox";
            this.handTextBox.Size = new System.Drawing.Size(100, 20);
            this.handTextBox.TabIndex = 77;
            this.handTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handTextBox_KeyDown);
            // 
            // SendAngles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 178);
            this.Controls.Add(this.sendClawButton);
            this.Controls.Add(this.sendPanButton);
            this.Controls.Add(this.sendTiltButton);
            this.Controls.Add(this.sendElbowButton);
            this.Controls.Add(this.sendHandButton);
            this.Controls.Add(this.clawMinusButton);
            this.Controls.Add(this.clawPlusButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clawTextBox);
            this.Controls.Add(this.shoulderPanMinusButton);
            this.Controls.Add(this.shoulderPanPlusButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shoulderPanTextBox);
            this.Controls.Add(this.shoulderTiltMinusButton);
            this.Controls.Add(this.elbowMinusButon);
            this.Controls.Add(this.handMinusButton);
            this.Controls.Add(this.shoulderTiltPlusButton);
            this.Controls.Add(this.elbowPlusButton);
            this.Controls.Add(this.handPlusButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shoulderTiltTextBox);
            this.Controls.Add(this.elbowTextBox);
            this.Controls.Add(this.handTextBox);
            this.Name = "SendAngles";
            this.Text = "SendAngles";
            this.Load += new System.EventHandler(this.SendAngles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendClawButton;
        private System.Windows.Forms.Button sendPanButton;
        private System.Windows.Forms.Button sendTiltButton;
        private System.Windows.Forms.Button sendElbowButton;
        private System.Windows.Forms.Button sendHandButton;
        private System.Windows.Forms.Button clawMinusButton;
        private System.Windows.Forms.Button clawPlusButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clawTextBox;
        private System.Windows.Forms.Button shoulderPanMinusButton;
        private System.Windows.Forms.Button shoulderPanPlusButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox shoulderPanTextBox;
        private System.Windows.Forms.Button shoulderTiltMinusButton;
        private System.Windows.Forms.Button elbowMinusButon;
        private System.Windows.Forms.Button handMinusButton;
        private System.Windows.Forms.Button shoulderTiltPlusButton;
        private System.Windows.Forms.Button elbowPlusButton;
        private System.Windows.Forms.Button handPlusButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shoulderTiltTextBox;
        private System.Windows.Forms.TextBox elbowTextBox;
        private System.Windows.Forms.TextBox handTextBox;
    }
}