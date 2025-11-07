using MSOopdracht2.Exceptions;
using System.Numerics;

namespace MSOopdracht2
{
    public class CodeProgramExecutor
    {
        public List<string> Run(CodeProgram program, Grid? grid = null)
        {
            Character character = new Character(grid); //Character starts at (0,0) facing east 
            List<string> output = new List<string>();

            try
            {
                List<string> trace = program.Execute(character);
                if (grid != null)
                {
                    Vector2 endPos = grid.GetXPosition();
                    if (endPos == character.Position)
                    {
                        output.Add("Successfully reached end position");
                    }
                    else
                    {
                        output.Add("Character did not end at the right position");
                    }
                }

                //the path the character had
                output.Add(string.Join(", ", trace) + ".");

                //character's final coordinates and direction it faces
                output.Add($"End state ({character.Position.X},{character.Position.Y}) facing {character.Direction}.");
            }
            catch (OutOfBoundsException ex)
            {
                output.Add("Runtime error: " + ex.Message);
            }
            catch (BlockedMoveException ex)
            {
                output.Add("Runtime error: " + ex.Message);
            }
            return output;
        }
    }
}