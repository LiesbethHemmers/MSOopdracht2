using MSOopdracht2.Importers;
using MSOopdracht2.Parsers;
using System;
using System.Xml.Serialization;

namespace MSOopdracht2
{
    internal static class ExamplePrograms
    {
        static CodeProgram BasicProgram1()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"Programs\basicProgram1.txt");
            string fullFileName = file.FullName;

            CodeProgram basicProgram1 = import.Import(fullFileName);
            basicProgram1.Name = "BasicProgram1";

            return basicProgram1;
            //The endpoint is (6,3) facing east
        }

        static CodeProgram BasicProgram2()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"Programs\basicProgram2.txt");
            string fullFileName = file.FullName;

            CodeProgram basicProgram2 = import.Import(fullFileName);
            basicProgram2.Name = "BasicProgram2";

            return basicProgram2;
            //The endpoint is (0,0) facing east
        }

        static CodeProgram AdvancedProgram1()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"Programs\advancedProgram1.txt");
            string fullFileName = file.FullName;

            CodeProgram advancedProgram1 = import.Import(fullFileName);
            advancedProgram1.Name = "AdvancedProgram1";

            return advancedProgram1;
            //The endpoint is (0,0) facing east
        }

        static CodeProgram AdvancedProgram2()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"Programs\advancedProgram2.txt");
            string fullFileName = file.FullName;

            CodeProgram advancedProgram2 = import.Import(fullFileName);
            advancedProgram2.Name = "AdvancedProgram2";

            return advancedProgram2;
            //The endpoint is (9,0) facing east
        }

        static CodeProgram ExpertProgram1()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"Programs\expertProgram1.txt");
            string fullFileName = file.FullName;

            CodeProgram expertProgram1 = import.Import(fullFileName);
            expertProgram1.Name = "ExpertProgram1";

            return expertProgram1;
            //The endpoint (3,6) facing south
        }

        static CodeProgram ExpertProgram2()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"Programs\expertProgram2.txt");
            string fullFileName = file.FullName;

            CodeProgram expertProgram2 = import.Import(fullFileName);
            expertProgram2.Name = "ExpertProgram2";

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
            Grid grid = null;

            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"Programs\advancedGridProgram1.txt");
            string fullFileName = file.FullName;
            CodeProgram advancedGridProgram1 = import.Import(fullFileName);

            advancedGridProgram1.Name = "AdvancedGrid1";

            return advancedGridProgram1;
        }

        public static CodeProgram AdvancedGridProgram2()
        {
            Grid grid = null;

            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"Programs\advancedGridProgram2.txt");
            string fullFileName = file.FullName;
            CodeProgram advancedGridProgram2 = import.Import(fullFileName);

            advancedGridProgram2.Name = "AdvancedGrid2";

            return advancedGridProgram2;
        }

        public static CodeProgram ExpertGridProgram1()
        {
            Grid grid = null;

            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"Programs\expertGridProgram1.txt");
            string fullFileName = file.FullName;
            CodeProgram expertGridProgram1 = import.Import(fullFileName);

            expertGridProgram1.Name = "ExpertGrid1";

            return expertGridProgram1;
        }

        public static CodeProgram ExpertGridProgram2()
        {
            Grid grid = null;

            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"Programs\expertGridProgram2.txt");
            string fullFileName = file.FullName;
            CodeProgram expertGridProgram2 = import.Import(fullFileName);

            expertGridProgram2.Name = "ExpertGrid2";

            return expertGridProgram2;
        }

        public static CodeProgram GetRandomGridExampleProgram()
        {
            Random random = new Random();
            int choice = random.Next(1, 5);

            return choice switch
            {
                1 => AdvancedGridProgram1(),
                2 => AdvancedGridProgram2(),
                3 => ExpertGridProgram1(),
                4 => ExpertGridProgram2(),
                _ => throw new NotImplementedException() //Otherwise you will have a warning
            };
        }
    }
}
