using MSOopdracht2;
using MSOopdracht2.Parsers;
using MSOopdracht2.Importers;
using MSOopdracht2.Commands;
using MSOopdracht2.Enums;

namespace MSOopdracht2Test
{
    public class ImporterTests
    {
        [Fact]
        public void TxtGridImporterTest()
        {
            IGridParser parser = new TxtGridParser();
            IGridImporter importer = new TxtGridImporter(parser);

            //makes a temporary file with test data
            string testFile = Path.GetTempFileName();
            File.WriteAllLines(testFile, new[]
            {
                "oo+",
                "+o+",
                "+o+",
                "+ox"
            });
            Grid grid = importer.Import(testFile);

            //test if there is any data
            Assert.Equal(3, grid.LoadedGrid.GetLength(0));
            Assert.Equal(4, grid.LoadedGrid.GetLength(1));
        }

        [Fact]
        public void TxtProgramImporterTest()
        {
            IProgramParser parser = new TxtProgramParser();
            IProgramImporter importer = new TxtProgramImporter(parser);

            //makes a temporary file with test data
            string testFile = Path.GetTempFileName();
            File.WriteAllLines(testFile, new[]
            {
                "Move 1",
                "Turn right"
            });
            List<ICommand> compareCommands = new List<ICommand>()
            {
                new MoveCommand(1),
                new TurnCommand(TurnDirection.Right)
            };

            CodeProgram program = importer.Import(testFile);

            //test if there is any data
            Assert.Equal(compareCommands.Count, program.Commands.Count);
        }
    }
}