using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    public class TxtGridParser : IGridParser
    {
        public Grid Parse(string[] lines)
        {
            char[,] grid = null;
            for (int i = 0; i < lines.Length; i++)
            {
                //individual characters per line
                char[] parts = lines[i].ToCharArray();
                grid = new char[parts.Length, lines.Length];
                for (int y = 0; y < lines.Length; y++)
                {
                    for (int x = 0; x < parts.Length; x++)
                    {
                        grid[x, y] = parts[x];
                    }
                }
            }

            return new Grid(grid);
        }
    }
}
