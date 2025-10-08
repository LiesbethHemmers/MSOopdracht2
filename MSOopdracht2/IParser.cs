using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    internal interface IParser
    {
        CodeProgram Parse(string[] lines);
    }
}
