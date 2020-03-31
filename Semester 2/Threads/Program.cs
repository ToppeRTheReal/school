using System;
using Bank;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Threads
{
    class Program
    {

        static List<Account> Accounts = new List<Account>();
        static void Main(string[] args)
        {

            while (true) {
                Console.Write("Action> ");
                string cmd = Console.ReadLine();

                Console.Write("Amount> ");
                int amount = int.Parse(Console.ReadLine());

                Console.Write("Account Name> ");
                string acc = Console.ReadLine();

                var accPointer = Accounts.Where(x => x.Name == acc).FirstOrDefault();
                if(accPointer == null) {
                    accPointer = new Account(acc);
                    Accounts.Add(accPointer);
                }
                int x = accPointer.Balance;
                if(cmd == "withdraw") {
                    Thread withThread = new Thread(new ParameterizedThreadStart(y => accPointer.Withdraw(amount)));
                    if(x > accPointer.Balance) {
                        withThread.Start(amount);
                        Console.WriteLine("Withdrawal successful");
                    }
                }else if (cmd == "deposit") {
                    Thread depThread = new Thread(new ParameterizedThreadStart(y => accPointer.Deposit(amount)));
                    depThread.Start(amount);
                    Console.WriteLine("Deposit successful");
                }
            }
        }
    }
}
