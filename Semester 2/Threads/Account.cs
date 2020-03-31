using System;
using System.Threading;

namespace Bank {
    public class Account {
        public Account(string name) {
            this.Name = name;
        }
        public string Name;
        public int Balance;

        public int Deposit(int input) { 
            this.Balance = this.Balance + input;
            PrintBalance();
            return this.Balance;
        }

        public int Withdraw(int amount) {
            lock(this) {
                if(this.Balance < amount) {
                    // Print vil ikke :/
                    PrintBalance();
                    return -1;
                }
                this.Balance = this.Balance - amount;
                PrintBalance();
                return this.Balance;
            }
        }

        private void PrintBalance() {
            Console.WriteLine("Current balance of {0} is {1}", this.Name, this.Balance);
        }
    }
}