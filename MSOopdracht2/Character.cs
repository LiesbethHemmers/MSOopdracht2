using System.Numerics;

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
            switch (direction)
            {
                case Direction.East: position.X += steps; break;
                case Direction.South: position.Y += steps; break;
                case Direction.West: position.X -= steps; break;
                case Direction.North: position.Y -= steps; break; //because the upperleft corner is 0,0
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
    public enum Direction
    {
        East,
        South,
        West,
        North
    }
}