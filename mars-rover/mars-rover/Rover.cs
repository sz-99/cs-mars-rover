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

        public Position Rotate(Instruction instruction)
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
                    return CurrentPosition;
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
                    return CurrentPosition;
                }
                else { Console.WriteLine("Invalid Instruction, please try again."); }
                
            }
        }

        public Position Move (Instruction instruction)
        {
            if (instruction == Instruction.M)
            {
                if (CurrentPosition.Facing == Direction.N) CurrentPosition.y += 1;
                else if (CurrentPosition.Facing == Direction.E) CurrentPosition.x += 1;
                else if (CurrentPosition.Facing == Direction.S) CurrentPosition.y -= 1;
                else if(CurrentPosition.Facing == Direction.W) CurrentPosition.x -= 1;

                return CurrentPosition;
            }
            else return CurrentPosition;
        }

    }
}
