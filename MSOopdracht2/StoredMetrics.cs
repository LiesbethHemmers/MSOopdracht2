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
        private int commandAmmount;
        private int repeatAmmount;
        private int nestingAmmount;

        public StoredMetrics(int commandAmmount, int repeatAmmount, int nestingAmmount)
        {
            this.commandAmmount = commandAmmount;
            this.repeatAmmount = repeatAmmount;
            this.nestingAmmount = nestingAmmount;
        }

        public int getNesting()
        {
            return nestingAmmount;
        }

        public void setNesting(int depth)
        {
            this.nestingAmmount = depth;
        }

        public void CommandsPlusOne()
        {
            this.commandAmmount++;
        }

        public void RepeatsPlusOne()
        {
            this.repeatAmmount++;
        }

        public void NestingPlusOne()
        {
            this.nestingAmmount++;
        }

        public void Print()
        {
            Console.WriteLine($"commandammount = {commandAmmount} repeatAmmount = {repeatAmmount} nestingAmmount = {nestingAmmount}");
        }
    }
}
