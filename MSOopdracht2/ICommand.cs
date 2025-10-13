namespace MSOopdracht2
{
    public interface ICommand
    {
        public void Execute(Character character, List<string> trace);
    }
}