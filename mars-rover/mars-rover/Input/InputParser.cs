using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mars_rover.Input
{
    public class InputParser
    {
        private readonly IInputProcessor _inputProcessor;

        public InputParser(IInputProcessor inputProcessor)
        {
            _inputProcessor = inputProcessor;
        }

        public PlateauSize ParsePlateauInput()
        {
            while (true)
            {
                _inputProcessor.WriteOutput("Please input plateau size, represented by two integers separated by space. E.g: 5 5");
                string input = _inputProcessor.ReadInput();
                if (!string.IsNullOrEmpty(input)
                        && input.All(c => char.IsDigit(c) || c == ' ')
                        && input.Contains(' ')
                        && !input.StartsWith(' ')
                        && !input.EndsWith(' '))
                {
                    string[] inputArr = input.Split(' ');
                    var inputNums = inputArr.Select(n => int.Parse(n)).ToList();
                    return new PlateauSize(inputNums[0], inputNums[1]);
                }
                else
                {
                    Console.WriteLine("Plateau input is invalid, please try again");
                }
            }
        }

        public Rover ParseLandingPosition()
        {
            Position position = new(0,0,Direction.N);
            while (true)
            {
                _inputProcessor.WriteOutput("Please input landing position represented by integers x, y and a direction represented by a letter(NESW). E.g: 1 2 N");
                string input = _inputProcessor.ReadInput();
                
                if (!string.IsNullOrEmpty(input)
                        && input.All(c => char.IsDigit(c) || c == ' ' || char.IsLetter(c))
                        && input.Contains(' ')
                        && !input.StartsWith(' ')
                        && !input.EndsWith(' '))
                {
                    string[] inputArr = input.Split(' ');
                    if (inputArr[0].All(c => char.IsDigit(c))
                    && inputArr[1].All(c => char.IsDigit(c)))
                    {
                        var number1 = Int32.TryParse(inputArr[0], out int num1);
                        var number2 = Int32.TryParse(inputArr[1], out int num2);
                        position.x = num1;
                        position.y = num2;
                    }
                    else break;
                    if (inputArr[2].All(c => char.IsLetter(c)))
                    {
                        position.Facing = inputArr[2].ToUpper() switch
                        {
                            "N" => Direction.N,
                            "E" => Direction.E,
                            "S" => Direction.S,
                            "W" => Direction.W,
                            _ => Direction.N
                        };
                    }
                    else break;
                    return new Rover(position);
                }
                else
                {
                    Console.WriteLine("Plateau input is invalid, please try again");
                }
            }
            return new Rover(position);


        }

        public List<Instruction> ParseInstructions()
        {
            List<Instruction> instructions = new List<Instruction>();
            while (true)
            {
                _inputProcessor.WriteOutput("Please input a series of instructions, consisting only of letters L(Left),R(Right),M(Move).");
                string input = _inputProcessor.ReadInput();
                
                if (!string.IsNullOrEmpty(input))
                {
                    foreach (char c in input)
                    {
                        if (char.ToUpper(c) == 'L')
                        {
                            instructions.Add(Instruction.L);
                        }
                        else if (char.ToUpper(c) == 'R')
                        {
                            instructions.Add(Instruction.R);
                        }
                        else if (char.ToUpper(c) == 'M')
                        {
                            instructions.Add(Instruction.M);
                        }

                    }
                    return instructions;
                }

                else
                {
                    Console.WriteLine("Input is invalid, please try again.");
                }
            }

        }
    }
}
