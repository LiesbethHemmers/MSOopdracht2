using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    public class Grid
    {
        char[,] grid;

        public char[,] LoadedGrid { get { return grid; } }
        public Grid(char[,] grid)
        {
            this.grid = grid;
        }

        public char GetSymbol(int x, int y)
        {
            char symbol = grid[x, y];
            return symbol;
        }


    }
}
