using System.Xml.Serialization;

namespace MSOopdracht2
{
    internal static class ExamplePrograms
    {
        static CodeProgram BasicProgram1()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo fi = new FileInfo(@"Programs\basicProgram1.txt");
            string fullFileName = fi.FullName;

            CodeProgram basicProgram1 = import.Import(fullFileName);
            basicProgram1.Name = "BasicProgram1";

            return basicProgram1;
        }

        static CodeProgram BasicProgram2()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo fi = new FileInfo(@"Programs\basicProgram2.txt");
            string fullFileName = fi.FullName;

            CodeProgram basicProgram2 = import.Import(fullFileName);
            basicProgram2.Name = "BasicProgram2";

            return basicProgram2;
            //The endpoint is (0,0) facing east
        }

        static CodeProgram AdvancedProgram1()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo fi = new FileInfo(@"Programs\advancedProgram1.txt");
            string fullFileName = fi.FullName;

            CodeProgram advancedProgram1 = import.Import(fullFileName);
            advancedProgram1.Name = "AdvancedProgram1";

            return advancedProgram1;
            //The endpoint is (0,0) facing east
        }

        static CodeProgram AdvancedProgram2()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo fi = new FileInfo(@"Programs\advancedProgram2.txt");
            string fullFileName = fi.FullName;

            CodeProgram advancedProgram2 = import.Import(fullFileName);
            advancedProgram2.Name = "AdvancedProgram2";

            return advancedProgram2;
            //The endpoint is (18,10) facing south
        }

        static CodeProgram ExpertProgram1()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo fi = new FileInfo(@"Programs\expertProgram1.txt");
            string fullFileName = fi.FullName;

            CodeProgram expertProgram1 = import.Import(fullFileName);
            expertProgram1.Name = "EpertProgram1";

            return expertProgram1;
            //The endpoint (3,6) facing south
        }

        static CodeProgram ExpertProgram2()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo fi = new FileInfo(@"Programs\expertProgram2.txt");
            string fullFileName = fi.FullName;

            CodeProgram expertProgram2 = import.Import(fullFileName);
            expertProgram2.Name = "EpertProgram2";

            return expertProgram2;
            //The endpoint (0,0) facing east
        }

        public static CodeProgram GetRandomExampleProgram()
        {
            Random random = new Random();
            int choice = random.Next(1, 7);

            return choice switch
            {
                1 => BasicProgram1(),
                2 => BasicProgram2(),
                3 => AdvancedProgram1(),
                4 => AdvancedProgram2(),
                5 => ExpertProgram1(),
                6 => ExpertProgram2(),
                _ => throw new NotImplementedException() //Otherwise you will have a warning
            };
        }

        public static CodeProgram AdvancedGridProgram1()
        {
            return new CodeProgram(new List<ICommand>
            {
                new RepeatCommand(2, new List<ICommand>
                {
                    new RepeatUntilCommand(new WallAheadCondition(), new List<ICommand>
                    {
                        new MoveCommand(1)
                    }),
                    new TurnCommand(TurnDirection.Right)
                }),
                new RepeatUntilCommand(new GridEdgeCondition(), new List<ICommand>
                {
                    new MoveCommand(1)
                }),
                new TurnCommand(TurnDirection.Left),
                new MoveCommand(1)
            }, "AdvancedGrid1");
        }
        public static CodeProgram GetRandomGridExampleProgram()
        {
            Random random = new Random();
            int choice = random.Next(1, 2);

            return choice switch
            {
                1 => AdvancedGridProgram1(),
                _ => throw new NotImplementedException() //Otherwise you will have a warning
            };
        }
    }
}
