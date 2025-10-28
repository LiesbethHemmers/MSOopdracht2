using System.Numerics;
using MSOopdracht2;
using MSOopdracht2.Commands;

namespace MSOopdracht2Test
{
    public class MoveCommandTests
    {
        [Fact]
        public void MoveForwardEastTest()
        {
            //initialize all testobjects
            Character character = new Character();
            List<string> trace = new List<string>();
            MoveCommand moveCommand = new MoveCommand(3);

            //execute the tested method
            moveCommand.Execute(character, trace);

            Assert.Equal(new Vector2(3, 0), character.Position);
            Assert.Single(trace);
            Assert.Contains("Move 3", trace[0]);
        }

        [Fact]
        public void MoveForwardNorthTest()
        {
            //initialize all testobjects
            Character character = new Character();
            List<string> trace = new List<string>();
            MoveCommand moveCommand = new MoveCommand(3);

            character.TurnLeft();//so that the character faces north

            //execute the tested method
            moveCommand.Execute(character, trace);

            Assert.Equal(new Vector2(0, -3), character.Position);
            Assert.Single(trace);
            Assert.Contains("Move 3", trace[0]);
        }
    }
}