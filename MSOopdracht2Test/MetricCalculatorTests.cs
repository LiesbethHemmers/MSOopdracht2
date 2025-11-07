using MSOopdracht2;
using MSOopdracht2.Commands;
using MSOopdracht2.Conditions;
using MSOopdracht2.Enums;
using MSOopdracht2.Metrics;

namespace MSOopdracht2Test
{
    public class MetricCalculatorTests
    {
        [Fact]
        public void CommandAmountTest()
        {
            CodeProgram commandProgram = new CodeProgram(new List<ICommand>
            {
                new MoveCommand(10),
                new TurnCommand(TurnDirection.Right),
                new MoveCommand(10),
            }, "commandProgram");
            MetricCalculator calculator = new MetricCalculator();

            StoredMetrics result = calculator.CalculateMetrics(commandProgram);

            Assert.Equal(3, result.CommandAmount);
        }

        [Fact]
        public void RepeatAmountTest()
        {
            CodeProgram repeatProgram = new CodeProgram(new List<ICommand>
            {
                new RepeatCommand(3, new List<ICommand>{
                new TurnCommand(TurnDirection.Left),
                new MoveCommand(4)}),
            }, "repeatProgram");
            MetricCalculator calculator = new MetricCalculator();

            StoredMetrics result = calculator.CalculateMetrics(repeatProgram);

            Assert.Equal(1, result.RepeatAmount);
        }


        [Fact]
        public void NestingAmountTest()
        {
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
            
            StoredMetrics result = calculator.CalculateMetrics(nestedProgram);

            Assert.Equal(3, result.NestingAmount);
        }

        [Fact]
        public void ZeroCommandsTest()
        {
            CodeProgram nestedProgramZeroCommands = new CodeProgram(new List<ICommand>
            {
                new RepeatCommand(2, new List<ICommand>
                {
                    new RepeatCommand(3, new List<ICommand>
                    {
                        new RepeatCommand(2, new List<ICommand>{
                        })
                    })
                })
            }, "nestingProgramZeroCommands");
            MetricCalculator calculator = new MetricCalculator();

            StoredMetrics result = calculator.CalculateMetrics(nestedProgramZeroCommands);

            Assert.Equal(3, result.NestingAmount);
        }

        [Fact]
        public void EmptyProgramTest()
        {
            CodeProgram nestedProgramZeroCommands = new CodeProgram(new List<ICommand>
            {
            }, "emptyProgram");
            MetricCalculator calculator = new MetricCalculator();

            StoredMetrics result = calculator.CalculateMetrics(nestedProgramZeroCommands);

            Assert.Equal(0, result.CommandAmount);
            Assert.Equal(0, result.RepeatAmount);
            Assert.Equal(0, result.NestingAmount);
        }
    }
}