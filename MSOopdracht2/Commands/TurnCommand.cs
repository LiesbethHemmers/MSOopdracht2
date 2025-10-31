using MSOopdracht2.Enums;

namespace MSOopdracht2.Commands
{
    public class TurnCommand : ICommand
    {
        private readonly TurnDirection _turn;

        public TurnCommand(TurnDirection turn)
        {
            _turn = turn;
        }
        public string Execute(Character character)
        {
            if (_turn == TurnDirection.Left)
            {
                character.TurnLeft();
                return "Turn left";
            }
            else
            {
                character.TurnRight();
                return "Turn right";
            }
        }
    }
}