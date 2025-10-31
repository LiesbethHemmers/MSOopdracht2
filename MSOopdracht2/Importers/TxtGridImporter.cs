using MSOopdracht2.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2.Importers
{
    internal class GridImporter : IGridImporter
    {
        private readonly IGridParser _parser;
        public GridImporter(IGridParser parser)
        {
            _parser = parser;
        }

        public Grid Import(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);//this is thus a string array containing all lines of the file
            Grid parsedGrid = _parser.Parse(lines);
            return parsedGrid;
        }
    }
}
