using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Encapsulation
{
    public class EncapsulationProgram
    {
        // Method to get BankBalance Details
        public void Bankbalance()
        {
            BankBalance balance = new BankBalance();     //object creation to access void type method in class
            balance.AddBalance(2000);                   //Method call with parameters
            balance.DeductBalance(1000);                //Method call with parameters
        }

    }
}
