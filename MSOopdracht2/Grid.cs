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
        public Grid(int width, int height)
        {
            grid = new char[width, height];
        }


    }
}
