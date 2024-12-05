using mars_rover.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover
{
    public static class UI
    {
        public static UserAction PromptForAction()
        {
            while (true)
            {
                Console.WriteLine("Welcome to Mars! Please choose what you'd like to do by clicking the corresponding number key.");
                Console.WriteLine("[1] Make a Plateau");
                Console.WriteLine("[2] Create a Rover");
                Console.WriteLine("[3] Move the Rover");
                Console.WriteLine("[4] Quit");

                char userInput = Console.ReadKey().KeyChar;
                if (char.IsDigit(userInput) && userInput < 5 && userInput > 0)
                {
                    switch (userInput) 
                    {
                        case '1': return UserAction.MakePlateau;
                        case '2': return UserAction.CreateRover;
                        case '3': return UserAction.MoveRover;
                        case '4': return UserAction.Quit;
                        default:
                            {
                                Console.WriteLine("Input invalid, please try again.");
                                return PromptForAction();
                            }
                    }

                }
                else Console.WriteLine("Input invalid, please try again.");
                
            }
        }

        public enum UserAction
        {
            MakePlateau, CreateRover, MoveRover, Quit
        }
    }
}
