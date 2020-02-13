using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    public class SavingsAcct : InterestAccount {
        
        private void setDescription(string description) {
            this.Description = description;
        }
        public SavingsAcct(double interestRate) : base(interestRate) {
            setDescription("Savings Account");
        }
        
        public SavingsAcct() : base() {
            setDescription("Savings Account");
        }
    }
}
