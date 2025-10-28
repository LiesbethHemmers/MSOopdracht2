using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2.Conditions
{
    public class WallAheadCondition : ICondition
    {
        public bool Evaluate(Character character)
        {
            if (character.Grid.LoadedGrid == null)
            {
                return false;
            }

            Vector2 nextPos = character.NextPos();
            char symbol = character.Grid.GetSymbol((int)nextPos.X, (int)nextPos.Y);

            if (symbol == '+')
            {
                return true;
            }
            return false;
        }
    }
}
