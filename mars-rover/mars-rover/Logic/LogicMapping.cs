using mars_rover.Input.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover.Logic
{
    public class LogicMapping
    {
        public Rover Rover { get; private set; }
        public LogicMapping(Rover rover, List<Instruction> instructions)
        {
            Rover = rover;
            Rover.Movement(instructions);
        }
        public LogicMapping()
        {

        }

    }
}
