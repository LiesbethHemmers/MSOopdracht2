using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    public class MoveCommand : ICommand
    {
        int steps;

        public MoveCommand(int steps)
        {
            this.steps = steps;
        }
        public void Execute(Character character, List<string> trace)
        {
            character.MoveForward(steps);
            trace.Add("Move " + steps);
        }
    }
}
