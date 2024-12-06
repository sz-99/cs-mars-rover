using mars_rover.Input.enums;
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

        public Position Movement(List<Instruction> instructions)
        {
            if (instructions != null)
            {
                foreach (Instruction instruction in instructions)
                {
                    if (instruction == Instruction.L
                        || instruction == Instruction.R) Rotate(instruction);
                    else if (instruction == Instruction.M) Move(instruction);
                    else if (instruction == Instruction.F) Rotate180(instruction);
                }
                Console.WriteLine($"New Position @ \nx:{CurrentPosition.x}, y:{CurrentPosition.y}, facing {CurrentPosition.Facing}\n----------------");
            }
            return CurrentPosition;
        }

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
                else { Console.WriteLine("Invalid Instruction, please try again.\n----------------"); }
                
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

        public Position Rotate180(Instruction instruction)
        {
            while (true)
            {
                if (instruction == Instruction.F)
                {
                    if (CurrentPosition.Facing == Direction.S)
                          CurrentPosition.Facing = Direction.N;
                    else if (CurrentPosition.Facing == Direction.W) 
                                CurrentPosition.Facing = Direction.E;
                    else CurrentPosition.Facing += 2;
                    
                    return CurrentPosition;
                }
               
                
                else { Console.WriteLine("Invalid Instruction, please try again.\n----------------"); }

            }
        }

    }
}
