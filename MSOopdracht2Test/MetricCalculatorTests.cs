using MSOopdracht2;

namespace MSOopdracht2Test
{
    public class MetricCalculatorTests
    {
        [Fact]
        public void CommandAmmountTest()
        {
            //Initialize the test objects:
            CodeProgram commandProgram = new CodeProgram(new List<ICommand>
            {
                new MoveCommand(10),
                new TurnCommand(TurnDirection.Right),
                new MoveCommand(10),
            }, "commandProgram");
            MetricCalculator calculator = new MetricCalculator();

            //execute the tested method
            StoredMetrics result = calculator.CalculateMetrics(commandProgram);

            Assert.Equal(3, result.CommandAmmount);
        }

        [Fact]
        public void RepeatAmmountTest()
        {
            //Initialize the test objects:
            CodeProgram repeatProgram = new CodeProgram(new List<ICommand>
            {
                new RepeatCommand(3, new List<ICommand>{
                new TurnCommand(TurnDirection.Left),
                new MoveCommand(4)}),
            }, "repeatProgram");
            MetricCalculator calculator = new MetricCalculator();

            //execute the tested method
            StoredMetrics result = calculator.CalculateMetrics(repeatProgram);

            Assert.Equal(1, result.RepeatAmmount);
        }


        [Fact]
        public void NestingAmmountTest()
        {
            //Initialize the test objects:
            CodeProgram nestedProgram = new CodeProgram(new List<ICommand>
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
            }, "nestingProgram");
            MetricCalculator calculator = new MetricCalculator();

            //execute the tested method
            StoredMetrics result = calculator.CalculateMetrics(nestedProgram);

            Assert.Equal(3, result.NestingAmmount);
        }
    }
}
