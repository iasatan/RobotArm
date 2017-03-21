namespace RobotArm.Forms
{
    partial class Start
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeClaw = new System.Windows.Forms.Button();
            this.openClaw = new System.Windows.Forms.Button();
            this.setPosition = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendAngleToServoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMacroMakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticTacToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(199, 90);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 23);
            this.button8.TabIndex = 63;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.zMinus_Click);
            // 
            // button7
            // 
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(199, 58);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 23);
            this.button7.TabIndex = 62;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.yMinus_Click);
            // 
            // button6
            // 
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(199, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 61;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.xMinus_Click);
            // 
            // button5
            // 
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(156, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 23);
            this.button5.TabIndex = 60;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.zPlus_Click);
            // 
            // button4
            // 
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(156, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 59;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.yPlus_Click);
            // 
            // button3
            // 
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(156, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 58;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.xPlus_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(5, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Port:";
            // 
            // comTextBox
            // 
            this.comTextBox.Location = new System.Drawing.Point(40, 122);
            this.comTextBox.Name = "comTextBox";
            this.comTextBox.Size = new System.Drawing.Size(100, 20);
            this.comTextBox.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Z:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "X:";
            // 
            // closeClaw
            // 
            this.closeClaw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeClaw.Location = new System.Drawing.Point(266, 56);
            this.closeClaw.Name = "closeClaw";
            this.closeClaw.Size = new System.Drawing.Size(97, 23);
            this.closeClaw.TabIndex = 51;
            this.closeClaw.Text = "Close Claw";
            this.closeClaw.UseVisualStyleBackColor = true;
            this.closeClaw.Click += new System.EventHandler(this.closeClaw_Click);
            // 
            // openClaw
            // 
            this.openClaw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.openClaw.Location = new System.Drawing.Point(266, 25);
            this.openClaw.Name = "openClaw";
            this.openClaw.Size = new System.Drawing.Size(97, 23);
            this.openClaw.TabIndex = 50;
            this.openClaw.Text = "Open Claw";
            this.openClaw.UseVisualStyleBackColor = true;
            this.openClaw.Click += new System.EventHandler(this.openClaw_Click);
            // 
            // setPosition
            // 
            this.setPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.setPosition.Location = new System.Drawing.Point(266, 87);
            this.setPosition.Name = "setPosition";
            this.setPosition.Size = new System.Drawing.Size(97, 23);
            this.setPosition.TabIndex = 49;
            this.setPosition.Text = "Send Position";
            this.setPosition.UseVisualStyleBackColor = true;
            this.setPosition.Click += new System.EventHandler(this.sendPos_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(40, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 47;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 46;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.functionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(378, 24);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.armDetailsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // armDetailsToolStripMenuItem
            // 
            this.armDetailsToolStripMenuItem.Name = "armDetailsToolStripMenuItem";
            this.armDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.armDetailsToolStripMenuItem.Text = "Arm Details";
            this.armDetailsToolStripMenuItem.Click += new System.EventHandler(this.armDetailsToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendAngleToServoToolStripMenuItem,
            this.openMacroMakerToolStripMenuItem,
            this.playGamesToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // sendAngleToServoToolStripMenuItem
            // 
            this.sendAngleToServoToolStripMenuItem.Name = "sendAngleToServoToolStripMenuItem";
            this.sendAngleToServoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.sendAngleToServoToolStripMenuItem.Text = "Send angle to servo";
            this.sendAngleToServoToolStripMenuItem.Click += new System.EventHandler(this.sendAngleToServoToolStripMenuItem_Click);
            // 
            // openMacroMakerToolStripMenuItem
            // 
            this.openMacroMakerToolStripMenuItem.Name = "openMacroMakerToolStripMenuItem";
            this.openMacroMakerToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.openMacroMakerToolStripMenuItem.Text = "Open Macro Maker";
            this.openMacroMakerToolStripMenuItem.Click += new System.EventHandler(this.openMacroMakerToolStripMenuItem_Click);
            // 
            // playGamesToolStripMenuItem
            // 
            this.playGamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticTacToeToolStripMenuItem});
            this.playGamesToolStripMenuItem.Name = "playGamesToolStripMenuItem";
            this.playGamesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.playGamesToolStripMenuItem.Text = "Play Games";
            // 
            // ticTacToeToolStripMenuItem
            // 
            this.ticTacToeToolStripMenuItem.Name = "ticTacToeToolStripMenuItem";
            this.ticTacToeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ticTacToeToolStripMenuItem.Text = "TicTacToe";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem,
            this.contactMeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fAQToolStripMenuItem.Text = "F.A.Q";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // contactMeToolStripMenuItem
            // 
            this.contactMeToolStripMenuItem.Name = "contactMeToolStripMenuItem";
            this.contactMeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.contactMeToolStripMenuItem.Text = "Contact Developer";
            this.contactMeToolStripMenuItem.Click += new System.EventHandler(this.contactMeToolStripMenuItem_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 152);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeClaw);
            this.Controls.Add(this.openClaw);
            this.Controls.Add(this.setPosition);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox comTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeClaw;
        private System.Windows.Forms.Button openClaw;
        private System.Windows.Forms.Button setPosition;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem armDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendAngleToServoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMacroMakerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticTacToeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactMeToolStripMenuItem;
    }
}