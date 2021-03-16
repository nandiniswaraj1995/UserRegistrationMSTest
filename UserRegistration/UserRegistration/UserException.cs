using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_MOBILE_NUMBER,
            INVALID_EMAIL_ID,
            INVALID_PASSWORD,
           
        }
        private readonly ExceptionType type;
        public UserException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
