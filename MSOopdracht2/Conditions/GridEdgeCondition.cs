using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2.Conditions
{
    public class GridEdgeCondition : ICondition
    {
        public bool Evaluate(Character character)
        {
            if (character.Grid.LoadedGrid == null)
            {
                return false;
            }

            Vector2 nextPos = character.NextPos();
            bool inBounds = character.Grid.InBounds((int)nextPos.X, (int)nextPos.Y);

            if (inBounds)
            {
                return false;
            }
            return true;
        }
    }
}
