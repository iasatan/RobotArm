using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace RobotArm.Util
{
    public class SerialCom
    {
        SerialPort port;
        Model.Angles angles = new Model.Angles();
        void initPort()
        {
            try
            {
                port.Open();
                port.Close();
            }
            catch (Exception) { }
        }
        public void connectToCom(string portName)
        {
            port = new SerialPort(portName, 9600);
            initPort();
        }

        void putZerosBeforeNumberIfNeceserry(byte number, SerialPort port)
        {
            if (number < 100)
            {
                if (number < 10)
                    port.Write("0");
                port.Write("0");
            }
        }
        public void writeAnglesToSerial(Model.Angles angles)
        {
            port.Open();
            port.Write("h");//hand
            putZerosBeforeNumberIfNeceserry(angles.HandAngle, port);
            port.Write(Convert.ToString(angles.HandAngle));

            port.Write("e");//elbow
            putZerosBeforeNumberIfNeceserry(angles.ElbowAngle, port);
            port.Write(Convert.ToString(angles.ElbowAngle));

            port.Write("p"); //shoulderPan
            putZerosBeforeNumberIfNeceserry(angles.PanAngle, port);
            port.Write(Convert.ToString(angles.PanAngle));

            port.Write("t");//shoulderTilt
            putZerosBeforeNumberIfNeceserry(angles.TiltAngle, port);
            port.Write(Convert.ToString(angles.TiltAngle));
            port.Close();
        }
        public void claw(string pos)
        {
            try
            {
                port.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Nincs elérhető port");
            }

            port.Write("c");
            if (pos == "close")
            {
                putZerosBeforeNumberIfNeceserry(Properties.Settings.Default.clawClosed, port);
                port.Write(Convert.ToString(Properties.Settings.Default.clawClosed));
            }
            else if (pos == "open")
            {
                putZerosBeforeNumberIfNeceserry(Properties.Settings.Default.clawOpen, port);
                port.Write(Convert.ToString(Properties.Settings.Default.clawOpen));
            }
            try { port.Close(); } catch (Exception) { }
        }
        public string connectedToCom()
        {
            try
            {
                return port.PortName;
            }
            catch (Exception)
            {
                return "Not Connected";
            }
        }
        public void sendPosToServo(string servo, byte angle)
        {
            port.Open();
            putZerosBeforeNumberIfNeceserry(angle, port);
            port.Write(servo + Convert.ToString(angle));
            port.Close();
        }


        #region tictactoe
        static void grabdNextPiece() //TODO: Keresd meg a bábukat
        {

        }
        public void movePieceToBoard(string box)//TODO: Tedd a bábut a megfelelő helyre
        {
            grabdNextPiece();
            if (box == "A1")
            {

            }
            else if (box == "A2")
            {

            }
            else if (box == "A3")
            {

            }
            else if (box == "B1")
            {

            }
            else if (box == "B2")
            {

            }
            else if (box == "C1")
            {

            }
            else if (box == "C2")
            {

            }
            else if (box == "C3")
            {

            }
        }


        #endregion tictactoe
    }
}
