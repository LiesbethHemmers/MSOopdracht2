using MSOopdracht2.Importers;
using MSOopdracht2.Parsers;

namespace MSOopdracht2
{
    public static class ExamplePrograms
    {
        private static string BasicProgram1Content()
        {
            FileInfo file = new FileInfo(@"FilePrograms\BasicProgram1.txt");
            string fullFileName = file.FullName;
            return fullFileName;
            //The endpoint is (6,3) facing east
        }

        private static string BasicProgram2Content()
        {
            FileInfo file = new FileInfo(@"FilePrograms\BasicProgram2.txt");
            string fullFileName = file.FullName;
            return fullFileName;
            //The endpoint is (0,0) facing east
        }

        private static string AdvancedProgram1Content()
        {
            FileInfo file = new FileInfo(@"FilePrograms\AdvancedProgram1.txt");
            string fullFileName = file.FullName;
            return fullFileName;
            //The endpoint is (0,0) facing east
        }

        private static string AdvancedProgram2Content()
        {
            FileInfo file = new FileInfo(@"FilePrograms\AdvancedProgram2.txt");
            string fullFileName = file.FullName;
            return fullFileName;
            //The endpoint is (9,0) facing east
        }

        private static string ExpertProgram1Content()
        {
            FileInfo file = new FileInfo(@"FilePrograms\ExpertProgram1.txt");
            string fullFileName = file.FullName;
            return fullFileName;
            //The endpoint (3,6) facing south
        }

        private static string ExpertProgram2Content()
        {
            FileInfo file = new FileInfo(@"FilePrograms\ExpertProgram2.txt");
            string fullFileName = file.FullName;
            return fullFileName;
            //The endpoint (0,0) facing east
        }

        //still need to make corresponding grids
        public static CodeProgram AdvancedGridProgram1()
        {
            Grid grid = null;

            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"Programs\AdvancedGridProgram1.txt");
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
            FileInfo file = new FileInfo(@"Programs\AdvancedGridProgram2.txt");
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
            FileInfo file = new FileInfo(@"Programs\ExpertGridProgram1.txt");
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
            FileInfo file = new FileInfo(@"Programs\ExpertGridProgram2.txt");
            string fullFileName = file.FullName;
            CodeProgram expertGridProgram2 = import.Import(fullFileName);

            expertGridProgram2.Name = "ExpertGrid2";

            return expertGridProgram2;
        }

        public static string GetTextBasicExampleProgram()
        {
            Random random = new Random();
            int choice = random.Next(1, 3);

            return choice switch
            {
                1 => BasicProgram1Content(),
                2 => BasicProgram2Content(),
                _ => throw new NotImplementedException() //Otherwise you will have a warning
            };
        }

        public static string GetTextAdvancedExampleProgram()
        {
            Random random = new Random();
            int choice = random.Next(1, 3);

            return choice switch
            {
                1 => AdvancedProgram1Content(),
                2 => AdvancedProgram2Content(),
                _ => throw new NotImplementedException() //Otherwise you will have a warning
            };
        }

        public static string GetTextExpertExampleProgram()
        {
            Random random = new Random();
            int choice = random.Next(1, 3);

            return choice switch
            {
                1 => ExpertProgram1Content(),
                2 => ExpertProgram2Content(),
                _ => throw new NotImplementedException() //Otherwise you will have a warning
            };
        }

    }
}
