using MSOopdracht2.Commands;

namespace MSOopdracht2
{
    public class CodeProgram
    {
        string name;
        List<ICommand> commands = new List<ICommand>();

        public string Name { get { return name; } set { name = value; } }
        public List<ICommand> Commands { get { return commands; } }

        public CodeProgram(List<ICommand> commands, string name)
        {
            this.commands = commands;
            this.name = name;
        }
        
        public void Execute(Character character, List<string> trace)
        {
            foreach (ICommand command in commands)
            {
                command.Execute(character, trace);
            }
        }
    }
}