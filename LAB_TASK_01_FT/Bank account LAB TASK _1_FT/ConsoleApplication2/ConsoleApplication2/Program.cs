using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("any name ", "id", 6000000);
            Account a2 = new Account("any name", "id", 4000000);

            a1.Withdraw(100000);
            a1.Deposit(10000);
            a2.Transfer(a2, 100000);
            a1.ShowAllTransaction();
            a2.ShowAllTransaction();
        }
    }

}