using System;

namespace BankingLibrary {
    /*Abstract - class only exists to support other classes. Cannot be called on its own 
             
    */

    public abstract class Account {

        public decimal Balance { get; set; }
        public int AcctNbr { get; private set; }
        public string Description { get; set; } = "Account";

        private static int NextAcctNbr = 1;
        private const int AcctNbrInc = 9;
        
        private int AttemptsToOverdraw = 0;

        private bool CheckAmountGTZero(decimal amount) {
            return (amount <= 0) ? false : true; 
        }
        public void Deposit(decimal amount) {
            if (CheckAmountGTZero(amount)) 
            Balance += amount;
        } 

        private bool IsSufficientFunds(decimal amount) {
            if (amount < Balance) {
                return true;
            }
            AttemptsToOverdraw++;
            return false;
        }
        public bool Withdraw(decimal amount) {
            if(CheckAmountGTZero(amount) && IsSufficientFunds(amount)) //IsSufficientFunds may not be called and may not increment AttemptsToOverdraw
            Balance -= amount;
            return true;
        }

        public void Transfer(decimal amount, Account toAcct) {
            if (this.Withdraw(amount)) { toAcct.Deposit(amount); } //Withdraw method is bool. Executes and returns bool value in If Statement
        }

        public override string ToString() {
            return $"AcctNbr={AcctNbr}, Desc={Description}, Balance= ${Balance}";
        }

        public void Debug() {
            Console.WriteLine(this);
        }
        public Account() {
            this.AcctNbr = 100000 + NextAcctNbr;
            NextAcctNbr += AcctNbrInc;

        } //default constructor
    }
}
