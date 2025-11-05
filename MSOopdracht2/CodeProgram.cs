using MSOopdracht2.Commands;

namespace MSOopdracht2
{
    public class CodeProgram
    {
        public string Name { get; set; }

        public List<ICommand> Commands { get; }

        public CodeProgram(List<ICommand> commands, string name)
        {
            this.Commands = commands;
            this.Name = name;
        }
        
        public List<string> Execute(Character character)
        {
            List<string> trace = new List<string>();
            foreach (ICommand command in Commands)
            {
                string part = command.Execute(character);
                trace.Add(part);
            }
            return trace;
        }
    }
} 