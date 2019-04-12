using ConsoleApp2.DB;
using ConsoleApp2.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    [Table("BankInfo")]
    class Bank : IMethod
    {
        /// <summary>
        /// Bank Idendification
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BankID { get; set; }

        /// <summary>
        /// Bank Name
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Bank Account Number
        /// </summary>
        public int BankAccountNumber { get; set; }


        public ICollection<Address> Addresses { get; set; }

        public string GetAdrress()
        {
            string[] ads = new string[4];
            Console.WriteLine("enter your door number, road name, postcode and city");
            for (int i = 0; i < ads.Length; i++)
            {
                ads[i] = Console.ReadLine();
            }
            Address add = new Address(ads);
            using (var ctx = new Db())
            {
                ctx.Addresses.Add(add);
                ctx.SaveChanges();
            }
            string fullAdress = add.HouseNumber + add.RoadName + add.City + add.PostCode;
            return fullAdress;
        }

        public void GetName()
        {
            Console.WriteLine("enter your bank name");
            BankName = Console.ReadLine();
        }

        public void GetBankAccountNumber()
        {
            Console.WriteLine("enter your account number");
            string accountNumber = Console.ReadLine();
            var convertStringToInt = ConvertToInt(accountNumber);

            BankAccountNumber = convertStringToInt;
        }

        public int ConvertToInt(string accountNumber)
        {
            int bankAccountNumber = int.Parse(accountNumber);
            return bankAccountNumber;
        }

    }
}
