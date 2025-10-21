using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MSOopdracht2
{
    internal class RepeatUntilCommand : ICommand
    {
        string condition;
        List<ICommand> commands;
        public List<ICommand> Commands { get { return commands; } }

        public RepeatUntilCommand(string condition, List<ICommand> commands)
        {
            this.condition = condition;
            this.commands = commands;
        }

        public void Execute(Character character, List<string> trace)
        {
            
        }

        //bool GridEdge(Character character)
        //{
        //   Direction dir = character.Direction;
        //   Vector2 pos = character.Position;
        //   char[,] gr = grid.LoadedGrid;
        //    if (pos.X + 1 == gr.GetLength(0) && dir == Direction.East)//+1 because gridedge is true if the next step is outside of the grid
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}
