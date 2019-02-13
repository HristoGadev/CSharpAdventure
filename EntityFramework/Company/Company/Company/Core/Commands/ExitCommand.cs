using CompanyApp.Core.Contracts;
using System;
using System.Threading;

namespace CompanyApp.Core.Commands
{
    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            Console.WriteLine("The program will end in:");
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(900);
            }
            Environment.Exit(0);
            return null;
        }
    }
}
