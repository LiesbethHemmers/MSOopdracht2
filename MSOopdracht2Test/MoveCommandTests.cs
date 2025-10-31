﻿using System.Numerics;
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
            MoveCommand moveCommand = new MoveCommand(3);

            //execute the tested method
            string trace = moveCommand.Execute(character);

            Assert.Equal(new Vector2(3, 0), character.Position);
            Assert.Contains("Move 3", trace);
        }

        [Fact]
        public void MoveForwardNorthTest()
        {
            //initialize all testobjects
            Character character = new Character();
            MoveCommand moveCommand = new MoveCommand(3);

            character.TurnLeft();//so that the character faces north

            //execute the tested method
            string trace = moveCommand.Execute(character);

            Assert.Equal(new Vector2(0, -3), character.Position);
            Assert.Contains("Move 3", trace);
        }
    }
}