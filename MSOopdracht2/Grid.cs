using System.Numerics;

namespace MSOopdracht2
{
    public class Grid
    {
        //the left array (the 0 dimension) indicates the column index (x) and the right array (the 1 dimension) the row index (y). 
        //example: oo++
        //         +oo+
        //         ++ox has 4 columns and 3 rows, so that is new char[4,3]

        public char[,] LoadedGrid { get; }

        public Grid(char[,] grid)
        {
            LoadedGrid = grid;
        }

        public char GetSymbol(int x, int y)
        {
            char symbol = LoadedGrid[x, y];
            return symbol;
        }

        public int GetWidth()
        {
            return LoadedGrid.GetLength(0);
        }
        public int GetHeight()
        {
            return LoadedGrid.GetLength(1);
        }

        public bool InBounds(int x, int y)
        {
            return x < LoadedGrid.GetLength(0) && x >= 0 && y < LoadedGrid.GetLength(1) && y >= 0;
        }

        public Vector2 GetXPosition()
        {
            for (int y = 0; y < LoadedGrid.GetLength(1); y++)
            {
                for (int x = 0; x < LoadedGrid.GetLength(0); x++)
                {
                    if (LoadedGrid[x, y] == 'x')
                    {
                        return new Vector2(x, y);
                    }
                }
            }
            return Vector2.Zero;
        }

        public int Length(int v)
        {
            throw new NotImplementedException();
        }
    }
}
