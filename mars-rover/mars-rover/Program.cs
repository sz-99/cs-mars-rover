namespace mars_rover
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            InputParser inputParser = new InputParser();
            inputParser.ParsePlateauInput();
            var initialPos = inputParser.ParseLandingPosition();
            var newPos = inputParser.ParseInstructions(initialPos);
        }
    }
}
