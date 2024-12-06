using mars_rover.Input.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover.Objects
{
    public class Plateau : IPlateau
    {
        private Plateau(int x, int y)
        {
            PlateauX = x;
            PlateauY = y;
        }

        public int PlateauX { get; set; }
        public int PlateauY { get; set; }
        public static Dictionary<Rover, Position> RoverPositions { get; set; }
            = new Dictionary<Rover, Position>();

        private static Plateau _plateau;


        public static Plateau GetInstance(int x, int y)
        {
            if (_plateau == null)
            {
                _plateau = new Plateau(x, y);
            }
            return _plateau;

        }

        public static bool IsPositionFilled(Position position)
        {
            foreach (var kvp in RoverPositions)
            {
                if (kvp.Key.CurrentPosition == position)
                    return true;
            }
            return false;
        }




    }
}
