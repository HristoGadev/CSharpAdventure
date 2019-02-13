using System;

namespace Telephony
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            var phoneNumInput = Console.ReadLine().Split();
            var URLInput = Console.ReadLine().Split();
            Smartphone smartphone = new Smartphone();

            for (int i = 0; i < phoneNumInput.Length; i++)
            {
                smartphone.Calling(phoneNumInput[i]);
            }
            for (int i = 0; i < URLInput.Length; i++)
            {
                smartphone.Browse(URLInput[i]);
            }
        }
    }
}
