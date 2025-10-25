namespace MSOopdracht2
{
    public class StoredMetrics
    {
        public int CommandAmount { get; set; }
        public int RepeatAmount { get; set; }
        public int NestingAmount { get; set; }

        public StoredMetrics(int commandAmount, int repeatAmount, int nestingAmount)
        {
            this.CommandAmount = commandAmount;
            this.RepeatAmount = repeatAmount;
            this.NestingAmount = nestingAmount;
        }

        public List<string> GetMetrics()
        {
            return new List<string>
                { $"commandAmount = {CommandAmount} repeatAmount = {RepeatAmount} nestingAmount = {NestingAmount}" };
        }
    }
}