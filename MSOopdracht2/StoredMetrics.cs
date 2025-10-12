using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    internal class StoredMetrics
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
