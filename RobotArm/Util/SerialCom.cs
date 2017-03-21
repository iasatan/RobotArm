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
        void InitPort()
        {
            try
            {
                port.Open();
                port.Close();
            }
            catch (Exception) { }
        }
        public void ConnectToCom(string portName)
        {
            port = new SerialPort(portName, 9600);
            InitPort();
        }
        /// <summary>
        /// sends "0"-s ahead if neceserry, because the serial port can't handle double or triple digits numbers
        /// </summary>
        /// <param name="number"></param>
        /// <param name="port"></param>
        void PutZerosBeforeNumberIfNeceserry(byte number, SerialPort port)
        {
            if (number < 100)
            {
                if (number < 10)
                    port.Write("0");
                port.Write("0");
            }
        }/// <summary>
        /// Sends the calculated positions to the arduino
        /// </summary>
        /// <param name="angles"></param>
        public void WriteAnglesToSerial(Model.Angles angles)
        {
            port.Open();
            port.Write("h");//hand
            PutZerosBeforeNumberIfNeceserry(angles.HandAngle, port);
            port.Write(Convert.ToString(angles.HandAngle));

            port.Write("e");//elbow
            PutZerosBeforeNumberIfNeceserry(angles.ElbowAngle, port);
            port.Write(Convert.ToString(angles.ElbowAngle));

            port.Write("p"); //shoulderPan
            PutZerosBeforeNumberIfNeceserry(angles.PanAngle, port);
            port.Write(Convert.ToString(angles.PanAngle));

            port.Write("t");//shoulderTilt
            PutZerosBeforeNumberIfNeceserry(angles.TiltAngle, port);
            port.Write(Convert.ToString(angles.TiltAngle));
            port.Close();
        }
        /// <summary>
        /// Opens or Closes the claw
        /// </summary>
        /// <param name="pos"></param>
        public void Claw(string pos)
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
                PutZerosBeforeNumberIfNeceserry(Properties.Settings.Default.clawClosed, port);
                port.Write(Convert.ToString(Properties.Settings.Default.clawClosed));
            }
            else if (pos == "open")
            {
                PutZerosBeforeNumberIfNeceserry(Properties.Settings.Default.clawOpen, port);
                port.Write(Convert.ToString(Properties.Settings.Default.clawOpen));
            }
            try { port.Close(); } catch (Exception) { }
        }
        /// <summary>
        /// returns the name of the port where the computer is connected to
        /// </summary>
        /// <returns></returns>
        public string GetPortName()
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
        /// <summary>
        /// sends angle to a specific servo
        /// </summary>
        /// <param name="servo">letter of the servo</param>
        /// <param name="angle"></param>
        public void SendPosToServo(string servo, byte angle)
        {
            port.Open();
            PutZerosBeforeNumberIfNeceserry(angle, port);
            port.Write(servo + Convert.ToString(angle));
            port.Close();
        }


        #region tictactoe
        static void GrabdNextPiece() //TODO: Keresd meg a bábukat
        {

        }
        public void MovePieceToBoard(string box)//TODO: Tedd a bábut a megfelelő helyre
        {
            GrabdNextPiece();
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
