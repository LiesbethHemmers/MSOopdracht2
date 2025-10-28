namespace MSOopdracht2.Commands
{
    public interface ICommand
    {
        public void Execute(Character character, List<string> trace);
    }
}