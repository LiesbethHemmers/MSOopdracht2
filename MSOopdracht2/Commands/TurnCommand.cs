using MSOopdracht2.Enums;

namespace MSOopdracht2.Commands
{
    public class TurnCommand : ICommand
    {
        TurnDirection turn;

        public TurnCommand(TurnDirection turn)
        {
            this.turn = turn;
        }
        public void Execute(Character character, List<string> trace)
        {
            if (turn == TurnDirection.Left)
            {
                character.TurnLeft();
                trace.Add("Turn left");
            }
            else
            {
                character.TurnRight();
                trace.Add("Turn right");
            }
        }
    }

   
}