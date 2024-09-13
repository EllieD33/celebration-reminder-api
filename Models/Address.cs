using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CelebrationReminderAPI.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        [Required]
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string StreetLine3 { get; set; }
        [Required]
        public string City { get; set; }
        public string State { get; set; }
        [Required]
        public string PostalCode { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
    }
}