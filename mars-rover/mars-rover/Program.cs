using mars_rover.Input;
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


            }

        }
    }
}
