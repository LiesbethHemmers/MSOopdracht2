namespace MSOopdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Load a random example program");
            Console.WriteLine("2: Import a program from a text file");
            string choice = Console.ReadLine();//stash user choice
            CodeProgram codeProgram = null;//fill in later, based on user choice

            if (choice == "1")
            {
                codeProgram = ExamplePrograms.GetRandomExampleProgram();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter filepath");
                string filePath = Console.ReadLine();
                IParser parser = new TxtParser();
                IImporter importer = new TxtImporter(parser);
                codeProgram = importer.Import(filePath);
            }

            Console.WriteLine("1: Execute loaded program");
            Console.WriteLine("2: Calculate metrics");

            string secondChoice = Console.ReadLine();

            if (secondChoice == "1")
            {
                CodeProgramExecutor executor = new CodeProgramExecutor();
                executor.Run(codeProgram);
            }
            else if (secondChoice == "2")
            {
                MetricCalculator calculator = new MetricCalculator();
                StoredMetrics metric = calculator.CalculateMetrics(codeProgram);
                metric.Print();
            }
        }
    }
}
