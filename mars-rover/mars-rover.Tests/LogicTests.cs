using FluentAssertions;
using mars_rover;
using mars_rover.Input;
using Moq;

namespace mars_rover.Tests
{
    public class LogicTests
    {
      

        [Test]
        [TestCase(1,2,Direction.N, Instruction.R, Direction.E)]
        [TestCase(1, 2, Direction.N, Instruction.L, Direction.W)]
        [TestCase(5, 3, Direction.E, Instruction.R, Direction.S)]
        [TestCase(6, 6, Direction.E, Instruction.L, Direction.N)]



        public void RotateTest(int x, int y, Direction currentDirection, Instruction instruction, Direction expected)
        {
            //arrange
            Position position = new(x, y, currentDirection);
            Rover testRover = new Rover(position);

            //act
            var result = testRover.Rotate(instruction);

            //assert
            result.Should().Be(expected);
        }

    }
}