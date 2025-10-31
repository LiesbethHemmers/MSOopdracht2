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
            //initialize all testobjects
            Character character = new Character();
            List<ICommand> commands = new List<ICommand>()
            {
                new MoveCommand(1),
                new TurnCommand(TurnDirection.Right)
            };
            string expected = "Move 1, Turn right, Move 1, Turn right, Move 1, Turn right";

            RepeatCommand repeatCommand = new RepeatCommand(3, commands);
           

            //execute the tested method
            string trace = repeatCommand.Execute(character);

            Assert.Equal(expected, trace);
            Assert.Equal(new Vector2(0, 1), character.Position); //the character should end on 0,1
            Assert.Equal(Direction.North, character.Direction);//should end looking north
        }
    }
}