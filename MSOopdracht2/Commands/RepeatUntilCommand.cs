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
        private readonly ICondition _condition;
        public List<ICommand> Commands { get; }

        public RepeatUntilCommand(ICondition condition, List<ICommand> commands)
        {
            _condition = condition;
            Commands = commands;
        }

        public string Execute(Character character)
        {
            List<string> traceParts = new List<string>();
            while (!_condition.Evaluate(character))
            {
                foreach (ICommand command in Commands)
                {
                    string part = command.Execute(character);
                    traceParts.Add(part);
                }
            }

            return string.Join(", ", traceParts);
        }
    }
}
