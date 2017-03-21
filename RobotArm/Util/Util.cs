using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RobotArm.Util
{
    class Util
    {
        #region buttons
        public static void PlusButton(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = 0.ToString();
            }
            else
            {
                textBox.Text = Convert.ToString(Convert.ToInt16(textBox.Text) + 1);
            }
        }
        public static void MinusButton(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = 0.ToString();
            }
            else
            {
                textBox.Text = Convert.ToString(Convert.ToInt16(textBox.Text) - 1);
            }
        }
        public static void PlusButton(TextBox textBox, byte max, byte min)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = 0.ToString();
            }
            else
            {
                if (Convert.ToByte(textBox.Text) < Math.Max(min, max))
                {
                    textBox.Text = Convert.ToString(Convert.ToInt16(textBox.Text) + 1);
                }
            }
        }
        public static void MinusButton(TextBox textBox, byte max, byte min)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = 0.ToString();
            }
            else
            {
                if (Convert.ToByte(textBox.Text) > Math.Min(min, max))
                {
                    textBox.Text = Convert.ToString(Convert.ToInt16(textBox.Text) - 1);
                }
            }
        }
        #endregion buttons
    }

}

