using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    internal class CodeProgram
    {
        string name;
        List<ICommand> commands = new List<ICommand>();

        public string Name { get { return name; } }
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
