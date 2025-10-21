namespace MSOopdracht2
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the app!");
            Console.WriteLine("1: Load a random example program");
            Console.WriteLine("2: Import a program from a text file");
            Console.WriteLine("3: Do a pathfinding exercise");
            string choice = Console.ReadLine();//stash user choice
            CodeProgram codeProgram = null;//fill in later, based on user choice
            Grid grid = null; //if the user chooses the pathfinding option then it will be filled in

            if (choice == "1")
            {
                codeProgram = ExamplePrograms.GetRandomExampleProgram();
                Console.WriteLine("You have chosen:" + codeProgram.Name);
            }
            else if (choice == "2")
            {
                while (true)
                {
                    Console.WriteLine("Enter filepath");
                    string filePath = Console.ReadLine();
                    IParser parser = new TxtParser();
                    IImporter importer = new TxtImporter(parser);
                    try
                    {
                        codeProgram = importer.Import(filePath);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Filepath not valid, please try again");
                    }
                }
            }
            else if (choice == "3")
            {
                while (true)
                {
                    Console.WriteLine("Enter filepath to grid");
                    string filePathGrid = Console.ReadLine();
                    IGridParser gridParser = new GridParser();
                    IGridImporter gridImporter = new GridImporter(gridParser);
                    try
                    {
                        grid = gridImporter.Import(filePathGrid);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Filepath not valid, please try again");
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter filepath to which you want to write the program");
                    string filePath = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Write the commands, write FINISH to stop");
                        List<string> lines = new List<string>();
                        while (true)
                        {
                            string line = Console.ReadLine();
                            if (line == "FINISH") break;
                            lines.Add(line); 
                        }
                        File.WriteAllLines(filePath, lines);
                        IParser parser = new TxtParser();
                        IImporter importer = new TxtImporter(parser);
                        codeProgram = importer.Import(filePath);
                        break;
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("FilePath not valid, please try again");
                    }
                }
                CodeProgramExecutor executor = new CodeProgramExecutor();
                executor.Run(codeProgram, grid);
            }

            if(choice != "3")
            {
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
}
