namespace MSOopdracht2
{
    internal class TxtParser : IParser
    {
        public TxtParser()
        {

        }

        //So this method bundles the other 3 methods:
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
            for (linePointer = linePointer + 1; linePointer < lines.Length; linePointer++)
            {
                int numOfLeadingSpaces = lines[linePointer].TakeWhile(char.IsWhiteSpace).Count();
                int currentDepth = numOfLeadingSpaces / 4; //So the currentDepth is 1 is the ammount of leading spaces are 4, 2 if there are 8, etc.
                string[] parts = lines[linePointer].Trim().Split(' ');

                if (currentDepth < depth) 
                {
                    //The for loop in parse automatically makes linePointer higher by 1 after each iteration, so we need to lower linePointer here,
                    //because otherwise the first line with less indentation would be skipped:
                    linePointer--; 
                    break;  //After this break the commands will be returned
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
                    //So if there's another repeat I will just call the CreateNestedCommand functions again, but with 
                    //1 higher depth  because obviously the identation would be higher:
                    else if (parts[0] == "Repeat")
                    {
                        List<ICommand> nestedCommands = CreateNestedCommands(lines, ref linePointer, depth + 1);
                        RepeatCommand repeatCommand = new RepeatCommand(int.Parse(parts[1]), nestedCommands);
                        commands.Add(repeatCommand);
                    }
                }
            }
            return commands;
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