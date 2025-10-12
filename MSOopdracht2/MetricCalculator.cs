using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    internal class MetricCalculator
    {
        public MetricCalculator(CodeProgram program)
        {

        }

        public StoredMetrics CalculateMetrics(CodeProgram program)
        {
            StoredMetrics storedMetrics = new StoredMetrics(0, 0, 0);

            foreach (ICommand command in program.Commands)
            {
                storedMetrics.commandAmmount++;
                if (command is RepeatCommand)
                {
                    storedMetrics.repeatAmmount++;
                    if (storedMetrics.nestingAmmount < 1)
                    {
                        storedMetrics.nestingAmmount++;
                    }
                    CalculateNesting(storedMetrics, (RepeatCommand)command, 1);
                }
            }
            return storedMetrics;
        }

        public void CalculateNesting(StoredMetrics storedMetrics, RepeatCommand repeatCommand, int depth)
        {
            foreach (ICommand command in repeatCommand.GetCommands())
            {
                storedMetrics.commandAmmount++;
                if (command is RepeatCommand)
                {
                    int newDepth = depth + 1;
                    if (newDepth > storedMetrics.nestingAmmount)
                    {
                        while (storedMetrics.nestingAmmount < newDepth)
                        {
                            storedMetrics.nestingAmmount++;
                        }
                    }
                    storedMetrics.repeatAmmount++;
                    CalculateNesting(storedMetrics, (RepeatCommand)command, newDepth);
                }
            }
        }
    }
}
