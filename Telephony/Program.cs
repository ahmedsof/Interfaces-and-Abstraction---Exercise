using System;
using Telephony.Exeptions;
using Telephony.Models;

namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phoneNumber = Console.ReadLine().Split();
            string[] sitesUrl = Console.ReadLine().Split();

            StationaryPhone statPhone = new StationaryPhone();
            Smartphone smart = new Smartphone();

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                try
                {
                    if (phoneNumber[i].Length == 7)
                    {

                        Console.WriteLine(statPhone.Call(phoneNumber[i]));
                    }
                    else if (phoneNumber[i].Length == 10)
                    {
                        Console.WriteLine(smart.Call(phoneNumber[i]));
                    }
                    else
                    {
                        throw new InvalidPhoneNumberException();
                    }
                }
                catch (InvalidPhoneNumberException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }

            for (int i = 0; i < sitesUrl.Length; i++)
            {
                try
                {
                    Console.WriteLine(smart.Browse(sitesUrl[i]));
                }
                catch (InvalidUrlExeption ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
