using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2.Conditions
{
    public interface ICondition
    {
        public bool Evaluate(Character character);
    }
}
