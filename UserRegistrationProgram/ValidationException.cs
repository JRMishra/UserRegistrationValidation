using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class ValidationException : Exception
    {
        public enum InvalidationType
        {
            INVALID_FIRST_NAME=1,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_PHONE_NUMBER,
            INVALID_PASSWORD
        }

        private readonly InvalidationType invalid;

        public ValidationException(InvalidationType type, string message) : base(message)
        {
            invalid = type;
        }
    }
}
