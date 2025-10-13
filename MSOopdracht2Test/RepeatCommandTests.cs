using System.Numerics;
using MSOopdracht2;

namespace MSOopdracht2Test
{
    public class RepeatCommandsTests
    {
        [Fact]
        public void RepeatTest()
        {
            //initialize all testobjects
            Character character = new Character();
            List<string> trace = new List<string>();
            List<MSOopdracht2.ICommand> commands = new List<MSOopdracht2.ICommand>()
            {
                new MoveCommand(1),
                new TurnCommand(TurnDirection.Right)
            };

            RepeatCommand repeatCommand = new RepeatCommand(3, commands);

            //execute the tested method
            repeatCommand.Execute(character, trace);

            Assert.Equal(6, trace.Count);//there should be 6 items

            List<string> expected = new List<string>
            {
                "Move 1",
                "Turn right",
                "Move 1",
                "Turn right",
                "Move 1",
                "Turn right"
            };

            Assert.Equal(expected, trace);
            Assert.Equal(new Vector2(0, 1), character.Position); //the character should end on 0,1
            Assert.Equal(Direction.North, character.Direction);//should end looking north
        }
    }
}