using mars_rover.Input;
using mars_rover.Input.enums;
using mars_rover.Logic;
using mars_rover.UI;

namespace mars_rover
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            InputParser inputParser = new InputParser(new InputProcessor());

            while(true)
            {
                UserAction action = ui.PromptForAction();

                ActionMapping actionMapping = new ActionMapping(action, inputParser);

                LogicMapping logicMapping = new LogicMapping(inputParser.ParseLandingPosition(), inputParser.ParseInstructions());

            }

        }
    }
}
