using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    internal interface ICommand
    {
        public void Execute(Character character, List<string> trace);
    }
}
