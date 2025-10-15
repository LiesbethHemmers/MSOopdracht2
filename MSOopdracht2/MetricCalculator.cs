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
                    
                    //Update the nesting if this is the first repeat in the program
                    if (storedMetrics.NestingAmount < 1)
                    {
                        storedMetrics.NestingAmount++;
                    }
                    CalculateNesting(storedMetrics, (RepeatCommand)command, 1);
                }
            }
            return storedMetrics;
        }

        //This method recursively checks repeats and updates the different ammounts
        public void CalculateNesting(StoredMetrics storedMetrics, RepeatCommand repeatCommand, int depth)
        {
            foreach (ICommand command in repeatCommand.Commands)
            {
                storedMetrics.CommandAmount++;
                if (command is RepeatCommand) //So this is true if the list of the repeatcommand has another repeatcommand
                {
                    int newDepth = depth + 1;
                    
                    //To keep the NestingAmmount the same as the deepest nesting level
                    if (newDepth > storedMetrics.NestingAmount)
                    {
                        storedMetrics.NestingAmount = newDepth;
                    }
                    storedMetrics.RepeatAmount++;
                    //So if the list had another repeatcommand, i need to call this method again:
                    CalculateNesting(storedMetrics, (RepeatCommand)command, newDepth);
                }
            }
        }
    }
}
