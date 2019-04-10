using ConsoleApp2.Classes;
using ConsoleApp2.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new Db())
            {
                User user = new User();
                var name = user.GetName();
                var address = user.GetAdrress();

                Bank bank = new Bank();
                Console.WriteLine("enter your bank name");
                bank.BankName = Console.ReadLine();

                Console.WriteLine("enter your account number");
                string accountNumber = Console.ReadLine();
                int bankAccountNumber = int.Parse(accountNumber);
                bank.BankAccountNumber = bankAccountNumber;

                ctx.Users.Add(user);
                ctx.Banks.Add(bank);
                ctx.SaveChanges();
            }
        }
    }
}
