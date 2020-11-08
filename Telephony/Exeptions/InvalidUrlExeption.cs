using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Exeptions
{
    public class InvalidUrlExeption : Exception
    {
        private const string INVALID_URL_EXCEPTION_MESSAGE = "Invalid URL!";

        public InvalidUrlExeption(): base(INVALID_URL_EXCEPTION_MESSAGE)
        {

        }
    }
}
