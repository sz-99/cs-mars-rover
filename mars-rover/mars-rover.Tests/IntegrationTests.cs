using FluentAssertions;
using mars_rover.Input;
using mars_rover.Input.enums;
using mars_rover.Objects;
using Moq;

namespace mars_rover.Tests
{
    public class IntegrationTests
    {
      

        [Test]
        public void InputAndLogicIntegrationTest()
        {
            //arrange
            List<string> inputs = new List<string>()
            {
                "5 5",
                "1 2 N",
                "LMLMLMLMM",
                "3 3 E",
                "MMRMMRMRRM"
            };

            var mockInputProcessor = new Mock<IInputProcessor>();
            mockInputProcessor.SetupSequence(input => input.ReadInput())
                                                            .Returns(inputs[0])
                                                            .Returns(inputs[1])
                                                            .Returns(inputs[2]);
                                                            
            InputParser inputParser = new(mockInputProcessor.Object);

            //act
            Plateau plateauSize = inputParser.ParsePlateauInput();
            Rover rover1 = inputParser.ParseLandingPosition();
            List<Instruction> rover1Instructions = inputParser.ParseInstructions();

            var result = rover1.Movement(rover1Instructions);

            //assert
            (rover1.CurrentPosition.x).Should().Be(1);
            (rover1.CurrentPosition.y).Should().Be(3);
            (rover1.CurrentPosition.Facing).Should().Be(Direction.N);

        }


        [Test]
        public void InputAndLogicIntegrationTest2()
        {
            //arrange
            List<string> inputs = new List<string>()
            {
                "5 5",
                "1 2 N",
                "LMLMLMLMM",
                "3 3 E",
                "MMRMMRMRRM"
            };

            var mockInputProcessor = new Mock<IInputProcessor>();
            mockInputProcessor.SetupSequence(input => input.ReadInput())
                                                            .Returns(inputs[0])
                                                            .Returns(inputs[3])
                                                            .Returns(inputs[4]);

            InputParser inputParser = new(mockInputProcessor.Object);

            //act
            Plateau plateauSize = inputParser.ParsePlateauInput();
            Rover rover1 = inputParser.ParseLandingPosition();
            List<Instruction> rover1Instructions = inputParser.ParseInstructions();

            var result = rover1.Movement(rover1Instructions);

            //assert
            (rover1.CurrentPosition.x).Should().Be(5);
            (rover1.CurrentPosition.y).Should().Be(1);
            (rover1.CurrentPosition.Facing).Should().Be(Direction.E);

        }

    }
}