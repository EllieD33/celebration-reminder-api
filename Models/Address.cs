using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CelebrationReminderAPI.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        [Required]
        [StringLength(150)]
        public string StreetLine1 { get; set; }
        [StringLength(150)]
        public string StreetLine2 { get; set; }
        [StringLength(150)]
        public string StreetLine3 { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [Required]
        [StringLength(15)]
        public string PostalCode { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
    }
}