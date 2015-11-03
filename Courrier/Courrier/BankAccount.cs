using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcity
{
    public class BankAccount
    {
        double amount; //The amount in a count

        public BankAccount()
        {
            amount = 5000.0; //In default is 5000 euros ;
        }

        public double setCredit(double prmCredit)
        {
            //Set a credit to the count and return the final amount
            return amount += prmCredit;
        }

        public double setDebit(double prmDebit)
        {
            //Set a debit to the count and return the final amount
            return amount -= prmDebit;
        }

        public double getAmount()
        {
            //Return the amount of the count
            return amount;
        }
    }
}
