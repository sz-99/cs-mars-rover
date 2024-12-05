using mars_rover.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover
{
    public class Rover
    {
        public Rover(Position currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        public Position CurrentPosition {  get; set; }

        public Direction Rotate(Instruction instruction)
        {
            while (true)
            {
                if (instruction == Instruction.L)
                {
                    if (CurrentPosition.Facing == Direction.N)
                    {
                        CurrentPosition.Facing = Direction.W;
                    }
                    else
                    {
                        CurrentPosition.Facing -= 1;
                    }
                    return CurrentPosition.Facing;
                }
                else if (instruction == Instruction.R)
                {
                    if (CurrentPosition.Facing == Direction.W)
                    {
                        CurrentPosition.Facing = Direction.N;
                    }
                    else
                    {
                        CurrentPosition.Facing += 1;
                    }
                    return CurrentPosition.Facing;
                }
                else { Console.WriteLine("Invalid Instruction, please try again."); }
                
            }
        }

    }
}
