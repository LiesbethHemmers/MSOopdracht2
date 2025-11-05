using MSOopdracht2.Conditions;

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
            while (!_condition.Evaluate(character) && Commands.Count != 0)//without the count check, the command can keep trying to evaluate the condition forever, because the condition never changes
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
