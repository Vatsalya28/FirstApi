namespace FirstAPI.Exceptions
{
    public class NoSuchEmployeeException : Exception
    {
        string message;
        public NoSuchEmployeeException()
        {
            message = "NO employee with the given id";
        }
        public override string Message => message;
    }
}