using MSOopdracht2;
using MSOopdracht2.Commands;
using MSOopdracht2.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace MSOopdracht2Test
{
    public class RepeatUntilCommandTests
    {
        [Fact]
        public void RepeatUntilWithWallAhead()
        {
            //initialize all testobjects
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
                new MoveCommand(1)
            };
            string expected = "Move 1, Move 1";

            RepeatUntilCommand repeatUntilCommand = new RepeatUntilCommand(condition, commands);

            //execute the tested method
            string trace = repeatUntilCommand.Execute(character);

            //(3,0) is blocked, so the position of the character should be 1 for that
            Assert.Equal(new Vector2(2, 0), character.Position);

            Assert.Equal(expected, trace);
        }

        [Fact]
        public void RepeatUntilWithGridEdge()
        {
            //initialize all testobjects
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
            string expected = "Move 1, Move 1, Move 1, Move 1";

            RepeatUntilCommand repeatUntilCommand = new RepeatUntilCommand(condition, commands);

            //execute the tested method
            string trace = repeatUntilCommand.Execute(character);

            //(5,0) is outside of the grid, so the last position should be (4, 0) 
            Assert.Equal(new Vector2(4, 0), character.Position);
            
            Assert.Equal(expected, trace);
        }
    }
}
