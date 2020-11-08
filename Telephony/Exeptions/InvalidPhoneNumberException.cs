using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Exeptions
{
    public class InvalidPhoneNumberException :Exception
    {
        private const string INVALID_PHONENUMBER_EXCEPTION_MESSAGE = "Invalid number!";

        public InvalidPhoneNumberException() : base(INVALID_PHONENUMBER_EXCEPTION_MESSAGE)
        {

        }
    }
}
