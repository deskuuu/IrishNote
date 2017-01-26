namespace Common.Exceptions
{
    public class InvalidUsernameException : InvalidUserDataException
    {
        public InvalidUsernameException() : base()
        {
        }

        public InvalidUsernameException(string message) : base(message)
        {
        }

        public override string Message
        {
            get
            {
                return Constants.ErrorMessagesConstants.InvalidUsernameMessage;
            }
        }
    }
}
