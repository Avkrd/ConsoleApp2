using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    class Bank 
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

    }
}
