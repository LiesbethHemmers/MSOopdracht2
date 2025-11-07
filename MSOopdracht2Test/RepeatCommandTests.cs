using System.Numerics;
using MSOopdracht2;
using MSOopdracht2.Commands;
using MSOopdracht2.Enums;

namespace MSOopdracht2Test
{
    public class RepeatCommandsTests
    {
        [Fact]
        public void RepeatTest()
        {
            Character character = new Character();
            List<ICommand> commands = new List<ICommand>()
            {
                new MoveCommand(1),
                new TurnCommand(TurnDirection.Right)
            };
            string expected = "Move 1, Turn right, Move 1, Turn right, Move 1, Turn right";

            RepeatCommand repeatCommand = new RepeatCommand(3, commands);
           
            string trace = repeatCommand.Execute(character);

            Assert.Equal(expected, trace);
            Assert.Equal(new Vector2(0, 1), character.Position);//the character should end on (0,1)
            Assert.Equal(Direction.North, character.Direction);//should end looking north
        }

        [Fact]
        public void RepeatZeroTimesTest()
        {
            Character character = new Character();
            List<ICommand> commands = new List<ICommand>()
            {
                new MoveCommand(1),
                new TurnCommand(TurnDirection.Right)
            };
            RepeatCommand repeatCommand = new RepeatCommand(0, commands);

            string trace = repeatCommand.Execute(character);

            //when 'times' is zero, the command should return an empty string because the inner commands are not executed
            Assert.Equal(string.Empty, trace);
        }

        [Fact]
        public void RepeatWithNoCommandsTest()
        {
            Character character = new Character();
            List<ICommand> commands = new List<ICommand>();
            RepeatCommand repeatCommand = new RepeatCommand(2, commands);

            string trace = repeatCommand.Execute(character);

            //there is nothing to execute with an empty inner command list, so it should return an empty string
            Assert.Equal(string.Empty, trace);
        }
    }
}