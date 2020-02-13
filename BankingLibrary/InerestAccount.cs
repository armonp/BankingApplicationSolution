using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    public class InterestAccount : Account {

        public decimal InterestRate { get; private set; }

        public InterestAccount(double interestRate) : this() {
            InterestRate = Convert.ToDecimal(interestRate);
        }

        public override string ToString() {
            return base.ToString() + $", InterestRate= {InterestRate*100}%";
        }

        public InterestAccount() : base() {
            this.Description = "Interest Account"; //change name of interest account
        } //default constructor of child class. Needs :base() to call default constructor of parent
    }
}
