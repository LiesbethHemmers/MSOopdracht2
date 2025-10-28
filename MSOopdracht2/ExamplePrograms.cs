using MSOopdracht2.Importers;
using MSOopdracht2.Parsers;
using System;
using System.Xml.Serialization;

namespace MSOopdracht2
{
    public static class ExamplePrograms
    {
        static string BasicProgram1Content()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"FilePrograms\basicProgram1.txt");
            string fullFileName = file.FullName;
            return fullFileName;
            //CodeProgram basicProgram1 = import.Import(fullFileName);
            //basicProgram1.Name = "BasicProgram1";

            //return basicProgram1;
            //The endpoint is (6,3) facing east
        }

        static string BasicProgram2Content()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"FilePrograms\basicProgram2.txt");
            string fullFileName = file.FullName;
            return fullFileName;
            //CodeProgram basicProgram2 = import.Import(fullFileName);
            //basicProgram2.Name = "BasicProgram2";

            //return basicProgram2;
            //The endpoint is (0,0) facing east
        }

        static string AdvancedProgram1Content()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"FilePrograms\advancedProgram1.txt");
            string fullFileName = file.FullName;
            return fullFileName; ;
            //CodeProgram advancedProgram1 = import.Import(fullFileName);
            //advancedProgram1.Name = "AdvancedProgram1";

            //return advancedProgram1;
            //The endpoint is (0,0) facing east
        }

        static string AdvancedProgram2Content()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"FilePrograms\advancedProgram2.txt");
            string fullFileName = file.FullName;
            return fullFileName;
            //CodeProgram advancedProgram2 = import.Import(fullFileName);
            //advancedProgram2.Name = "AdvancedProgram2";

            //return advancedProgram2;
            //The endpoint is (9,0) facing east
        }

        static string ExpertProgram1Content()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"FilePrograms\expertProgram1.txt");
            string fullFileName = file.FullName;
            return fullFileName;
            //CodeProgram expertProgram1 = import.Import(fullFileName);
            //expertProgram1.Name = "ExpertProgram1";

            //return expertProgram1;
            //The endpoint (3,6) facing south
        }

        static string ExpertProgram2Content()
        {
            TxtProgramParser parser = new TxtProgramParser();
            TxtProgramImporter import = new TxtProgramImporter(parser);
            FileInfo file = new FileInfo(@"FilePrograms\expertProgram2.txt");
            string fullFileName = file.FullName;
            return fullFileName;
            //CodeProgram expertProgram2 = import.Import(fullFileName);
            //expertProgram2.Name = "ExpertProgram2";

            //return expertProgram2;
            //The endpoint (0,0) facing east
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
