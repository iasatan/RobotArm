using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RobotArm.Properties.Settings;

namespace RobotArm.Forms
{
    public partial class CalibrateArm : Form
    {
        public CalibrateArm()
        {
            InitializeComponent();
        }

        private void CalibrateArm_Load(object sender, EventArgs e)
        {
            tabPage3.Hide();
            textBox1.Text = Convert.ToString(Default.handLength);
            textBox2.Text = Convert.ToString(Default.foreArmLength);
            textBox3.Text = Convert.ToString(Default.upperArmLength);
            textBox4.Text = Convert.ToString(Default.baseHeight);
            clawClosedTextBox.Text = Convert.ToString(Default.clawClosed);
            clawOpenedTextBox.Text = Convert.ToString(Default.clawOpen);
        }

        #region tabPage1
        private void saveButton_Click(object sender, EventArgs e)
        {
            Default.handLength = Convert.ToDouble(textBox1.Text);
            Default.foreArmLength = Convert.ToDouble(textBox2.Text);
            Default.upperArmLength = Convert.ToDouble(textBox3.Text);
            Default.baseHeight = Convert.ToByte(textBox4.Text);
            Default.Save();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 2.54);
                if (Convert.ToDouble(textBox5.Text) > 10000000)
                {
                    MessageBox.Show("Dude, stop playing");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please use coma, not dot");
            }

        }
        private void handInsertButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox5.Text;
        }

        private void upperInsertButton_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox5.Text;
        }

        private void foreInsertButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox5.Text;
        }

        private void baseInsertButton_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox5.Text;
        }
        #endregion tabPage1
        #region tabPage2
        private void saveClawButton_Click(object sender, EventArgs e)
        {
            Default.clawClosed = Convert.ToByte(clawClosedTextBox.Text);
            Default.clawOpen = Convert.ToByte(clawOpenedTextBox.Text);
            Default.Save();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.instructables.com/id/Calibrating-Servos-for-Bracketrobot-Arm/");
        }
        #endregion tabPage2
        #region tabControl3
        private void elbowMaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveServoButton_Click(object sender, EventArgs e)
        {

        }
        #endregion tabControl3

    }
}
