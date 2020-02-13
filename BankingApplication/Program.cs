using BankingLibrary;
using System;

namespace BankingApplication {
    class Program {
        static void Main(string[] args) {

            var int1 = new InterestAccount(.025);
            int1.Debug();
            var chk1 = new Account();

            chk1.Deposit(100);
            chk1.Withdraw(75);
            chk1.Deposit(-10);
            chk1.Withdraw(1000);
            chk1.Deposit(0);
            chk1.Withdraw(100);

            var chk2 = new Account();
            chk2.Deposit(200);
            chk2.Withdraw(40);
            chk1.Debug();
            chk2.Debug();

            chk2.Transfer(100, chk1);

            chk1.Debug();
            chk2.Debug();

        }
    }
}
