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
                user.GetName();
                var address = user.GetAdrress();

                Bank bank = new Bank();
                bank.GetName();

                bank.GetBankAccountNumber();

                var bankAddress = bank.GetAdrress();
                ctx.Users.Add(user);
                ctx.Banks.Add(bank);
                ctx.SaveChanges();
            }
        }
    }
}
