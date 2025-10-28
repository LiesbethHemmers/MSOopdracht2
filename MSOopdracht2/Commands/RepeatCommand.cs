namespace MSOopdracht2.Commands
{
    public class RepeatCommand : ICommand
    {
        int times;
        List<ICommand> commands;
        public List<ICommand> Commands { get { return commands; } }

        public RepeatCommand(int times, List<ICommand> commands)
        {
            this.times = times;
            this.commands = commands;
        }
        
        public void Execute(Character character, List<string> trace)
        {
            for (int i = 0; i < times; i++)
            {
                foreach (ICommand command in commands)
                {
                    command.Execute(character, trace);
                }
            }
            
        }
    }
}