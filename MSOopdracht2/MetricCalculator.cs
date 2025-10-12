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
                storedMetrics.CommandAmmount++;
                if (command is RepeatCommand)
                {
                    storedMetrics.RepeatAmmount++;
                    if (storedMetrics.NestingAmmount < 1)
                    {
                        storedMetrics.NestingAmmount++;
                    }
                    CalculateNesting(storedMetrics, (RepeatCommand)command, 1);
                }
            }
            return storedMetrics;
        }

        public void CalculateNesting(StoredMetrics storedMetrics, RepeatCommand repeatCommand, int depth)
        {
            foreach (ICommand command in repeatCommand.Commands)
            {
                storedMetrics.CommandAmmount++;
                if (command is RepeatCommand)
                {
                    int newDepth = depth + 1;
                    if (newDepth > storedMetrics.NestingAmmount)
                    {
                        while (storedMetrics.NestingAmmount < newDepth)
                        {
                            storedMetrics.NestingAmmount++;
                        }
                    }
                    storedMetrics.RepeatAmmount++;
                    CalculateNesting(storedMetrics, (RepeatCommand)command, newDepth);
                }
            }
        }
    }
}
