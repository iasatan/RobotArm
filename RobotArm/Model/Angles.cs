using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotArm.Model
{
    public class Angles
    {
        private byte[] angles = new byte[4];

        public byte PanAngle
        {
            get { return angles[0]; }
            set { angles[0] = value; }
        }
        public byte TiltAngle
        {
            get { return angles[1]; }
            set { angles[1] = value; }
        }
        public byte ElbowAngle
        {
            get { return angles[2]; }
            set { angles[2] = value; }
        }
        public byte HandAngle
        {
            get { return angles[3]; }
            set { angles[3] = value; }
        }
    }
}
