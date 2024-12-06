using FluentAssertions;
using mars_rover.Input.enums;
using mars_rover.Objects;
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
            Position expectedResult = new Position(x, y, expected);

            //act
            var result = testRover.Rotate(instruction);

            //assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        [TestCase(1, 2, Direction.N, Instruction.M, 1, 3, Direction.N)]
        [TestCase(5, 3, Direction.W, Instruction.M, 4, 3, Direction.W)]
        [TestCase(3, 4, Direction.S, Instruction.M, 3, 3, Direction.S)]


        public void MoveTest(int x, int y, Direction currentDirection, Instruction instruction, int newX, int newY, Direction newDirection)
        {
            //arrange
            Position position = new(x, y, currentDirection);
            Rover testRover = new Rover(position);
            Position expectedResult = new(newX,newY, newDirection);

            //act
            var result = testRover.Move(instruction);

            //assert
            result.Should().BeEquivalentTo(expectedResult);
        }

    }
}