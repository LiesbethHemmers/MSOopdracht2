using System.Numerics;

namespace MSOopdracht2
{
    internal class CodeProgramExecutor
    {
        public CodeProgramExecutor()
        {

        }

        public void Run(CodeProgram program, Grid grid = null)
        {
            Character character = new Character(grid); //Character starts at (0,0) facing east 
            List<string> trace = new List<string>();

            program.Execute(character, trace);
            if (grid != null)
            {
                Vector2 endPos = grid.GetXPosition();
                if (endPos == character.Position)
                {
                    Console.WriteLine("Succesfuly reached endposition");
                }
                else
                {
                    Console.WriteLine("Character did not end at the right position");
                }

            }
            //Firstly we need to print out the path the character had:
            Console.WriteLine(string.Join(",", trace) + ".");

            //Lastly we need to print it's finally coordinates and directions it faces:
            Console.WriteLine($"End state ({character.Position.X},{character.Position.Y}) facing {character.Direction}.");
        }
    }
}