using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    public class Grid
    {
        //the left array (the 0 dimension) indicates the column index (x) and the right array (the 1 dimension) the row index (y). 
        //example: oo++
        //         +oo+
        //         ++ox has 4 columns and 3 rows, so that is new char[4,3]
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

        public bool InBounds(int x, int y)
        {
            if (x < grid.GetLength(0) && x >= 0 && y < grid.GetLength(1) && y >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
