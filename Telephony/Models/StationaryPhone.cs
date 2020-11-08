using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Exeptions;
using Telephony.Interfaces;

namespace Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        public StationaryPhone()
        {
                
        }
        public string Call(string phoneNum)
        {

            if (!phoneNum.All(x => char.IsDigit(x)))
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Dialing... {phoneNum}";
        }
    }
}
