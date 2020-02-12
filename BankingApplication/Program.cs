using BankingLibrary;
using System;

namespace BankingApplication {
    class Program {
        static void Main(string[] args) {
            var checking = new Account();
            var saving = new Account();

            checking.Deposit(100);

            checking.Withdraw(75);
        }
    }
}
