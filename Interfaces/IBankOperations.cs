using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Interfaces
{
    internal interface IBankOperations
    {
        int TimeDeposit(string type, int period, int rate, int amount);
        void Withdraw(int amount);
        void Deposit(int amount);
    }
}
