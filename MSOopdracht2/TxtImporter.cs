using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    internal class TxtImporter : IImporter
    {
        IParser parser;
        public TxtImporter(IParser parser)
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
