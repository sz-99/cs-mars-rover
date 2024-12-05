using mars_rover.Input;

namespace mars_rover
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
          
            InputProcessor inputProcessor = new();
            InputParser inputParser = new(inputProcessor);

            PlateauSize plateauSize = inputParser.ParsePlateauInput();
            Rover rover1= inputParser.ParseLandingPosition();
            List<Instruction> rover1Instructions = inputParser.ParseInstructions();

            Console.WriteLine($"Current Pos: x: {rover1.CurrentPosition.x}, y: {rover1.CurrentPosition.y}, Facing: {rover1.CurrentPosition.Facing}");

           rover1.Movement(rover1Instructions);

            Console.WriteLine($"New Pos: x: {rover1.CurrentPosition.x}, y: {rover1.CurrentPosition.y}, Facing: {rover1.CurrentPosition.Facing}");

        }
    }
}
