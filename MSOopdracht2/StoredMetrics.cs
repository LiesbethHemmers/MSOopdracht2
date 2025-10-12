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
        public int commandAmmount { get; set; }
        public int repeatAmmount { get; set; }
        public int nestingAmmount { get; set; }

        public StoredMetrics(int commandAmmount, int repeatAmmount, int nestingAmmount)
        {
            this.commandAmmount = commandAmmount;
            this.repeatAmmount = repeatAmmount;
            this.nestingAmmount = nestingAmmount;
        }

        public void Print()
        {
            Console.WriteLine($"commandammount = {commandAmmount} repeatAmmount = {repeatAmmount} nestingAmmount = {nestingAmmount}");
        }
    }
}
