using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        public void Browse(string website)
        {
            if (website.Any(x =>char.IsDigit(x)))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {website}!");
            }
           
        }

        public void Calling(string phoneNumber)
        {
            if (phoneNumber.All(x => char.IsDigit(x)))
            {
                Console.WriteLine($"Calling... {phoneNumber}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
           
        }

    }
}
