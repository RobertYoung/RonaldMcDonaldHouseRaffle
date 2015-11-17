using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RonaldMcDonaldHouseRaffle.Data.Entities
{
    [Table("contestant_details")]
    public class ContestantDetails
    {
        [Key]
        [Column("contestant_id")]
        public int ContestantId { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("surname")]
        public string Surname { get; set; }

        [Column("address1")]
        public string Address1 { get; set; }

        [Column("address2")]
        public string Address2 { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("postcode")]
        public string Postcode { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
