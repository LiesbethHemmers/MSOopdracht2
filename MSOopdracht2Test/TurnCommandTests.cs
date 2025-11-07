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
            Character character = new Character();
            TurnCommand turnCommand = new TurnCommand(TurnDirection.Left);

            string trace = turnCommand.Execute(character);

            Assert.Equal(Direction.North, character.Direction);
            Assert.Contains("Turn left", trace);
        }

        [Fact]
        public void TurnRightTest()
        {
            Character character = new Character();
            TurnCommand turnCommand = new TurnCommand(TurnDirection.Right);

            string trace = turnCommand.Execute(character);

            Assert.Equal(Direction.South, character.Direction);
            Assert.Contains("Turn right", trace);
        }
    }
}