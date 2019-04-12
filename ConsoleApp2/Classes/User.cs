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
    [Table("UserInfo")]
    class User : IMethod
    {
        /// <summary>
        /// User Identification.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserId { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public User()
        {
            //this.Addresses = new List<Address>();
        }

        // public string GetAdrress()
        //{
        //    Console.WriteLine("where do you live?");
        //    HouseNumber = Console.ReadLine();
        //    RoadName = Console.ReadLine();
        //    City = Console.ReadLine();
        //    PostCode = Console.ReadLine();

        //    string fullAdress = HouseNumber + RoadName + City + PostCode;

        //    return fullAdress;
        //}

        public string GetAdrress()
        {
            string[] ads = new string[4];
            //string[] question = new string[] { "e", "r", "t", "y"};

            Console.WriteLine("enter your house number, road name, postcode and city");
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
            FirstName = Console.ReadLine();
            LastName = Console.ReadLine();
        }

        public int ConvertToInt(string number)
        {
            int bankAccountNumber = int.Parse(number);
            return bankAccountNumber;
        }

        //public void GetAdrress()
        //{
        //    using (var ctx = new Db())
        //    {
        //        string[] ads = new string[4];
        //        //int i = 0;
        //        //i++;
        //        Console.WriteLine("enter");
        //        for (int i = 0; i < ads.Length; i++)
        //        {
        //            Console.WriteLine("");
        //            ads[i] = Console.ReadLine();
        //        }
        //        Address add = new Address(ads);

        //        ctx.Addresses.Add(add);
        //        ctx.SaveChanges();


        //    }

        //}

        //public string GetAdrress()
        //{
        //    Address add = new Address();
        //    add.City = "e";
        //    add.PostCode = "e";
        //    add.HouseNumber = "e";
        //    add.RoadName = "e";

        //    string fullAdress = add.HouseNumber + add.RoadName + add.City + add.PostCode;

        //    return fullAdress;
        //}
    }
}
