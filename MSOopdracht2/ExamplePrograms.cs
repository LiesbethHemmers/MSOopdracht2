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
        public static string AdvancedGridProgram1()
        {
            FileInfo file = new FileInfo(@"FilePrograms\AdvancedGridProgram1.txt");
            string fullFileName = file.FullName;
            return fullFileName;
        }

        public static string AdvancedGridProgram2()
        {
            FileInfo file = new FileInfo(@"FilePrograms\AdvancedGridProgram2.txt");
            string fullFileName = file.FullName;
            return fullFileName;
        }

        public static string ExpertGridProgram1()
        {
            FileInfo file = new FileInfo(@"FilePrograms\ExpertGridProgram1.txt");
            string fullFileName = file.FullName;
            return fullFileName;
        }

        public static string ExpertGridProgram2()
        {
            FileInfo file = new FileInfo(@"FilePrograms\ExpertGridProgram2.txt");
            string fullFileName = file.FullName;
            return fullFileName;
        }

        public static string AdvancedGrid1()
        {
            FileInfo file = new FileInfo(@"FileGrids\AdvancedGrid1.txt");
            string fullFileName = file.FullName;
            return fullFileName;
        }

        public static string AdvancedGrid2()
        {
            FileInfo file = new FileInfo(@"FileGrids\AdvancedGrid2.txt");
            string fullFileName = file.FullName;
            return fullFileName;
        }

        public static string ExpertGrid1()
        {
            FileInfo file = new FileInfo(@"FileGrids\ExpertGrid1.txt");
            string fullFileName = file.FullName;
            return fullFileName;
        }

        public static string ExpertGrid2()
        {
            FileInfo file = new FileInfo(@"FileGrids\ExpertGrid2.txt");
            string fullFileName = file.FullName;
            return fullFileName;
        }

        public static string ExerciseGrid1()
        {
            FileInfo file = new FileInfo(@"FileGrids\ExerciseGrid1.txt");
            string fullFileName = file.FullName;
            return fullFileName;
        }

        public static string ExerciseGrid2()
        {
            FileInfo file = new FileInfo(@"FileGrids\ExerciseGrid2.txt");
            string fullFileName = file.FullName;
            return fullFileName;
        }

        public static string ExerciseGrid3()
        {
            FileInfo file = new FileInfo(@"FileGrids\ExerciseGrid3.txt");
            string fullFileName = file.FullName;
            return fullFileName;
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
