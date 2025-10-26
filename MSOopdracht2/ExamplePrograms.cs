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
            return new CodeProgram(new List<ICommand>
            {
                new MoveCommand(10),
                new TurnCommand(TurnDirection.Right),
                new MoveCommand(10),
                new TurnCommand(TurnDirection.Right),
                new MoveCommand(10),
                new TurnCommand(TurnDirection.Right),
                new MoveCommand(10),
                new TurnCommand(TurnDirection.Right)
                //The endpoint is (0,0) facing east
            }, "BasicProgram2");
        }

        static CodeProgram AdvancedProgram1()
        {
            return new CodeProgram(new List<ICommand>
            {
                new RepeatCommand(4, new List<ICommand>{new MoveCommand(10), new TurnCommand(TurnDirection.Right)})
                //The endpoint is (0,0) facing east
            }, "AdvancedProgram1");
        }

        static CodeProgram AdvancedProgram2()
        {
            return new CodeProgram(new List<ICommand>
            {
                new RepeatCommand(3, new List<ICommand>{
                new MoveCommand(2),
                new TurnCommand(TurnDirection.Right),
                new MoveCommand(3),
                new TurnCommand(TurnDirection.Left),
                new MoveCommand(4)}),
                new TurnCommand(TurnDirection.Right),
                new MoveCommand(1)
                //The endpoint is (18,10) facing south
            }, "AdvancedProgram2");
        }

        static CodeProgram ExpertProgram1()
        {
            return new CodeProgram(new List<ICommand>
            {
                new MoveCommand(5),
                new TurnCommand(TurnDirection.Left),
                new TurnCommand(TurnDirection.Left),
                new MoveCommand(3),
                new TurnCommand(TurnDirection.Right),
                new MoveCommand(4),
                new RepeatCommand(3, new List<ICommand>{
                new MoveCommand(1),
                new TurnCommand(TurnDirection.Right),
                new RepeatCommand(5, new List<ICommand>
                {
                    new MoveCommand(2)
                })}),
                new TurnCommand(TurnDirection.Left)
                //The endpoint (3,6) facing south
            }, "ExpertProgram1");
        }

        static CodeProgram ExpertProgram2()
        {
            return new CodeProgram(new List<ICommand>
            {
                new RepeatCommand(2, new List<ICommand>
                {
                    new MoveCommand(2),
                    new RepeatCommand(3, new List<ICommand>
                    {
                        new MoveCommand(3),
                        new RepeatCommand(2, new List<ICommand>{
                            new TurnCommand(TurnDirection.Right)
                        })
                    })
                })
                //The endpoint (0,0) facing east
            }, "ExpertProgram2");
        }

        public static CodeProgram GetRandomExampleProgram()
        {
            Random random = new Random();
            int choice = random.Next(1, 2);

            return choice switch
            {
                1 => BasicProgram1(),
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
