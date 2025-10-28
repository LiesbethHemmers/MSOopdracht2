using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2.Importers
{
    internal interface IGridImporter
    {
        public Grid Import(string filePath);
    }
}
