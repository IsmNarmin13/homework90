namespace Utils.Exeptions
{
    public class CapacityLimitException : Exception
    {
        public CapacityLimitException(string message) : base(message) { }
    }
    public class AlreadyExistsException : Exception
    {
        public AlreadyExistsException(string message) : base(message) { }
    }

    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) { }
    }
}