using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using static RobotArm.Util.Util;
using static RobotArm.Properties.Settings;

namespace RobotArm.Forms
{
    public partial class Start : Form
    {
        Util.SerialCom port = new Util.SerialCom();
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            initComboBox1();
            textBox1.Text = Default.X;
            textBox2.Text = Default.Y;
            textBox3.Text = Default.Z;
            port.connectToCom(comboBox1.Text);
            comTextBox.Text = port.connectedToCom();
        }

        public void initComboBox1()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string available in ports)
            {
                comboBox1.Items.Add(available);
            }
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }


        #region Menu
        private void armDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CalibrateArm().Show();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void contactMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:satanadam@outlook.com");
        }

        private void sendAngleToServoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SendAngles(port).Show();
        }

        private void openMacroMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new Macro(port).Show();
        }

        private void ticTacToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You will need a camera for this");
            //new TicTacToe(port).Show();
        }


        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\FAQ.html");
        }
        #endregion Menu
        #region servoSenderButtons
        private void sendPos_Click(object sender, EventArgs e)
        {
            // port.writeAnglesToSerial(new xyzToServoPos(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text)).calculateAngles());
        }

        private void openClaw_Click(object sender, EventArgs e)
        {
            port.claw("open");
        }

        private void closeClaw_Click(object sender, EventArgs e)
        {
            port.claw("close");
        }

        #endregion
        #region +/- buttons
        private void xPlus_Click_1(object sender, EventArgs e)
        {
            PlusButton(textBox1);
        }
        private void xMinus_Click(object sender, EventArgs e)
        {
            MinusButton(textBox1);
        }
        private void yPlus_Click(object sender, EventArgs e)
        {
            PlusButton(textBox2);
        }
        private void yMinus_Click(object sender, EventArgs e)
        {
            MinusButton(textBox2);
        }
        private void zPlus_Click(object sender, EventArgs e)
        {
            PlusButton(textBox3);
        }
        private void zMinus_Click(object sender, EventArgs e)
        {
            MinusButton(textBox3);
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Default.X = textBox1.Text;
            Default.Save();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Default.Y = textBox2.Text;
            Default.Save();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Default.Z = textBox3.Text;
            Default.Save();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            port.connectToCom(comboBox1.Text);
            comTextBox.Text = port.connectedToCom();
        }

    }
}
