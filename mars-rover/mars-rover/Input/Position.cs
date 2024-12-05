using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover.Input
{
    public class Position
    {
        public Position(int x, int y, Direction facing)
        {
            this.x = x;
            this.y = y;
            Facing = facing;
        }

        public int x { get; set; }
        public int y { get; set; }
        public Direction Facing { get; set; }
    }
}
