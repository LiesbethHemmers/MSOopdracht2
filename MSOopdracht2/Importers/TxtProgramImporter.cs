using MSOopdracht2.Parsers;

namespace MSOopdracht2.Importers
{
    public class TxtProgramImporter : IProgramImporter
    {
        private readonly IProgramParser _parser;
        public TxtProgramImporter(IProgramParser parser)
        {
            _parser = parser;
        }

        public CodeProgram Import(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);//this is thus a string array containing all lines of the file
            CodeProgram parsedProgram = _parser.Parse(lines);
            return parsedProgram;
        }
    }
}