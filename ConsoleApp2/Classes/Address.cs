using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    [Table("AddressInfo")]
    public class Address 
    {
        /// <summary>
        /// Address Identification
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AddressID { get; set; }

        /// <summary>
        /// House Number
        /// </summary>
        public string HouseNumber { get; set; }

        /// <summary>
        /// Road Name
        /// </summary>
        public string RoadName { get; set; }

        /// <summary>
        /// Postal Code
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }

        public Address(string [] ads)
        {
            this.HouseNumber = ads[0];
            this.RoadName = ads[1];
            this.PostCode = ads[2];
            this.City = ads[3];
        }

        public Address()
        {
        }
    }
}
