using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotArm.Model
{
    /// <summary>
    /// Stores the 3D position where the computer will convert into angles and send to the arduino
    /// </summary>
    class Position
    {
        int x;
        int y;
        int z;
        public Position()
        {

        }

        public Position(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
    }
}
