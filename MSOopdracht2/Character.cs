using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    internal class Character
    {
        Vector2 position;
        Direction direction;

        Vector2 Position { get; }
        Direction Direction { get; }

        public Character()
        {
            position = Vector2.Zero;
            direction = Direction.East;
        }

        public void TurnLeft()
        {
            //east -> north
            int dir = (int)direction;//every enum has a number
            int newdir = (dir + 3) % 4;
            direction = (Direction)newdir;//back to direction
        }

        public void TurnRight()
        {
            //east->south
            int dir = (int)direction;//every enum has a number
            int newdir = (dir + 1) % 4;
            direction = (Direction)newdir;//back to direction
        }

        public void MoveForward(int steps)
        {
            switch (direction)
            {
                case Direction.East: position.X += steps; break;
                case Direction.South: position.Y += steps; break;
                case Direction.West: position.X -= steps; break;
                case Direction.North: position.Y -= steps; break; //because the upperleft corner is 0,0
            }
        }
    }
    enum Direction
    {
        East,
        South,
        West,
        North
    }
}
