using System;

namespace BankingLibrary {

    public class Account {

        public decimal Balance { get; set; }
        public string AcctNbr { get; set; }
        public string Description { get; set; }

        public void Deposit(decimal amount) {
            Balance += amount;
        }

        public void Withdraw(decimal amount) {
            Balance -= amount;
        }

        public void Transfer(decimal amount, Account toAcct, Account fromAcct) {
            fromAcct.Withdraw(amount);
            toAcct.Deposit(amount);
        }

        public Account() {} //default constructor
    }
}
