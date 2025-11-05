namespace MSOopdracht2.Exceptions
{
    public class BlockedMoveException : Exception
    {
        public BlockedMoveException(string message) : base(message) { }
    }
}