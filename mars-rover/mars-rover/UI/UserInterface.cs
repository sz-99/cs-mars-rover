using mars_rover.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover.UI
{
    public class UserInterface
    {
        public static bool IsRunning { get; set; } = true;
        public UserAction PromptForAction()
        {
            while (true)
            {
                Console.WriteLine("Welcome to Mars! Please choose what you'd like to do by clicking the corresponding key.");
                Console.WriteLine("[P] Make a Plateau");
                Console.WriteLine("[C] Create a Rover");
                Console.WriteLine("[M] Move the Rover");
                Console.WriteLine("[X] Quit");

                char userInput = Console.ReadKey().KeyChar;
                if (char.ToUpper(userInput) == 'P' || char.ToUpper(userInput) == 'C' || char.ToUpper(userInput) == 'M' || char.ToUpper(userInput) == 'X')
                {
                    switch (userInput) 
                    {
                        case 'P': return UserAction.MakePlateau;
                        case 'C': return UserAction.CreateRover;
                        case 'M': return UserAction.MoveRover;
                        case 'X': return UserAction.Quit;
                        default:
                            {
                                Console.WriteLine("Input invalid, please try again.\n----------------");
                                return PromptForAction();
                            }
                    }

                }
                else Console.WriteLine("Input invalid, please try again.\n----------------");
                
            }
        }
    }
}
