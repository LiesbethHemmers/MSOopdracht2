using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    internal class TxtParser : IParser
    {
        public TxtParser()
        {

        }

        public CodeProgram Parse(string[] lines, string filePath)
        {
            CodeProgram program = new CodeProgram(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');

                if (parts[0] == "Move")
                {
                    MoveCommand moveCommand = new MoveCommand(int.Parse(parts[1]));
                    program.AddCommand(moveCommand);
                }

                else if (parts[0] == "Turn")
                {
                    if (parts[1] == "left")
                    {
                        TurnCommand turnCommand = new TurnCommand(TurnDirection.Left);
                        program.AddCommand(turnCommand);
                    }
                    else
                    {
                        TurnCommand turnCommand = new TurnCommand(TurnDirection.Right);
                        program.AddCommand(turnCommand);
                    }
                }
            }
            return program;
        }
    }
}
