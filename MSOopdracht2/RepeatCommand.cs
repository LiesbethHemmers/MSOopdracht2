using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    public class RepeatCommand : ICommand
    {
        int times;
        List<ICommand> commands;

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
