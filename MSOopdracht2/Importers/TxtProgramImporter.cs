using MSOopdracht2.Parsers;

namespace MSOopdracht2.Importers
{
    public class TxtProgramImporter : IProgramImporter
    {
        IProgramParser parser;
        public TxtProgramImporter(IProgramParser parser)
        {
            this.parser = parser;
        }

        public CodeProgram Import(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);//this is thus a string array containing all lines of the file
            CodeProgram parsedProgram = parser.Parse(lines);
            return parsedProgram;
        }
    }
}