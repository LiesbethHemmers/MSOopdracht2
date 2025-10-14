namespace MSOopdracht2
{
    internal static class ExamplePrograms
    {
        //The basicprograms are only turn and move commands
        static CodeProgram BasicProgram1()
        {
            return new CodeProgram(new List<ICommand>
            {
                new MoveCommand(2),
                new TurnCommand(TurnDirection.Right),
                new MoveCommand(3),
                new TurnCommand(TurnDirection.Left),
                new MoveCommand(4)
                //The endpoint is (6,3) facing east
            }, "BasicProgram1");
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
            int choice = random.Next(1, 7);

            return choice switch
            {
                1 => BasicProgram1(),
                2 => BasicProgram2(),
                3 => AdvancedProgram1(),
                4 => AdvancedProgram2(),
                5 => ExpertProgram1(),
                6 => ExpertProgram2(),
                _ => BasicProgram2()
            };
        }
    }
}
