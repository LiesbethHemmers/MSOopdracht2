using MSOopdracht2.Exceptions;
using System.Numerics;

namespace MSOopdracht2
{
    internal class CodeProgramExecutor
    {
        public CodeProgramExecutor()
        {

        }

        public List<string> Run(CodeProgram program, Grid grid = null)
        {
            Character character = new Character(grid); //Character starts at (0,0) facing east 
            List<string> trace = new List<string>();
            List<string> output = new List<string>();

            try
            {
                program.Execute(character, trace);
                if (grid != null)
                {
                    Vector2 endPos = grid.GetXPosition();
                    if (endPos == character.Position)
                    {
                        output.Add("Succesfully reached end position");
                    }
                    else
                    {
                        output.Add("Character did not end at the right position");
                    }

                }

                //Firstly we need to print out the path the character had:
                output.Add(string.Join(",", trace) + ".");

                //Lastly we need to print it's finally coordinates and directions it faces:
                output.Add($"End state ({character.Position.X},{character.Position.Y}) facing {character.Direction}.");
            }
            catch (OutOfBoundsException ex)
            {
                output.Add("Runtime error" + ex.Message);
            }
            catch (BlockedMoveException ex)
            {
                output.Add("Runtime error" + ex.Message);
            }
            
            return output;
        }
    }
}