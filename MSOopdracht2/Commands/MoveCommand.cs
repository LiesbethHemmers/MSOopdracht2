namespace MSOopdracht2.Commands
{
    public class MoveCommand : ICommand
    {
        private readonly int _steps;

        public MoveCommand(int steps)
        {
            _steps = steps;
        }
        public string Execute(Character character)
        {
            character.MoveForward(_steps);
            return $"Move {_steps}";
        }
    }
}