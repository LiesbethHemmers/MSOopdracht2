namespace MSOopdracht2
{
    public class StoredMetrics
    {
        public int CommandAmmount { get; set; }
        public int RepeatAmmount { get; set; }
        public int NestingAmmount { get; set; }

        public StoredMetrics(int commandAmmount, int repeatAmmount, int nestingAmmount)
        {
            this.CommandAmmount = commandAmmount;
            this.RepeatAmmount = repeatAmmount;
            this.NestingAmmount = nestingAmmount;
        }

        public void Print()
        {
            Console.WriteLine($"commandammount = {CommandAmmount} repeatAmmount = {RepeatAmmount} nestingAmmount = {NestingAmmount}");
        }
    }
}