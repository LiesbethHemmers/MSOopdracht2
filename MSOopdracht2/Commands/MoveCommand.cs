namespace MSOopdracht2.Commands
{
    public class MoveCommand : ICommand
    {
        int steps;

        public MoveCommand(int steps)
        {
            this.steps = steps;
        }
        public void Execute(Character character, List<string> trace)
        {
            character.MoveForward(steps);
            trace.Add("Move " + steps);
        }
    }
}