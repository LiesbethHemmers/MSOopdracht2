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

        public CodeProgram Parse(string[] lines)
        {
            List<ICommand> commands = new List<ICommand>();
            CodeProgram program = new CodeProgram(commands, "txtProgram");

            for (int linePointer = 0; linePointer < lines.Length; linePointer++)
            {
                string[] parts = lines[linePointer].Split(' ');

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
                    RepeatCommand repeatCommand = new RepeatCommand(int.Parse(parts[1]), CreateNestedCommands(lines, ref linePointer, 1));
                    commands.Add(repeatCommand);
                }
            }
            return program;
        }

        private List<ICommand> CreateNestedCommands(string[] lines, ref int linePointer, int depth)
        {
            List<ICommand> commands = new List<ICommand>();

            for (linePointer = linePointer + 1; linePointer < lines.Length; linePointer++)
            {
                int numOfLeadingSpaces = lines[linePointer].TakeWhile(char.IsWhiteSpace).Count();
                int currentDepth = numOfLeadingSpaces / 4;
                string[] parts = lines[linePointer].Trim().Split(' ');

                if (currentDepth < depth) //So if you're on a lower depth 
                {
                    linePointer--; //So you go back one because otherwise you skip one line
                    break;
                }

                if (currentDepth == depth) //So if you're still on the same depth
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
                        List<ICommand> nestedCommands = CreateNestedCommands(lines, ref linePointer, depth + 1); //So you're nesting deeper
                        if (nestedCommands.Count == 0)
                        {
                            break;
                        }
                        RepeatCommand repeatCommand = new RepeatCommand(int.Parse(parts[1]), nestedCommands);
                        commands.Add(repeatCommand);
                    }
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
