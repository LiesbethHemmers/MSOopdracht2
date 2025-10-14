using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    public class MetricCalculator
    {
        public MetricCalculator()
        {

        }

        public StoredMetrics CalculateMetrics(CodeProgram program)
        {
            StoredMetrics storedMetrics = new StoredMetrics(0, 0, 0);

            foreach (ICommand command in program.Commands)
            {
                storedMetrics.CommandAmount++;
                if (command is RepeatCommand)
                {
                    storedMetrics.RepeatAmount++;
                    //So this if statement is her, because if you're NestingAmount is already higher then one, you don't need to 
                    //make it even higher, since it would get to high:
                    if (storedMetrics.NestingAmount < 1)
                    {
                        storedMetrics.NestingAmount++;
                    }
                    CalculateNesting(storedMetrics, (RepeatCommand)command, 1);
                }
            }
            return storedMetrics;
        }

        //This method goes through all the commands in the repeat, so it can count them and to look for deeper nesting levels:
        public void CalculateNesting(StoredMetrics storedMetrics, RepeatCommand repeatCommand, int depth)
        {
            foreach (ICommand command in repeatCommand.Commands)
            {
                storedMetrics.CommandAmount++;
                if (command is RepeatCommand) //So this is true if the list of the repeatcommand has another repeatcommand
                {
                    int newDepth = depth + 1;
                    //So this if statement is her so if the NestingAmount is lower than the depth
                    //we're in now, we make it higher until the depth we're in now is equal to the NestingAmount:
                    if (newDepth > storedMetrics.NestingAmount)
                    {
                        while (storedMetrics.NestingAmount < newDepth)
                        {
                            storedMetrics.NestingAmount++;
                        }
                    }
                    storedMetrics.RepeatAmount++;
                    //So if the list had another repeatcommand, i need to call this method again:
                    CalculateNesting(storedMetrics, (RepeatCommand)command, newDepth);
                }
            }
        }
    }
}
