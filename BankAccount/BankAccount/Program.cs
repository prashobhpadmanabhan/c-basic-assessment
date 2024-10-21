using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var acc1 = new BankAccount(1, "a", 0);
            acc1.deposit(10);
            acc1.withdrawal(10);
            acc1.showAccDetails();
        }
    }
}
