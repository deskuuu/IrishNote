namespace Common.Constants
{
    public sealed class ErrorMessagesConstants
    {
        public const string InvalidHyperlink = "Invalid provided source link!";

        #region UserFields
        public const string InvalidMeilMessage = "Invalid e-meil format!";
        public const string InvalidPasswordFormatMessage = "Password must be greather than 4 symbols!";
        public const string InvalidNameFieldMessage = "Invalid name!";
        #endregion

        #region Message box captions
        public const string MsgBoxCaptionAboutClick = "Hyperlink exception";
        public const string MsgBoxCaptionUser = "User data exeption";
        public const string MsgBoxLoginDataCaption = "Invalid login data";
        public const string MsgBoxSaveCaption = "Custom note";
        #endregion

        public const string UserExcistMsg = "Username was registerd.Try with another one!";
        public const string InvalidLoginDataMsg = "Invalid username or password!";
        public const string NullDataMsg = "Please input data!";
        public const string NullNoteMsg = "Note cannot be empty!";

        #region Application exception messages
        public const string InvalidUserDataMessage = "Invalid user data!";
        public const string InvalidUsernameMessage = "Invalid username!";
        public const string InvalidPasswordMessage = "Invalid password!";
        #endregion

        public const string SaveWithougthUser = "To save your custom note, please log in or make a new registration!";
    }
}
