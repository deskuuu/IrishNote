namespace Common.Exceptions
{
    public class InvalidPasswordException : InvalidUserDataException
    {
        public InvalidPasswordException() : base()
        {
        }

        public InvalidPasswordException(string message) : base(message)
        {
        }

        public override string Message
        {
            get
            {
                return Constants.ErrorMessagesConstants.InvalidPasswordMessage;
            }
        }
    }
}
