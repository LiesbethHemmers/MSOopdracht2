using MSOopdracht2.Parsers;

namespace MSOopdracht2.Importers
{
    public class TxtGridImporter : IGridImporter
    {
        private readonly IGridParser _parser;
        public TxtGridImporter(IGridParser parser)
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
