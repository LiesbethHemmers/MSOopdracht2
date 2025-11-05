using System.Numerics;

namespace MSOopdracht2.Conditions
{
    public class GridEdgeCondition : ICondition
    {
        public bool Evaluate(Character character)
        {
            if (character.Grid == null) return true;
            Vector2 nextPos = character.NextPos();
            bool inBounds = character.Grid.InBounds((int)nextPos.X, (int)nextPos.Y);

            return !inBounds;
        }
    }
}
