using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Exeptions;
using Telephony.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : IBrowsable, ICallable
    {
        public Smartphone()
        {
                
        }
        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidUrlExeption();
            }
            return $"Browsing: {url}!";
        }

        public string Call(string phoneNum)
        {
            if (!phoneNum.All(x => char.IsDigit(x)))
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Calling... {phoneNum}";
        }
    }
}
