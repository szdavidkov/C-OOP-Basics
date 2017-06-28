using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTest
{
    public class Tester
    {
        public static void Main()
        {
            var accounts = new Dictionary<int,BankAccount>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                var commandArg = input.Split();
                var command = commandArg[0];
                switch (command)
                {
                    case "Create":
                        Create(commandArg, accounts);
                        break;

                    case "Deposit":
                        Deposit(commandArg, accounts);
                        break;
                    case "WithDraw":
                        WithDraw(commandArg, accounts);
                        break;
                    case "Print":
                        Print(commandArg, accounts);
                        break;

                }
            }
        }

        private static void Print(string[] commandArg, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(commandArg[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine(accounts[id].ToString());
            }
            else
            {
                Console.WriteLine($"Account does not exist");
            }

        }

        private static void WithDraw(string[] commandArg, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(commandArg[1]);
            var amount = double.Parse(commandArg[2]);

            if (accounts.ContainsKey(id))
            {
                if (accounts[id].Balance < amount)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    accounts[id].Withdraw(amount);
                }               
            }
            else
            {
                Console.WriteLine($"Account does not exist");
            }
        }

        private static void Deposit(string[] commandArg, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(commandArg[1]);
            var amount = double.Parse(commandArg[2]);

            if (accounts.ContainsKey(id))
            {
                accounts[id].Deposit(amount);
            }
            else
            {
                Console.WriteLine($"Account does not exist");
            }
        }

        private static void Create(string[] commandArg, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(commandArg[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.ID = id;
                accounts.Add(id,acc);
            }
        }
    }
}
