using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, BankAccount> clients = new Dictionary<int, BankAccount>();

        while (true)
        {
            var text = Console.ReadLine();
            if (text == "End")
                break;

            var input = text.Split().ToArray();
            var command = input[0];
            var idNumber = int.Parse(input[1]);

            switch (command)
            {
                case "Create":
                    Create(clients, idNumber);
                    break;
                case "Deposit":
                    var newDeposit = int.Parse(input[2]);
                    if (ValidateAccountExist(idNumber, clients))
                    {
                        clients[idNumber].Deposit(newDeposit);
                    }
                    break;
                case "Withdraw":
                    var withdrawAmmount = int.Parse(input[2]);
                    if (ValidateAccountExist(idNumber, clients))
                    {
                        clients[idNumber].Withdraw(withdrawAmmount);
                    }

                    break;
                case "Print":
                    if (ValidateAccountExist(idNumber, clients))
                    {
                        Console.WriteLine(clients[idNumber]);
                    }
                    break;
            }
        }
    }

    private static bool ValidateAccountExist(int idNumber, Dictionary<int, BankAccount> clients)
    {
        if (clients.ContainsKey(idNumber) == false)
        {
            Console.WriteLine("Account does not exist");
            return false;
        }
        else
        {
            return true;
        }
    }

    private static void Create(Dictionary<int, BankAccount> clients, int idNumber)
    {
        if (clients.ContainsKey(idNumber) == false)
        {
            clients.Add(idNumber, new BankAccount() { Id = idNumber });
        }
        else
        {
            Console.WriteLine("Account already exists");
        }
    }

}

