using MSOopdracht2;
using MSOopdracht2.Commands;
using MSOopdracht2.Enums;

namespace MSOopdracht2Test
{
    public class TurnCommandTests
    {
        [Fact]
        public void TurnLeftTest()
        {
            //initialize all testobjects
            Grid grid = null; //dummy
            Character character = new Character(grid);
            TurnCommand turnCommand = new TurnCommand(TurnDirection.Left);

            //execute the tested method
            string trace = turnCommand.Execute(character);

            Assert.Equal(Direction.North, character.Direction);
            Assert.Contains("Turn left", trace);
        }

        [Fact]
        public void TurnRightTest()
        {
            //initialize all testobjects
            Grid grid = null; //dummy
            Character character = new Character(grid);
            TurnCommand turnCommand = new TurnCommand(TurnDirection.Right);

            //execute the tested method
            string trace = turnCommand.Execute(character);

            Assert.Equal(Direction.South, character.Direction);
            Assert.Contains("Turn right", trace);
        }
    }
}