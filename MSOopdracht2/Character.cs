using System.Numerics;
using MSOopdracht2.Enums;
using MSOopdracht2.Exceptions;

namespace MSOopdracht2
{
    public class Character
    {
        Vector2 position;
        Direction direction;
        Grid grid;

        public Vector2 Position { get { return position; } }
        public Direction Direction { get { return direction; } }
        public Grid Grid { get { return grid; } }

        public Character(Grid grid = null)//default is null because only the pathfinding exercises need a grid
        {
            position = Vector2.Zero;
            direction = Direction.East;
            this.grid = grid;
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
            for (int i = 0; i < steps; i++)
            {
                Vector2 nextPos = NextPos();
                if (grid != null)
                {
                    if (!grid.InBounds((int)nextPos.X, (int)nextPos.Y))
                    {
                        throw new OutOfBoundsException($"({nextPos.X}, {nextPos.Y}) is outside of the grid");
                    }
                    char symbol = grid.GetSymbol((int)nextPos.X, (int)nextPos.Y);
                    if (symbol == '+')
                    {
                        throw new BlockedMoveException($"({nextPos.X}, {nextPos.Y}) is blocked");
                    }

                }
                position = nextPos;
            }
        }

        public Vector2 NextPos()
        {
            Vector2 nextPos = position;
            switch (direction)
            {
                case Direction.East: nextPos.X += 1; break;
                case Direction.South: nextPos.Y += 1; break;
                case Direction.West: nextPos.X -= 1; break;
                case Direction.North: nextPos.Y -= 1; break;
            }
            return nextPos;
        }
    }
}