using System.Net.Mime;
using System.Numerics;
using MSOopdracht2.Enums;
using MSOopdracht2.Exceptions;

namespace MSOopdracht2
{
    public class Character
    {
        public Vector2 Position { get; private set; }
        public Direction Direction { get; private set; }
        public Grid? Grid { get; }//grid can be null, because the grid is optional

        public List<(int x, int y)> AllPositions { get; }

        public Character(Grid? grid = null)//default is null because only the pathfinding exercises need a grid
        {
            AllPositions = new List<(int x, int y)> { (0, 0) };
            Position = Vector2.Zero;
            Direction = Direction.East;
            Grid = grid;
        }

        public void TurnLeft()
        {
            //east -> north
            int dir = (int)Direction;//every enum has a number
            int newDir = (dir + 3) % 4;
            Direction = (Direction)newDir;//back to direction
        }

        public void TurnRight()
        {
            //east -> south
            int dir = (int)Direction;//every enum has a number
            int newDir = (dir + 1) % 4;
            Direction = (Direction)newDir;//back to direction
        }

        public void MoveForward(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                Vector2 nextPos = NextPos();
                if (Grid != null)
                {
                    if (!Grid.InBounds((int)nextPos.X, (int)nextPos.Y))
                    {
                        throw new OutOfBoundsException($"({nextPos.X}, {nextPos.Y}) is outside of the grid");
                    }
                    char symbol = Grid.GetSymbol((int)nextPos.X, (int)nextPos.Y);
                    if (symbol == '+')
                    {
                        throw new BlockedMoveException($"({nextPos.X}, {nextPos.Y}) is blocked");
                    }
                }
                Position = nextPos;
                AllPositions.Add(((int x, int y))(nextPos.X, nextPos.Y));
            }
        }

        public Vector2 NextPos()
        {
            Vector2 nextPos = Position;
            switch (Direction)
            {
                case Direction.East: nextPos.X += 1; break;
                case Direction.South: nextPos.Y += 1; break;
                case Direction.West: nextPos.X -= 1; break;
                case Direction.North: nextPos.Y -= 1; break;
            }
            return nextPos;
        }

        public Character GetInstance()
        {
            return this;
        }
    }
}