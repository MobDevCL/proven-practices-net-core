using System;
using System.Collections.Generic;
using System.Text;

namespace mobdev.bestpractice.domain
{
    public class Account
    {
        private decimal balance = 0;

        public decimal Deposit(decimal deposit)
        {
            return this.BalanceSum(deposit);
        }

        private decimal BalanceSum(decimal amount)
        {
            return balance = balance + amount;
        }

         public void TransferFunds(Account destination, decimal amount)
        {
            this.balance = this.balance - amount;
            destination.balance = destination.balance + amount;
        }
    }
}
