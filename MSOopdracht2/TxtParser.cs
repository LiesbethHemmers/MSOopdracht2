using System.Data;

namespace MSOopdracht2
{
    public class TxtParser : IParser
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


        List<ICommand> CreateNestedCommands(string[] lines, ref int linePointer, int depth)
        {
            List<ICommand> commands = new List<ICommand>();

            //Starts from the line after the repeat statement:
            for (linePointer++; linePointer < lines.Length; linePointer++)
            {
                int numOfLeadingSpaces = lines[linePointer].TakeWhile(char.IsWhiteSpace).Count();
                int currentDepth = numOfLeadingSpaces / 4; //So if the currentDepth is 1, amount of leading spaces are 4, if 2, there are 8, etc.
                string[] parts = lines[linePointer].Trim().Split(' ');

                if (currentDepth < depth)
                {
                    linePointer--; //To not skip the first line with less indentation:
                    break;  //The commands need to be returned after concluding that the currentDepth is lower than the depth
                }

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
                        List<ICommand> nestedCommands = CreateNestedCommands(lines, ref linePointer, depth + 1); //depth is one higher: you have a repeat in a repeat
                        RepeatCommand repeatCommand = new RepeatCommand(int.Parse(parts[1]), nestedCommands);
                        commands.Add(repeatCommand);
                    }
                }
            }
            return commands; //So this are the commands that belong to a repeat command
        }

        TurnCommand ParseTurnCommand(string[] parts)
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

        MoveCommand ParseMoveCommand(string[] parts)
        {
            MoveCommand moveCommand = new MoveCommand(int.Parse(parts[1]));
            return moveCommand;
        }
    }
}