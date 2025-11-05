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
            //initialize all test objects
            Character character = new Character();
            TurnCommand turnCommand = new TurnCommand(TurnDirection.Left);

            //execute the tested method
            string trace = turnCommand.Execute(character);

            Assert.Equal(Direction.North, character.Direction);
            Assert.Contains("Turn left", trace);
        }

        [Fact]
        public void TurnRightTest()
        {
            //initialize all test objects
            Character character = new Character();
            TurnCommand turnCommand = new TurnCommand(TurnDirection.Right);

            //execute the tested method
            string trace = turnCommand.Execute(character);

            Assert.Equal(Direction.South, character.Direction);
            Assert.Contains("Turn right", trace);
        }
    }
}