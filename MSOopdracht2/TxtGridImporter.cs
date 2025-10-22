using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    internal class GridImporter : IGridImporter
    {
        IGridParser parser;
        public GridImporter(IGridParser parser)
        {
            this.parser = parser;
        }

        public Grid Import(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);//this is thus a string array containing all lines of the file
            Grid parsedGrid = parser.Parse(lines);
            return parsedGrid;
        }
    }
}
