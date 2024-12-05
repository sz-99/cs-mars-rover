using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover
{
    public class PlateauSize
    {
        public PlateauSize(int plateauX, int plateauY)
        {
            PlateauX = plateauX;
            PlateauY = plateauY;
        }

        protected int PlateauX {  get; set; }
        protected int PlateauY { get; set; }

     

       
    }
}
