namespace Common.Exceptions
{
    using System;

    public class InvalidUserDataException : ApplicationException
    {
        public InvalidUserDataException() : base()
        {
        }

        public InvalidUserDataException(string message) : base(message)
        {
        }

        public override string Message
        {
            get
            {
                return Constants.ErrorMessagesConstants.InvalidUserDataMessage;
            }
        }
    }
}
