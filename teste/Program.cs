using System.Globalization;
using teste;
using teste.Entities;
namespace MyApp
{
    class Program
    {
        private static void Main(string[] args)
        {
           Account acc1 = new Account(1001, "Alex", 500.0m);
           Account acc2 = new SavingsAccount(1002, "Maria", 500.0m, 0.01);

           acc1.Withdraw(10.0m);
           acc2.Withdraw(10.0m);
           
           Console.WriteLine(acc1.Balance);
           Console.WriteLine(acc2.Balance);
        }
    }          
}

