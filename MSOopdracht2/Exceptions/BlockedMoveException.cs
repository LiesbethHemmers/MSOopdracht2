using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2.Exceptions
{
    public class BlockedMoveException : Exception
    {
        public BlockedMoveException(string message) : base(message) { }
    }
}