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
            int width = lines[0].Length;
            int height = lines.Length;
            char[,] grid = new char[width, height];
            for (int y = 0; y < height; y++)
            {
                //individual characters per line
                char[] parts = lines[y].ToCharArray();
                for (int x = 0; x < width; x++)
                {
                    grid[x, y] = parts[x];
                }
            }

            return new Grid(grid);
        }
    }
}
