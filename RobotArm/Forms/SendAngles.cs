using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RobotArm.Util.Util;
using static RobotArm.Properties.Settings;

namespace RobotArm.Forms
{
    public partial class SendAngles : Form
    {
        Util.SerialCom port;
        public SendAngles(Util.SerialCom port)
        {
            InitializeComponent();
            this.port = port;

        }

        private void SendAngles_Load(object sender, EventArgs e)
        {
            clawTextBox.Text = Default.claw;
            handTextBox.Text = Default.hand;
            elbowTextBox.Text = Default.elbow;
            shoulderPanTextBox.Text = Default.shoulderPan;
            shoulderTiltTextBox.Text = Default.shoulderTilt;
        }

        #region +/- buttons
        private void handPlusButton_Click(object sender, EventArgs e)
        {
            PlusButton(handTextBox);
        }
        private void handMinusButton_Click(object sender, EventArgs e)
        {
            MinusButton(handTextBox);
        }
        private void elbowPlusButton_Click(object sender, EventArgs e)
        {
            PlusButton(elbowTextBox);
        }

        private void elbowMinusButon_Click(object sender, EventArgs e)
        {
            MinusButton(elbowTextBox);
        }

        private void shoulderTiltPlusButton_Click(object sender, EventArgs e)
        {
            PlusButton(shoulderTiltTextBox);
        }

        private void shoulderTiltMinusButton_Click(object sender, EventArgs e)
        {
            MinusButton(shoulderTiltTextBox);
        }

        private void shoulderPanPlusButton_Click(object sender, EventArgs e)
        {
            PlusButton(shoulderPanTextBox);
        }

        private void shoulderPanMinusButton_Click(object sender, EventArgs e)
        {
            MinusButton(shoulderPanTextBox);
        }

        private void clawPlusButton_Click(object sender, EventArgs e)
        {
            PlusButton(clawTextBox, Default.clawClosed, Default.clawOpen);
        }

        private void clawMinusButton_Click(object sender, EventArgs e)
        {
            MinusButton(clawTextBox, Default.clawOpen, Default.clawClosed);
        }

        #endregion
        #region sendButtons
        private void sendHandButton_Click(object sender, EventArgs e)
        {
            port.sendPosToServo("h", Convert.ToByte(handTextBox.Text));
        }

        private void sendElbowButton_Click(object sender, EventArgs e)
        {
            port.sendPosToServo("e", Convert.ToByte(elbowTextBox.Text));
        }

        private void sendTiltButton_Click(object sender, EventArgs e)
        {
            port.sendPosToServo("t", Convert.ToByte(shoulderTiltTextBox.Text));
        }

        private void sendPanButton_Click(object sender, EventArgs e)
        {
            port.sendPosToServo("p", Convert.ToByte(shoulderPanTextBox.Text));
        }

        private void sendClawButton_Click(object sender, EventArgs e)
        {
            port.sendPosToServo("c", Convert.ToByte(clawTextBox.Text));
        }
        private void handTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendHandButton_Click(this, new EventArgs());
            }
        }

        private void elbowTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendElbowButton_Click(this, new EventArgs());
            }
        }

        private void shoulderTiltTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendTiltButton_Click(this, new EventArgs());
            }
        }

        private void shoulderPanTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendPanButton_Click(this, new EventArgs());
            }
        }

        private void clawTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendClawButton_Click(this, new EventArgs());
            }
        }
        #endregion

        private void handTextBox_TextChanged(object sender, EventArgs e)
        {
            Default.hand = handTextBox.Text;
            Default.Save();
        }

        private void elbowTextBox_TextChanged(object sender, EventArgs e)
        {
            Default.elbow = elbowTextBox.Text;
            Default.Save();
        }

        private void shoulderTiltTextBox_TextChanged(object sender, EventArgs e)
        {
            Default.shoulderTilt = shoulderTiltTextBox.Text;
            Default.Save();
        }

        private void shoulderPanTextBox_TextChanged(object sender, EventArgs e)
        {
            Default.shoulderPan = shoulderPanTextBox.Text;
            Default.Save();
        }

        private void clawTextBox_TextChanged(object sender, EventArgs e)
        {
            Default.claw = clawTextBox.Text;
            Default.Save();
        }
    }
}
