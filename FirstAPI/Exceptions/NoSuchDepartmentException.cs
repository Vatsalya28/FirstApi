namespace FirstAPI.Exceptions
{
    public class NoSuchDepartmentException:Exception
    {
        string message;
        public NoSuchDepartmentException()
        {
            message = "No department of given id";
        }
        public override string Message => message;

    }
}
