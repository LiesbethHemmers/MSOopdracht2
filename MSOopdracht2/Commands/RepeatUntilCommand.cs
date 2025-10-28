using MSOopdracht2.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2.Commands
{
    public class RepeatUntilCommand : ICommand
    {
        ICondition condition;
        List<ICommand> commands;
        public List<ICommand> Commands { get { return commands; } }

        public RepeatUntilCommand(ICondition condition, List<ICommand> commands)
        {
            this.condition = condition;
            this.commands = commands;
        }

        public void Execute(Character character, List<string> trace)
        {
            while (!condition.Evaluate(character))
            {
                foreach (ICommand command in commands)
                {
                    command.Execute(character, trace);
                }
            }
        }
    }
}
