using System.Numerics;

namespace MSOopdracht2.Conditions
{
    public class WallAheadCondition : ICondition
    {
        public bool Evaluate(Character character)
        {
            if (character.Grid == null) return true;
            Vector2 nextPos = character.NextPos();
            char symbol = character.Grid.GetSymbol((int)nextPos.X, (int)nextPos.Y);
            return symbol == '+';
        }
    }
}