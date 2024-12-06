using mars_rover.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover.UI
{
    public class ActionMapping
    {
        public ActionMapping(UserAction action, InputParser inputParser) 
        {
            UserInterface ui = new();
            switch(action)
            {
                case UserAction.MakePlateau: 
                    inputParser.ParsePlateauInput();break;

                case UserAction.CreateRover: 
                    inputParser.ParseLandingPosition(); break;

                case UserAction.MoveRover: 
                    inputParser.ParseInstructions(); break;

                case UserAction.Quit: break;

                default: ui.PromptForAction(); break;
            }
        
        }
    }
}
