using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Windows.Input;
using MSOopdracht2;

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

            Assert.Equal(new Vector2(3, 0), character.Position);//checks equality
            Assert.Single(trace);//checks that trace only contains 1 element
            Assert.Contains("Move 3", trace[0]);//chechs if the one element trace contains, the string is

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

            Assert.Equal(new Vector2(0, -3), character.Position);//checks equality
            Assert.Single(trace);//checks that trace only contains 1 element
            Assert.Contains("Move 3", trace[0]);//chechs if the one element trace contains, the string is

        }
    }
}