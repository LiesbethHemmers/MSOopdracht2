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
            Character character = new Character();
            MoveCommand moveCommand = new MoveCommand(3);

            string trace = moveCommand.Execute(character);

            Assert.Equal(new Vector2(3, 0), character.Position);
            Assert.Equal("Move 3", trace);
        }

        [Fact]
        public void MoveForwardNorthTest()
        {
            Character character = new Character();
            MoveCommand moveCommand = new MoveCommand(3);

            character.TurnLeft();//so that the character faces north

            string trace = moveCommand.Execute(character);

            Assert.Equal(new Vector2(0, -3), character.Position);
            Assert.Equal("Move 3", trace);
        }

        [Fact]
        public void MoveForwardWithNoStepsTest()
        {
            Character character = new Character();
            MoveCommand moveCommand = new MoveCommand(0);

            string trace = moveCommand.Execute(character);

            Assert.Equal(new Vector2(0, 0), character.Position);
            Assert.Equal("Move 0", trace);
        }

        [Fact]
        public void MoveForwardWithNegativeStepsTest()
        {
            Character character = new Character();
            MoveCommand moveCommand = new MoveCommand(-2);

            string trace = moveCommand.Execute(character);

            //when negative steps are given, it should be the same as if zero steps were given
            Assert.Equal(new Vector2(0, 0), character.Position);
            Assert.Equal("Move 0", trace);
        }
    }
}