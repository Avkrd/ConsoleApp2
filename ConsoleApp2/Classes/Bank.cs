using ConsoleApp2.DB;
using ConsoleApp2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    class Bank : IMethod
    {
        /// <summary>
        /// Bank Idendification
        /// </summary>
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
            //string[] question = new string[] { "e", "r", "t", "y"};

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
    }
}
