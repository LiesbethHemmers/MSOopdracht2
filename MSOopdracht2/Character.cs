using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    public class Character
    {
        Vector2 position;
        Direction direction;

        public Vector2 Position { get { return position; } }
        public Direction Direction { get { return direction; } }

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
    public enum Direction
    {
        East,
        South,
        West,
        North
    }
}
