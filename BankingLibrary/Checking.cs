using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    /*Composition
     * for use in lieu of Inheritance
     */
    public class Checking  {

        private InterestAccount iacct; //created shorthand for InterestAccount
        public int CheckNbr { get; private set; }

        public void Deposit(decimal amount) {
            iacct.Deposit(amount); 
        }

        public bool Withdraw(decimal amount) {
            CheckNbr++;
            return iacct.Withdraw(amount);
        }

        public void Transfer(decimal amount, Account toAcct) {
            iacct.Transfer(amount, toAcct);
        }
        public void Transfer(decimal amount, Checking toAcct) {
            iacct.Transfer(amount, toAcct.iacct) ;
        }
        public Checking (double intRate) {
            iacct = new InterestAccount(intRate);
            iacct.Description = "Checking";
        }
        public Checking() :this(0.02) {
                         //Interest Account cannot be abstract
        }
    }
}
