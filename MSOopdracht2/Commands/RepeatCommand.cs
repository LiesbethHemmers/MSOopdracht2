namespace MSOopdracht2.Commands
{
    public class RepeatCommand : ICommand
    {
        private readonly int _times;
        public List<ICommand> Commands { get; }

        public RepeatCommand(int times, List<ICommand> commands)
        {
            _times = times;
            Commands = commands;
        }
        
        public string Execute(Character character)
        {
            //this command should collect all strings from its subcommands
            List<string> traceParts = new List<string>();
            for (int i = 0; i < _times; i++)
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