using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RobotArm.Properties.Settings;

namespace RobotArm.Util
{
    class PositionToAngles
    {
        double baseHeight = Default.baseHeight;
        double handLenght = Default.handLength;
        double upperArmLenght = Default.upperArmLength;
        double foreArmLenght = Default.foreArmLength;
        Model.Position pos;

        public PositionToAngles(Model.Position pos)
        {
            this.pos = pos;
        }

        /// <summary>
        /// returns the calculated angles
        /// </summary>
        /// <returns>Angles angles</returns>
        public Model.Angles GetCalculatedAngles()
        {
            Model.Angles angles = new Model.Angles();
            double R = CalculateR();
            double D = Math.Sqrt((handLenght - baseHeight) * (handLenght - baseHeight) + R * R);
            angles.PanAngle = CalculatePanAngle(R, D);
            angles.TiltAngle = CalculateTiltAngle(R);
            angles.ElbowAngle = CalculateElbowAngle(R, D);
            angles.HandAngle = CalculateHandAngle(angles.PanAngle, angles.ElbowAngle);
            angles.ElbowAngle = (byte)(180 - angles.ElbowAngle);
            return angles;
        }
        #region math
        double CalculateR()
        {
            double R;
            R = Math.Sqrt(pos.X * pos.X + pos.Y * pos.Y);
            R = Math.Sqrt(pos.Z * pos.Z + R * R);
            return R;
        }
        byte CalculateTiltAngle(double R)
        {
            double angle;
            angle = Math.Asin(pos.Y / R);
            angle = Math.Round(angle * 180 / Math.PI);
            return (byte)angle;
        }
        byte CalculateElbowAngle(double R, double D)
        {
            double angle;
            angle = Math.Acos(((upperArmLenght * upperArmLenght) + (foreArmLenght * foreArmLenght) - (D * D)) / (2 * foreArmLenght * upperArmLenght));
            return (byte)angle;
        }
        byte CalculatePanAngle(double R, double D)
        {
            double angle;
            double sTheta1, sTheta2;
            sTheta1 = Math.Asin((handLenght - baseHeight) / D);
            sTheta2 = Math.Asin((upperArmLenght / D) * Math.Sin(CalculateElbowAngle(R, D)));
            angle = sTheta1 + sTheta2;
            angle = Math.Round((angle * 180 / Math.PI));
            return (byte)angle;
        }
        byte CalculateHandAngle(byte panAngle, byte elbowAngle)
        {
            double angle;
            angle = 270 - panAngle - elbowAngle;
            angle = angle - 90;
            if (angle > 180)
                angle = 0;
            else
                angle = 180 - angle;
            return (byte)angle;
        }
        #endregion math
    }
}
