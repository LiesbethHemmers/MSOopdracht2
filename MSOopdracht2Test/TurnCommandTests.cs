using MSOopdracht2;

namespace MSOopdracht2Test
{
    public class TurnCommandTests
    {
        [Fact]
        public void TurnLeftTest()
        {
            //initialize all testobjects
            Character character = new Character();
            List<string> trace = new List<string>();
            TurnCommand turnCommand = new TurnCommand(TurnDirection.Left);

            //execute the tested method
            turnCommand.Execute(character, trace);

            Assert.Equal(Direction.North, character.Direction);//checks equality
            Assert.Single(trace);//checks that trace only contains 1 element
            Assert.Contains("Turn left", trace[0]);//chechs if the one element trace contains, the string is
        }

        [Fact]
        public void TurnRightTest()
        {
            //initialize all testobjects
            Character character = new Character();
            List<string> trace = new List<string>();
            TurnCommand turnCommand = new TurnCommand(TurnDirection.Right);

            //execute the tested method
            turnCommand.Execute(character, trace);

            Assert.Equal(Direction.South, character.Direction);//checks equality
            Assert.Single(trace);//checks that trace only contains 1 element
            Assert.Contains("Turn right", trace[0]);//chechs if the one element trace contains, the string is
        }
    }
}