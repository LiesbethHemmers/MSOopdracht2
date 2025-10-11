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
                storedMetrics.CommandsPlusOne();
                if (command is RepeatCommand)
                {
                    storedMetrics.RepeatsPlusOne();
                    if (storedMetrics.getNesting() < 1)
                    {
                        storedMetrics.setNesting(1);
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
                storedMetrics.CommandsPlusOne();
                if (command is RepeatCommand)
                {
                    int newDepth = depth + 1;
                    if (newDepth > storedMetrics.getNesting())
                    {
                        storedMetrics.setNesting(newDepth);
                    }
                    storedMetrics.RepeatsPlusOne();
                    CalculateNesting(storedMetrics, (RepeatCommand)command, newDepth);
                }
            }
        }
    }
}
