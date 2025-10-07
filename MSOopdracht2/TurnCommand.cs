using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    public class TurnCommand : ICommand
    {
        TurnDirection turn;

        public TurnCommand(TurnDirection turn)
        {
            this.turn = turn;
        }
        public void Execute(Character character, List<string> trace)
        {
            if (turn == TurnDirection.Left)
            {
                character.TurnLeft();
                trace.Add("Turn left");
            }
            else
            {
                character.TurnRight();
                trace.Add("Turn right");
            }
        }
    }

    public enum TurnDirection
    {
        Left,
        Right
    }
}
