using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    public interface IGridParser
    {
        public Grid Parse(string[] lines);
    }
}
