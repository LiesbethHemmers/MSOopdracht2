using MSOopdracht2;
using MSOopdracht2.Commands;
using MSOopdracht2.Conditions;
using System.Numerics;
using MSOopdracht2.Enums;

namespace MSOopdracht2Test
{
    public class RepeatUntilCommandTests
    {
        [Fact]
        public void RepeatUntilWithWallAhead()
        {
            //initialize all test objects
            //5x1 grid: 0  1  2  3  4
            //         ' '' '' ''+'' '
            char[,] mockGrid = new char[5, 1]
            {
                {' ' },
                {' ' },
                {' ' },
                {'+' },
                {' ' }
            };
            Grid grid = new Grid(mockGrid);
            Character character = new Character(grid);

            ICondition condition = new WallAheadCondition();
            List<ICommand> commands = new List<ICommand>()
            {
                new MoveCommand(1),
                new TurnCommand(TurnDirection.Left),
                new TurnCommand(TurnDirection.Right)
            };
            RepeatUntilCommand repeatUntilCommand = new RepeatUntilCommand(condition, commands);
            string expected = "Move 1, Turn left, Turn right, Move 1, Turn left, Turn right";

            //execute the tested method
            string trace = repeatUntilCommand.Execute(character);

            //(3,0) is blocked, so the position of the character should be 1 before that
            Assert.Equal(new Vector2(2, 0), character.Position);
            Assert.Equal(expected, trace);
        }

        [Fact]
        public void RepeatUntilWithGridEdge()
        {
            //initialize all test objects
            //5x1 grid: 0  1  2  3  4
            //         ' '' '' '' '' '
            char[,] mockGrid = new char[5, 1]
            {
                {' ' },
                {' ' },
                {' ' },
                {' ' },
                {' ' }
            };
            Grid grid = new Grid(mockGrid);
            Character character = new Character(grid);
            ICondition condition = new GridEdgeCondition();
            List<ICommand> commands = new List<ICommand>()
            {
                new MoveCommand(1)
            };
            RepeatUntilCommand repeatUntilCommand = new RepeatUntilCommand(condition, commands);
            string expected = "Move 1, Move 1, Move 1, Move 1";

            //execute the tested method
            string trace = repeatUntilCommand.Execute(character);

            //(5,0) is outside the grid, so the last position should be (4, 0) 
            Assert.Equal(new Vector2(4, 0), character.Position);
            
            Assert.Equal(expected, trace);
        }

        [Fact]
        public void RepeatUntilWithoutGrid()
        {
            //initialize all test objects
            Character character = new Character();
            ICondition condition = new GridEdgeCondition();
            List<ICommand> commands = new List<ICommand>()
            {
                new MoveCommand(1)
            };
            RepeatUntilCommand repeatUntilCommand = new RepeatUntilCommand(condition, commands);

            //execute the tested method
            string trace = repeatUntilCommand.Execute(character);

            //if there is no grid, the RepeatUntil command should stop executing immediately so the returned string must be empty
            Assert.Equal(string.Empty, trace);
        }

        [Fact]
        public void RepeatUntilImmediateWallAhead()
        {
            //initialize all test objects
            char[,] mockGrid = new char[2, 1]
            {
                {' ' },
                {'+' }
            };
            Grid grid = new Grid(mockGrid);
            Character character = new Character(grid);

            ICondition condition = new WallAheadCondition();
            List<ICommand> commands = new List<ICommand>()
            {
                new MoveCommand(1)
            };
            RepeatUntilCommand repeatUntilCommand = new RepeatUntilCommand(condition, commands);

            //execute the tested method
            string trace = repeatUntilCommand.Execute(character);

            //the character should not move
            Assert.Equal(Vector2.Zero, character.Position);
            Assert.Equal(string.Empty, trace);
        }

        [Fact]
        public void RepeatUntilWithNoCommandsTest()
        {
            //initialize all test objects
            //5x1 grid: 0  1  2  3  4
            //         ' '' '' '' '' '
            char[,] mockGrid = new char[5, 1]
            {
                {' ' },
                {' ' },
                {' ' },
                {' ' },
                {' ' }
            };
            Grid grid = new Grid(mockGrid);
            Character character = new Character(grid);
            ICondition condition = new GridEdgeCondition();
            List<ICommand> commands = new List<ICommand>();

            RepeatUntilCommand repeatUntilCommand = new RepeatUntilCommand(condition, commands);

            //execute the tested method
            string trace = repeatUntilCommand.Execute(character);
            //when there are no commands in the list, the RepeatUntil command should be stopped immediately
            Assert.Equal(string.Empty, trace);
        }
    }
}
