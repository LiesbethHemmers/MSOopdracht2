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
                if (command is RepeatCommand or RepeatUntilCommand)
                {
                    storedMetrics.RepeatAmount++;
                    
                    //Update the NestingAmount if this is the first repeat in the program
                    if (storedMetrics.NestingAmount < 1)
                    {
                        storedMetrics.NestingAmount++;
                    }
                    CalculateNesting(storedMetrics, command, 1);
                }
            }
            return storedMetrics;
        }

        //This method recursively checks repeats and updates the different amounts
        public void CalculateNesting(StoredMetrics storedMetrics, ICommand command, int depth)
        {
            if (command is RepeatCommand repeatCommand)
            {
                RepeatCommand repeat = (RepeatCommand)command;
                foreach (ICommand innerCommand in repeat.Commands)
                {
                    storedMetrics.CommandAmount++;
                    if (innerCommand is RepeatCommand or RepeatUntilCommand) //So this is true if the list of the repeatcommand has another repeatcommand
                    {
                        int newDepth = depth + 1;

                        //To keep the NestingAmmount the same as the current deepest nesting level
                        if (newDepth > storedMetrics.NestingAmount)
                        {
                            storedMetrics.NestingAmount = newDepth;
                        }

                        storedMetrics.RepeatAmount++;

                        CalculateNesting(storedMetrics, innerCommand, newDepth);
                    }
                }
            }

            else if (command is RepeatUntilCommand repeatUntilCommand)
            {
                RepeatUntilCommand repeatUntil = (RepeatUntilCommand)command;
                foreach (ICommand innerCommand in repeatUntil.Commands)
                {
                    storedMetrics.CommandAmount++;
                    if (innerCommand is RepeatCommand or RepeatUntilCommand) //So this is true if the list of the repeatcommand has another repeatcommand
                    {
                        int newDepth = depth + 1;

                        //To keep the NestingAmmount the same as the current deepest nesting level
                        if (newDepth > storedMetrics.NestingAmount)
                        {
                            storedMetrics.NestingAmount = newDepth;
                        }

                        storedMetrics.RepeatAmount++;

                        CalculateNesting(storedMetrics, innerCommand, newDepth);
                    }
                }
            }
        }
    }
}
