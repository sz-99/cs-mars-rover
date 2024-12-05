using FluentAssertions;
using mars_rover;
using mars_rover.Input;
using Moq;

namespace mars_rover.Tests
{
    public class InputTests
    {
      

        [Test]
        public void ParsePlateauInputTest_NormalCase()
        {
            //arrange
            var mockInputProcessor = new Mock<IInputProcessor>();
            mockInputProcessor.Setup(input => input.ReadInput()).Returns("5 5");
            var parser = new InputParser(mockInputProcessor.Object);

            PlateauSize expectedOutput = new PlateauSize(5, 5);

            //act
            PlateauSize result = parser.ParsePlateauInput();

            //assert
            Assert.AreEqual(expectedOutput.PlateauX, result.PlateauX);
            Assert.AreEqual(expectedOutput.PlateauY, result.PlateauY);
        }

        [Test]
        public void ParseLandingPosTest_NormalCase()
        {
            //arrange
            var mockInputProcessor = new Mock<IInputProcessor>();
            mockInputProcessor.Setup(input => input.ReadInput()).Returns("1 2 N");
            var parser = new InputParser(mockInputProcessor.Object);

            Position expectedOutput = new Position(1, 2, Direction.N);

            //act
            Position result = parser.ParseLandingPosition();

            //assert
            result.Should().BeEquivalentTo(expectedOutput);
        }

        [Test]
        public void ParseInstructionsTest_NormalCase()
        {
            //arrange
            var mockInputProcessor = new Mock<IInputProcessor>();
            mockInputProcessor.Setup(input => input.ReadInput()).Returns("LMLMLMLMM");
            var parser = new InputParser(mockInputProcessor.Object);

            List<Instruction> expectedOutput = new List<Instruction>()
            {
                Instruction.L,
                Instruction.M,
                Instruction.L,
                Instruction.M,
                Instruction.L,
                Instruction.M,
                Instruction.L,
                Instruction.M,
                Instruction.M
            };

            //act
            var result = parser.ParseInstructions();

            //assert
            result.Should().BeEquivalentTo(expectedOutput);
        }
    }
}