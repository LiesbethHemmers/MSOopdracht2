using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
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

            for (int linePointer = 0; linePointer < lines.Length; linePointer++)
            {
                string[] parts = lines[linePointer].Split(' ');

                if (parts[0] == "Move")
                {
                    program.AddCommand(ParseMoveCommand(parts));
                }
                else if (parts[0] == "Turn")
                {
                    program.AddCommand(ParseTurnCommand(parts));

                }
                else if (parts[0] == "Repeat")
                {
                    RepeatCommand repeatCommand = new RepeatCommand(int.Parse(parts[1]), CreateNestedCommands(lines, linePointer++, 1));
                }
            }
            return program;
        }

        private List<ICommand> CreateNestedCommands(string[] lines, int linePointer, int depth)
        {
            List<ICommand> commands = new List<ICommand>();

            for (int j = linePointer; j < lines.Length; j++)
            {
                int numOfLeadingSpaces = lines[linePointer].TakeWhile(char.IsWhiteSpace).Count();
                int currentDepth = numOfLeadingSpaces / 4;
                string[] parts = lines[linePointer].Split(' ');

                if (currentDepth == depth)
                {
                    if (parts[0] == "Move")
                    {
                        commands.Add(ParseMoveCommand(parts));
                    }
                    else if (parts[0] == "Turn")
                    {
                        commands.Add(ParseTurnCommand(parts));
                    }
                    else if (parts[0] == "Repeat")
                    {
                        List<ICommand> nestedCommands = CreateNestedCommands(lines, linePointer++, depth++);
                        if (nestedCommands.Count == 0)
                        {
                            break;
                        }
                        RepeatCommand repeatCommand = new RepeatCommand(int.Parse(parts[1]), nestedCommands);
                        commands.Add(repeatCommand);
                    }
                }

                else if (currentDepth < depth)
                {
                    return new List<ICommand>();
                }
            }

            return commands;
        }

        private TurnCommand ParseTurnCommand(string[] parts)
        {
            if (parts[1] == "left")
            {
                TurnCommand turnCommand = new TurnCommand(TurnDirection.Left);
                return turnCommand;
            }
            else
            {
                TurnCommand turnCommand = new TurnCommand(TurnDirection.Right);
                return turnCommand;
            }
        }

        private MoveCommand ParseMoveCommand(string[] parts)
        {
            MoveCommand moveCommand = new MoveCommand(int.Parse(parts[1]));
            return moveCommand;
        }

    }
}
