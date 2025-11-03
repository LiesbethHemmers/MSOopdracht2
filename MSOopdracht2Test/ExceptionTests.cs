using MSOopdracht2;
using MSOopdracht2.Exceptions;

namespace MSOopdracht2Test
{
    public class ExceptionTests
    {
        [Fact]
        public void MoveForwardBlockedMoveException()
        {
            //Initialize the test objects
            char[,] mockGrid = { {' '}, {'+'} };
            Grid grid = new Grid(mockGrid);
            Character character = new Character(grid);

            Assert.Throws<BlockedMoveException>(() => character.MoveForward(1));
        }

        [Fact]
        public void MoveForwardOutOfBoundsException()
        {
            //Initialize the test objects
            char[,] mockGrid = { { ' ' } };
            Grid grid = new Grid(mockGrid);
            Character character = new Character(grid);

            Assert.Throws<OutOfBoundsException>(() => character.MoveForward(1));
        }
    }
}
